using HelpfulThings.Connect.Steam.Interfaces;
using Xunit;

namespace HelpfulThings.Connect.Steam.Tests.Live
{
    public class PlayerServiceClientLiveTests : BaseLiveTest
    {
        private readonly PlayerServiceClient _serviceUnderTest;
        
        public PlayerServiceClientLiveTests()
        {
            _serviceUnderTest = TestServiceProvider.GetService(typeof(IPlayerServiceClient)) as PlayerServiceClient;
        }

        [Fact]
        public async void GetOwnedGamesLive()
        {
            var result = await _serviceUnderTest.GetOwnedGames(TestConstants.SteamIds.AlFarnsworth);
            
            Assert.NotNull(result);
            Assert.NotNull(result.OwnedGames);
            
            Assert.True(result.GamesCount > 0);
            Assert.True(result.OwnedGames.Count == result.GamesCount);
        }
        
        [Fact]
        public async void GetRecentlyPlayedGamesLive()
        {
            var result = await _serviceUnderTest.GetRecentlyPlayedGames(TestConstants.SteamIds.AlFarnsworth);
            
            Assert.NotNull(result);
            Assert.NotNull(result.RecentlyPlayedGames);
            
            Assert.True(result.TotalCount > 0);
            Assert.True(result.RecentlyPlayedGames.Count == result.TotalCount);
        }
        
        [Fact]
        public async void IsPlayingSharedGameLive()
        {
            var result = await _serviceUnderTest.IsPlayingSharedGame(
                TestConstants.SteamIds.AlFarnsworth,
                TestConstants.Applications.CounterStrikeGlobalOffensive);
            
            Assert.NotNull(result);
            
            Assert.True(result.LenderSteamId == "0");
        }
    }
}