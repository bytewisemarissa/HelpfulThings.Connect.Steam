using System.Collections.Generic;
using System.Threading.Tasks;
using HelpfulThings.Connect.Steam.Models.Store;

namespace HelpfulThings.Connect.Steam.Interfaces
{
    public interface IStoreApiClient
    {
        Task<ApplicationDetailResponse> GetApplicationDetails(int applicationId);
    }
}