using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1271
{
    class Program
    {
        static void Main()
        {
            string[] ab = Console.ReadLine().Split(' ');

            BigInteger a = BigInteger.Parse(ab[0]);
            BigInteger b = BigInteger.Parse(ab[1]);

            var c = a / b;
            var d = a % b;

            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }
}
