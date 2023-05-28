using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrifindoToys
{
    public partial class Register : Form
    {

        Employee employee = new Employee();

        public Register()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            employee.FullName = txtEmployeeName.Text.Trim();
            employee.MonthlySalary = decimal.Parse(txtMonthlySalary.Text);
            employee.OverTimeRatesHourly = decimal.Parse(txtOverTimeRatesHourly.Text);

            if (txtEmployeeName.Text == null && txtMonthlySalary.Text == null && txtOverTimeRatesHourly == null)
                MessageBox.Show("Please fill the all fields.");
            else 
            {
                using (DBModels db = new DBModels())
                {
                    db.Employees.Add(employee);
                    db.SaveChanges();
                    // HomeForm homeForm = new HomeForm();
                }
                MessageBox.Show("Employee data saved successfully");
            }
        }
    }
}
