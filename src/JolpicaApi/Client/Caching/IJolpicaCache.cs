using System;
using JolpicaApi.Responses;

namespace JolpicaApi.Client.Caching
{
    public interface IJolpicaCache : IDisposable
    {
        // TODO: Doc: Only used for new entries
        TimeSpan CacheEntryLifetime { get; set; }

        void AddOrReplace(string url, JolpicaResponse response);

        T Get<T>(string url) where T : JolpicaResponse;

        void Remove(string url);

        void Clear();
    }
}