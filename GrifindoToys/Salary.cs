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
    public partial class Salary : Form
    {
        Employee employee = new Employee();

        public int EmployeeId { get; set; }
        public string FullName { get; set; }
        public decimal MonthlySalary { get; set; }
        public decimal OverTimeRatesHourly { get; set; }
        public decimal Allowances { get; set; }
        public int DateRange { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public int NoOfLeaves { get; set; }

        public Salary()
        {
            InitializeComponent();
            btnSave.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCalculateSalary_Click(object sender, EventArgs e)
        {
            int governmentTax = txtGovernmentTax.Text == "" ? 0 : Int32.Parse(txtGovernmentTax.Text);
            decimal totalSalary = MonthlySalary + Allowances;

            // Base pay value calculation
            int overTimeHours = txtOverTimeHours.Text == "" ? 0 : Int32.Parse(txtOverTimeHours.Text);
            decimal basePayValue = MonthlySalary + Allowances + (OverTimeRatesHourly * overTimeHours);
            label1.Text = basePayValue.ToString();

            // No pay value
            decimal noPayValue = (totalSalary / DateRange) * NoOfLeaves;
            label3.Text = noPayValue.ToString();

            // Gross pay value
            decimal grossPayValue = basePayValue - (noPayValue + basePayValue * governmentTax);
            label2.Text = grossPayValue.ToString();

            btnSave.Enabled = true;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            employee.EmployeeId = this.EmployeeId;
            employee.FullName = this.FullName;
            employee.MonthlySalary = this.MonthlySalary;
            employee.OverTimeRatesHourly = this.OverTimeRatesHourly;
            employee.Allowances = this.Allowances;
            employee.TwoMonthsSalary = this.MonthlySalary * 2;
            employee.NoPayValue = Decimal.Parse(label3.Text);
            employee.BasePayValue = Decimal.Parse(label1.Text);
            employee.GrossPay = Decimal.Parse(label2.Text);
            employee.DateRange = this.DateRange;
            employee.BeginDate = this.BeginDate;
            employee.EndDate = this.EndDate;
            employee.NoOfLeaves = this.NoOfLeaves;
            employee.OverTimeHours = txtOverTimeHours.Text == "" ? 0 : Int32.Parse(txtOverTimeHours.Text);

            using (DBModels db = new DBModels())
            {
                if (employee.EmployeeId != 0)
                    db.Entry(employee).State = EntityState.Modified;

                db.SaveChanges();
            }

            MessageBox.Show("Employee salary calculation saved successfully");
            this.Dispose();
        }
    }
}
