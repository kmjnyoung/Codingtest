using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace baekjoon_p1271
{
    internal class Program_p1271
    {
        static void Main(string[] args)
        {
            string[] nm = Console.ReadLine().Split(); //돈 n과 생명체의 수 m을 입력
            BigInteger n = BigInteger.Parse(nm[0]); // 배열의 첫 번째 값에 접근, 돈 n
            BigInteger m = BigInteger.Parse(nm[1]); // 배열의 두 번째 값에 접근, 생명체의 수 m

            BigInteger a = n / m; // 생명체 하나에게 돌아가는 돈의 양
            BigInteger b = n % m; // 남는 돈

            Console.WriteLine(a);
            Console.WriteLine(b);

            // 문자하나이면 char, 문자열은 string

            // 형변환: 암시적 변환, 명시적 변환
            // 어떤 자료형으로 선언된 변수를 다른 자료형으로 변환하는 것을 형변환이라고 한다.
            // 이 때, 코드에 직접 변환 될 자료형을 입력해야 하는 것을 '명시적 형변환'이라고 하고,
            // 변환 될 자료형을 입력하지 않아도 되는 형변환을 '암시적 형변환'이라고 한다.
        }
    }
}
