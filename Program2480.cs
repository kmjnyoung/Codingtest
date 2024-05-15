using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baekjoon_2480
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' '); //주사위의 눈 3개를 입력받음, split으로 구분
            int a = int.Parse(str[0]); // parse를 이용하여 strng에서 int로 형변환
            int b = int.Parse(str[1]);
            int c = int.Parse(str[2]);

            if (a == b && b == c) // 같은 눈이 3개가 나올 경우 10000원 + 같은눈 * 1000
            {
                Console.WriteLine(10000 + a * 1000);
            }
            else if (a == b) // 같은 눈이 2개가 나올 경우 1000원 + 같은눈 * 100, a와 b가 같을 경우
            {
                Console.WriteLine(1000 + a * 100);
            }
            else if (a == c) // a와 c가 같을 경우
            {
                Console.WriteLine(1000 +a * 100);
            }
            else if (b == c) // b와 c가 같을 경우
            {
                Console.WriteLine(1000 + b * 100);
            }
            else // 모두 다른눈이 나올 경우 최대 * 100
            {
                if (a > b && a > c) //a가 가장 큰 경우
                {
                    Console.WriteLine(100 * a);
                }
                else if (b > a && b > c) // b가 가장 클 때
                {
                    Console.WriteLine(100 * b);
                }
                else // c가 가장 클 때
                {
                    Console.WriteLine(100 * c);
                }
            }
        }
        // Convert.ToString() 숫자 데이터 형식을 문자열로 변경
        // Convert.ToInt32() 숫자 데이터 형식을 정수 형식으로 변경
        // Convert.ToDuble() 숫자 데이터 형식을 실수 형식으로 변경
        // Convert.ToChar() 입력받은 숫자 또는 문자열 하나를 문자로 변경
    }
}
