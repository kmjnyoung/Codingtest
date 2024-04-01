using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2744
{
    class Program
    {
        static void Main()
        {
            char[] lines = Console.ReadLine().ToCharArray();
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i] >= 97)
                {
                    lines[i] = (char)(lines[i] - 32);
                }
                else
                {
                    lines[i] = (char)(lines[i] + 32);
                }
            }

            Console.WriteLine(lines);
        }
    }
}
