using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using HelpfulThings.Connect.Steam.Exceptions;
using HelpfulThings.Connect.Steam.Interfaces;
using HelpfulThings.Connect.Steam.Metering;
using Newtonsoft.Json;

namespace HelpfulThings.Connect.Steam
{
    public class RequestRouter : IRequestRouter
    {
        private readonly SteamApiOptions _configuration;
        private readonly ISteamRequestMeter _meter;
        private readonly IHttpClientFactory _httpClientFactory;

        public RequestRouter(
            SteamApiOptions configuration, 
            ISteamRequestMeter requestMeteringMonitor,
            IHttpClientFactory factory)
        {
            _configuration = configuration;
            _meter = requestMeteringMonitor;
            _httpClientFactory = factory;
        }

        public async Task<T> MakeApiRequest<T>(
            string relativeUri, 
            Dictionary<string, string> parameters,
            bool includeApiKey)
        {
            var client = _httpClientFactory.CreateClient("api");
            
            var requestPath = BuildRequestPath(client.BaseAddress, relativeUri, parameters, includeApiKey);
            
            var scheduledTime = _meter.ScheduleRequest();

            await Task.Delay(Math.Clamp((scheduledTime - DateTime.UtcNow).Milliseconds, 0, int.MaxValue));

            var response = await client.GetAsync(requestPath);

            ValidateResponse(response);
            
            var responseJson = await response.Content.ReadAsStringAsync();

            var parsedResponse = JsonConvert.DeserializeObject<T>(responseJson);

            return parsedResponse;
        }
        
        public async Task<T> MakeStoreRequest<T>(
            string relativeUri, 
            Dictionary<string, string> parameters,
            bool includeApiKey)
        {
            var client = _httpClientFactory.CreateClient("store");
            
            var requestPath = BuildRequestPath(client.BaseAddress, relativeUri, parameters, includeApiKey);
            
            var scheduledTime = _meter.ScheduleRequest();

            await Task.Delay(scheduledTime - DateTime.UtcNow);

            var response = await client.GetAsync(requestPath);

            ValidateResponse(response);

            var responseJson = await response.Content.ReadAsStringAsync();

            var parsedResponse = JsonConvert.DeserializeObject<T>(responseJson);

            return parsedResponse;
        }

        private static void ValidateResponse(HttpResponseMessage response)
        {
            switch (response.StatusCode)
            {
                case HttpStatusCode.OK:
                    return;
                case HttpStatusCode.BadRequest:
                    throw new RequestException(
                        (int)HttpStatusCode.BadRequest,
                        "Bad Request",
                        "HelpfulThingsConnect.Steam may be out of date, check for updates.");
                case HttpStatusCode.NotFound:
                    throw new RequestException(
                        (int)HttpStatusCode.NotFound,
                        "Not Found",
                        "HelpfulThingsConnect.Steam may be out of date, check for updates.");
                case HttpStatusCode.Unauthorized:
                    throw new RequestException(
                        (int)HttpStatusCode.NotFound,
                        "Not Found",
                        "Your API key is probably incorrect, please double check.");
                case HttpStatusCode.InternalServerError:
                    throw new RequestException(
                        (int)HttpStatusCode.InternalServerError,
                        "Internal Server Error",
                        "Steam is having problems, please try again later.");
                default:
                    throw new RequestException(
                        (int)response.StatusCode,
                        response.StatusCode.ToString(),
                        "Unexpected error when calling the Steam API.");
            }
        }

        private string BuildRequestPath(
            Uri basePath,
            string relativePath, 
            Dictionary<string, string> queryParameters,
            bool includeApiKey)
        {
            var builder = new UriBuilder(basePath) {Path = relativePath};

            var query = HttpUtility.ParseQueryString(builder.Query);
            
            query["format"] = "json";

            if (includeApiKey)
            {
                query["key"] = _configuration.ApiKey;
            }
            
            foreach (var (key, value) in queryParameters)
            {
                query[key] = value;
            }

            builder.Query = query.ToString();

            return builder.ToString();
        }
    }
}