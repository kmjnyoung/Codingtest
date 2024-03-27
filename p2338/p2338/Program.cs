using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2338
{
    class Program
    {
        static void Main(string[] args)
        {
            // string a = int.Parse(Console.ReadLine());
            string a = Console.ReadLine();
            int aa = int.Parse(a);

            string b = Console.ReadLine();
            int bb = int.Parse(b);

            Console.WriteLine(aa + bb);
            Console.WriteLine(aa - bb);
            Console.WriteLine(aa * bb);
        }
    }
}
