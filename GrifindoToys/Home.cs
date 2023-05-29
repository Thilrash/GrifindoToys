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
    public partial class HomeForm : Form
    {
        Employee employee = new Employee();

        public HomeForm()
        {
            InitializeComponent();
            PopulateEmployeeTable();
            btnDelete.Enabled = false;
            btnView.Enabled = false;
            btnEdit.Enabled = false;
            btnSettings.Enabled = false;
            btnSalaryCalculation.Enabled = false;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.ShowDialog();
        }

        public void PopulateEmployeeTable()
        {
            using (DBModels db = new DBModels()) { dgvEmployeeDataTable.DataSource = db.Employees.ToList<Employee>(); }
        }

        private void btnRefreshTable_Click(object sender, EventArgs e)
        {
            PopulateEmployeeTable();
            btnDelete.Enabled = false;
            btnView.Enabled = false;
            btnEdit.Enabled = false;
            btnSettings.Enabled = false;
            btnSalaryCalculation.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this record?", "EFC Desktop Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using(DBModels db = new DBModels()) 
                {
                    var entry = db.Entry(employee);

                    if (entry.State == EntityState.Detached)
                        db.Employees.Attach(employee);

                    db.Employees.Remove(employee);
                    db.SaveChanges();
                    PopulateEmployeeTable();

                    btnDelete.Enabled = false;
                    btnView.Enabled = false;
                    btnEdit.Enabled = false;
                    btnSettings.Enabled = false;
                    btnSalaryCalculation.Enabled = false;

                    MessageBox.Show("Deleted Successfully");
                }
            }
        }

        private void dgvEmployeeDataTable_DoubleClick(object sender, EventArgs e)
        {
            if (dgvEmployeeDataTable.CurrentRow.Index != -1)
            {
                employee.EmployeeId = Convert.ToInt32(dgvEmployeeDataTable.CurrentRow.Cells["EmployeeId"].Value);

                using (DBModels db = new DBModels()) { employee = db.Employees.Where(x => x.EmployeeId == employee.EmployeeId).FirstOrDefault(); }

                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
                btnView.Enabled = true;
                btnSettings.Enabled = true;

                if (employee.BasePayValue != null)
                    btnSalaryCalculation.Enabled = true;
            } 
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Name = "Edit Employee Details";
            register.Text = "Edit Employee Details";
            register.btnSave.Text = "Edit";
            register.employeeId = employee.EmployeeId;
            register.txtEmployeeName.Text = employee.FullName;
            register.txtMonthlySalary.Text = employee.MonthlySalary.ToString();
            register.txtOverTimeRatesHourly.Text = employee.OverTimeRatesHourly.ToString();
            register.txtAllowances.Text = employee.Allowances.ToString();
            register.groupBox1.Text = "Edit Employee Details";
            register.ShowDialog();
        }

        private void dgvEmployeeDataTable_Click(object sender, EventArgs e)
        {
            if (dgvEmployeeDataTable.CurrentRow.Index != -1)
            {
                employee.EmployeeId = Convert.ToInt32(dgvEmployeeDataTable.CurrentRow.Cells["EmployeeId"].Value);

                using (DBModels db = new DBModels()) { employee = db.Employees.Where(x => x.EmployeeId == employee.EmployeeId).FirstOrDefault(); }

                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
                btnView.Enabled = true;
                btnSettings.Enabled = true;

                if (employee.BasePayValue != null)
                    btnSalaryCalculation.Enabled = true;
            }
        }

        private void btnSearchEmployee_Click(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dgvEmployeeDataTable.DataSource;
            bindingSource.Filter = "EmployeeId Like '%" + txtSearchEmployee.Text + "%'";
            dgvEmployeeDataTable.DataSource = bindingSource;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.EmployeeId = employee.EmployeeId;
            settings.FullName = employee.FullName;
            settings.MonthlySalary = (decimal)employee.MonthlySalary;
            settings.OverTimeRatesHourly = (decimal)employee.OverTimeRatesHourly;
            settings.Allowances = (decimal)employee.Allowances;
            if (employee.DateRange != null)
                settings.DateRange = (int)employee.DateRange;
            if (employee.BeginDate != null)
                settings.BeginDate = (DateTime)employee.BeginDate;
            if (employee.EndDate != null)
                settings.EndDate = (DateTime)employee.EndDate;
            if (employee.NoOfLeaves != null)
                settings.NoOfLeaves = (int)employee.NoOfLeaves;
            settings.ShowDialog();
        }

        private void btnSalaryCalculation_Click(object sender, EventArgs e)
        {
            if (employee.NoOfLeaves != null)
            {
                Salary salary = new Salary();
                salary.EmployeeId = employee.EmployeeId;
                salary.FullName = employee.FullName;
                salary.MonthlySalary = (decimal)employee.MonthlySalary;
                salary.OverTimeRatesHourly = (int)employee.OverTimeRatesHourly;
                salary.Allowances = (decimal)employee.Allowances;
                salary.DateRange = (int)employee.DateRange;
                salary.BeginDate = (DateTime)employee.BeginDate;
                salary.EndDate = (DateTime)employee.EndDate;
                salary.NoOfLeaves = (int)employee.NoOfLeaves;
                salary.ShowDialog();
            } 
            else 
            {
                MessageBox.Show("You need to first configure the settings for this employee");
            }
            
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            EmployeeInfo employeeInfo = new EmployeeInfo();
            employeeInfo.EmployeeId = employee.EmployeeId;
            employeeInfo.FullName = employee.FullName;
            employeeInfo.MonthlySalary = (decimal)employee.MonthlySalary;
            employeeInfo.OverTimeRatesHourly = (decimal)employee.OverTimeRatesHourly;
            employeeInfo.Allowances = (decimal)employee.Allowances;
            if (employee.DateRange != null)
                employeeInfo.DateRange = (int)employee.DateRange;
            if (employee.BeginDate != null)
                employeeInfo.BeginDate = (DateTime)employee.BeginDate;
            if (employee.EndDate != null)
                employeeInfo.EndDate = (DateTime)employee.EndDate;
            if (employee.NoOfLeaves != null)
                employeeInfo.NoOfLeaves = (int)employee.NoOfLeaves;
            if (employee.BasePayValue != null)
                employeeInfo.BasePayValue = (decimal)employee.BasePayValue;
            if (employee.NoPayValue != null)
                employeeInfo.NoPayValue = (decimal)employee.NoPayValue;
            if (employee.GrossPay != null)
                employeeInfo.GrossPayValue = (decimal)employee.GrossPay;
            if (employee.OverTimeHours != null)
                employeeInfo.OverTimesHours = (int)employee.OverTimeHours;
            employeeInfo.ShowDialog();
        }
    }
}
