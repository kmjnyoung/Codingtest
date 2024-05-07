using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baekjoon_p1009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 테스트케이스 회수 입력

            while (n > 0)
            {
                string[] ab = Console.ReadLine().Split(); //  테스트 케이스a, b

                int a = int.Parse(ab[0]);
                int b = int.Parse(ab[1]);

                int result = a;

                /*for (int i = 1; i < b % 4 + 4; i++) // B를 4로 나눈 나머지를 곱함
                    result = (result * a) % 10;

                // 0은 존재하지 않으므로, 10으로 수정
                if (result == 0)
                    result = 10;*/

                Console.WriteLine(result);
            }
        }
    }
}

