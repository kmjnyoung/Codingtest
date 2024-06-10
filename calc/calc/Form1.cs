using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        enum Operators
        { 
            None, 
            Add,
            Subtract,
            Multiply,
            Divide,
            Result
        }

        Operators currentOperator = Operators.None;
        Boolean operatorChangeFlag = false;
        int firstOperand = 0;
        int secondOperand = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Result_Click(object sender, EventArgs e)
        {
            secondOperand = Int32.Parse(display.Text);
            if (currentOperator == Operators.Add)
            {
                firstOperand += secondOperand;
                display.Text = firstOperand.ToString();
            }
            else if (currentOperator == Operators.Subtract)
            {
                firstOperand -= secondOperand;
                display.Text = firstOperand.ToString();
            }
            else if (currentOperator == Operators.Multiply)
            {
                firstOperand *= secondOperand;
                display.Text = firstOperand.ToString();
            }
            else if (currentOperator == Operators.Divide)
            {
                if (secondOperand == 0)  //0으로 나눌 경우 예외처리
                {
                    display.Text = "0으로 나눌 수 없습니다";
                }
                else 
                {
                    firstOperand /= secondOperand;
                    display.Text = firstOperand.ToString();
                }
            }

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(display.Text);
            currentOperator = Operators.Add;
            operatorChangeFlag = true;
        }

        private void button_Subtract_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(display.Text);
            currentOperator = Operators.Subtract;
            operatorChangeFlag = true;
        }

        private void button_Multiply_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(display.Text);
            currentOperator = Operators.Multiply;
            operatorChangeFlag = true;
        }

        private void button_Divide_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(display.Text);
            currentOperator = Operators.Divide;
            operatorChangeFlag = true;
        }

        private void button_AC_Click(object sender, EventArgs e)
        {
            firstOperand = 0;
            secondOperand = 0;
            currentOperator = Operators.None;
            display.Text = "0";
        }

        private void botton_Zero_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "0";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void button_One_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "1";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void button_Two_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "2";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void button_Three_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "3";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void button_Four_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "4";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void button_Five_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "5";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void button_Six_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "6";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void button_Seven_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "7";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void button_Eight_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "8";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void button_Nine_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "9";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

    }
}
