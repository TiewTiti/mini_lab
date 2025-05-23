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
    public partial class MultiplyTable : Form
    {
        public MultiplyTable()
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (int.TryParse(textBox1.Text, out int number))
            {
                for (int i = 1; i <= 30; i++)
                {
                    listBox1.Items.Add($"{number} x {i} = {number * i}");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
