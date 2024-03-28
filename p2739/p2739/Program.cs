using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2739
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine($"{n} * {i} = {n * i}");
            }
        }
    }
}
