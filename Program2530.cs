using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2530
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] time = Console.ReadLine().Split(' '); //현재시각 시, 분, 초
            int h = int.Parse(time[0]);
            int m = int.Parse(time[1]);
            int s = int.Parse(time[2]);

            int cookingtime = int.Parse(Console.ReadLine()); // 요리에 필요한 시간

            s += cookingtime % 60; //  초
            m += (cookingtime / 60) % 60; // 분 
            h += cookingtime / 3600; // 시

            if (s >= 60) // s가 60보다 클 경우 m증가, s는 나머지 m분 s초
            {
                s %= 60;
                m++;
            }
            
            if (m >= 60) // m이 60보다 클 경우 h증가, h시간 m분
            { 
                m %= 60;
                h++;
            }

            if (h >= 24) // h가 24보다 클 경우 24로 나눈 나머지
            { 
                h %= 24;
            }

            Console.Write("{0} {1} {2}", h, m, s);
        }
    }
}
