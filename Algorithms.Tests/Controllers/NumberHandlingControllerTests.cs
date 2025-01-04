using Xunit;
using Microsoft.AspNetCore.Mvc;
using Algorithms.Controllers;

namespace Algorithms.Tests.Controllers
{
    public class NumberHandlingControllerTests
    {
        private readonly NumberHandlingController _controller;

        public NumberHandlingControllerTests()
        {
            _controller = new NumberHandlingController();
        }

        [Fact]
        public void PrimeNumber_InputIsPrime_ReturnsPrimeNumber()
        {
            // Arrange
            int input = 7;

            // Act
            var result = _controller.PrimeNumber(input) as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Prime Number", result.Value);
        }

        [Fact]
        public void PrimeNumber_InputIsNotPrime_ReturnsNotPrime()
        {
            // Arrange
            int input = 8;

            // Act
            var result = _controller.PrimeNumber(input) as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Not Prime", result.Value);
        }

        [Fact]
        public void LeapYear_InputIsLeapYear_ReturnsLeapYear()
        {
            // Arrange
            int input = 2000;

            // Act
            var result = _controller.LeapYear(input) as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Leap Year", result.Value);
        }

        [Fact]
        public void LeapYear_InputIsNotLeapYear_ReturnsNotLeapYear()
        {
            // Arrange
            int input = 1999;

            // Act
            var result = _controller.LeapYear(input) as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Not Leap Year", result.Value);
        }

        [Fact]
        public void ArmstrongNumber_InputIsArmstrongNumber_ReturnsArmstrongNumber()
        {
            // Arrange
            int input = 153;

            // Act
            var result = _controller.ArmstrongNumber(input) as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Armstrong Number", result.Value);
        }

        [Fact]
        public void ArmstrongNumber_InputIsNotArmstrongNumber_ReturnsNotArmstrongNumber()
        {
            // Arrange
            int input = 123;

            // Act
            var result = _controller.ArmstrongNumber(input) as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Not Armstrong Number", result.Value);
        }

        [Fact]
        public void FibonacciSeries_InputIsFibonacci_ReturnsFibonacci()
        {
            // Arrange
            string input = "0112358";

            // Act
            var result = _controller.FibonacciSeries(input) as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Fibonacci", result.Value);
        }

        [Fact]
        public void FibonacciSeries_InputIsNotFibonacci_ReturnsNotFibonacci()
        {
            // Arrange
            string input = "0112345";

            // Act
            var result = _controller.FibonacciSeries(input) as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Not Fibonacci", result.Value);
        }
    }
}
