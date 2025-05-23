using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2234_2240_2244
{
    public partial class oeanalysis_frm : Form
    {
        public oeanalysis_frm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }   

        private void button2_Click(object sender, EventArgs e)
        {
            string inputText = textBox1.Text;
            Result_lbl.Visible = false;

            if (int.TryParse(inputText, out int number))
            {
                if (number % 2 == 0)
                {
                    Result_lbl.Text = textBox1.Text + " IS EVEN NUMBER";
                    Result_lbl.Visible = true;
                }
                else
                {
                    Result_lbl.Text = textBox1.Text + " IS ODD NUMBER";
                    Result_lbl.Visible = true;
                }
            }
            else
            {
                Result_lbl.Text = "INVALID INPUT";
                Result_lbl.ForeColor = Color.Red;
                Result_lbl.Visible = true;
            }
        }
    }
}
