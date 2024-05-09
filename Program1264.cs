using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string A = Console.ReadLine().ToUpper(); //문자열을 입력받고 대문자로 바꿔서 A에 저장
                int cnt = 0; // 모음의 갯수를 저장, 0으로 초기화

                if (A.Equals("#"))
                {
                    return;
                }
                // #을 입력하면 종료
                
                else
                {
                    for (int i = 0; i < A.Length; i++) // 입력받은 문자열을 하나하나 확인
                    {
                        if (A[i].Equals('A') || A[i].Equals('E') || A[i].Equals('I') || A[i].Equals('U') || A[i].Equals('O'))
                        {
                            cnt++;
                        } // 모음에 해당할 경우 cnt를 증가시킴
                    }

                    Console.WriteLine(cnt); // 출력
                }
            }
        }
    }
}
// toupper : 대문자로 변경된 문자열을 반환
// tolower : 소문자로 변경된 문자열을 반환
// 두 메서드를 모두 이용하면 대소문자 구분없이 문자열을 비교 가능
