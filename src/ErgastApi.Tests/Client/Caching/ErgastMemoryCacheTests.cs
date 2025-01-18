using System;
using FluentAssertions;
using JolpiApi.Client.Caching;
using JolpiApi.Responses;
using Xunit;

namespace JolpiApi.Tests.Client.Caching
{
    public class ErgastMemoryCacheTests
    {
        private ErgastMemoryCache Cache { get; }

        public ErgastMemoryCacheTests()
        {
            Cache = new ErgastMemoryCache();
        }

        [Theory]
        [AutoMockedData]
        public void ExpiredResponseIsNotReturned(string url, ErgastResponse response)
        {
            // Arrange
            Cache.CacheEntryLifetime = TimeSpan.FromMinutes(-1);
            Cache.AddOrReplace(url, response);

            // Act
            var cachedResponse = Cache.Get<ErgastResponse>(url);

            // Assert
            cachedResponse.Should().BeNull();
        }

        [Theory]
        [AutoMockedData]
        public void CachedResponseIsReturned(string url, ErgastResponse response)
        {
            // Arrange
            Cache.CacheEntryLifetime = TimeSpan.FromMinutes(1);
            Cache.AddOrReplace(url, response);

            // Act
            var cachedResponse = Cache.Get<ErgastResponse>(url);

            // Assert
            cachedResponse.Should().Be(response);
        }
    }
}
