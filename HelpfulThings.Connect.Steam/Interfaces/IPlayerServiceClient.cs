using System.Threading.Tasks;
using HelpfulThings.Connect.Steam.Models.PlayerService;

namespace HelpfulThings.Connect.Steam.Interfaces
{
    public interface IPlayerServiceClient
    {
        Task<OwnedGamesResponse> GetOwnedGames(string steamId);
        Task<RecentlyPlayedGameResponse> GetRecentlyPlayedGames(string steamId);
        Task<IsPlaySharedGameResponse> IsPlayingSharedGame(string steamId, int appId);
    }
}