using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_csharp
{
    internal class Task2_Spygame
    {
        static void main()
        {
            Console.WriteLine($"spy_game([1,2,4,0,0,7,5]) --> {Spy_game(new int[] { 1, 2, 4, 0, 0, 7, 5 })}");
            Console.WriteLine($"spy_game([1,0,2,4,0,5,7]) --> {Spy_game(new int[] { 1, 0, 2, 4, 0, 5, 7 })}");
            Console.WriteLine($"spy_game([1,7,2,0,4,5,0]) --> {Spy_game(new int[] { 1, 7, 2, 0, 4, 5, 0 })}");
        }
        public static bool Spy_game(int[] num)
        {
            int[] order = { 0,0,7};
            int orderindex = 0;
            for(int i = 0; i < num.Length; i++) 
            {
                if (num[i] == order[orderindex])
                {
                    orderindex++;
                }
                if(orderindex == order.Length)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
