using System.Collections.Generic;
using System.Threading.Tasks;
using HelpfulThings.Connect.Steam.Models.SteamUserStats;

namespace HelpfulThings.Connect.Steam
{
    public interface ISteamUserStatsClient
    {
        Task<AchievementResponse> GetGlobalAchievementPercentagesForApp(int applicationId);
        Task<GlobalStatsResponse> GetGlobalStatsForGame(int applicationId, List<string> statNames);
        Task<PlayerAchievementsResponse> GetPlayerAchievements(string steamId, int applicationId);
        Task<UserStatsForGameResponse> GetUserStatsForGame(string steamId, int applicationId);
        Task<SchemaForGameResponse> GetSchemaForGame(int applicationId);
    }
}