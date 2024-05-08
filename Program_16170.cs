using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace baekjoon_p16170
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.UtcNow; // 현재의 utc시간

            //DateTime 객체를 문자열로 변환
            string year = date.ToString("yyyy"); // 년
            string month = date.ToString("MM"); // 월
            string day = date.ToString("dd"); // 일

            Console.WriteLine($"{year}\n{month}\n{day}");
            // $를 이용하여 문자열 보간
            // year, month, day에 저장된 값을 세 줄로 구분하여 출력

            // 문자열 보간을 이용하여 코드의 가독성 향상
            // 문자열을 시작하는 큰따옴표 앞에 $를 붙여서 사용
            // 중괄호를 사용하여 변수, 메서드, 수식 등을 문자열이 아닌 코드취급을 받도록 함

            // DateTime
            // 특정시간, 현재시간 입력
            // Tostring이용하여 출력
            // y(한자리연도), yy(마지막 두자리), yyyy(연도전체)
            // dd(달 두자리), dddd(요일의 전체 이름)
            // h(12시간형식 1,2자리), hh(12시간형식 2자리)
            // H(24시간, 1자리), HH(24시간, 2자리)
            // M(달 한자리 또는 두자리), MM(달 두자리)
            // m(한 자리 또는 두 자리 분), mm(두자리 분)
            // s(한 자리 또는 두 자리 초), ss(두자리 초)
            // t(한 자리 a.m, p.m 약어), tt(두 자리 약어)
        }
    }
}
