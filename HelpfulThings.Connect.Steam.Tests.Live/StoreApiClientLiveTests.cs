using System;
using System.Collections.Generic;
using HelpfulThings.Connect.Steam.Interfaces;
using Xunit;

namespace HelpfulThings.Connect.Steam.Tests.Live
{
    public class StoreApiClientLiveTests : BaseLiveTest
    {
        private readonly IStoreApiClient _serviceUnderTest;
        
        public StoreApiClientLiveTests()
        {
            _serviceUnderTest = TestServiceProvider.GetService(typeof(IStoreApiClient)) as StoreApiClient;
        }
        
        [Fact]
        public async void GetApplicationDetails_VoidBastards()
        {
            var result = await _serviceUnderTest.GetApplicationDetails(TestConstants.Applications.VoidBastards);
            
            Assert.NotNull(result);
            Assert.True(result.WasSuccess);
            Assert.Equal("game", result.ApplicationDetail.Type);
            Assert.Equal("Void Bastards", result.ApplicationDetail.Name);
            Assert.Equal(857980, result.ApplicationDetail.ApplicationId);
            Assert.Equal(0, result.ApplicationDetail.RequiredAge);
            Assert.False(result.ApplicationDetail.IsFree);
            Assert.Equal("full", result.ApplicationDetail.ControllerSupport);
            Assert.NotNull(result.ApplicationDetail.DlcSteamIds);
            Assert.True(result.ApplicationDetail.DlcSteamIds.Length > 0);
            Assert.True(result.ApplicationDetail.DetailedDescription.Length > 0);
            Assert.True(result.ApplicationDetail.AboutTheGame.Length > 0);
            Assert.True(result.ApplicationDetail.ShortDescription.Length > 0);
            Assert.True(result.ApplicationDetail.SupportedLanguages.Length > 0);
            Assert.NotNull(result.ApplicationDetail.HeaderImageUri);
            Assert.NotNull(result.ApplicationDetail.Website);
            Assert.NotNull(result.ApplicationDetail.PcRequirements);
            Assert.True(result.ApplicationDetail.PcRequirements.Minimum.Length > 0);
            Assert.True(result.ApplicationDetail.PcRequirements.Recommended.Length > 0);
            Assert.NotNull(result.ApplicationDetail.MacRequirements);
            Assert.True(result.ApplicationDetail.MacRequirements.Minimum.Length > 0);
            Assert.True(result.ApplicationDetail.MacRequirements.Recommended.Length > 0);
            Assert.NotNull(result.ApplicationDetail.LinuxRequirements);
            Assert.True(result.ApplicationDetail.LinuxRequirements.Minimum.Length > 0);
            Assert.True(result.ApplicationDetail.LinuxRequirements.Recommended.Length > 0);
            Assert.NotNull(result.ApplicationDetail.Developers);
            Assert.True(result.ApplicationDetail.Developers.Length > 0);
            Assert.NotNull(result.ApplicationDetail.PriceOverview);
            Assert.Equal("USD", result.ApplicationDetail.PriceOverview.Currency);
            Assert.Equal(2999, result.ApplicationDetail.PriceOverview.InitialCents);
            Assert.Equal(2009, result.ApplicationDetail.PriceOverview.FinalCents);
            Assert.Equal(33, result.ApplicationDetail.PriceOverview.DiscountPercent);
            Assert.Equal("$29.99", result.ApplicationDetail.PriceOverview.InitialFormatted);
            Assert.Equal("$20.09", result.ApplicationDetail.PriceOverview.FinalFormatted);
            Assert.NotNull(result.ApplicationDetail.Packages);
            Assert.True(result.ApplicationDetail.Packages.Length > 0);
            Assert.NotNull(result.ApplicationDetail.PackageGroups);
            Assert.True(result.ApplicationDetail.PackageGroups.Length > 0);
            Assert.Equal("default", result.ApplicationDetail.PackageGroups[0].Name);
            Assert.Equal("Buy Void Bastards", result.ApplicationDetail.PackageGroups[0].Title);
            Assert.Equal("", result.ApplicationDetail.PackageGroups[0].Description);
            Assert.Equal("Select a purchase option", result.ApplicationDetail.PackageGroups[0].SelectionText);
            Assert.Equal("", result.ApplicationDetail.PackageGroups[0].SaveText);
            Assert.Equal(0, result.ApplicationDetail.PackageGroups[0].DisplayType);
            Assert.False(result.ApplicationDetail.PackageGroups[0].IsRecurringSubscription);
            Assert.NotNull(result.ApplicationDetail.PackageGroups[0].SubItems);
            Assert.Equal(269977, result.ApplicationDetail.PackageGroups[0].SubItems[0].PackageId);
            Assert.Equal("-33%", result.ApplicationDetail.PackageGroups[0].SubItems[0].PercentSavingsText);
            Assert.Equal(0, result.ApplicationDetail.PackageGroups[0].SubItems[0].PercentSavings);
            Assert.Equal("Void Bastards - <span class=\"discount_original_price\">$29.99</span> $20.09", result.ApplicationDetail.PackageGroups[0].SubItems[0].OptionText);
            Assert.Equal("", result.ApplicationDetail.PackageGroups[0].SubItems[0].OptionDescription);
            Assert.Equal("0", result.ApplicationDetail.PackageGroups[0].SubItems[0].CanGetFreeLicense);
            Assert.False(result.ApplicationDetail.PackageGroups[0].SubItems[0].IsFreeLicence);
            Assert.Equal(2009, result.ApplicationDetail.PackageGroups[0].SubItems[0].PriceWithDiscountCents);
            Assert.NotNull(result.ApplicationDetail.PlatformSummary);
            Assert.True(result.ApplicationDetail.PlatformSummary.SupportsWindows);
            Assert.True(result.ApplicationDetail.PlatformSummary.SupportsMac);
            Assert.False(result.ApplicationDetail.PlatformSummary.SupportsLinux);
            Assert.NotNull(result.ApplicationDetail.MetacriticSummary);
            Assert.Equal(80, result.ApplicationDetail.MetacriticSummary.Score);
            Assert.NotNull(result.ApplicationDetail.MetacriticSummary.MetacriticUri);
            Assert.NotNull(result.ApplicationDetail.Categories);
            Assert.True(result.ApplicationDetail.Categories.Length > 0);
            Assert.Equal(2, result.ApplicationDetail.Categories[0].Id);
            Assert.Equal("Single-player", result.ApplicationDetail.Categories[0].Description);
            Assert.NotNull(result.ApplicationDetail.Genres);
            Assert.True(result.ApplicationDetail.Genres.Length > 0);
            Assert.Equal(1, result.ApplicationDetail.Genres[0].Id);
            Assert.Equal("Action", result.ApplicationDetail.Genres[0].Description);
            Assert.NotNull(result.ApplicationDetail.ScreenShots);
            Assert.True(result.ApplicationDetail.ScreenShots.Length > 0);
            Assert.Equal(0, result.ApplicationDetail.ScreenShots[0].Id);
            Assert.NotNull(result.ApplicationDetail.ScreenShots[0].PathFull);
            Assert.NotNull(result.ApplicationDetail.ScreenShots[0].ThumbnailUri);
            Assert.NotNull(result.ApplicationDetail.Movies);
            Assert.True(result.ApplicationDetail.Movies.Length > 0);
            Assert.Equal(256735003, result.ApplicationDetail.Movies[0].Id);
            Assert.Equal("Announce Trailer", result.ApplicationDetail.Movies[0].Name);
            Assert.NotNull(result.ApplicationDetail.Movies[0].ThumbnailUri);
            Assert.True(result.ApplicationDetail.Movies[0].ShouldHighlight);
            Assert.NotNull(result.ApplicationDetail.Movies[0].WebMovieUris);
            Assert.True(result.ApplicationDetail.Movies[0].WebMovieUris.Count > 0);
            Assert.NotNull(result.ApplicationDetail.Movies[0].WebMovieUris["480"]);
            Assert.NotNull(result.ApplicationDetail.RecommendationMetadata);
            Assert.True(result.ApplicationDetail.RecommendationMetadata.Total > 0);
            Assert.NotNull(result.ApplicationDetail.AchievementMetadata);
            Assert.Equal(24, result.ApplicationDetail.AchievementMetadata.Total);
            Assert.NotNull(result.ApplicationDetail.AchievementMetadata.HighlightedAchievements);
            Assert.True(result.ApplicationDetail.AchievementMetadata.HighlightedAchievements[0].Name.Length > 0);
            Assert.NotNull(result.ApplicationDetail.AchievementMetadata.HighlightedAchievements[0].IconPath);
            Assert.NotNull(result.ApplicationDetail.ReleaseDateSummary);
            Assert.False(result.ApplicationDetail.ReleaseDateSummary.IsComingSoon);
            Assert.Equal(Convert.ToDateTime("May 28, 2019"), result.ApplicationDetail.ReleaseDateSummary.Date);
            Assert.NotNull(result.ApplicationDetail.SupportInformation);
            Assert.Null(result.ApplicationDetail.SupportInformation.SupportUri);
            Assert.Equal("support@bluemanchu.com", result.ApplicationDetail.SupportInformation.SupportEmail);
            Assert.NotNull(result.ApplicationDetail.BackgroundImageUri);
            Assert.NotNull(result.ApplicationDetail.ContentDescriptors);
            Assert.NotNull(result.ApplicationDetail.ContentDescriptors.Ids);
            Assert.True(result.ApplicationDetail.ContentDescriptors.Ids.Length > 0);
            Assert.Equal("Includes cartoon violence and gore. Strong language.", result.ApplicationDetail.ContentDescriptors.Notes);
        }

        [Fact]
        public async void GetApplicationDetails_CounterStrikeGlobalOffensive()
        {
            var result = await _serviceUnderTest.GetApplicationDetails(TestConstants.Applications.CounterStrikeGlobalOffensive);
        }
        
        [Fact]
        public async void GetApplicationDetails_EmpiresMod()
        {
            var result = await _serviceUnderTest.GetApplicationDetails(TestConstants.Applications.EmpiresMod);
        }
    }
}