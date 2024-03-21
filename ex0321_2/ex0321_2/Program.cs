using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int a;
        int b;
        string[] ab = Console.ReadLine().Split(' ');

        a = int.Parse(ab[0]);
        b = int.Parse(ab[1]);

        int minus = a - b;

        Console.WriteLine("{0}", minus);
    }
}
