using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_csharp
{
    internal class Task5_Array
    {
        static public void Array()
        {
            int[] numbers = { 10, 20, 10, 40, 50, 60, 70 }; // initialize the array of numbers
            int target = 50; // initialize the target number
            int n = numbers.Length; // get the length of the array

            for (int i = 0; i < n - 1; i++) // loop through the array from the beginning up to the second-to-last element
            {
                for (int j = i + 1; j < n; j++) // loop through the array from the element after i to the end
                {
                    if (numbers[i] + numbers[j] == target) // if the sum of the two elements equals the target number
                    {
                        Console.WriteLine("Output: " + i + ", " + j); // output the indices of the two elements
                        return; // exit the function
                    }
                }
            }

            Console.WriteLine("No pair of elements in the array has a sum equal to the target number."); // output if no pair of elements in the array has a sum equal to the target number
        }
    }
}
