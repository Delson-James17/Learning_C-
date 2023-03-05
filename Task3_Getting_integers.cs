using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_csharp
{
    internal class Task3_Getting_integers
    {
        static void getting_integers()
        {
            /*Task 3: 
    Given three integers between 1 and 11, if their sum is less than or equal to 21, return their sum. If their sum exceeds 21 and there's an eleven, reduce the total sum by 10. Finally, if the sum (even after adjustment) exceeds 21, return 'BUST'"
Example: [8,7,6] = return 21
         [9,8,11] = 28 - 10 = return 18
         [11,10,11] = 32 - 10 = 22 return BUST
         [8,9,10] = 27 = return BUST*/

            readinputs(out int num1, out int num2, out int num3, out int total);
            if (total <= 21)
            {
                Console.WriteLine($"[{num1}, {num2}, {num3}] = return {total}");
            }
            else if (total >= 21 && (num1 == 11 || num2 == 11 || num3 == 11))
            {
                Console.WriteLine($"[{num1}, {num2}, {num3}] = return {total} - 10 = {total - 10} BURST");

            }
            else
            {
                Console.WriteLine($"[{num1}, {num2}, {num3}] = return BURST");
            }
        }

        static void readinputs(out int num1, out int num2, out int num3, out int total)
        {
            //if manual random numbers 
            Console.WriteLine("Enter a first number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second number:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a third number:");
            num3 = Convert.ToInt32(Console.ReadLine());
            //IF need an automatic random numbers 
            /*  Random integer= new Random();
              int num1= integer.Next(1,11);
              int num2 = integer.Next(1, 11);
              int num3 = integer.Next(1, 11);*/
            total = num1 + num2 + num3;
        }
    }
}
