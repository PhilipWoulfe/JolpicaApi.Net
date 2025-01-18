using System;
using JolpiApi.Responses;

namespace JolpiApi.Client.Caching
{
    public interface IErgastCache : IDisposable
    {
        // TODO: Doc: Only used for new entries
        TimeSpan CacheEntryLifetime { get; set; }

        void AddOrReplace(string url, ErgastResponse response);

        T Get<T>(string url) where T : ErgastResponse;

        void Remove(string url);

        void Clear();
    }
}