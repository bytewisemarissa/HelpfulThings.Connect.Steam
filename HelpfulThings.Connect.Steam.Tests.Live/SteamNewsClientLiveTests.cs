using Xunit;

namespace HelpfulThings.Connect.Steam.Tests.Live
{
    public class SteamNewsClientLiveTests : BaseLiveTest
    {
        private readonly SteamNewsClient _serviceUnderTest;
        
        public SteamNewsClientLiveTests()
        {
            _serviceUnderTest = TestServiceProvider.GetService(typeof(ISteamNewsClient)) as SteamNewsClient;
        }
        
        [Fact]
        public async void GetOwnedGamesLive()
        {
            var result = await _serviceUnderTest.GetNewsForApp(
                TestConstants.Applications.CounterStrikeGlobalOffensive,
                3, 
                150);
            
            Assert.NotNull(result);
            Assert.Equal(TestConstants.Applications.CounterStrikeGlobalOffensive, result.ApplicationId);
            Assert.NotNull(result.NewItems);
            Assert.True(result.NewItems.Count == 3);
            foreach (var newsItem in result.NewItems)
            {
                Assert.NotNull(newsItem);
                Assert.True(newsItem.Contents.Length >= 150);
            }
            Assert.True(result.Count > 0);
        }
    }
}