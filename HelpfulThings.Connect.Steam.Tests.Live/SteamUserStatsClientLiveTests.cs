using System.Collections.Generic;
using HelpfulThings.Connect.Steam.Interfaces;
using Xunit;

namespace HelpfulThings.Connect.Steam.Tests.Live
{
    public class SteamUserStatsClientLiveTests : BaseLiveTest
    {
        private readonly SteamUserStatsClient _serviceUnderTest;
        
        public SteamUserStatsClientLiveTests()
        {
            _serviceUnderTest = TestServiceProvider.GetService(typeof(ISteamUserStatsClient)) as SteamUserStatsClient;
        }
        
        [Fact]
        public async void GetGlobalAchievementPercentagesForApp()
        {
            var result = await _serviceUnderTest.GetGlobalAchievementPercentagesForApp(
                TestConstants.Applications.CounterStrikeGlobalOffensive);
            
            Assert.NotNull(result);
            
            Assert.True(result.Achievements.Count > 0);
        }
        
        [Fact]
        public async void GetGlobalStatsForGame()
        {
            var statNames = new List<string>()
            {
                "global.map.emp_isle",
                "global.map.emp_crossroads",
                "global.rounds_won.be"
            };
            
            var result = await _serviceUnderTest.GetGlobalStatsForGame(
                TestConstants.Applications.EmpiresMod,
                statNames);
            
            Assert.NotNull(result);
            
            Assert.True(result.GlobalStatistics.Count == statNames.Count);
        }
        
        [Fact]
        public async void GetPlayerAchievements()
        {
            var result = await _serviceUnderTest.GetPlayerAchievements(
                TestConstants.SteamIds.AlFarnsworth,
                TestConstants.Applications.CounterStrikeGlobalOffensive);
            
            Assert.NotNull(result);
            
            Assert.Equal(TestConstants.SteamIds.AlFarnsworth, result.SteamId);
            Assert.Equal("Counter-Strike: Global Offensive", result.GameName);
            Assert.True(result.Achievements.Count > 0);
            Assert.True(result.Success);
        }
        
        [Fact]
        public async void GetUserStatsForGame()
        {
            var result = await _serviceUnderTest.GetUserStatsForGame(
                TestConstants.SteamIds.AlFarnsworth,
                TestConstants.Applications.CounterStrikeGlobalOffensive);
            
            Assert.NotNull(result);
            
            Assert.Equal(TestConstants.SteamIds.AlFarnsworth, result.SteamId);
            Assert.Equal("ValveTestApp260", result.GameName);
            Assert.True(result.Statistics.Count > 0);
            Assert.True(result.Achievements.Count > 0);
        }
        
        [Fact]
        public async void GetSchemaForGame()
        {
            var result = await _serviceUnderTest.GetSchemaForGame(
                TestConstants.Applications.CounterStrikeGlobalOffensive);
            
            Assert.NotNull(result);
            
            Assert.Equal("ValveTestApp260", result.GameName);
            Assert.Equal("240", result.GameVersion);
            
            Assert.NotNull(result.AvailableGameStatistics);
            
            Assert.True(result.AvailableGameStatistics.Achievements.Count > 0);
            Assert.True(result.AvailableGameStatistics.Statistics.Count > 0);
        }
    }
}