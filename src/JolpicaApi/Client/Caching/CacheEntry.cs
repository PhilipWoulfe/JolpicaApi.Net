using System;

namespace JolpicaApi.Client.Caching
{
    public class CacheEntry<T>
    {
        public T Item { get; set; }

        public DateTimeOffset Expiration { get; set; }
    }
}