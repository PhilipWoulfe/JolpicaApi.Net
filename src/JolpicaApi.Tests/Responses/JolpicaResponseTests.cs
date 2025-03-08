﻿using FluentAssertions;
using JolpicaApi.Responses;
using Xunit;

namespace JolpicaApi.Tests.Responses
{
    public class JolpiResponseTests
    {
        [Theory]
        [AutoMockedData(0, 0, 1)]
        [AutoMockedData(10, 0, 11)]
        [AutoMockedData(0, 10, 11)]
        [AutoMockedData(10, 10, 21)]
        [AutoMockedData(20, 10, 31)]
        [AutoMockedData(0, 10, 1000)]
        public void HasMorePages_TotalResultsGreaterThanLimitPlusOffset_ShouldBeTrue(int offset, int limit, int totalResults)
        {
            // Arrange
            var response = new MockJolpiResponse(offset, limit, totalResults);

            // Assert
            response.HasMorePages.Should().BeTrue();
        }

        [Theory]
        [AutoMockedData(0, 0, 0)]
        [AutoMockedData(0, 10, 0)]
        [AutoMockedData(0, 10, 10)]
        [AutoMockedData(10, 0, 0)]
        [AutoMockedData(10, 0, 9)]
        [AutoMockedData(10, 0, 10)]
        [AutoMockedData(10, 10, 0)]
        [AutoMockedData(10, 10, 20)]
        [AutoMockedData(20, 10, 30)]
        public void HasMorePages_TotalResultsLessThanOrEqualToLimitPlusOffset_ShouldBeFalse(int offset, int limit, int totalResults)
        {
            // Arrange
            var response = new MockJolpiResponse(offset, limit, totalResults);

            // Assert
            response.HasMorePages.Should().BeFalse();
        }

        [Theory]
        [AutoMockedData(1, 0, 0)]
        [AutoMockedData(1, 0, 10)]
        [AutoMockedData(1, 0, 10)]
        [AutoMockedData(2, 10, 10)]
        public void Page(int expectedPage, int offset, int limit)
        {
            // Arrange
            var response = new MockJolpiResponse(offset, limit);

            // Assert
            response.Page.Should().Be(expectedPage);
        }

        [Theory]
        [AutoMockedData(1, 0, -1)]
        [AutoMockedData(1, 0, 0)]
        [AutoMockedData(1, 10, -1)]
        [AutoMockedData(1, 10, 0)]
        public void Page_LimitIsEqualToOrLessThanZero_ShouldBeOne(int expectedPage, int offset, int limit)
        {
            // Arrange
            var response = new MockJolpiResponse(offset, limit);

            // Assert
            response.Page.Should().Be(expectedPage);
        }

        [Theory]
        [AutoMockedData(1, -1, 0)]
        [AutoMockedData(1, 0, 0)]
        [AutoMockedData(1, -1, 10)]
        [AutoMockedData(1, 0, 10)]
        public void Page_OffsetIsEqualToOrLessThanZero_ShouldBeOne(int expectedPage, int offset, int limit)
        {
            // Arrange
            var response = new MockJolpiResponse(offset, limit);

            // Assert
            response.Page.Should().Be(expectedPage);
        }

        [Theory]
        [AutoMockedData(2, 3, 4)]
        [AutoMockedData(2, 3, 7)]
        [AutoMockedData(3, 11, 10)]
        [AutoMockedData(3, 15, 10)]
        public void Page_OffsetAndLimitDoesNotDivideEvenly_ShouldBeRoundedUp(int expectedPage, int offset, int limit)
        {
            // Arrange
            var response = new MockJolpiResponse(offset, limit);

            // Assert
            response.Page.Should().Be(expectedPage);
        }

        [Theory]
        [AutoMockedData(0, 10, 0)]
        [AutoMockedData(1, 10, 5)]
        [AutoMockedData(1, 10, 10)]
        [AutoMockedData(2, 10, 11)]
        [AutoMockedData(2, 10, 20)]
        [AutoMockedData(3, 10, 30)]
        [AutoMockedData(11, 10, 101)]
        public void TotalPages_WorksAsExpected(int expectedTotalPages, int limit, int totalResults)
        {
            // Arrange
            var response = new MockJolpiResponse(limit: limit, totalResults: totalResults);

            // Assert
            response.TotalPages.Should().Be(expectedTotalPages);
        }

        [Theory]
        [AutoMockedData(0, 10)]
        public void TotalPages_ReturnsZeroIfLimitIsZeroOrBelow(int limit, int totalResults)
        {
            // Arrange
            var response = new MockJolpiResponse(limit: limit, totalResults: totalResults);

            // Assert
            response.TotalPages.Should().Be(0);
        }

        private class MockJolpiResponse : JolpicaResponse
        {
            public MockJolpiResponse(int offset = 0, int limit = 0, int totalResults = 0)
            {
                Offset = offset;
                Limit = limit;
                TotalResults = totalResults;
            }
        }
    }
}
