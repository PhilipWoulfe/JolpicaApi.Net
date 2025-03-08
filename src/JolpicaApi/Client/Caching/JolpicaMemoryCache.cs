using System;
using JolpicaApi.Responses;



/* Unmerged change from project 'JolpicaApi (net8.0)'
Added:
using JolpiApi;
using JolpiApi.Client;
using JolpiApi.Client.Caching;
using JolpicaApi.Client.Caching;
*/






#if NETSTANDARD
using Microsoft.Extensions.Caching.Memory;
#else
using System.Runtime.Caching;
#endif

namespace JolpicaApi.Client.Caching
{
    /// <summary>
    /// Provides a memory cache for storing Jolpica API responses.
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of the <see cref="JolpicaMemoryCache"/> class with a specified cache entry lifetime.
    /// </remarks>
    /// <param name="cacheEntryLifetime">The cache entry lifetime.</param>
    public class JolpicaMemoryCache(TimeSpan cacheEntryLifetime) : IJolpicaCache
    {
        private static readonly TimeSpan DefaultCacheEntryLifetime = TimeSpan.FromHours(1);

#if NETSTANDARD
        private MemoryCache Cache { get; set; } = new MemoryCache(new MemoryCacheOptions());
#else
        private MemoryCache Cache { get; set; } = new MemoryCache(nameof(JolpicaMemoryCache));
#endif

        /// <summary>
        /// Gets or sets the cache entry lifetime.
        /// </summary>
        public TimeSpan CacheEntryLifetime { get; set; } = cacheEntryLifetime;

        /// <summary>
        /// Initializes a new instance of the <see cref="JolpicaMemoryCache"/> class with the default cache entry lifetime.
        /// </summary>
        public JolpicaMemoryCache()
            : this(DefaultCacheEntryLifetime)
        {
        }

        /// <summary>
        /// Adds or replaces a cache entry for the specified URL with the given response.
        /// </summary>
        /// <param name="url">The URL of the cache entry.</param>
        /// <param name="response">The response to cache.</param>
        public void AddOrReplace(string url, JolpicaResponse response)
        {
            Cache.Set(url, response, DateTimeOffset.UtcNow + CacheEntryLifetime);
        }

        /// <summary>
        /// Gets a cached response for the specified URL.
        /// </summary>
        /// <typeparam name="T">The type of the response.</typeparam>
        /// <param name="url">The URL of the cache entry.</param>
        /// <returns>The cached response, or null if not found.</returns>
        public T Get<T>(string url) where T : JolpicaResponse
        {
            return Cache.Get(url) as T;
        }

        /// <summary>
        /// Removes a cache entry for the specified URL.
        /// </summary>
        /// <param name="url">The URL of the cache entry.</param>
        public void Remove(string url)
        {
            Cache.Remove(url);
        }

        /// <summary>
        /// Clears all cache entries.
        /// </summary>
        public void Clear()
        {
            Cache.Dispose();
#if NETSTANDARD
            Cache = new MemoryCache(new MemoryCacheOptions());
#else
            Cache = new MemoryCache(nameof(JolpicaMemoryCache));
#endif
        }

        /// <summary>
        /// Disposes the cache.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Disposes the cache.
        /// </summary>
        /// <param name="disposing">A value indicating whether the method is being called from the Dispose method.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!disposing) return;

            Cache.Dispose();
        }
    }
}