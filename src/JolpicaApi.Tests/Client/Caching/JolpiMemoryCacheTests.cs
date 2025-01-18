using System;
using FluentAssertions;
using JolpicaApi.Client.Caching;
using JolpicaApi.Responses;
using Xunit;

namespace JolpicaApi.Tests.Client.Caching
{
    public class JolpiMemoryCacheTests
    {
        private JolpiMemoryCache Cache { get; }

        public JolpiMemoryCacheTests()
        {
            Cache = new JolpiMemoryCache();
        }

        [Theory]
        [AutoMockedData]
        public void ExpiredResponseIsNotReturned(string url, JolpiResponse response)
        {
            // Arrange
            Cache.CacheEntryLifetime = TimeSpan.FromMinutes(-1);
            Cache.AddOrReplace(url, response);

            // Act
            var cachedResponse = Cache.Get<JolpiResponse>(url);

            // Assert
            cachedResponse.Should().BeNull();
        }

        [Theory]
        [AutoMockedData]
        public void CachedResponseIsReturned(string url, JolpiResponse response)
        {
            // Arrange
            Cache.CacheEntryLifetime = TimeSpan.FromMinutes(1);
            Cache.AddOrReplace(url, response);

            // Act
            var cachedResponse = Cache.Get<JolpiResponse>(url);

            // Assert
            cachedResponse.Should().Be(response);
        }
    }
}
