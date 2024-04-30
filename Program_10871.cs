using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baekjoon_p10871
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] B = Console.ReadLine().Split();
            // 배열 B의 첫 인덱스는 N(개수)
            // 배열 B의 두 번째 인덱스는 X

            string[] A = Console.ReadLine().Split();
            // 수열 A(N개의 정수)

            // stringbuilder객체생성
            StringBuilder result = new StringBuilder(Console.ReadLine());
            
            for (int i = 0; i < int.Parse(B[0]); i++) // 수열A의 개수만큼 반복
            {
                if (int.Parse(B[1]) > int.Parse(A[i])) // 정수 x보다 작은 숫자
                {
                    result.Append(A[i] + " "); //  조건을 만족하면 result에 추가, 공백으로 구분
                }
            }
            Console.WriteLine(result.ToString());

            // string builder
            // stringbuilder를 사용하면 문자열을 조합할때마다 새로운 변수를 생성하지 않고 결합
            // 내부에 함수가 존재해서 값들을 조합하거나 삭제할때에도 새로운 인스턴스가 생성되지 않음.
            



        }
    }
}
