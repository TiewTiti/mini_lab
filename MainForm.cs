using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicCsharp;
using WinFormsApp1;

namespace Lab_2234_2240_2244
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmExOne frm1 = new frmExOne();
            frm1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oeanalysis_frm oddevencal = new oeanalysis_frm();
            oddevencal.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MultiplyTable multiplyTableForm = new MultiplyTable();
            multiplyTableForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmRandomNumber randomNumber = new frmRandomNumber();
            randomNumber.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Calcu calcu = new Calcu();
            calcu.Show();
        }
    }
}
