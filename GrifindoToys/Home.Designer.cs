namespace GrifindoToys
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnSalaryCalculation = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRefreshTable = new System.Windows.Forms.Button();
            this.dgvEmployeeDataTable = new System.Windows.Forms.DataGridView();
            this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonthlySalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OverTimeRatesHourly = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Allowances = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TwoMonthsSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoPayValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BasePayValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrossPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateRange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BeginDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoOfLeaves = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearchEmployee = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.txtSearchEmployee = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grifindo Toys Pay Roll System";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnSettings);
            this.groupBox1.Controls.Add(this.btnSalaryCalculation);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(50, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 505);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pay Roll Controls";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "Please select the employee before\r\nget the service from the buttons";
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(22, 57);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(222, 35);
            this.btnSettings.TabIndex = 11;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnSalaryCalculation
            // 
            this.btnSalaryCalculation.Location = new System.Drawing.Point(22, 117);
            this.btnSalaryCalculation.Name = "btnSalaryCalculation";
            this.btnSalaryCalculation.Size = new System.Drawing.Size(222, 35);
            this.btnSalaryCalculation.TabIndex = 10;
            this.btnSalaryCalculation.Text = "Salary Calculation";
            this.btnSalaryCalculation.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(41, 437);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(141, 33);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRefreshTable);
            this.groupBox2.Controls.Add(this.dgvEmployeeDataTable);
            this.groupBox2.Controls.Add(this.btnSearchEmployee);
            this.groupBox2.Controls.Add(this.btnView);
            this.groupBox2.Controls.Add(this.txtSearchEmployee);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.btnRegister);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(369, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(753, 505);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Employees Control";
            // 
            // btnRefreshTable
            // 
            this.btnRefreshTable.Location = new System.Drawing.Point(587, 56);
            this.btnRefreshTable.Name = "btnRefreshTable";
            this.btnRefreshTable.Size = new System.Drawing.Size(141, 35);
            this.btnRefreshTable.TabIndex = 11;
            this.btnRefreshTable.Text = "Refresh Table";
            this.btnRefreshTable.UseVisualStyleBackColor = true;
            this.btnRefreshTable.Click += new System.EventHandler(this.btnRefreshTable_Click);
            // 
            // dgvEmployeeDataTable
            // 
            this.dgvEmployeeDataTable.AllowUserToDeleteRows = false;
            this.dgvEmployeeDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeDataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeId,
            this.FullName,
            this.MonthlySalary,
            this.OverTimeRatesHourly,
            this.Allowances,
            this.TwoMonthsSalary,
            this.NoPayValue,
            this.BasePayValue,
            this.GrossPay,
            this.DateRange,
            this.BeginDate,
            this.EndDate,
            this.NoOfLeaves});
            this.dgvEmployeeDataTable.Location = new System.Drawing.Point(27, 104);
            this.dgvEmployeeDataTable.Name = "dgvEmployeeDataTable";
            this.dgvEmployeeDataTable.ReadOnly = true;
            this.dgvEmployeeDataTable.RowHeadersWidth = 51;
            this.dgvEmployeeDataTable.RowTemplate.Height = 24;
            this.dgvEmployeeDataTable.Size = new System.Drawing.Size(701, 312);
            this.dgvEmployeeDataTable.TabIndex = 10;
            this.dgvEmployeeDataTable.Click += new System.EventHandler(this.dgvEmployeeDataTable_Click);
            this.dgvEmployeeDataTable.DoubleClick += new System.EventHandler(this.dgvEmployeeDataTable_DoubleClick);
            // 
            // EmployeeId
            // 
            this.EmployeeId.DataPropertyName = "EmployeeId";
            this.EmployeeId.HeaderText = "EmployeeId";
            this.EmployeeId.MinimumWidth = 6;
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.ReadOnly = true;
            this.EmployeeId.Visible = false;
            this.EmployeeId.Width = 125;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Full Name";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // MonthlySalary
            // 
            this.MonthlySalary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MonthlySalary.DataPropertyName = "MonthlySalary";
            this.MonthlySalary.HeaderText = "Monthly Salary";
            this.MonthlySalary.MinimumWidth = 6;
            this.MonthlySalary.Name = "MonthlySalary";
            this.MonthlySalary.ReadOnly = true;
            // 
            // OverTimeRatesHourly
            // 
            this.OverTimeRatesHourly.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OverTimeRatesHourly.DataPropertyName = "OverTimeRatesHourly";
            this.OverTimeRatesHourly.HeaderText = "Over Time Rates Hourly";
            this.OverTimeRatesHourly.MinimumWidth = 6;
            this.OverTimeRatesHourly.Name = "OverTimeRatesHourly";
            this.OverTimeRatesHourly.ReadOnly = true;
            // 
            // Allowances
            // 
            this.Allowances.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Allowances.DataPropertyName = "Allowances";
            this.Allowances.HeaderText = "Allowances";
            this.Allowances.MinimumWidth = 6;
            this.Allowances.Name = "Allowances";
            this.Allowances.ReadOnly = true;
            // 
            // TwoMonthsSalary
            // 
            this.TwoMonthsSalary.DataPropertyName = "TwoMonthsSalary";
            this.TwoMonthsSalary.HeaderText = "Two Months Salary";
            this.TwoMonthsSalary.MinimumWidth = 6;
            this.TwoMonthsSalary.Name = "TwoMonthsSalary";
            this.TwoMonthsSalary.ReadOnly = true;
            this.TwoMonthsSalary.Visible = false;
            this.TwoMonthsSalary.Width = 125;
            // 
            // NoPayValue
            // 
            this.NoPayValue.DataPropertyName = "NoPayValue";
            this.NoPayValue.HeaderText = "No Pay Value";
            this.NoPayValue.MinimumWidth = 6;
            this.NoPayValue.Name = "NoPayValue";
            this.NoPayValue.ReadOnly = true;
            this.NoPayValue.Visible = false;
            this.NoPayValue.Width = 125;
            // 
            // BasePayValue
            // 
            this.BasePayValue.DataPropertyName = "BasePayValue";
            this.BasePayValue.HeaderText = "Base Pay Value";
            this.BasePayValue.MinimumWidth = 6;
            this.BasePayValue.Name = "BasePayValue";
            this.BasePayValue.ReadOnly = true;
            this.BasePayValue.Visible = false;
            this.BasePayValue.Width = 125;
            // 
            // GrossPay
            // 
            this.GrossPay.DataPropertyName = "GrossPay";
            this.GrossPay.HeaderText = "Gross Pay";
            this.GrossPay.MinimumWidth = 6;
            this.GrossPay.Name = "GrossPay";
            this.GrossPay.ReadOnly = true;
            this.GrossPay.Visible = false;
            this.GrossPay.Width = 125;
            // 
            // DateRange
            // 
            this.DateRange.DataPropertyName = "DateRange";
            this.DateRange.HeaderText = "Date Range";
            this.DateRange.MinimumWidth = 6;
            this.DateRange.Name = "DateRange";
            this.DateRange.ReadOnly = true;
            this.DateRange.Visible = false;
            this.DateRange.Width = 125;
            // 
            // BeginDate
            // 
            this.BeginDate.DataPropertyName = "BeginDate";
            this.BeginDate.HeaderText = "Begin Date";
            this.BeginDate.MinimumWidth = 6;
            this.BeginDate.Name = "BeginDate";
            this.BeginDate.ReadOnly = true;
            this.BeginDate.Visible = false;
            this.BeginDate.Width = 125;
            // 
            // EndDate
            // 
            this.EndDate.DataPropertyName = "EndDate";
            this.EndDate.HeaderText = "End Date";
            this.EndDate.MinimumWidth = 6;
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            this.EndDate.Visible = false;
            this.EndDate.Width = 125;
            // 
            // NoOfLeaves
            // 
            this.NoOfLeaves.DataPropertyName = "NoOfLeaves";
            this.NoOfLeaves.HeaderText = "No Of Leaves";
            this.NoOfLeaves.MinimumWidth = 6;
            this.NoOfLeaves.Name = "NoOfLeaves";
            this.NoOfLeaves.ReadOnly = true;
            this.NoOfLeaves.Visible = false;
            this.NoOfLeaves.Width = 125;
            // 
            // btnSearchEmployee
            // 
            this.btnSearchEmployee.Location = new System.Drawing.Point(267, 56);
            this.btnSearchEmployee.Name = "btnSearchEmployee";
            this.btnSearchEmployee.Size = new System.Drawing.Size(141, 35);
            this.btnSearchEmployee.TabIndex = 9;
            this.btnSearchEmployee.Text = "Search";
            this.btnSearchEmployee.UseVisualStyleBackColor = true;
            this.btnSearchEmployee.Click += new System.EventHandler(this.btnSearchEmployee_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(213, 437);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(141, 33);
            this.btnView.TabIndex = 7;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            // 
            // txtSearchEmployee
            // 
            this.txtSearchEmployee.Location = new System.Drawing.Point(27, 61);
            this.txtSearchEmployee.Name = "txtSearchEmployee";
            this.txtSearchEmployee.Size = new System.Drawing.Size(234, 24);
            this.txtSearchEmployee.TabIndex = 6;
            this.txtSearchEmployee.TextChanged += new System.EventHandler(this.txtSearchEmployee_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search employee";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(560, 437);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(141, 33);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(387, 437);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(141, 33);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 647);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "HomeForm";
            this.Text = "Grifindo Toys Pay Roll System";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeDataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSearchEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnSearchEmployee;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnSalaryCalculation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvEmployeeDataTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonthlySalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn OverTimeRatesHourly;
        private System.Windows.Forms.DataGridViewTextBoxColumn Allowances;
        private System.Windows.Forms.DataGridViewTextBoxColumn TwoMonthsSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoPayValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn BasePayValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrossPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateRange;
        private System.Windows.Forms.DataGridViewTextBoxColumn BeginDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoOfLeaves;
        private System.Windows.Forms.Button btnRefreshTable;
    }
}