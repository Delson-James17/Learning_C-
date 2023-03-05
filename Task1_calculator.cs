using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_csharp
{
    internal class Task1_calculator
    {
        static void calculator()
        {
            /*Task 1:  
    Create a project for Basic Calculator and write a program to perform basic operations of addition, subtraction, multiplication, division
    allow end user to select the operation he wants to do, also accepet values for the operation [2 numbers] and compute and show the result.
    and also provide option to exit from the application.*/
            bool exit = false;
            while (!exit)
            {
                try
                {
                    Console.WriteLine("Enter a First Number:");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter an Operator:");
                    char operation = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine("Enter a Second Number:");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    if (operation == '+')
                    {
                        Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
                    }

                    else if (operation == '-')
                    {
                        Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
                    }

                    else if ((operation == 'x') || (operation == '*'))
                    {
                        Console.WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2);
                    }

                    else if (operation == '/')
                    {
                        Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
                    }

                    else
                        Console.WriteLine("Wrong Character");
                }
                catch
                {
                    Console.WriteLine("Invalid Input");
                }
                try
                {
                    Console.WriteLine("Do you want to Clear or Exit ?");
                    char condition = Convert.ToChar(Console.ReadLine());
                    if (condition == 'C' || condition == 'c')
                    {
                        Console.Clear();
                    }
                    else if (condition == 'E' || condition == 'e')
                    {
                        exit = true;
                    }
                    else
                        Console.WriteLine("Wrong Character");
                }

                catch
                {
                    Console.WriteLine("Thank you");
                }
            }
        }
    }
}
