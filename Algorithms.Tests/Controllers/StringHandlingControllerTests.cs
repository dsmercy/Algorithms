using Algorithms.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Algorithms.Tests.Controllers
{
    public class StringHandlingControllerTests
    {
        private readonly StringHandlingController _controller;

        public StringHandlingControllerTests()
        {
            _controller = new StringHandlingController();
        }

        [Fact]
        public void ReverseString_ReturnsReversedString()
        {
            // Arrange
            string input = "abcdef";

            // Act
            var result = _controller.ReverseString(input) as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("fedcba", result.Value);
        }

        [Fact]
        public void ReverseSentence_ReturnsReversedSentence()
        {
            // Arrange
            string input = "do you bleed";

            // Act
            var result = _controller.ReverseSentence(input) as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("deelb uoy od", result.Value);
        }

        [Fact]
        public void ReverseSentenceWithoutOrder_ReturnsReversedWordsOrder()
        {
            // Arrange
            string input = "you will";

            // Act
            var result = _controller.ReverseSentenceWithoutOrder(input) as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("will you", result.Value);
        }

        [Fact]
        public void SortString_ReturnsAlphabeticallySortedString()
        {
            // Arrange
            string input = "bcadgf";

            // Act
            var result = _controller.SortString(input) as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("abcdfg", result.Value);
        }

        [Fact]
        public void CharOccurnace_ReturnsCharacterOccurrences()
        {
            // Arrange
            string input = "hello";

            // Act
            var result = _controller.CharOccurnace(input) as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            string expected = "Character 'h': 1 times\nCharacter 'e': 1 times\nCharacter 'l': 2 times\nCharacter 'o': 1 times\n";
            Assert.Equal(expected, result.Value);
        }

        [Fact]
        public void RemoveDuplicates_ReturnsStringWithoutDuplicates()
        {
            // Arrange
            string input = "aabbcc";

            // Act
            var result = _controller.RemoveDuplicates(input) as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("abc", result.Value);
        }

        [Fact]
        public void SubstringSearch_ReturnsYesIfSubstringFound()
        {
            // Arrange
            string mainString = "hello world";
            string subString = "world";

            // Act
            var result = _controller.SubstringSearch(mainString, subString) as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Yes", result.Value);
        }

        [Fact]
        public void SubstringSearch_ReturnsNoIfSubstringNotFound()
        {
            // Arrange
            string mainString = "hello world";
            string subString = "planet";

            // Act
            var result = _controller.SubstringSearch(mainString, subString) as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("No", result.Value);
        }

        [Fact]
        public void SubstringReplace_ReturnsStringWithReplacedSubstring()
        {
            // Arrange
            string mainString = "hello world";
            string oldSubstring = "world";
            string newSubstring = "planet";

            // Act
            var result = _controller.SubstringReplace(mainString, oldSubstring, newSubstring) as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("hello planet", result.Value);
        }

        [Fact]
        public void Palindrome_ReturnsPalindromeForValidInput()
        {
            // Arrange
            string input = "abba";

            // Act
            var result = _controller.Palindrome(input) as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Palindrome", result.Value);
        }

        [Fact]
        public void Palindrome_ReturnsNotPalindromeForInvalidInput()
        {
            // Arrange
            string input = "abcd";

            // Act
            var result = _controller.Palindrome(input) as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Not Palindrome", result.Value);
        }

        [Fact]
        public void AnagramStrings_ReturnsAnagramForValidInput()
        {
            // Arrange
            string input1 = "listen";
            string input2 = "silent";

            // Act
            var result = _controller.AnagramStrings(input1, input2) as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Anagram", result.Value);
        }

        [Fact]
        public void AnagramStrings_ReturnsNotAnagramForInvalidInput()
        {
            // Arrange
            string input1 = "hello";
            string input2 = "world";

            // Act
            var result = _controller.AnagramStrings(input1, input2) as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Not Anagram", result.Value);
        }
    }
}