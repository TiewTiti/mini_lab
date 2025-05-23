using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCsharp
{
    public partial class frmExOne : Form
    {
        public frmExOne()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtCode.Text) ||
                string.IsNullOrWhiteSpace(txtSalary.Text))
            {
                lblMessage.Text = "กรุณากรอกข้อมูลให้ครบถ้วน";
                return;
            }

            string employeeData = $"{txtCode.Text} - {txtName.Text} - Salary : {txtSalary:C}";
            lstEm.Items.Add(employeeData);

            txtName.Clear();
            txtCode.Clear();
            txtSalary.Clear();
            lblMessage.Text = "เพิ่มข้อมูลสำเร็จ";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Use SelectedItem instead of SelectedItems to remove the selected item.
            if (lstEm.SelectedItem != null)
            {
                lstEm.Items.Remove(lstEm.SelectedItem); // Remove the selected item.
                lblMessage.Text = "ลบข้อมูลสำเร็จ";
            }
            else
            {
                lblMessage.Text = "กรุณาเลือกรายการที่ต้องการลบ";
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var salaries = lstEm.Items.Cast<string>()
                .Select(item =>
                {
                    var parts = item.Split('-');
                    string salaryPart = parts.Last().Replace("เงินเดือน : ", "").Trim();
                    return decimal.Parse(salaryPart, System.Globalization.NumberStyles.Currency);
                }).ToList();

            if (salaries.Count > 0)
            {
                decimal maxSalary = salaries.Max();
                decimal minSalary = salaries.Min();
                decimal avgSalary = salaries.Average();
                lblMessage.Text = $" เงินเดือนสูงสุด : {maxSalary:C}, เงินเดือนต่ำสุด: {minSalary:C}, เงินเดือนเฉลี่ย: {avgSalary:C}";
            }
            else
            {
                lblMessage.Text = "ไม่พบข้อมูลพนักงาน";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lstEm.Items.Clear();
            txtCode.Clear();
            txtName.Clear();
            txtSalary.Clear();
            lblMessage.Text = "ล้างข้อมูลทั้งหมด";
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string allEmployeeData = "";
            for (int i = 0; i < lstEm.Items.Count; i++)
                allEmployeeData += lstEm.Items[i] + "\n";
            lblMessage.Text = string.IsNullOrEmpty(allEmployeeData) ? "ไม่มีข้อมูลพนักงาน" : allEmployeeData;
        }
    }
}
