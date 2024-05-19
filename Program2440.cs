using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2440
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); 

            for (int i = n; i >= 1; i--){          // 역삼각형의 행, n으로 초기화, 1보다 크거나 같을 때 반복
                for (int j = 0; j < i; j++) {      // 각 행에서 별의 개수 처리, 0으로 초기화, j < i까지 반복
                    Console.Write("*");            // *을 출력
                }
                
                Console.WriteLine();               // 개행
            }
        }
    }
}
