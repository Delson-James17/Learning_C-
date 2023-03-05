using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Learning_csharp
{
    internal class Task6_Algo
    {
        static public void Algo() {
 
             Console.WriteLine("Here 's an algorithm to solve the 8 coin problem using a balance weighing scale only for three times:");
            Console.WriteLine("Divide the 8 coins into three groups of three, three, and two coins each.");
            Console.WriteLine("Weigh the first group of three coins against the second group of three coins on the balance weighing scale:");
            Console.WriteLine("a.If the two groups balance, then the odd coin must be in the remaining group of two coins.Go to step 3.");
            Console.WriteLine("b.If one of the groups is heavier, then the odd coin must be in that group. Go to step 4.");
            Console.WriteLine("Weigh two of the three coins from the remaining group of two coins against each other:");
            Console.WriteLine("a.If they balance, then the odd coin is the remaining coin.Weigh it against any other coin to determine whether it is heavier or lighter.");
            Console.WriteLine("b.If one of the coins is heavier, then it is the odd coin.Weigh it against any other coin to determine whether it is heavier or lighter.");
            Console.WriteLine("Take the heavier group of three coins from step 2 and weigh two of its coins against two coins from the lighter group of three coins from step 2:");
            Console.WriteLine(" a.If they balance, then the odd coin is the remaining coin in the heavier group of three coins. Weigh it against any other coin to determine whether it is heavier or lighter.");
            Console.WriteLine(" b.If one of the groups is heavier, then the odd coin must be in that group. Weigh two coins from that group against each other:");
            Console.WriteLine("i.If they balance, then the odd coin is the remaining coin in that group. Weigh it against any other coin to determine whether it is heavier or lighter.");
            Console.WriteLine(" ii.If one of the coins is heavier, then it is the odd coin.Weigh it against any other coin to determine whether it is heavier or lighter.");
            Console.WriteLine(" This algorithm uses the balance weighing scale only three times to determine the odd coin among eight coins that can be heavier or lighter. It works by dividing the coins into three groups and weighing them against each other to eliminate two groups as containing the odd coin. The remaining group of two or three coins can then be weighed against each other to find the odd coin. By weighing only two or three coins at a time, the algorithm is able to use the balance weighing scale efficiently to find the odd coin in just three weighings.");
            Console.ReadLine();
        }
    }

}
