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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            PopulateEmployeeTable();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.ShowDialog();
        }

        public void PopulateEmployeeTable()
        {
            using (DBModels db = new DBModels())
            {
                dgvEmployeesTable.DataSource = db.Employees.ToList<Employee>();
            }
        }

    }
}
