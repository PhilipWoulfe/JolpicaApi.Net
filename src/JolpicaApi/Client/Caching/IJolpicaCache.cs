using System;
using JolpicaApi.Responses;

namespace JolpicaApi.Client.Caching
{
    /// <summary>
    /// Interface for caching Jolpica API responses.
    /// </summary>
    public interface IJolpicaCache : IDisposable
    {
        /// <summary>
        /// Gets or sets the lifetime of cache entries.
        /// </summary>
        TimeSpan CacheEntryLifetime { get; set; }

        /// <summary>
        /// Adds a new response to the cache or replaces an existing one.
        /// </summary>
        /// <param name="url">The URL of the request.</param>
        /// <param name="response">The response to cache.</param>
        void AddOrReplace(string url, JolpicaResponse response);

        /// <summary>
        /// Gets a cached response for the specified URL.
        /// </summary>
        /// <typeparam name="T">The type of the response.</typeparam>
        /// <param name="url">The URL of the request.</param>
        /// <returns>The cached response.</returns>
        T Get<T>(string url) where T : JolpicaResponse;

        /// <summary>
        /// Removes a cached response for the specified URL.
        /// </summary>
        /// <param name="url">The URL of the request.</param>
        void Remove(string url);

        /// <summary>
        /// Clears all cached responses.
        /// </summary>
        void Clear();
    }
}