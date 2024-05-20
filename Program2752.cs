using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2752
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' '); //입력받고 문자열을 분할

            int[] str2 = { int.Parse(str[0]), int.Parse(str[1]), int.Parse(str[2]) }; // 정수배열로 변환

            Array.Sort(str2); // 오름차순으로 정렬

            Console.WriteLine("{0}", string.Join(" ", str2)); // 배열을 공백으로 구분 및 출력
        }
        // Array.Sort
        // 배열 정렬에 사용되는 메서드
        // 배열을 오름차순으로 정렬, 사용자정의비교기준으로 정렬가능

        // string.join
        // 요소 또는 멤버 사이에 지정된 구분 기호를 사용하여 지정된 배열 요소나 컬렉션 멤버를 연결
    }
}
