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
            }
        }

        private void btnSearchEmployee_Click(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dgvEmployeeDataTable.DataSource;
            bindingSource.Filter = "EmployeeId Like '%" + txtSearchEmployee.Text + "%'";
            dgvEmployeeDataTable.DataSource = bindingSource;
        }

        private void txtSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            //(dgvEmployeeDataTable.DataSource as DataTable).DefaultView.RowFilter = string.Format("EmployeeId = '{0}'", txtSearchEmployee.Text);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
        }

        //private void btnSearchEmployee_Click(object sender, EventArgs e)
        //{
        //    string searchVal = txtSearchEmployee.Text;
        //    dgvEmployeeDataTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        //    try 
        //    {
        //        bool valueResult = false;

        //        foreach (DataGridView row in dgvEmployeeDataTable.Rows)
        //        {
        //            for (int i = 0; i < row.ColumnCount; i++)
        //            {
        //                if (row.Cells[i])
        //            }
        //        }
        //    }
        //    catch (Exception ex) 
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
    }
}
