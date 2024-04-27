using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baekjoon_p10757
{
    internal class P10757
    {
        static void Main(string[] args)
        {
            string[] AB = Console.ReadLine().Split(); // A와 B를 한줄에 입력받아야 하므로 배열로 입력받고 Split이용하여 분할
            BigInteger A = BigInteger.Parse(AB[0]); // int로 처리할 수 없는 큰 수는 빅인티저를 사용하고 system.numerics를 참조해야함
            BigInteger B = BigInteger.Parse(AB[1]); // 배열의 인덱스값으로 접근하여 A와 B를 정의, String을 biginteager로 형변환
            Console.WriteLine(A + B); // A와 B를 출력
        }
    }
}
