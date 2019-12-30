namespace HelpfulThings.Connect.Steam.Metering
{
    public static class SteamEndpoints
    {
        public const string SteamApiBaseUrl = "https://api.steampowered.com/";
        public const string SteamStoreBaseUrl = "http://store.steampowered.com/api/";
        
        public static class PlayerService
        {
            private const string PlayerServiceBaseUrl = "/IPlayerService";
            public const string GetOwnedGames = PlayerServiceBaseUrl + "/GetOwnedGames/v0001/";
            public const string GetRecentlyPlayedGames = PlayerServiceBaseUrl + "/GetRecentlyPlayedGames/v0001/";
            public const string IsPlayingSharedGames = PlayerServiceBaseUrl + "/IsPlayingSharedGame/v0001/";
        }
        
        public static class SteamUser
        {
            private const string SteamUserServiceBaseUrl = "/ISteamUser";
            public const string GetPlayerSummaries = SteamUserServiceBaseUrl + "/GetPlayerSummaries/v0002/";
            public const string GetFriendsList = SteamUserServiceBaseUrl + "/GetFriendList/v0001/";
            public const string GetPlayerBans = SteamUserServiceBaseUrl + "/GetPlayerBans/v1/";
        }
        
        public static class SteamUserStats
        {
            private const string SteamUserStatsBaseUrl = "/ISteamUserStats";
            public const string GetGlobalAchievementPercentagesForApp = SteamUserStatsBaseUrl + "/GetGlobalAchievementPercentagesForApp/v0002/";
            public const string GetGlobalStatsForGame = SteamUserStatsBaseUrl + "/GetGlobalStatsForGame/v0001/";
            public const string GetPlayerAchievements = SteamUserStatsBaseUrl + "/GetPlayerAchievements/v0001/";
            public const string GetUserStatsForGame = SteamUserStatsBaseUrl + "/GetUserStatsForGame/v0002/";
            public const string GetSchemaForGame = SteamUserStatsBaseUrl + "/GetSchemaForGame/v2/";
        }

        public static class SteamNews
        {
            private const string SteamNewsBaseUrl = "/ISteamNews";
            public const string GetNewsForApp = SteamNewsBaseUrl + "/GetNewsForApp/v0002/";
        }
        
        public static class SteamApps
        {
            private const string SteamAppsBaseUrl = "/ISteamApps";
            public const string GetAppList = SteamAppsBaseUrl + "/GetAppList/v2/";
        }

        public static class StoreApi
        {
            private const string StoreApiBaseUrl = "/api";
            public const string ApplicationDetails = StoreApiBaseUrl + "/appdetails";
        }
    }
}