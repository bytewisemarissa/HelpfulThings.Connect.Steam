using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HelpfulThings.Connect.Steam.Interfaces
{
    public interface IRequestRouter
    {
        Task<T> MakeApiRequest<T>(string relativeUri, Dictionary<string, string> parameters, bool includeApiKey);
        Task<T> MakeStoreRequest<T>(string relativeUri, Dictionary<string, string> parameters, bool includeApiKey);
    }
}