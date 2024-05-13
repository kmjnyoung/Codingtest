using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baekjoon_p2439
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // *의 가로줄 개수 입력받기

            for (int i = 0; i < n; i++) // 삼각형의 각 행, n번 반복
            {
                for (int j = 0; j < n - i - 1; j++) // 행 별 공백 출력, n - i - 1은 공백의 개수
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i + 1; j++) // *출력, i + 1 별표의 개수
                {
                    Console.Write("*");
                }
                Console.Write("\n"); // 공백과 *출력 후 행 변경
            }
        }
        
        // while문
        // while(조건식){반복 실행될 코드}
        // 조건식이 거짓이 되면 탈출

        // do while
        // do{반복 실행될 코드} while(조건식)
        // 일단 한 번 실행 후 반복

        // for문
        // for(초기식; 조건식; 증감식;) {반복 실행 코드}
        // 특정 조건을 만족할 때까지 반복

        // for each문
        // for each(변수 in 배열)
        // 배열에 담겨있는 데이터를 순회하며 반복
    }
}
