using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace findnumber
{
    public partial class Form1 : Form
    {
        private int findNumber = 0;
        private int chance = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            findNumber = rand.Next(1, 11);
            chance = 20;
            display.Text = "숫자를 입력하세요";
        }

        private void ButtonInput_Click(object sender, EventArgs e)
        {
            int inputNumber = Int32.Parse(textBox.Text);

            if (inputNumber == findNumber)
            {
                display.Text = "성공";
            }
            else
            {
                chance--;
                display.Text = chance + "번 남았습니다.";
            }
            if (chance <= 0)
            {
                display.Text = "실패";
            }

        }

        // Random: 임의의 수를 생성할 때 사용하는 클래스
        // next(1,10): 1 ~ 9까지의 정수 중 하나를 선택
        // int32: 다른 형식을 32비트 부호가 있는 정수형으로 변환
    }
}
