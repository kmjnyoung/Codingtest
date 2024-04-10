using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p8393
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i <= a; i++)
            {
                sum += i;
            }
            Console.WriteLine($"{sum}");
        }
    }
}
