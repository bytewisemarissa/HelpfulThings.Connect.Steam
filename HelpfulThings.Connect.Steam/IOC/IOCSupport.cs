using System;
using System.Diagnostics;
using System.Net.Http.Headers;
using HelpfulThings.Connect.Steam.Interfaces;
using HelpfulThings.Connect.Steam.Metering;
using Microsoft.Extensions.DependencyInjection;

namespace HelpfulThings.Connect.Steam.IOC
{
    public static class IocSupport
    {
        public static void ConfigureSteamClient(
            this IServiceCollection collection, 
            Action<SteamApiOptions> steamApiOptionsAction)
        {
            var options = new SteamApiOptions();
            steamApiOptionsAction?.Invoke(options);

            collection.AddSingleton<SteamApiOptions>(options);

            switch (options.MeteringType)
            {
                case MeteringType.EvenSplit:
                    collection.AddSingleton<ISteamRequestMeter, EvenSplitMeter>();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            collection.AddHttpClient("api", client =>
            {
                client.BaseAddress = new Uri(SteamEndpoints.SteamApiBaseUrl);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue(
                    options.UserAgent,
                    options.UserAgentVersion));
            });

            collection.AddHttpClient("store", client =>
            {
                client.BaseAddress = new Uri(SteamEndpoints.SteamStoreBaseUrl);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue(
                    options.UserAgent,
                    options.UserAgentVersion));
            });
            
            collection.AddTransient<IRequestRouter, RequestRouter>();
            collection.AddTransient<IPlayerServiceClient, PlayerServiceClient>();
            collection.AddTransient<ISteamUserClient, SteamUserClient>();
            collection.AddTransient<ISteamUserStatsClient, SteamUserStatsClient>();
            collection.AddTransient<ISteamNewsClient, SteamNewsClient>();
            collection.AddTransient<ISteamAppsClient, SteamAppsClient>();
            collection.AddTransient<IStoreApiClient, StoreApiClient>();
        }
    }
}