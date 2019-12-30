using System;
using HelpfulThings.Connect.Steam.JsonConverters;
using Newtonsoft.Json;

namespace HelpfulThings.Connect.Steam.Models.Store
{
    public class ApplicationDetail
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("steam_appid")]
        public int ApplicationId { get; set; }
        
        [JsonProperty("required_age")]
        public int RequiredAge { get; set; }
        
        [JsonProperty("is_free")]
        public bool IsFree { get; set; }
        
        [JsonProperty("controller_support")]
        public string ControllerSupport { get; set; }
        
        [JsonProperty("dlc")]
        public string[] DlcSteamIds { get; set; }
        
        [JsonProperty("detailed_description")]
        public string DetailedDescription { get; set; }
        
        [JsonProperty("about_the_game")]
        public string AboutTheGame { get; set; }
        
        [JsonProperty("short_description")]
        public string ShortDescription { get; set; }
        
        [JsonProperty("supported_languages")]
        public string SupportedLanguages { get; set; }
        
        [JsonProperty("")]
        public string Reviews { get; set; }
        
        [JsonProperty("header_image")]
        public Uri HeaderImageUri { get; set; }
        
        [JsonProperty("website")]
        public Uri Website { get; set; }
        
        [JsonProperty("pc_requirements")]
        [JsonConverter(typeof(EmptyArrayConverter<ApplicationDetailSystemRequirementsSummary>))]
        public ApplicationDetailSystemRequirementsSummary PcRequirements { get; set; }
        
        [JsonProperty("mac_requirements")]
        [JsonConverter(typeof(EmptyArrayConverter<ApplicationDetailSystemRequirementsSummary>))]
        public ApplicationDetailSystemRequirementsSummary MacRequirements { get; set; }
        
        [JsonProperty("linux_requirements")]
        [JsonConverter(typeof(EmptyArrayConverter<ApplicationDetailSystemRequirementsSummary>))]
        public ApplicationDetailSystemRequirementsSummary LinuxRequirements { get; set; }
        
        [JsonProperty("developers")]
        public string[] Developers { get; set; }
        
        [JsonProperty("publishers")]
        public string[] Publishers { get; set; }
        
        [JsonProperty("price_overview")]
        public ApplicationDetailPriceOverview PriceOverview { get; set; }
        
        [JsonProperty("packages")]
        public string[] Packages { get; set; }
        
        [JsonProperty("package_groups")]
        public ApplicationDetailPackageGroupSummary[] PackageGroups { get; set; }
        
        [JsonProperty("platforms")]
        public ApplicationDetailPlatformSummary PlatformSummary { get; set; }
        
        [JsonProperty("metacritic")]
        public ApplicationDetailMetacriticSummary MetacriticSummary { get; set; }
        
        [JsonProperty("categories")]
        public ApplicationDetailGameCategory[] Categories { get; set; }
        
        [JsonProperty("genres")]
        public ApplicationDetailGameGenre[] Genres { get; set; }
        
        [JsonProperty("screenshots")]
        public ApplicationDetailScreenShotMetadata[] ScreenShots { get; set; }
        
        [JsonProperty("movies")]
        public ApplicationDetailMovieMetaData[] Movies { get; set; }
        
        [JsonProperty("recommendations")]
        public ApplicationDetailRecommendationMetadata RecommendationMetadata { get; set; }
        
        [JsonProperty("achievements")]
        public ApplicationDetailAchievementMetadata AchievementMetadata { get; set; }
        
        [JsonProperty("release_date")]
        public ApplicationDetailReleaseDateSummary ReleaseDateSummary { get; set; }
        
        [JsonProperty("support_info")]
        public ApplicationDetailSupportInformation SupportInformation { get; set; }
        
        [JsonProperty("background")]
        public Uri BackgroundImageUri { get; set; }
        
        [JsonProperty("content_descriptors")]
        public ApplicationDetailContentDescriptorsSummary ContentDescriptors { get; set; }
    }
}