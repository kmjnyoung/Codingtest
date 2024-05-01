using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baekjoon_p3003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split(' '); // 찾은 킹, 퀸, 룩, 비숍, 나이트, 폰의 개수 입력 후 나눔

            int[] b = {1,1,2,2,2,8}; //킹, 퀸, 룩, 비숍, 나이트, 폰의 원래 개수
            
            for (int i = 0; i < a.Length; i++) // 찾은 킹, 퀸 등의 수만큼 반복
            {
                b[i] -= int.Parse(a[i]); // 정수형으로 변환하고 원래 개수에서 발견한 개수를 뻄
            }

            Console.WriteLine(string.Join(" ",b));
            //string.join
            //각 요소 또는 멤버 사이에 지정된 구분 기호를 사용하여
            //지정된 배열 요소나 컬렉션 멤버를 연결

        }
    }
}
