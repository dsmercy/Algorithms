using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace Algorithms.Controllers
{
    [Route("api/pattern")]
    [ApiController]
    public class PatternController : ControllerBase
    {
        /// <summary>
        /// Simple Triangle
        /// </summary>
        /// <returns></returns>
        [HttpGet("simpletriangle")]
        public IActionResult SimpleTriangle(int n)
        {
            var pattern = new StringBuilder();
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    pattern.Append("*");
                }
                pattern.Append("\n"); // Newline for each row
            }
            return Content(pattern.ToString(), "text/plain");
        }

        /// <summary>
        /// triangle upside down
        /// </summary>
        /// <returns></returns>
        [HttpGet("triangle/upsidedown")]
        public IActionResult TriangleUpsideDown(int n)
        {
            var pattern = new StringBuilder();
            for (int i = n; i >= 1; i--)
            {
                string spaces = new string(' ', n - i);
                string asterisk = new string('*', i);
                pattern.Append(asterisk + spaces);
                pattern.Append("\n"); // Newline for each row
            }
            return Content(pattern.ToString(), "text/plain");
        }

        /// <summary>
        /// Pyramid pattern
        /// </summary>
        /// <returns></returns>
        [HttpGet("Pyramid")]
        public IActionResult Pyramid(int n)
        {
            var pattern = new StringBuilder();
            for (int i = 1; i <= n; i += 2)
            {
                int spaces = (n - i) / 2;
                string spaceStr = new string(' ', spaces);
                string asteriskStr = new string('*', i);
                pattern.Append(spaceStr + asteriskStr + spaceStr);
                pattern.Append("\n"); // Newline for each row
            }
            return Content(pattern.ToString(), "text/plain");
        }

        /// <summary>
        /// Diamond Pattern
        /// </summary>
        /// <returns></returns>
        [HttpGet("diamond")]
        public IActionResult DiamondPattern(int n)
        {
            var pattern = new StringBuilder();

            // Upper part of the diamond
            for (int i = 1; i <= n; i += 2)
            {
                int spaces = (n - i) / 2;
                string spaceStr = new string(' ', spaces);
                string asteriskStr = new string('*', i);
                pattern.Append(spaceStr + asteriskStr + spaceStr);
                pattern.Append("\n"); // Newline for each row
            }

            // Lower part of the diamond (excluding the center)
            for (int i = n - 2; i >= 1; i -= 2)
            {
                int spaces = (n - i) / 2;
                string spaceStr = new string(' ', spaces);
                string asteriskStr = new string('*', i);
                pattern.Append(spaceStr + asteriskStr + spaceStr);
                pattern.Append("\n"); // Newline for each row
            }

            return Content(pattern.ToString(), "text/plain");
        }
    }


}
