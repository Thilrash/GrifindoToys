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
    public partial class EmployeeInfo : Form
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
        public decimal NoPayValue { get; set; }
        public decimal GrossPayValue { get; set; }
= 0;    public decimal BasePayValue { get; set; }
        public int OverTimesHours { get; set; }

        public EmployeeInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void PopulateInfo()
        {
            label25.Text = this.FullName;
            label14.Text = this.MonthlySalary.ToString();
            label15.Text = this.OverTimeRatesHourly.ToString();
            label16.Text = this.Allowances.ToString();
            label17.Text = this.NoPayValue == 0 ? "N/A" : this.NoPayValue.ToString();
            label18.Text = this.BasePayValue == 0 ? "N/A" : this.BasePayValue.ToString();
            label19.Text = this.GrossPayValue == 0 ? "N/A" : this.GrossPayValue.ToString();
            label20.Text = this.DateRange == 0 ? "N/A" : this.DateRange.ToString();
            label21.Text = this.BeginDate.ToString() == "1/1/0001 12:00:00 AM" ? "N/A" : this.BeginDate.ToString();
            label22.Text = this.EndDate.ToString() == "1/1/0001 12:00:00 AM" ? "N/A" : this.EndDate.ToString();
            label23.Text = this.NoOfLeaves == 0 ? "N/A" : this.NoOfLeaves.ToString();
            label24.Text = this.OverTimesHours == 0 ? "N/A" : this.OverTimesHours.ToString();
        }

        private void EmployeeInfo_Load(object sender, EventArgs e)
        {
            PopulateInfo();
        }
    }
}
