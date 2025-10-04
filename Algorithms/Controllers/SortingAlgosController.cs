using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Algorithms.Controllers
{
    [Route("api/sorting")]
    [ApiController]
    public class SortingAlgosController : ControllerBase
    {

        /// <summary>
        /// Bubble sort
        /// </summary>
        /// <remarks>
        /// Bubble Sort repeatedly compares adjacent elements and swaps them if they are in the wrong order
        /// With each pass, the largest element "bubbles up" to the end of the list 
        /// until the array is sorted.
        /// </remarks>
        /// <returns></returns>
        [HttpPost("bubblesort")]
        public IActionResult BubbleSort(int[] input)
        {
            int n = input.Length;
            for (int i = 0; i < n - 1; i++)
            {
                // Flag to detect if any swap happens in this pass
                bool swapped = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (input[j] > input[j + 1])
                    {
                        // Swap adjacent elements
                        int temp = input[j];
                        input[j] = input[j + 1];
                        input[j + 1] = temp;

                        swapped = true;
                    }
                }

                // If no swaps happened, array is already sorted
                if (!swapped)
                    break;
            }

            return Ok(input);
        }

        /// <summary>
        /// Selection Sort
        /// </summary>
        /// <remarks>
        /// Selection Sort works by repeatedly finding the smallest (or largest) element from the unsorted part of the array and placing it at the beginning
        /// </remarks>
        /// <returns></returns>
        [HttpPost("selectionsort")]
        public IActionResult SelectionSort(int[] input)
        {
            int n = input.Length;

            for (int i = 0; i < n - 1; i++)
            {
                // Assume the minimum element is at position i
                int minIndex = i;

                // Find the index of the minimum element in the remaining array
                for (int j = i + 1; j < n; j++)
                {
                    if (input[j] < input[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // Swap the found minimum element with the element at position i
                if (minIndex != i)
                {
                    int temp = input[minIndex];
                    input[minIndex] = input[i];
                    input[i] = temp;
                }
            }

            return Ok(input);
        }
    }
}
