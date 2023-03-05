using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_csharp
{
    internal class Task2_Fizz_buzz
    {
        static void fizz_buzz()
        {
            /*Task 2:
    Write a program that prints the integers from 1 to 100. But for multiples of three print \"Fizz\" instead of the number, and for the multiples of five print \"Buzz\". For numbers which are multiples of both three and five print \"FizzBuzz\"."

    Example: 1,2,Fizz,4,Buzz,Fizz,7,8,Fizz,Buzz,11,Fizz,13,14,FizzBuzz,16*/
            int n = 100;

            // Loop for 100 times
            for (int i = 1; i <= n; i++)
            {

                if (i % 15 == 0)
                    Console.Write("FizzBuzz" + " ");
                else if (i % 3 == 0)
                    Console.Write("Fizz" + " ");

                else if (i % 5 == 0)
                    Console.Write("Buzz" + " ");

                else
                    Console.Write(i + " ");
            }
        }
    }
}
