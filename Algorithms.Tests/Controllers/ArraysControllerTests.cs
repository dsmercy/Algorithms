using Xunit;
using Microsoft.AspNetCore.Mvc;
using Algorithms.Controllers;

namespace Algorithms.Tests.Controllers
{
    public class ArraysControllerTests
    {
        private readonly ArraysController _controller;

        public ArraysControllerTests()
        {
            _controller = new ArraysController();
        }

        [Fact]
        public void MinMax_ValidInput_ReturnsCorrectResult()
        {
            // Arrange
            var input = new int[] { 10, 50, 1, 3, 55, 1000 };

            // Act
            var result = _controller.MinMax(input) as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(200, result.StatusCode);
            Assert.Equal("Min: 1 and Max: 1000", result.Value);
        }

        [Fact]
        public void MinMax_SingleElement_ReturnsSameMinAndMax()
        {
            // Arrange
            var input = new int[] { 42 };

            // Act
            var result = _controller.MinMax(input) as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(200, result.StatusCode);
            Assert.Equal("Min: 42 and Max: 42", result.Value);
        }

        [Fact]
        public void MinMax_NegativeNumbers_ReturnsCorrectResult()
        {
            // Arrange
            var input = new int[] { -10, -50, -1, -3, -55, -1000 };

            // Act
            var result = _controller.MinMax(input) as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(200, result.StatusCode);
            Assert.Equal("Min: -1000 and Max: -1", result.Value);
        }
    }
}
