using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2742
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // n을 입력받고 int형으로 형변환
            int n = int.Parse(Console.ReadLine());
            
            // stringbuilder생성 
            StringBuilder stringbuilder = new StringBuilder();

            // n부터 1까지 반복
            for (int i = n; i > 0; i--)
            {
                stringbuilder.AppendLine(i.ToString()); // i를 문자열로 변환
            }
            Console.WriteLine(stringbuilder); // 출력
        }

        // stringbuilder
        // 문자열을 조합할 때 새로운 변수를 생성하지 않고 조합가능
        // 가변 문자열 처리에 사용
        // 반복문 내에서 문자열을 반복적으로 수정할 때 유리
    }
}
