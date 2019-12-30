using System.Collections.Generic;
using System.Threading.Tasks;
using HelpfulThings.Connect.Steam.Interfaces;
using HelpfulThings.Connect.Steam.Metering;
using HelpfulThings.Connect.Steam.Models.Store;

namespace HelpfulThings.Connect.Steam
{
    public class StoreApiClient : IStoreApiClient
    {
        private readonly IRequestRouter _router;
        
        public StoreApiClient(IRequestRouter router)
        {
            _router = router;
        }
        
        public async Task<ApplicationDetailResponse> GetApplicationDetails(int applicationId)
        {
            var parameters = new Dictionary<string, string>()
            {
                {"appids", applicationId.ToString()}
            };

            var response = await _router.MakeStoreRequest<Dictionary<string, ApplicationDetailResponse>>(
                SteamEndpoints.StoreApi.ApplicationDetails, 
                parameters,
                false);

            return response[applicationId.ToString()];
        }
    }
}