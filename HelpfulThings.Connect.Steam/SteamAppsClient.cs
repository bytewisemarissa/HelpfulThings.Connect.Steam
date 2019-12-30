using System.Collections.Generic;
using System.Threading.Tasks;
using HelpfulThings.Connect.Steam.Interfaces;
using HelpfulThings.Connect.Steam.Metering;
using HelpfulThings.Connect.Steam.Models.SteamApps;

namespace HelpfulThings.Connect.Steam
{
    public class SteamAppsClient : ISteamAppsClient
    {
        private readonly IRequestRouter _router;
        
        public SteamAppsClient(IRequestRouter router)
        {
            _router = router;
        }

        public async Task<AppListResponse> GetApplicationList()
        {
            var response = await _router.MakeApiRequest<AppListWrapper>(
                SteamEndpoints.SteamApps.GetAppList, 
                new Dictionary<string, string>(), 
                false);

            return response.Response;
        }
    }
}