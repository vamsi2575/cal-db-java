using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string op1 = string.Empty;
        string op2 = string.Empty;
        char Operator;
        double res=0.0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmd1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input += "1";
            this.textBox1.Text += input;
        }

        private void cmd2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input += "2";
            this.textBox1.Text += input;

        }

        private void cmd3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input += "3";
            this.textBox1.Text += input;

        }

        private void cmd4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input += "4";
            this.textBox1.Text += input;
        }

        private void cmd5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input += "5";
            this.textBox1.Text += input;
        }

        private void cmd6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input += "6";
            this.textBox1.Text += input;
        }

        private void cmd7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input += "7";
            this.textBox1.Text += input;
        }

        private void cmd8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input += "8";
            this.textBox1.Text += input;
        }

        private void cmd9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input += "9";
            this.textBox1.Text += input;
        }

        private void cmd0_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input += "0";
            this.textBox1.Text += input;
        }

        private void cmde_Click(object sender, EventArgs e)
        {
            op2 = input;
            double num1, num2;
            double.TryParse(op1, out num1);
            double.TryParse(op2, out num2);
            if (Operator == '+')
            {
                res = num1 + num2;
                textBox1.Text = res.ToString();
            }
            else if(Operator=='-')
            {
                res = num1 - num2;
                textBox1.Text = res.ToString();
            }
            else if (Operator == '*')
            {
                res = num1 * num2;
                textBox1.Text = res.ToString();
            }
            else if (Operator == '/')
            {
                if (num2 == 0)
                    textBox1.Text = "not possible";
                else
                {
                    res = num1 / num2;
                    textBox1.Text = res.ToString();
                }
            }
            else if (Operator == '^')
            {

                res = System.Math.Pow(num1, num2);
                textBox1.Text = res.ToString();
            }
            else if (Operator == '%')
            {
                res = num1 % num2;
                textBox1.Text = res.ToString();
            }
            input = "";

        }

        private void cmdd_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input += ".";
            this.textBox1.Text += input;
        }

        private void cmdp_Click(object sender, EventArgs e)
        {
            op1 = input;
            Operator = '+';
            input = string.Empty;
        }

        private void cmdm_Click(object sender, EventArgs e)
        {
            op1 = input;
            Operator = '*';
            input = string.Empty;
        }

        private void cmds_Click(object sender, EventArgs e)
        {
            op1 = input;
            Operator = '-';
            input = string.Empty;
        }

        private void cmddiv_Click(object sender, EventArgs e)
        {
            op1 = input;
            Operator = '/';
            input = string.Empty;
        }
        private void cmdpow_Click(object sender, EventArgs e)
        {
            op1 = input;
            Operator = '^';
            input = string.Empty;
        }
        private void cmdrem_Click(object sender, EventArgs e)
        {
            op1 = input;
            Operator = '%';
            input = string.Empty;
        }
        

        private void cmdsroot_Click(object sender, EventArgs e)
        {
            string op3 = string.Empty;
            op3 = input;
            double num3;
            double.TryParse(op3,out num3);
            res = System.Math.Pow(num3, 0.5);
            textBox1.Text = res.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdclr_Click(object sender, EventArgs e)
        {
            op1 = string.Empty;
            op2 = string.Empty;
            input = string.Empty;
            textBox1.Text = string.Empty;
        }


        private void cmdoff_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox1.Text = "";
            cmd0.Enabled = false;
            cmd1.Enabled = false;
            cmd2.Enabled = false;
            cmd3.Enabled = false;
            cmd4.Enabled = false;
            cmd5.Enabled = false;
            cmd6.Enabled = false;
            cmd7.Enabled = false;
            cmd8.Enabled = false;
            cmd9.Enabled = false;
            cmde.Enabled = false;
        }

        private void cmdon_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox1.Text = "";
            cmd0.Enabled = true;
            cmd1.Enabled = true;
            cmd2.Enabled = true;
            cmd3.Enabled = true;
            cmd4.Enabled = true;
            cmd5.Enabled = true;
            cmd6.Enabled = true;
            cmd7.Enabled = true;
            cmd8.Enabled = true;
            cmd9.Enabled = true;
            cmde.Enabled = true;
        }


    }
}
