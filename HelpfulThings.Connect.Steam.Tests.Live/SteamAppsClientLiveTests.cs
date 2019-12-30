using Xunit;

namespace HelpfulThings.Connect.Steam.Tests.Live
{
    public class SteamAppsClientLiveTests : BaseLiveTest
    {
        private readonly SteamAppsClient _serviceUnderTest;
        
        public SteamAppsClientLiveTests()
        {
            _serviceUnderTest = TestServiceProvider.GetService(typeof(ISteamAppsClient)) as SteamAppsClient;
        }
        
        [Fact]
        public async void GetApplicationList()
        {
            var result = await _serviceUnderTest.GetApplicationList();
            
            Assert.NotNull(result);
            Assert.NotNull(result.Applications);
            Assert.True(result.Applications.Count > 0);
        }
    }
}