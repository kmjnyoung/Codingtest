using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2741
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder allnumber = new StringBuilder();

            for (int i = 1; i <= n; i++)
            {
                allnumber.AppendLine(i.ToString());
            }

            Console.WriteLine(allnumber);
        }
    }
}
