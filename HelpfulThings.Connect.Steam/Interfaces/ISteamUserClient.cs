using System.Collections.Generic;
using System.Threading.Tasks;
using HelpfulThings.Connect.Steam.Enums;
using HelpfulThings.Connect.Steam.Models.SteamUser;

namespace HelpfulThings.Connect.Steam.Interfaces
{
    public interface ISteamUserClient
    {
        Task<PlayerSummariesResponse> GetOwnedGames(List<string> steamIds);
        Task<FriendListResponse> GetFriendList(string steamId, SteamRelationship relationshipFilter);
        Task<PlayerBansResponse> GetPlayerBans(List<string> steamIds);
    }
}