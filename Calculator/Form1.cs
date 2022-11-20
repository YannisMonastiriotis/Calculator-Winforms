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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            operatorName.Text = "+";
            if (inputNums.Text != "")
            {
                secondaryNumLabel.Text = inputNums.Text;
            }
            inputNums.Text = "";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            var firstNum = inputNums.Text;
            inputNums.Text = "";
            secondaryNumLabel.Text = firstNum;
            operatorName.Text = "-";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            inputNums.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            inputNums.Text += "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            inputNums.Text += "1";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            inputNums.Text += "2";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            inputNums.Text += "3";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            inputNums.Text += "4";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            inputNums.Text += "5";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            inputNums.Text += "6";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            inputNums.Text += "7";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            inputNums.Text += "8";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            inputNums.Text += "9";
        }

        private void button4_Click(object sender, EventArgs e)
        {
        
            inputNums.Text += ".";
        }

        private void operatorName_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            operatorName.Text = "X";
            if (inputNums.Text != "")
            {
                secondaryNumLabel.Text = inputNums.Text;
            }
            inputNums.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            var firstNum = inputNums.Text;
            inputNums.Text = "";
            secondaryNumLabel.Text = firstNum;
            operatorName.Text = "%";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double firstnum = 0;
            double secondNum = 0;
            double.TryParse(inputNums.Text, out firstnum); double.TryParse(secondaryNumLabel.Text, out secondNum);
            if (operatorName.Text== "+")
            {
            if(firstnum != 0 && secondNum != 0)
            {
                inputNums.Text = Convert.ToString(firstnum + secondNum);
            }
            }

            if (operatorName.Text == "-")
            {
                if (firstnum != 0 && secondNum != 0)
                {
                    inputNums.Text = Convert.ToString(firstnum - secondNum);
                }
            }

            if (operatorName.Text == "X")
            {
                if (firstnum != 0 && secondNum != 0)
                {
                    inputNums.Text = Convert.ToString(firstnum  * secondNum);
                }
            }
            if (operatorName.Text == "%")
            {
                if (firstnum != 0 && secondNum != 0)
                {
                    inputNums.Text = Convert.ToString(firstnum / secondNum);
                }
            }
            secondaryNumLabel.Text = "";
            operatorName.Text = "";
        
        }
    }
}
