using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baekjoon_P10869
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ab = Console.ReadLine().Split(' '); // 배열을 이용하여 입력받고 split으로 분할
            Console.WriteLine(int.Parse(ab[0]) + int.Parse(ab[1])); // string을 int로 형변환 및 순서대로 사칙연산, 더하기
            Console.WriteLine(int.Parse(ab[0]) - int.Parse(ab[1])); // 뺴기
            Console.WriteLine(int.Parse(ab[0]) * int.Parse(ab[1])); // 곱
            Console.WriteLine(int.Parse(ab[0]) / int.Parse(ab[1])); // 몫
            Console.WriteLine(int.Parse(ab[0]) % int.Parse(ab[1])); // 나머지
        }
    }
}
