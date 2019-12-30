using System.Collections.Generic;
using System.Threading.Tasks;
using HelpfulThings.Connect.Steam.Interfaces;
using HelpfulThings.Connect.Steam.Metering;
using HelpfulThings.Connect.Steam.Models;
using HelpfulThings.Connect.Steam.Models.SteamUserStats;

namespace HelpfulThings.Connect.Steam
{
    public class SteamUserStatsClient : ISteamUserStatsClient
    {
        private readonly IRequestRouter _router;
        
        public SteamUserStatsClient(IRequestRouter router)
        {
            _router = router;
        }
        
        public async Task<AchievementResponse> GetGlobalAchievementPercentagesForApp(int applicationId)
        {
            var parameters = new Dictionary<string, string>()
            {
                {"gameid", applicationId.ToString()}
            };

            var response = await _router.MakeApiRequest<AchievementPercentagesWrapper>(
                SteamEndpoints.SteamUserStats.GetGlobalAchievementPercentagesForApp, 
                parameters,
                false);

            return response.Response;
        }
        
        public async Task<GlobalStatsResponse> GetGlobalStatsForGame(int applicationId, List<string> statNames)
        {
            var parameters = new Dictionary<string, string>()
            {
                {"appid", applicationId.ToString()},
                {"count", statNames.Count.ToString()}
            };
            
            for (var i = 0; i < statNames.Count; i++)
            {
                parameters.Add($"name[{i}]", statNames[i]);
            }
            
            var response = await _router.MakeApiRequest<ResponseBase<GlobalStatsResponse>>(
                SteamEndpoints.SteamUserStats.GetGlobalStatsForGame, 
                parameters,
                false);

            return response.Response;
        }
        
        public async Task<PlayerAchievementsResponse> GetPlayerAchievements(string steamId, int applicationId)
        {
            var parameters = new Dictionary<string, string>()
            {
                {"appid", applicationId.ToString()},
                {"steamid", steamId}
            };
            
            var response = await _router.MakeApiRequest<PlayerAchievementsWrapper>(
                SteamEndpoints.SteamUserStats.GetPlayerAchievements, 
                parameters,
                true);

            return response.Response;
        }
        
        public async Task<UserStatsForGameResponse> GetUserStatsForGame(string steamId, int applicationId)
        {
            var parameters = new Dictionary<string, string>()
            {
                {"appid", applicationId.ToString()},
                {"steamid", steamId}
            };
            
            var response = await _router.MakeApiRequest<UserStatsForGameWrapper>(
                SteamEndpoints.SteamUserStats.GetUserStatsForGame, 
                parameters,
                true);

            return response.Response;
        }
        
        public async Task<SchemaForGameResponse> GetSchemaForGame(int applicationId)
        {
            var parameters = new Dictionary<string, string>()
            {
                {"appid", applicationId.ToString()}
            };
            
            var response = await _router.MakeApiRequest<SchemaForGameWrapper>(
                SteamEndpoints.SteamUserStats.GetSchemaForGame, 
                parameters,
                true);

            return response.Response;
        }
    }
}