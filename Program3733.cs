using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baekjoon_p3733
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] SN = Console.ReadLine().Split();
            
            int S = int.Parse(SN[0]); // 지분 S
            int N = int.Parse(SN[1]); // 그룹의 인원 N

            Console.WriteLine(S/(N+1)); // 전체지분 S를 그룹인원과 수석심판원으로 나눈 몫
        }
    }
}
