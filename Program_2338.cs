using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace baekjoon_p2338
{
    internal class Program_p2338
    {
        static void Main(string[] args)
        {
            // A와 B를 입력받음, Biginteger형으로 형변환
            BigInteger A = BigInteger.Parse(Console.ReadLine());
            BigInteger B = BigInteger.Parse(Console.ReadLine());

            // A와 B에 대하여 더하기, 빼기, 곱하기 연산, 출력
            Console.WriteLine(A + B);
            Console.WriteLine(A - B);
            Console.WriteLine(A * B);

            // int로 다 계산하지 못하는 숫자를 계산하려면 BigInteger를 사용
            // System.Numerics;를 참조하여 사용
        }
    }
}
