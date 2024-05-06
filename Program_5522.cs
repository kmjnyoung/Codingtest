using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baekjoon_p5522
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int all = 0; // 총점 all을 0으로 초기화

            for (int i = 0; i < 5; i++) // 5회 입력받기 위한 반복문
            {
                string a = Console.ReadLine(); // 문자열 형태로 입력받고,
                int b = int.Parse(a); // 정수형으로 변환
                all += b; // 입력된 값들의 누적 합계
            }

            Console.WriteLine(all); // 출력
        }

        // 특정값을 정수형으로 변환하기 위해  convert.toint32()함수와 int.parse() 함수 사용
        // int.parse(): string 가능, char 불가능, null값을 반환하면 예외 발생
        // convert.toint32(): string, char 모두 가능, null값을 변환하면 0값을 반환
    }
}
