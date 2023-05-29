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
    public partial class Settings : Form
    {
        public int EmployeeId { get; set; }
        public string FullName { get; set; }
        public decimal MonthlySalary { get; set; }
        public decimal OverTimeRatesHourly { get; set; }
        public decimal Allowances { get; set; }
        public int DateRange { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public int NoOfLeaves { get; set; }
        
        Employee employee = new Employee();
        
        public Settings()
        {
            InitializeComponent();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            employee.EmployeeId = EmployeeId;
            employee.FullName = FullName;
            employee.MonthlySalary = MonthlySalary;
            employee.OverTimeRatesHourly = OverTimeRatesHourly;
            employee.Allowances = Allowances;
            employee.DateRange = int.Parse(txtDateRangeSalaryCycle.Text);
            employee.BeginDate = dtpSalaryBeginDate.Value.Date;
            employee.EndDate = dtpSalaryEndDate.Value.Date;
            employee.NoOfLeaves = int.Parse(txtNoEmployeeLeaves.Text);

            using (DBModels db = new DBModels())
            {
                if (employee.EmployeeId != 0)
                    db.Entry(employee).State = EntityState.Modified;

                db.SaveChanges();
                MessageBox.Show("Saved successfully");
                this.Dispose();
            }   
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            if (DateRange != 0 || DateRange == null)
            {
                txtDateRangeSalaryCycle.Text = DateRange.ToString();
                dtpSalaryBeginDate.Text = BeginDate.ToString();
                dtpSalaryEndDate.Text = EndDate.ToString();
                txtNoEmployeeLeaves.Text = NoOfLeaves.ToString();
            }
        }
    }
}
