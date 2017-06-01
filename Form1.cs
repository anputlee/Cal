using System;
using System.Data;
using System.Windows.Forms;

namespace 计算器
{
    public partial class Form1 : Form
    {
        private static bool mBool;
        private static double m;

        public Form1()
        {
            InitializeComponent();
        }

        private void mplus_Click(object sender, EventArgs e)
        {
            m += Convert.ToDouble(input.Text.ToString());
            mView.Text = "M = " + m;
        }

        private void mmin_Click(object sender, EventArgs e)
        {
            m -= Convert.ToDouble(input.Text.ToString());
            mView.Text = "M = " + m;
        }

        private void mic_Click(object sender, EventArgs e)
        {
            if (mBool)
            {
                m = 0;
                mView.Text = "M = " + m;
            }
            else
            {
                input.Text = Convert.ToString(m);
                mBool = true;
            }
        }

        private void del_Click(object sender, EventArgs e)
        {
            string text = input.Text;
            input.Text = text.Substring(0, text.Length - 1);
        }

        private void one_Click(object sender, EventArgs e)
        {
            input.Text += "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            input.Text += "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            input.Text += "3";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            input.Text += "+";
        }

        private void four_Click(object sender, EventArgs e)
        {
            input.Text += "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            input.Text += "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            input.Text += "6";
        }

        private void min_Click(object sender, EventArgs e)
        {
            input.Text += "-";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            input.Text += "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            input.Text += "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            input.Text += "9";
        }

        private void multi_Click(object sender, EventArgs e)
        {
            input.Text += "*";
        }

        private void dot_Click(object sender, EventArgs e)
        {
            input.Text += ".";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            input.Text += "0";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            DataTable eval = new DataTable();
            object result = eval.Compute(input.Text, "");
            output.Text = Convert.ToString(result);
        }

        private void div_Click(object sender, EventArgs e)
        {
            input.Text += "/";
        }
    }
}
