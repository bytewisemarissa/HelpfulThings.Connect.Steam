using System.Collections.Generic;
using HelpfulThings.Connect.Steam.Enums;
using HelpfulThings.Connect.Steam.Interfaces;
using Xunit;

namespace HelpfulThings.Connect.Steam.Tests.Live
{
    public class SteamUserClientListTests : BaseLiveTest
    {
        private readonly SteamUserClient _serviceUnderTest;
        
        public SteamUserClientListTests()
        {
            _serviceUnderTest = TestServiceProvider.GetService(typeof(ISteamUserClient)) as SteamUserClient;
        }
        
        [Fact]
        public async void GetOwnedGames()
        {
            var testIds = new List<string>()
            {
                TestConstants.SteamIds.AlFarnsworth,
                TestConstants.SteamIds.Test
            };
            
            var result = await _serviceUnderTest.GetOwnedGames(testIds);
            
            Assert.NotNull(result);
            
            Assert.True(result.Players.Count == testIds.Count);
        }
        
        [Fact]
        public async void GetFriendsList()
        {
            var result =
                await _serviceUnderTest.GetFriendList(
                    TestConstants.SteamIds.AlFarnsworth, 
                    SteamRelationship.All);
            
            Assert.NotNull(result);
            
            Assert.True(result.Friends.Count > 0);
        }
        
        [Fact]
        public async void GetPlayerBans()
        {
            var testIds = new List<string>()
            {
                TestConstants.SteamIds.AlFarnsworth,
                TestConstants.SteamIds.Test
            };
            
            var result = await _serviceUnderTest.GetPlayerBans(testIds);
            
            Assert.NotNull(result);
            
            Assert.True(result.Players.Count == testIds.Count);
        }
    }
}