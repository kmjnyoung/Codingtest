using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2475
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            int sum = 0;
            
            for (int i = 0; i < input.Length; i++)
            {
                sum += (int)Math.Pow(int.Parse(input[i]), 2); // math.pow는 double형으로 반환
            }
            
            int result = sum % 10;
            Console.WriteLine(result);
        }
    }
}
