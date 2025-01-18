using System;
using JolpiApi.Responses;

namespace JolpiApi.Client.Caching
{
    public interface IJolpiCache : IDisposable
    {
        // TODO: Doc: Only used for new entries
        TimeSpan CacheEntryLifetime { get; set; }

        void AddOrReplace(string url, JolpiResponse response);

        T Get<T>(string url) where T : JolpiResponse;

        void Remove(string url);

        void Clear();
    }
}