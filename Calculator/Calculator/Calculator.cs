﻿using System;
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
    public partial class Calculator : Form
    {
        public int Result = 0;
        public bool inNewNum = true;


        public Calculator()
        {
            InitializeComponent();
        }
        public int Add(int number1, int number2)
        {
            int sum = number1 + number2;
            return sum;
        }
        public float Add(float number1, float number2)
        {
            float sum = number1 + number2;
            return sum;
        }
        public int sub(int number1, int number2)
        {
            int sub = number1 - number2;
            return sub;
        }

        private void NumButton1_Click(object sender, EventArgs e)
        {
            SetNum("1");
        }

        private void NumButton2_Click(object sender, EventArgs e)
        {
            SetNum("2");
        }

        // 숫자 입력 함수
        public void SetNum(string num)
        {
            if (NumScreen.Text == "0")
                NumScreen.Text = num;
            else
                NumScreen.Text += num;
        }

        private void Numplus_Click(object sender, EventArgs e)
        {

        }
    }
}
