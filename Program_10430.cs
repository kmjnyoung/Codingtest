using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baekjoon_p10430
{
    internal class Program_ㅔ10430_2
    {
        static void Main(string[] args)
        {
            string[] abc =Console.ReadLine().Split(' '); // 첫 째 줄에 a, b, c가 주어져야 하므로 배열을 이용하고 입력을 받음, 문자열이므로 string
            int a = int.Parse(abc[0]); // string을 정수형인 int로 형변환
            int b = int.Parse(abc[1]);
            int c = int.Parse(abc[2]);
            // 문제에 나온 식들을 하나씩 계산하여 같은지 확인, 출력시 줄이 바뀌어야 하므로 Consloe.WriterLine사용

            //1, 2, 3을 입력했을 경우
            Console.WriteLine((a + b) % c); // 1과 2를 더하면 3, 3과 3을 나눈 나무지는 0이므로 0이 출력
            Console.WriteLine(((a % c) + (b % c)) % c); // 1과 3을 나눈 나머지는 1, 2와 3을 나눈 나머지는 2, 괄호가 있으므로 먼저 더하면 3, 3과 3을 나눈 나머지는 0이므로 0이 출력
            Console.WriteLine((a * b) % c); // 괄호안에 있는 1과 2를 곱하면 2, 3으로 나누면 나머지 2이므로 출력값은 2
            Console.WriteLine(((a % c) * (b % c)) % c); // 1과 3을 나누면 나머지 1, 2와 3을 나누면 나머지 2, 1과 2를 곱하면 2, 2와 3을 나누면 나머지 2이므로 출력값 2
        }
    }
}
