using System;
using FluentAssertions;
using JolpicaApi.Client.Caching;
using JolpicaApi.Responses;
using Xunit;

namespace JolpicaApi.Tests.Client.Caching
{
    public class JolpiMemoryCacheTests
    {
        private JolpicaMemoryCache Cache { get; }

        public JolpiMemoryCacheTests()
        {
            Cache = new JolpicaMemoryCache();
        }

        [Theory]
        [AutoMockedData]
        public void ExpiredResponseIsNotReturned(string url, JolpicaResponse response)
        {
            // Arrange
            Cache.CacheEntryLifetime = TimeSpan.FromMinutes(-1);
            Cache.AddOrReplace(url, response);

            // Act
            var cachedResponse = Cache.Get<JolpicaResponse>(url);

            // Assert
            cachedResponse.Should().BeNull();
        }

        [Theory]
        [AutoMockedData]
        public void CachedResponseIsReturned(string url, JolpicaResponse response)
        {
            // Arrange
            Cache.CacheEntryLifetime = TimeSpan.FromMinutes(1);
            Cache.AddOrReplace(url, response);

            // Act
            var cachedResponse = Cache.Get<JolpicaResponse>(url);

            // Assert
            cachedResponse.Should().Be(response);
        }
    }
}
