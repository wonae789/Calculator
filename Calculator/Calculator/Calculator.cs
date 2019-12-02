using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public enum operators { Add,Sub,Multi,Div }

    public partial class Calculator : Form
    {
        public double Result = 0;
        public bool isNewNum = true;
        public operators Opt = operators.Add;

        public Calculator()
        {
            InitializeComponent();
        }
        public int Add(int number1, int number2)
        {
            int sum = number1 + number2;
            return sum;
        }
        public double Add(double number1, double number2)
        {
            double sum = number1 + number2;
            return sum;
        }
        public int Sub(int number1, int number2)
        {
            int sub = number1 - number2;
            return sub;
        }
        public double Sub(double number1, double number2)
        {
            double sub = number1 - number2;
            return sub;
        }

        private void NumButton1_Click(object sender, EventArgs e)
        {
            Button numButton = (Button)sender; 
            SetNum(numButton.Text); // 버튼의 텍스트를 인자로 넘길수 있도록 위한 용도
        }

        // 숫자 입력 함수
        public void SetNum(string num)
        {
            if (isNewNum)
            {
                NumScreen.Text = num;
                isNewNum = false;
            }
            else if (NumScreen.Text == "0")
            {
                NumScreen.Text = num;
            }
            else
            {
                NumScreen.Text += num;

            }
        }

        private void Numplus_Click(object sender, EventArgs e) // 이벤트 핸들러를 공유하도록 코딩.
        {
            if(isNewNum==false)
            {
                int num = int.Parse(NumScreen.Text); // 문자를 숫자로 변환하여 저장.
                if (Opt == operators.Add)
                    Result = Add(Result, num);
                else if (Opt == operators.Sub)
                    Result = Sub(Result, num);
                else if (Opt == operators.Multi)
                    Result *= num;
                else if (Opt == operators.Div)
                    Result /= num;
                NumScreen.Text = Result.ToString();
                isNewNum = true; // 새로운 숫자 입력 체크용.
            }

            Button optButton = (Button)sender;
            if(optButton.Text=="+")
                Opt = operators.Add;
            else if(optButton.Text == "-")
                Opt = operators.Sub;
            else if (optButton.Text == "*")
                Opt = operators.Multi;
            else if (optButton.Text == "/")
                Opt = operators.Div;

        }

        private void NumClear_Click(object sender, EventArgs e)
        {
            Result = 0;
            isNewNum = true;
            Opt = operators.Add;

            NumScreen.Text = "0";
        }
    }
}
