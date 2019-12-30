using System.Threading.Tasks;
using HelpfulThings.Connect.Steam.Models.SteamApps;

namespace HelpfulThings.Connect.Steam
{
    public interface ISteamAppsClient
    {
        Task<AppListResponse> GetApplicationList();
    }
}