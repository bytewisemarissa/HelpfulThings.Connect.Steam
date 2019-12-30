using System.Collections.Generic;
using System.Threading.Tasks;
using HelpfulThings.Connect.Steam.Interfaces;
using HelpfulThings.Connect.Steam.Metering;
using HelpfulThings.Connect.Steam.Models;
using HelpfulThings.Connect.Steam.Models.PlayerService;

namespace HelpfulThings.Connect.Steam
{
    public class PlayerServiceClient : IPlayerServiceClient
    {
        private readonly IRequestRouter _router;
        
        public PlayerServiceClient(IRequestRouter router)
        {
            _router = router;
        }
        
        public async Task<OwnedGamesResponse> GetOwnedGames(string steamId)
        {
            var parameters = new Dictionary<string, string>()
            {
                {"steamid", steamId}
            };

            var response = await _router.MakeApiRequest<ResponseBase<OwnedGamesResponse>>(
                SteamEndpoints.PlayerService.GetOwnedGames, 
                parameters,
                true);

            return response.Response;
        }

        public async Task<RecentlyPlayedGameResponse> GetRecentlyPlayedGames(string steamId)
        {
            var parameters = new Dictionary<string, string>()
            {
                {"steamid", steamId}
            };

            var response = await _router.MakeApiRequest<ResponseBase<RecentlyPlayedGameResponse>>(
                SteamEndpoints.PlayerService.GetRecentlyPlayedGames, 
                parameters,
                true);

            return response.Response;
        }
        
        public async Task<IsPlaySharedGameResponse> IsPlayingSharedGame(string steamId, int appId)
        {
            var parameters = new Dictionary<string, string>()
            {
                {"steamid", steamId},
                {"appid_playing", appId.ToString()}
            };

            var response =  await _router.MakeApiRequest<ResponseBase<IsPlaySharedGameResponse>>(
                SteamEndpoints.PlayerService.IsPlayingSharedGames, 
                parameters,
                true);

            return response.Response;
        }
    }
}