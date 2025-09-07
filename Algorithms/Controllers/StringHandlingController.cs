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
        public IActionResult ReverseString(string input="abcdef", [FromQuery]bool useInbuiltFunction = false)
        {
            if (useInbuiltFunction) {
                //with inbuilt function

                char[] charArray = input.ToCharArray();
                Array.Reverse(charArray);
                return Ok(new string(charArray));
            }

            string stringOutput = string.Empty;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                stringOutput += input[i];
            }

            return Ok(stringOutput);
        }

        /// <summary>
        /// Reverse a Sentence with changing order of words
        /// </summary>
        /// <returns></returns>
        [HttpGet("reverse/sentence/withorder")]
        public IActionResult ReverseSentence(string input="do you bleed", bool useInbuiltFunction = false)
        {
            if (useInbuiltFunction)
            {
                //with inbuilt function

                char[] charArray = input.ToCharArray();
                Array.Reverse(charArray);
                return Ok(new string(charArray));
            }

            string stringOutput = string.Empty;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                stringOutput += input[i];
            }

            return Ok(stringOutput);
        }

        /// <summary>
        /// Reverse a Sentence without changing order of words
        /// </summary>
        /// <returns></returns>
        [HttpGet("reverse/sentence/withoutorder")]
        public IActionResult ReverseSentenceWithoutOrder(string input="you will", bool useInbuiltFunction = false)
        {
            if (useInbuiltFunction)
            {
                //with inbuilt function

                string[] inputStringArray2 = input.Split(' ');

                Array.Reverse(inputStringArray2);
                string outputString2 = string.Join(" ", inputStringArray2);
                return Ok(outputString2);
            }

            string[] inputStringArray = input.Split(' ');

            string outputString = string.Empty;

            for (int i = inputStringArray.Length - 1; i >= 0; i--)
            {
                outputString += inputStringArray[i] + " ";
            }

            return Ok(outputString.TrimEnd());
        }

        /// <summary>
        /// sort a string in alphabetical order
        /// </summary>
        /// <returns></returns>
        [HttpGet("sort/alphabetical")]
        public IActionResult SortString(string input="bcadgf", bool useInbuiltFunction = false)
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
        public IActionResult CharOccurnace(string input="", bool useInbuiltFunction = false)
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
        public IActionResult RemoveDuplicates(string input, bool useInbuiltFunction = false)
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
        public IActionResult SubstringSearch(string mainString, string subString, bool useInbuiltFunction = false)
        {
            return Ok(mainString.Contains(subString)?"Yes":"No");
        }

        /// <summary>
        /// Substring Replace
        /// </summary>
        /// <returns></returns>
        [HttpGet("substring/search")]
        public IActionResult SubstringReplace(string mainString, string oldSubstring, string newSubstring, bool useInbuiltFunction = false)
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
        /// <remarks>
        /// An *anagram* is a word or phrase formed by rearranging the letters of another word or phrase.
        /// Example: "listen" and "silent".
        /// </remarks>
        /// <returns></returns>
        [HttpGet("anagram")]
        public IActionResult AnagramStrings(string input, string input2, bool useInbuiltFunction = false)
        {
            char[] charArray1 = input.ToCharArray();
            char[] charArray2 = input2.ToCharArray();
            Array.Sort(charArray1);
            Array.Sort(charArray2);
            return Ok(new string(charArray1) == new string(charArray2) ? "Anagram" : "Not Anagram");

        }

        /// <summary>
        /// Count the number of vowels in a string
        /// </summary>
        /// <remarks>
        /// Vowels are considered to be 'a', 'e', 'i', 'o', 'u' (case insensitive).
        /// Example: "hello" contains 2 vowels ('e' and 'o').
        /// </remarks>
        /// <returns>Number of vowels in the input string</returns>
        [HttpGet("count-vowels")]
        public IActionResult CountVowels(string input, bool useInbuiltFunction = false)
        {
            if (string.IsNullOrEmpty(input))
                return Ok(0);

            int vowelCount;

            if (useInbuiltFunction)
            {
                // Using LINQ and built-in functions
                vowelCount = input.Count(c => "aeiouAEIOU".Contains(c));
            }
            else
            {
                // Manual implementation
                vowelCount = 0;
                string vowels = "aeiouAEIOU";

                for (int i = 0; i < input.Length; i++)
                {
                    for (int j = 0; j < vowels.Length; j++)
                    {
                        if (input[i] == vowels[j])
                        {
                            vowelCount++;
                            break;
                        }
                    }
                }
            }

            return Ok(new { Input = input, VowelCount = vowelCount });
        }

        /// <summary>
        /// Find the first non-repeating character in a string and return its index
        /// </summary>
        /// <remarks>
        /// A non-repeating character appears exactly once in the string.
        /// Example: In "leetcode", 'l' is the first non-repeating character at index 0.
        /// Returns -1 if no non-repeating character is found.
        /// </remarks>
        /// <returns>Index of first non-repeating character or -1 if none found</returns>
        [HttpGet("first-non-repeating")]
        public IActionResult FirstNonRepeatingCharacter(string input, bool useInbuiltFunction = false)
        {
            if (string.IsNullOrEmpty(input))
                return Ok(new { Input = input, Index = -1, Character = (char?)null });

            int firstIndex;
            char? firstChar = null;

            if (useInbuiltFunction)
            {
                // Using LINQ and built-in functions
                var charGroups = input
                    .Select((c, i) => new { Character = c, Index = i })
                    .GroupBy(x => x.Character)
                    .Where(g => g.Count() == 1)
                    .OrderBy(g => g.First().Index)
                    .FirstOrDefault();

                if (charGroups != null)
                {
                    firstIndex = charGroups.First().Index;
                    firstChar = charGroups.Key;
                }
                else
                {
                    firstIndex = -1;
                }
            }
            else
            {
                // Manual implementation using dictionary
                var charCount = new Dictionary<char, int>();

                // Count frequency of each character
                for (int i = 0; i < input.Length; i++)
                {
                    if (charCount.ContainsKey(input[i]))
                        charCount[input[i]]++;
                    else
                        charCount[input[i]] = 1;
                }

                // Find first character with count 1
                firstIndex = -1;
                for (int i = 0; i < input.Length; i++)
                {
                    if (charCount[input[i]] == 1)
                    {
                        firstIndex = i;
                        firstChar = input[i];
                        break;
                    }
                }
            }

            return Ok(new { Input = input, Index = firstIndex, Character = firstChar });
        }

        /// <summary>
        /// Check if parentheses are valid (properly opened and closed)
        /// </summary>
        /// <remarks>
        /// Valid parentheses include '()', '[]', '{}' and their combinations.
        /// Each opening bracket must have a corresponding closing bracket in the correct order.
        /// Example: "()[]{}" is valid, "([)]" is not valid.
        /// </remarks>
        /// <returns>True if parentheses are valid, false otherwise</returns>
        [HttpGet("valid-parentheses")]
        public IActionResult ValidParentheses(string input, bool useInbuiltFunction = false)
        {
            if (string.IsNullOrEmpty(input))
                return Ok(new { Input = input, IsValid = true });

            bool isValid;

            if (useInbuiltFunction)
            {
                // Using Stack<T> (built-in collection)
                var stack = new Stack<char>();
                var pairs = new Dictionary<char, char> { { ')', '(' }, { ']', '[' }, { '}', '{' } };

                foreach (char c in input)
                {
                    if (c == '(' || c == '[' || c == '{')
                    {
                        stack.Push(c);
                    }
                    else if (c == ')' || c == ']' || c == '}')
                    {
                        if (stack.Count == 0 || stack.Pop() != pairs[c])
                        {
                            return Ok(new { Input = input, IsValid = false });
                        }
                    }
                }

                isValid = stack.Count == 0;
            }
            else
            {
                // Manual implementation using array as stack
                char[] stack = new char[input.Length];
                int top = -1;

                for (int i = 0; i < input.Length; i++)
                {
                    char c = input[i];

                    if (c == '(' || c == '[' || c == '{')
                    {
                        // Push to stack
                        top++;
                        if (top >= stack.Length)
                        {
                            isValid = false;
                            return Ok(new { Input = input, IsValid = isValid });
                        }
                        stack[top] = c;
                    }
                    else if (c == ')' || c == ']' || c == '}')
                    {
                        // Check if stack is empty
                        if (top == -1)
                        {
                            isValid = false;
                            return Ok(new { Input = input, IsValid = isValid });
                        }

                        // Pop and check matching
                        char popped = stack[top];
                        top--;

                        if ((c == ')' && popped != '(') ||
                            (c == ']' && popped != '[') ||
                            (c == '}' && popped != '{'))
                        {
                            isValid = false;
                            return Ok(new { Input = input, IsValid = isValid });
                        }
                    }
                }

                isValid = top == -1;
            }

            return Ok(new { Input = input, IsValid = isValid });
        }

        /// <summary>
        /// Count how many palindromic substrings exist in string
        /// </summary>
        /// <remarks>
        /// A palindromic substring reads the same forwards and backwards.
        /// Example: "abc" has 3 palindromic substrings ("a", "b", "c").
        /// Example: "aaa" has 6 palindromic substrings ("a", "a", "a", "aa", "aa", "aaa").
        /// </remarks>
        /// <returns>Count of palindromic substrings</returns>
        [HttpGet("palindromic-substrings")]
        public IActionResult CountPalindromicSubstrings(string input, bool useInbuiltFunction = false)
        {
            if (string.IsNullOrEmpty(input))
                return Ok(new { Input = input, Count = 0 });

            int count;

            if (useInbuiltFunction)
            {
                // Using LINQ and built-in string methods
                count = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    for (int j = i; j < input.Length; j++)
                    {
                        string substring = input.Substring(i, j - i + 1);
                        string reversed = new string(substring.Reverse().ToArray());
                        if (substring.Equals(reversed, StringComparison.Ordinal))
                            count++;
                    }
                }
            }
            else
            {
                // Manual implementation - expand around centers
                count = 0;

                for (int i = 0; i < input.Length; i++)
                {
                    // Odd length palindromes (center at i)
                    count += ExpandAroundCenter(input, i, i);

                    // Even length palindromes (center between i and i+1)
                    count += ExpandAroundCenter(input, i, i + 1);
                }
            }

            return Ok(new { Input = input, Count = count });
        }

        // Helper method for palindromic substrings
        private int ExpandAroundCenter(string s, int left, int right)
        {
            int count = 0;
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                count++;
                left--;
                right++;
            }
            return count;
        }

        /// <summary>
        /// Check if string represents a valid number
        /// </summary>
        /// <remarks>
        /// Valid numbers include integers, decimals, and scientific notation.
        /// Examples: "0", "0.1", " 0.1 ", "abc" (false), "1 a" (false), "2e10", "+6e-1"
        /// Handles leading/trailing whitespace, signs, decimal points, and scientific notation.
        /// </remarks>
        /// <returns>True if string represents a valid number, false otherwise</returns>
        [HttpGet("valid-number")]
        public IActionResult IsValidNumber(string input, bool useInbuiltFunction = false)
        {
            if (string.IsNullOrEmpty(input))
                return Ok(new { Input = input, IsValid = false });

            bool isValid;

            if (useInbuiltFunction)
            {
                // Using built-in parsing methods
                isValid = double.TryParse(input.Trim(), out _);
            }
            else
            {
                // Manual implementation
                string s = input.Trim();
                if (string.IsNullOrEmpty(s))
                {
                    isValid = false;
                }
                else
                {
                    isValid = IsValidNumberManual(s);
                }
            }

            return Ok(new { Input = input, IsValid = isValid });
        }

        // Helper method for manual number validation
        private bool IsValidNumberManual(string s)
        {
            int i = 0;
            int n = s.Length;

            // Check for sign
            if (i < n && (s[i] == '+' || s[i] == '-'))
                i++;

            bool isNumeric = false;

            // Check for digits before decimal point
            while (i < n && char.IsDigit(s[i]))
            {
                i++;
                isNumeric = true;
            }

            // Check for decimal point
            if (i < n && s[i] == '.')
            {
                i++;
                // Check for digits after decimal point
                while (i < n && char.IsDigit(s[i]))
                {
                    i++;
                    isNumeric = true;
                }
            }

            // Must have at least one digit
            if (!isNumeric)
                return false;

            // Check for scientific notation
            if (i < n && (s[i] == 'e' || s[i] == 'E'))
            {
                i++;

                // Check for sign in exponent
                if (i < n && (s[i] == '+' || s[i] == '-'))
                    i++;

                // Must have at least one digit in exponent
                if (i >= n || !char.IsDigit(s[i]))
                    return false;

                while (i < n && char.IsDigit(s[i]))
                    i++;
            }

            // Should have consumed all characters
            return i == n;
        }

        /// <summary>
        /// Find the longest word in a sentence
        /// </summary>
        /// <remarks>
        /// Words are separated by spaces. Punctuation is considered part of the word.
        /// Example: "The quick brown fox" returns "quick" or "brown" (both have length 5).
        /// If multiple words have the same max length, returns the first one found.
        /// </remarks>
        /// <returns>The longest word in the sentence</returns>
        [HttpGet("longest-word")]
        public IActionResult LongestWordInSentence(string input, bool useInbuiltFunction = false)
        {
            if (string.IsNullOrEmpty(input))
                return Ok(new { Input = input, LongestWord = "", Length = 0 });

            string longestWord;
            int maxLength;

            if (useInbuiltFunction)
            {
                // Using LINQ and built-in string methods
                var words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (words.Length == 0)
                {
                    longestWord = "";
                    maxLength = 0;
                }
                else
                {
                    longestWord = words.OrderByDescending(w => w.Length).First();
                    maxLength = longestWord.Length;
                }
            }
            else
            {
                // Manual implementation
                longestWord = "";
                maxLength = 0;
                string currentWord = "";

                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == ' ')
                    {
                        if (currentWord.Length > maxLength)
                        {
                            maxLength = currentWord.Length;
                            longestWord = currentWord;
                        }
                        currentWord = "";
                    }
                    else
                    {
                        currentWord += input[i];
                    }
                }

                // Check the last word
                if (currentWord.Length > maxLength)
                {
                    maxLength = currentWord.Length;
                    longestWord = currentWord;
                }
            }

            return Ok(new { Input = input, LongestWord = longestWord, Length = maxLength });
        }
    }
}
