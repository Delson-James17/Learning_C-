using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_csharp
{
    internal class Task4_Fibonacci
    {
        static public void fibonacci()
        {
            int max = 4000000;
            int next = 0;
            int sum = 0;
            int prev = 1;
            while (next <= max)
            {
                Console.WriteLine(next);
                next = sum + prev;
                sum = prev;
                prev = next;
            }
            Console.WriteLine("The sum of even-valued terms in the Fibonacci sequence up to four million is: " + sum); // output the sum of even-valued terms 3524578
        }
    }
}
