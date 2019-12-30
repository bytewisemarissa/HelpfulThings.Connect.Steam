using System.Collections.Generic;
using System.Threading.Tasks;
using HelpfulThings.Connect.Steam.Enums;
using HelpfulThings.Connect.Steam.Interfaces;
using HelpfulThings.Connect.Steam.Metering;
using HelpfulThings.Connect.Steam.Models;
using HelpfulThings.Connect.Steam.Models.SteamUser;

namespace HelpfulThings.Connect.Steam
{
    public class SteamUserClient : ISteamUserClient
    {
        private readonly IRequestRouter _router;
        
        public SteamUserClient(IRequestRouter router)
        {
            _router = router;
        }
        
        public async Task<PlayerSummariesResponse> GetOwnedGames(List<string> steamIds)
        {
            var parameters = new Dictionary<string, string>()
            {
                {"steamids", string.Join(',', steamIds)}
            };

            var response = await _router.MakeApiRequest<ResponseBase<PlayerSummariesResponse>>(
                SteamEndpoints.SteamUser.GetPlayerSummaries, 
                parameters,
                true);

            return response.Response;
        }
        
        public async Task<FriendListResponse> GetFriendList(string steamId, SteamRelationship relationshipFilter)
        {
            var parameters = new Dictionary<string, string>()
            {
                {"steamid", steamId},
                {"relationship", relationshipFilter.ToString()}
            };

            var response = await _router.MakeApiRequest<FriendListWrapper>(
                SteamEndpoints.SteamUser.GetFriendsList, 
                parameters,
                true);

            return response.Response;
        }
        
        public async Task<PlayerBansResponse> GetPlayerBans(List<string> steamIds)
        {
            var parameters = new Dictionary<string, string>()
            {
                {"steamids", string.Join(',', steamIds)}
            };

            var response = await _router.MakeApiRequest<PlayerBansResponse>(
                SteamEndpoints.SteamUser.GetPlayerBans, 
                parameters,
                true);

            return response;
        }
    }
}