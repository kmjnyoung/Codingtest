using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2420
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] NM = Console.ReadLine().Split();
            
            long N = long.Parse(NM[0]); // long: -2147486648 ~ 2147483647 int: -32768 ~ 32767
            long M = long.Parse(NM[1]);
            
            Console.WriteLine(Math.Abs(N - M));
        }
    }
}
