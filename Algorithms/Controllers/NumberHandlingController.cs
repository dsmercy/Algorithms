using Microsoft.AspNetCore.Mvc;

namespace Algorithms.Controllers
{
    [Route("api/number")]
    [ApiController]
    public class NumberHandlingController : ControllerBase
    {
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
