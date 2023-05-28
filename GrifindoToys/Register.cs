using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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

        public int employeeId { get; set; }

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
            if (txtEmployeeName.Text == "" && txtMonthlySalary.Text == "" && txtOverTimeRatesHourly.Text == "" && txtAllowances.Text == "")
                MessageBox.Show("Please fill the all fields.");

            if (btnSave.Text == "Save")
            {
                using (DBModels db = new DBModels())
                {
                    employee.FullName = txtEmployeeName.Text.Trim();
                    employee.MonthlySalary = decimal.Parse(txtMonthlySalary.Text);
                    employee.OverTimeRatesHourly = decimal.Parse(txtOverTimeRatesHourly.Text);
                    employee.Allowances = decimal.Parse(txtAllowances.Text);

                    if (employee.EmployeeId == 0)
                        db.Employees.Add(employee);
                        db.SaveChanges();
                }
                MessageBox.Show("Employee data saved successfully");
                this.Dispose();
            }
            else
            {
                employee.EmployeeId = employeeId;
                employee.FullName = txtEmployeeName.Text.Trim();
                employee.MonthlySalary = decimal.Parse(txtMonthlySalary.Text);
                employee.OverTimeRatesHourly = decimal.Parse(txtOverTimeRatesHourly.Text);
                employee.Allowances = decimal.Parse(txtAllowances.Text);

                using (DBModels db = new DBModels())
                {
                    if (employee.EmployeeId != 0)
                        db.Entry(employee).State = EntityState.Modified;
                    
                    db.SaveChanges();
                }
                MessageBox.Show("Employee data edited successfully");
                this.Dispose();
            }            
        }
    }
}
