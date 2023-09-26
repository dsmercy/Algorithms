using Microsoft.AspNetCore.Mvc;

namespace Algorithms.Controllers
{
    [Route("api/arrays")]
    [ApiController]
    public class ArraysController : Controller
    {
        //private const int[] Ints = new int[] { 10, 50, 1, 3, 55, 1000 };

        /// <summary>
        /// Get min and max number
        /// </summary>
        /// <returns></returns>
        [HttpPost("minmax")]
        public IActionResult MinMax(int[] input)
        {
            Array.Sort(input);
            int min = input[0];
            int max = input[input.Length-1];

            return Ok($"Min: {min} and Max: {max}");
        }
    }
}
