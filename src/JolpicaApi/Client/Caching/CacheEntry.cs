using System;

namespace JolpicaApi.Client.Caching
{
    /// <summary>
    /// Represents a cache entry with an item and its expiration time.
    /// </summary>
    /// <typeparam name="T">The type of the item in the cache entry.</typeparam>
    public class CacheEntry<T>
    {
        /// <summary>
        /// Gets or sets the item in the cache entry.
        /// </summary>
        public T Item { get; set; }

        /// <summary>
        /// Gets or sets the expiration time of the cache entry.
        /// </summary>
        public DateTimeOffset Expiration { get; set; }
    }
}