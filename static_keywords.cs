using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_csharp
{
    internal class static_keywords
    {
        class car
        {
            static int wheels;
            static int doors;
            const int max_wheels = 5;

            static car() // static constructor , which get called when a class is loaded into the memory 
            {

            }
            public car() // which get invoked when object is created 
            {

            }
            public static void speed()
            {

            }
        }
        class Program
        {
            static int count = 0;

            static void method()
            {
                Console.WriteLine("Hello static");
            }
            static void Static_keywords()
            {
                /*car c = new car();// default constructor will get invoked 
               car.speed(); // static constructor will be called when ever the first use of your class */
                int x = 10;
                increment(x);
                Console.WriteLine(x); // 10
                increment(ref x);
                Console.WriteLine(x); //11 memory blocks address 11
            }
            static void increment(int a)// copied to the variable
            {
                a = a + 1;
                return;
            }
            //reference parameter
            static void increment(ref int a)
            {
                a = a + 1; //11
                return;
            }
            static int additions(int a, int b) // values int
            {
                return a + b;
            }
            static float additions(float a, float b) //values int ,float
            {
                return a + b;
            }
        }
    }
}
