using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4101
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                string[] ab = Console.ReadLine().Split();
                int a = int.Parse(ab[0]);
                int b = int.Parse(ab[1]);

                if (a == 0 && b == 0) break;

                int c = a - b;
                string result = (c > 0) ? "Yes" : "No";
                Console.WriteLine(result);
            }
        }
    }
}
