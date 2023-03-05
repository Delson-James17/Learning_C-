using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_csharp
{
    internal class Task1_Fun
    {
        public static void main()
        {
            Console.WriteLine($"fun([1, 3, 5]) --> {Fun(new int[] { 1, 3, 5 })}");
            Console.WriteLine($"fun([4, 5, 6, 7, 8, 9]) -->{Fun(new int[] { 4, 5, 6, 7, 8, 9 })}");
            Console.WriteLine($"fun([2, 1, 6, 9, 11]) --> {Fun(new int[] { 2, 1, 6, 9, 11 })}");
            Console.WriteLine($"fun([3, 1, 6, 7, 11]) --> {Fun(new int[] { 3, 1, 6, 7, 11 })}");
        }
        static public int Fun(int[] num)
        {
            int total = 0 ;
            bool skip = false ;
            for(int i = 0; i < num.Length; i++)
            {
                if (num[i] == 6)
                {
                    skip = true ;
                }
                else if (num[i] == 9)
                {
                    skip= false ;
                }
                else if (!skip)
                {
                    total += num[i];
                }
            }
            return total ;
        }

    }
}
