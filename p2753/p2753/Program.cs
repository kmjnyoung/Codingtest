using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2753
{
    class Program
    {
        static void Main()
        {
            int yn = int.Parse(Console.ReadLine());

            if (yn % 4 == 0 && yn % 100 != 0)
            {
                Console.WriteLine("1");
            }
            else if (yn % 400 == 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
