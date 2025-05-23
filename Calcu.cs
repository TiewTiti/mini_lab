using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Calcu : Form
    {
        double firstNumber = 0;
        string operation = "";
        public Calcu()
        {
            InitializeComponent();
        }
        private bool IsLastCharOperator()
        {
            if (string.IsNullOrEmpty(textBox1.Text)) return false;

            char lastChar = textBox1.Text[^1];
            return lastChar == '+' || lastChar == '-' || lastChar == '*' || lastChar == '/';
        }

        private void Calcu_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void bt11_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !IsLastCharOperator())
            {
                textBox1.Text += "/";
            }
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void btDot_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                var result = new System.Data.DataTable().Compute(textBox1.Text, null);
                textBox1.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("รูปแบบการคำนวณไม่ถูกต้อง!", "ข้อผิดพลาด");
            }
        }

        private void bt14_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !IsLastCharOperator())
            {
                textBox1.Text += "+";
            }
        }

        private void bt13_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !IsLastCharOperator())
            {
                textBox1.Text += "-";
            }
        }

        private void bt12_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !IsLastCharOperator())
            {
                textBox1.Text += "*";
            }
        }
    }
}
