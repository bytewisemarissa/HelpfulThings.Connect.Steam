using System.Collections.Generic;
using System.Threading.Tasks;
using HelpfulThings.Connect.Steam.Interfaces;
using HelpfulThings.Connect.Steam.Metering;
using HelpfulThings.Connect.Steam.Models.SteamNews;

namespace HelpfulThings.Connect.Steam
{
    public class SteamNewsClient : ISteamNewsClient
    {
        private readonly IRequestRouter _router;
        
        public SteamNewsClient(IRequestRouter router)
        {
            _router = router;
        }
        
        public async Task<NewsForApplicationResponse> GetNewsForApp(
            int applicationId, 
            int newsItemCount, 
            int previewLength)
        {
            var parameters = new Dictionary<string, string>()
            {
                {"appid", applicationId.ToString()},
                {"count", newsItemCount.ToString()},
                {"maxlength", previewLength.ToString()}
            };

            var response = await _router.MakeApiRequest<NewsForApplicationWrapper>(
                SteamEndpoints.SteamNews.GetNewsForApp, 
                parameters,
                true);

            return response.Response;
        }
    }
}