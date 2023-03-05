using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_csharp
{
    internal class Task3_letters
    {
        public static void letters()
        {
            {
                Print_big(out char letter);

                Dictionary<char, string[]> patterns = new Dictionary<char, string[]>()
            {
                { 'a',new string[]{"  *  "," * * ", "*****", "*   *", "*   *" } },
                {'b', new string[] {"**** ", "*   *", "**** ", "*   *", "**** "}},
            // Add patterns for other letters as needed
                {'e', new string[] {"*****", "*    ", "*****", "*    ", "*****"}}

            };
                string[] lines = patterns[letter];

                for (int i = 0; i < 5; i++)
                {
                    if (letter == 'a' || letter == 'b' || letter == 'e')
                    {
                        Console.WriteLine(lines[i]);
                    }
                    else if (letter == 'C' || letter == 'c')
                    {
                        Console.Clear();
                    }
                    else if (letter == 'X' || letter == 'x')
                    {

                        Environment.Exit(0);
                    }

                }
            }

            static void Print_big(out char letter)
            {
                Console.WriteLine("Choose and Enter a letter from A , B , E:");
                letter = Convert.ToChar(value: Console.ReadLine());
            }
        }
    }
}
