using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baekjoon_p3733_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inputList = new List<string>(); //입력받은 문자열을 저정할 리스트

            while (true) //무한루프. 계속 입력가능
            { 
                var input = Console.ReadLine(); //입력

                if (string.IsNullOrEmpty(input)) // 입력값이 null일 경우 반복문 중지
                {
                    break;
                }

                inputList.Add(input); //입력된 문자열을 리스트에 추가
            }

            for (int i = 0; i < inputList.Count; i++) //리스트에 저장된 값들을 하나씩 확인
            {
                string[] splitInput = inputList[i].Split(' '); //입력된 문자열을 배열에 저장, 공백으로 구분

                int n = int.Parse(splitInput[0]); // 첫 번째 인덱스 값 = n
                int s = int.Parse(splitInput[1]); // 두 번째 인덱스 값 = s

                Console.WriteLine(s / (n + 1)); //s를 n+1로 나눈 몫 출력

                // isnullorempty
                // string이 null이거나 empty이면 true를 반환하고, 그렇지 않을경우 false반환
                // string의 존재형태 3가지 문자열, 빈 문자열(""), null
                // 빈 분자열은 string.length호출 시 에러가 발생할 수 있으므로 주의

                // var
                // 변수의 자료형을 자동으로 저장
                // 지역변수로 선언해야 함
                // 선언과 동시에 초기화 필요
            }
        }
    }
}
