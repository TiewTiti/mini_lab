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
    public partial class frmRandomNumber : Form
    {
        private int randomNumber;
        public frmRandomNumber()
        {
            InitializeComponent();
            GenerateRandomNumber();
        }

        private void GenerateRandomNumber()
        {
            Random rand = new Random();
            randomNumber = rand.Next(1, 101); // สุ่มเลขระหว่าง 1-100
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int userGuess;
            if (int.TryParse(textBox1.Text, out userGuess))
            {
                DialogResult result = MessageBox.Show(
                    "ยืนยันคำตอบไหมครับ ?",
                    "คำตอบ",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button2
                );
                if (userGuess > randomNumber)
                {
                    label2.Text = "สูงไปครับ ฟ้าแลบบบ";

                }
                else if (userGuess < randomNumber)
                {
                    label2.Text = "ต่ำไปครับ ฟ้าแลบบบ";
                }
                else
                {
                    label2.Text = "ถูกต้องแล้วครับบบ!!!!";
                    MessageBox.Show("ถูกต้องแล้วครับบบ! รับเงินรางวัล 1ล้านดอง!!!", "ยินดีด้วยปริศนาฟ้าแลป");
                    GenerateRandomNumber(); // สุ่มตัวเลขใหม่
                }
            }
            else
            {
                MessageBox.Show("กรุณาป้อนตัวเลขที่ถูกต้อง", "ข้อผิดพลาด");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmRandomNumber_Load(object sender, EventArgs e)
        {

        }
    }
}
