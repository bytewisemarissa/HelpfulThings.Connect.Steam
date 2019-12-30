using System.Threading.Tasks;
using HelpfulThings.Connect.Steam.Models.SteamNews;

namespace HelpfulThings.Connect.Steam
{
    public interface ISteamNewsClient
    {
        Task<NewsForApplicationResponse> GetNewsForApp(
            int applicationId, 
            int newsItemCount, 
            int previewLength);
    }
}