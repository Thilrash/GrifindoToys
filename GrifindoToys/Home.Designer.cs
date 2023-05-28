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
            this.btnSearchEmployee = new System.Windows.Forms.Button();
            this.dgvEmployeesTable = new System.Windows.Forms.DataGridView();
            this.btnView = new System.Windows.Forms.Button();
            this.txtSearchEmployee = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonthlySalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OverTimeRatesHourly = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Allowances = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeesTable)).BeginInit();
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
            this.btnSettings.Location = new System.Drawing.Point(22, 127);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(222, 35);
            this.btnSettings.TabIndex = 11;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnSalaryCalculation
            // 
            this.btnSalaryCalculation.Location = new System.Drawing.Point(22, 71);
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
            this.groupBox2.Controls.Add(this.btnSearchEmployee);
            this.groupBox2.Controls.Add(this.dgvEmployeesTable);
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
            // btnSearchEmployee
            // 
            this.btnSearchEmployee.Location = new System.Drawing.Point(283, 56);
            this.btnSearchEmployee.Name = "btnSearchEmployee";
            this.btnSearchEmployee.Size = new System.Drawing.Size(141, 35);
            this.btnSearchEmployee.TabIndex = 9;
            this.btnSearchEmployee.Text = "Search";
            this.btnSearchEmployee.UseVisualStyleBackColor = true;
            // 
            // dgvEmployeesTable
            // 
            this.dgvEmployeesTable.AccessibleName = "";
            this.dgvEmployeesTable.AllowUserToDeleteRows = false;
            this.dgvEmployeesTable.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvEmployeesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeId,
            this.FullName,
            this.MonthlySalary,
            this.OverTimeRatesHourly,
            this.Allowances});
            this.dgvEmployeesTable.Location = new System.Drawing.Point(43, 101);
            this.dgvEmployeesTable.Name = "dgvEmployeesTable";
            this.dgvEmployeesTable.RowHeadersWidth = 51;
            this.dgvEmployeesTable.RowTemplate.Height = 24;
            this.dgvEmployeesTable.Size = new System.Drawing.Size(656, 318);
            this.dgvEmployeesTable.TabIndex = 8;
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
            this.txtSearchEmployee.Location = new System.Drawing.Point(43, 61);
            this.txtSearchEmployee.Name = "txtSearchEmployee";
            this.txtSearchEmployee.Size = new System.Drawing.Size(234, 24);
            this.txtSearchEmployee.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 39);
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
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(387, 437);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(141, 33);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // EmployeeId
            // 
            this.EmployeeId.HeaderText = "EmployeeId";
            this.EmployeeId.MinimumWidth = 6;
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.Visible = false;
            this.EmployeeId.Width = 125;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FullName.HeaderText = "Full Name";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            // 
            // MonthlySalary
            // 
            this.MonthlySalary.HeaderText = "Monthly Salary";
            this.MonthlySalary.MinimumWidth = 6;
            this.MonthlySalary.Name = "MonthlySalary";
            this.MonthlySalary.Width = 125;
            // 
            // OverTimeRatesHourly
            // 
            this.OverTimeRatesHourly.HeaderText = "Over Time Rates Hourly";
            this.OverTimeRatesHourly.MinimumWidth = 6;
            this.OverTimeRatesHourly.Name = "OverTimeRatesHourly";
            this.OverTimeRatesHourly.Width = 125;
            // 
            // Allowances
            // 
            this.Allowances.HeaderText = "Allowances";
            this.Allowances.MinimumWidth = 6;
            this.Allowances.Name = "Allowances";
            this.Allowances.Width = 125;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeesTable)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvEmployeesTable;
        private System.Windows.Forms.Button btnSearchEmployee;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnSalaryCalculation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonthlySalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn OverTimeRatesHourly;
        private System.Windows.Forms.DataGridViewTextBoxColumn Allowances;
    }
}