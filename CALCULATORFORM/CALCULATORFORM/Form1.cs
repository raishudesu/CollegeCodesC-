using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CALCULATORFORM
{
    public partial class CACULATOR : Form
    {
        double FirstNumber;
        string Operation;
        static double add(double x, double y)
        {
            return x + y;
        }
        static double sub(double x, double y)
        {
            return x - y;
        }
        static double mul(double x, double y)
        {
            return x * y;
        }
        static double div(double x, double y)
        {
            return x / y;
        }
        public CACULATOR()
        {
            InitializeComponent();
            btn_add.Enabled = false;
            btn_sub.Enabled = false;
            btn_mul.Enabled = false;
            btn_div.Enabled = false;
            btn_equal.Enabled = false;
        }

        private void text_BoxCALC_TextChanged(object sender, EventArgs e)
        {
            if (text_BoxCALC.Text != null)
            {
                btn_add.Enabled = true;
                btn_sub.Enabled = true;
                btn_mul.Enabled = true;
                btn_div.Enabled = true;
                btn_equal.Enabled = true;
            }
            if (text_BoxCALC.Text.IndexOf('.') > -1)
            {
                btn_dpoint.Enabled = false;
            }
            if (text_BoxCALC.Text.IndexOf("0") > -1)
            {
                btn_dpoint.Enabled = true;
            }

        }
        private void btn_n0_Click(object sender, EventArgs e)
        {
            text_BoxCALC.Text = text_BoxCALC.Text + "0";
        }
        private void btn_n1_Click(object sender, EventArgs e)
        {
            if (text_BoxCALC.Text == "0" && text_BoxCALC.Text != null)
            {
                text_BoxCALC.Text = "1";
            }
            else
            {
                text_BoxCALC.Text = text_BoxCALC.Text + "1";
            }
        }
        private void btn_n2_Click(object sender, EventArgs e)
        {
            if (text_BoxCALC.Text == "0" && text_BoxCALC.Text != null)
            {
                text_BoxCALC.Text = "2";
            }
            else
            {
                text_BoxCALC.Text = text_BoxCALC.Text + "2";
            }
        }
        private void btn_n3_Click(object sender, EventArgs e)
        {
            if (text_BoxCALC.Text == "0" && text_BoxCALC.Text != null)
            {
                text_BoxCALC.Text = "3";
            }
            else
            {
                text_BoxCALC.Text = text_BoxCALC.Text + "3";
            }
        }
        private void btn_n4_Click(object sender, EventArgs e)
        {
            if (text_BoxCALC.Text == "0" && text_BoxCALC.Text != null)
            {
                text_BoxCALC.Text = "4";
            }
            else
            {
                text_BoxCALC.Text = text_BoxCALC.Text + "4";
            }
        }
        private void btn_n5_Click(object sender, EventArgs e)
        {
            if (text_BoxCALC.Text == "0" && text_BoxCALC.Text != null)
            {
                text_BoxCALC.Text = "5";
            }
            else
            {
                text_BoxCALC.Text = text_BoxCALC.Text + "5";
            }
        }
        private void btn_n6_Click(object sender, EventArgs e)
        {
            if (text_BoxCALC.Text == "0" && text_BoxCALC.Text != null)
            {
                text_BoxCALC.Text = "6";
            }
            else
            {
                text_BoxCALC.Text = text_BoxCALC.Text + "6";
            }
        }
        private void btn_n7_Click(object sender, EventArgs e)
        {
            if (text_BoxCALC.Text == "0" && text_BoxCALC.Text != null)
            {
                text_BoxCALC.Text = "7";
            }
            else
            {
                text_BoxCALC.Text = text_BoxCALC.Text + "7";
            }
        }

        private void btn_n8_Click(object sender, EventArgs e)
        {
            if (text_BoxCALC.Text == "0" && text_BoxCALC.Text != null)
            {
                text_BoxCALC.Text = "8";
            }
            else
            {
                text_BoxCALC.Text = text_BoxCALC.Text + "8";
            }
        }

        private void btn_n9_Click(object sender, EventArgs e)
        {
            if (text_BoxCALC.Text == "0" && text_BoxCALC.Text != null)
            {
                text_BoxCALC.Text = "9";
            }
            else
            {
                text_BoxCALC.Text = text_BoxCALC.Text + "9";
            }
        }
        private void btn_dpoint_Click(object sender, EventArgs e)
        {
            text_BoxCALC.Text = text_BoxCALC.Text + ".";
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(text_BoxCALC.Text);
            text_BoxCALC.Text = "0";
            Operation = "/";
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(text_BoxCALC.Text);
            text_BoxCALC.Text = "0";
            Operation = "*";
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(text_BoxCALC.Text);
            text_BoxCALC.Text = "0";
            Operation = "-";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(text_BoxCALC.Text);
            text_BoxCALC.Text = "0";
            Operation = "+";
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(text_BoxCALC.Text);

            if (Operation == "+")
            {
                Result = add(FirstNumber, SecondNumber);
                text_BoxCALC.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            else if (Operation == "-")
            {
                Result = sub(FirstNumber, SecondNumber);
                text_BoxCALC.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            else if (Operation == "*")
            {
                Result = mul(FirstNumber, SecondNumber);
                text_BoxCALC.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            else if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    text_BoxCALC.Text = "Error!";
                }
                else
                {
                    Result = div(FirstNumber, SecondNumber);
                    text_BoxCALC.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            text_BoxCALC.Text = "0";
        }
    }
}
