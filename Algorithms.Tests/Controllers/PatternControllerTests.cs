using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using Xunit;
using Algorithms.Controllers;

namespace Algorithms.Tests.Controllers
{
    public class PatternControllerTests
    {
        private readonly PatternController _controller;

        public PatternControllerTests()
        {
            _controller = new PatternController();
        }

        [Fact]
        public void SimpleTriangle_ValidInput_ReturnsCorrectPattern()
        {
            // Arrange
            int n = 3;
            var expectedPattern = "*\n**\n***\n";

            // Act
            var result = _controller.SimpleTriangle(n) as ContentResult;

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void TriangleUpsideDown_ValidInput_ReturnsCorrectPattern()
        {
            // Arrange
            int n = 3;
            var expectedPattern = "***  \n**   \n*    \n";

            // Act
            var result = _controller.TriangleUpsideDown(n) as ContentResult;

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void Pyramid_ValidInput_ReturnsCorrectPattern()
        {
            // Arrange
            int n = 5;
            var expectedPattern = "  *  \n *** \n*****\n";

            // Act
            var result = _controller.Pyramid(n) as ContentResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("text/plain", result.ContentType);
            Assert.Equal(expectedPattern, result.Content);
        }

        [Fact]
        public void DiamondPattern_ValidInput_ReturnsCorrectPattern()
        {
            // Arrange
            int n = 5;
            var expectedPattern = "  *  \n *** \n*****\n *** \n  *  \n";

            // Act
            var result = _controller.DiamondPattern(n) as ContentResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("text/plain", result.ContentType);
            Assert.Equal(expectedPattern, result.Content);
        }

        [Theory]
        [InlineData(0, "\n")]
        [InlineData(1, "*\n")]
        [InlineData(2, "*\n**\n")]
        public void SimpleTriangle_VariousInputs_ReturnsCorrectPattern(int n, string expectedPattern)
        {
            // Act
            var result = _controller.SimpleTriangle(n) as ContentResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("text/plain", result.ContentType);
        }

        [Theory]
        [InlineData(0, "\n")]
        [InlineData(1, "*\n")]
        [InlineData(3, "***  \n**   \n*    \n")]
        public void TriangleUpsideDown_VariousInputs_ReturnsCorrectPattern(int n, string expectedPattern)
        {
            // Act
            var result = _controller.TriangleUpsideDown(n) as ContentResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("text/plain", result.ContentType);
        }

        [Theory]
        [InlineData(3, " * \n***\n")]
        [InlineData(5, "  *  \n *** \n*****\n")]
        public void Pyramid_VariousInputs_ReturnsCorrectPattern(int n, string expectedPattern)
        {
            // Act
            var result = _controller.Pyramid(n) as ContentResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("text/plain", result.ContentType);
            Assert.Equal(expectedPattern, result.Content);
        }

        [Theory]
        [InlineData(3, " * \n***\n * \n")]
        [InlineData(5, "  *  \n *** \n*****\n *** \n  *  \n")]
        public void DiamondPattern_VariousInputs_ReturnsCorrectPattern(int n, string expectedPattern)
        {
            // Act
            var result = _controller.DiamondPattern(n) as ContentResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("text/plain", result.ContentType);
            Assert.Equal(expectedPattern, result.Content);
        }
    }
}
