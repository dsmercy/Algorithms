using Microsoft.AspNetCore.Mvc;

namespace Algorithms.Controllers
{
    [Route("api/number")]
    [ApiController]
    public class NumberHandlingController : ControllerBase
    {   
        /// <summary>
        /// Prime number
        /// </summary>
        /// <returns></returns>
        [HttpGet("prime")]
        public IActionResult PrimeNumber(int input = 9)
        {
            if (input <= 1)
                return Ok("Not Prime");

            for (int i = 2; i <= input - 1; i++)
            {
                if (input % i == 0)
                {
                    return Ok("Not Prime");
                }
                else
                {
                    continue;
                }
            }

            return Ok("Prime Number");
        }

        /// <summary>
        /// Leap Year
        /// </summary>
        /// <returns></returns>
        [HttpGet("leapyear")]
        public IActionResult LeapYear(int input = 1994)
        {
            return Ok(input % 4 == 0 ? "Leap Year" : "Not Leap Year");
        }

        /// <summary>
        /// Armstrong Number(sum of its digits, each raised to the nth(count of digits) power, equals the number itself)
        /// </summary>
        /// <returns></returns>
        [HttpGet("armstrong")]
        public IActionResult ArmstrongNumber(int input = 153)
        {
            int originalNumber = input;
            int numberOfDigits = (int)Math.Floor(Math.Log10(input) + 1);
            int sum = 0;

            while (input > 0)
            {
                int digit = input % 10;
                sum += (int)Math.Pow(digit, numberOfDigits);
                input /= 10;
            }

            return Ok(originalNumber == sum ? "Armstrong Number" : "Not Armstrong Number");
        }

        /// <summary>
        /// fibonacci series(sequence of numbers where each number is the sum of the two preceding ones)
        /// </summary>
        /// <returns></returns>
        [HttpGet("fibonacciseries")]
        public IActionResult FibonacciSeries(string input = "0112358")
        {
            char[] inputArray = input.ToCharArray();

            // Convert char[] to int[] using LINQ
            int[] intArray = inputArray.Select(c => (int)Char.GetNumericValue(c)).ToArray();

            for (int i = 0; i <= intArray.Length - 3; i++)
            {
                if (intArray[i + 2] == intArray[i] + intArray[i + 1])
                {
                    continue;
                }
                else
                {
                    return Ok("Not Fibonacci");
                }
            }

            return Ok("Fibonacci");
        }
    }
}
