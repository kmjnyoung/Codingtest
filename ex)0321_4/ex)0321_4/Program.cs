using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_0321_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ab = Console.ReadLine().Split(' ');

            if (int.Parse(ab[0]) > int.Parse(ab[1]))
            {
                Console.WriteLine(">");
            }
            else if (int.Parse(ab[0]) < int.Parse(ab[1]))
            {
                Console.WriteLine("<");
            }
            else
            {
                Console.WriteLine("==");
            }
        }
    }
}
