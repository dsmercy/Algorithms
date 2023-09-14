using Microsoft.AspNetCore.Mvc;

namespace Algorithms.Controllers
{
    [Route("api/string")]
    [ApiController]
    public class StringHandlingController : ControllerBase
    {
        /// <summary>
        /// Reverse a String
        /// </summary>
        /// <returns></returns>
        [HttpGet("reverse")]
        public IActionResult ReverseString(string input="abcdef")
        {
            string stringOutput = string.Empty;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                stringOutput += input[i];
            }

            return Ok(stringOutput);

            //with inbuilt function

            //char[] charArray = input.ToCharArray();
            //Array.Reverse(charArray);
            //return Ok(new string(charArray));

        }

        /// <summary>
        /// Reverse a Sentence with changing order of words
        /// </summary>
        /// <returns></returns>
        [HttpGet("reverse/sentence/withorder")]
        public IActionResult ReverseSentence(string input="do you bleed")
        {
            string stringOutput = string.Empty;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                stringOutput += input[i];
            }

            return Ok(stringOutput);

            //with inbuilt function

            //char[] charArray = input.ToCharArray();
            //Array.Reverse(charArray);
            //return Ok(new string(charArray));

        }

        /// <summary>
        /// Reverse a Sentence without changing order of words
        /// </summary>
        /// <returns></returns>
        [HttpGet("reverse/sentence/withoutorder")]
        public IActionResult ReverseSentenceWithoutOrder(string input="you will")
        {
            string[] inputStringArray = input.Split(' ');

            string outputString = string.Empty;

            for (int i = inputStringArray.Length - 1; i >= 0; i--)
            {
                outputString += inputStringArray[i] + " ";
            }

            return Ok(outputString.TrimEnd());

            //with inbuilt function

            //string[] inputStringArray = input.Split(' ');

            //Array.Reverse(inputStringArray);
            //string outputString = string.Join(" ", inputStringArray);
            //return Ok(outputString);

        }

        /// <summary>
        /// sort a string in alphabetical order
        /// </summary>
        /// <returns></returns>
        [HttpGet("sort/alphabetical")]
        public IActionResult SortString(string input="bcadgf")
        {
            char[] inputStringArray = input.ToCharArray();
            Array.Sort(inputStringArray);
            
            return Ok((new string(inputStringArray)));
        }

        

        /// <summary>
        /// Count the occurrences of all characters in a string
        /// </summary>
        /// <returns></returns>
        [HttpGet("char/occurnace")]
        public IActionResult CharOccurnace(string input="")
        {
            // Create a dictionary to store character counts
            Dictionary<char, int> charCounts = new Dictionary<char, int>();

            // Iterate through each character in the input string
            foreach (char c in input)
            {
                // If the character is not in the dictionary, add it with a count of 1
                if (!charCounts.ContainsKey(c))
                {
                    charCounts[c] = 1;
                }
                else
                {
                    // If the character is already in the dictionary, increment its count
                    charCounts[c]++;
                }
            }

            string output = string.Empty;

            // Display the character counts
            foreach (var kvp in charCounts)
            {
                output += $"Character '{kvp.Key}': {kvp.Value} times"+"\n";
            }

            return Ok(output);
        }

        /// <summary>
        /// Remove duplicate characters from a string.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpGet("remove/duplicate")]
        public IActionResult RemoveDuplicates(string input)
        {
            char[] charArray = input.ToCharArray();
            string output = string.Empty;

            for (int i = 0; i <= charArray.Length -1; i++)
            {
                if (!output.Contains(charArray[i])) {
                output+= charArray[i];  
                }
            }
            return Ok(output);

            //with inbuilt function
            //return Ok(new string(input.Distinct().ToArray()));
        }
               

        /// <summary>
        /// Substring Search
        /// </summary>
        /// <returns></returns>
        [HttpGet("substring/replace")]
        public IActionResult SubstringSearch(string mainString, string subString)
        {
            return Ok(mainString.Contains(subString)?"Yes":"No");
        }

        /// <summary>
        /// Substring Replace
        /// </summary>
        /// <returns></returns>
        [HttpGet("substring/search")]
        public IActionResult SubstringReplace(string mainString, string oldSubstring, string newSubstring)
        {
            return Ok(mainString.Replace(oldSubstring, newSubstring));
        }

        /// <summary>
        /// Palindrome (reads the same forwards and backwards).
        /// </summary>
        /// <returns></returns>
        [HttpGet("palindrome")]
        public IActionResult Palindrome(string input = "abba")
        {
            string stringOutput = string.Empty;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                stringOutput += input[i];
            }

            return Ok(stringOutput == input ? "Palindrome" : "Not Palindrome");

            //with inbuilt function

            //char[] charArray = input.ToCharArray();
            //Array.Reverse(charArray);
            //return Ok(Ok(new string(charArray) == input ? "Palindrome" : "Not Palindrome"));

        }

        /// <summary>
        /// Determine if two strings are anagrams of each other(strings contains same characters)
        /// </summary>
        /// <returns></returns>
        [HttpGet("anagram")]
        public IActionResult AnagramStrings(string input, string input2)
        {
            char[] charArray1 = input.ToCharArray();
            char[] charArray2 = input2.ToCharArray();
            Array.Sort(charArray1);
            Array.Sort(charArray2);
            return Ok(new string(charArray1) == new string(charArray2) ? "Anagram" : "Not Anagram");

        }
    }
}
