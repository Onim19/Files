namespace BankManagementSystem.Code.GUI
{
    partial class EmployeeList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Panel_info = new System.Windows.Forms.Panel();
            this.lbID = new System.Windows.Forms.Label();
            this.lbSearch = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.Salary = new System.Windows.Forms.TextBox();
            this.lbSalary = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbVacancy = new System.Windows.Forms.ComboBox();
            this.Panel_gender = new System.Windows.Forms.Panel();
            this.RbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.lbGender = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lbVacancy = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.Dob = new System.Windows.Forms.DateTimePicker();
            this.lbLastName = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.TextBox();
            this.lbDob = new System.Windows.Forms.Label();
            this.Nid = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.TextBox();
            this.lbNid = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.dgvEmployeeList = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.Panel_info.SuspendLayout();
            this.Panel_gender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Panel_info);
            this.panel1.Controls.Add(this.dgvEmployeeList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1088, 621);
            this.panel1.TabIndex = 0;
            // 
            // Panel_info
            // 
            this.Panel_info.BackColor = System.Drawing.Color.Gainsboro;
            this.Panel_info.Controls.Add(this.lbID);
            this.Panel_info.Controls.Add(this.lbSearch);
            this.Panel_info.Controls.Add(this.tbSearch);
            this.Panel_info.Controls.Add(this.Salary);
            this.Panel_info.Controls.Add(this.lbSalary);
            this.Panel_info.Controls.Add(this.btnClear);
            this.Panel_info.Controls.Add(this.cbVacancy);
            this.Panel_info.Controls.Add(this.Panel_gender);
            this.Panel_info.Controls.Add(this.lbGender);
            this.Panel_info.Controls.Add(this.btnDelete);
            this.Panel_info.Controls.Add(this.btnUpdate);
            this.Panel_info.Controls.Add(this.lbVacancy);
            this.Panel_info.Controls.Add(this.lbFirstName);
            this.Panel_info.Controls.Add(this.Dob);
            this.Panel_info.Controls.Add(this.lbLastName);
            this.Panel_info.Controls.Add(this.Phone);
            this.Panel_info.Controls.Add(this.lbDob);
            this.Panel_info.Controls.Add(this.Nid);
            this.Panel_info.Controls.Add(this.lbPhone);
            this.Panel_info.Controls.Add(this.Email);
            this.Panel_info.Controls.Add(this.lbEmail);
            this.Panel_info.Controls.Add(this.Address);
            this.Panel_info.Controls.Add(this.lbNid);
            this.Panel_info.Controls.Add(this.LastName);
            this.Panel_info.Controls.Add(this.lbAddress);
            this.Panel_info.Controls.Add(this.FirstName);
            this.Panel_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_info.Location = new System.Drawing.Point(0, 0);
            this.Panel_info.Name = "Panel_info";
            this.Panel_info.Size = new System.Drawing.Size(1088, 354);
            this.Panel_info.TabIndex = 39;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.BackColor = System.Drawing.Color.Snow;
            this.lbID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbID.Location = new System.Drawing.Point(33, 19);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(26, 22);
            this.lbID.TabIndex = 44;
            this.lbID.Text = "Id";
            this.lbID.Visible = false;
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.BackColor = System.Drawing.Color.Snow;
            this.lbSearch.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbSearch.Location = new System.Drawing.Point(70, 305);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(67, 22);
            this.lbSearch.TabIndex = 43;
            this.lbSearch.Text = "Search";
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(160, 303);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(318, 24);
            this.tbSearch.TabIndex = 42;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // Salary
            // 
            this.Salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salary.Location = new System.Drawing.Point(719, 227);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(318, 24);
            this.Salary.TabIndex = 41;
            // 
            // lbSalary
            // 
            this.lbSalary.AutoSize = true;
            this.lbSalary.BackColor = System.Drawing.Color.Snow;
            this.lbSalary.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalary.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbSalary.Location = new System.Drawing.Point(568, 228);
            this.lbSalary.Name = "lbSalary";
            this.lbSalary.Size = new System.Drawing.Size(61, 22);
            this.lbSalary.TabIndex = 40;
            this.lbSalary.Text = "Salary";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(911, 288);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 39);
            this.btnClear.TabIndex = 39;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbVacancy
            // 
            this.cbVacancy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVacancy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVacancy.FormattingEnabled = true;
            this.cbVacancy.Items.AddRange(new object[] {
            "Admin",
            "Bank Teller",
            "Customer Service Officer",
            "Junior Officer",
            "Trainee Officer",
            "Data Entry Operator",
            "Operations Officer",
            "Back Office Executive",
            "Branch Operations Manager",
            "Accounts Officer",
            "Financial Analyst",
            "Internal Auditor",
            "Credit Officer",
            "Relationship Manager",
            "Risk Management Officer",
            "IT Officer",
            "Core Banking System Officer",
            "Cyber Security Analyst",
            "Marketing Officer",
            "Business Development Executive",
            "Branch Manager",
            "Regional Manager",
            "Chief Financial Officer"});
            this.cbVacancy.Location = new System.Drawing.Point(184, 61);
            this.cbVacancy.Name = "cbVacancy";
            this.cbVacancy.Size = new System.Drawing.Size(318, 28);
            this.cbVacancy.TabIndex = 38;
            // 
            // Panel_gender
            // 
            this.Panel_gender.BackColor = System.Drawing.Color.Transparent;
            this.Panel_gender.Controls.Add(this.RbFemale);
            this.Panel_gender.Controls.Add(this.rbMale);
            this.Panel_gender.Location = new System.Drawing.Point(184, 221);
            this.Panel_gender.Name = "Panel_gender";
            this.Panel_gender.Size = new System.Drawing.Size(318, 43);
            this.Panel_gender.TabIndex = 35;
            // 
            // RbFemale
            // 
            this.RbFemale.AutoSize = true;
            this.RbFemale.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RbFemale.Location = new System.Drawing.Point(130, 10);
            this.RbFemale.Name = "RbFemale";
            this.RbFemale.Size = new System.Drawing.Size(74, 20);
            this.RbFemale.TabIndex = 1;
            this.RbFemale.Text = "Female";
            this.RbFemale.UseVisualStyleBackColor = false;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rbMale.Location = new System.Drawing.Point(3, 10);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(58, 20);
            this.rbMale.TabIndex = 0;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = false;
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.BackColor = System.Drawing.Color.Snow;
            this.lbGender.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGender.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbGender.Location = new System.Drawing.Point(33, 230);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(72, 22);
            this.lbGender.TabIndex = 37;
            this.lbGender.Text = "Gender";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(771, 288);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 39);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(632, 288);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 39);
            this.btnUpdate.TabIndex = 35;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lbVacancy
            // 
            this.lbVacancy.AutoSize = true;
            this.lbVacancy.BackColor = System.Drawing.Color.Snow;
            this.lbVacancy.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVacancy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbVacancy.Location = new System.Drawing.Point(33, 64);
            this.lbVacancy.Name = "lbVacancy";
            this.lbVacancy.Size = new System.Drawing.Size(80, 22);
            this.lbVacancy.TabIndex = 19;
            this.lbVacancy.Text = "Vacancy";
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.BackColor = System.Drawing.Color.Snow;
            this.lbFirstName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFirstName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbFirstName.Location = new System.Drawing.Point(33, 104);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(100, 22);
            this.lbFirstName.TabIndex = 20;
            this.lbFirstName.Text = "First Name";
            // 
            // Dob
            // 
            this.Dob.CustomFormat = "yyyy-MM-dd";
            this.Dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dob.Location = new System.Drawing.Point(184, 184);
            this.Dob.Name = "Dob";
            this.Dob.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Dob.Size = new System.Drawing.Size(318, 24);
            this.Dob.TabIndex = 33;
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.BackColor = System.Drawing.Color.Snow;
            this.lbLastName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLastName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbLastName.Location = new System.Drawing.Point(33, 144);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(98, 22);
            this.lbLastName.TabIndex = 21;
            this.lbLastName.Text = "Last Name";
            // 
            // Phone
            // 
            this.Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.Location = new System.Drawing.Point(719, 62);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(318, 24);
            this.Phone.TabIndex = 32;
            // 
            // lbDob
            // 
            this.lbDob.AutoSize = true;
            this.lbDob.BackColor = System.Drawing.Color.Snow;
            this.lbDob.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDob.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbDob.Location = new System.Drawing.Point(33, 184);
            this.lbDob.Name = "lbDob";
            this.lbDob.Size = new System.Drawing.Size(116, 22);
            this.lbDob.TabIndex = 22;
            this.lbDob.Text = "Date of Birth";
            // 
            // Nid
            // 
            this.Nid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nid.Location = new System.Drawing.Point(719, 144);
            this.Nid.Name = "Nid";
            this.Nid.Size = new System.Drawing.Size(318, 24);
            this.Nid.TabIndex = 31;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.BackColor = System.Drawing.Color.Snow;
            this.lbPhone.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbPhone.Location = new System.Drawing.Point(568, 64);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(64, 22);
            this.lbPhone.TabIndex = 23;
            this.lbPhone.Text = "Phone";
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(719, 102);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(318, 24);
            this.Email.TabIndex = 30;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.BackColor = System.Drawing.Color.Snow;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbEmail.Location = new System.Drawing.Point(568, 104);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(62, 22);
            this.lbEmail.TabIndex = 24;
            this.lbEmail.Text = "E-mail";
            // 
            // Address
            // 
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(719, 184);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(318, 24);
            this.Address.TabIndex = 29;
            // 
            // lbNid
            // 
            this.lbNid.AutoSize = true;
            this.lbNid.BackColor = System.Drawing.Color.Snow;
            this.lbNid.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbNid.Location = new System.Drawing.Point(568, 144);
            this.lbNid.Name = "lbNid";
            this.lbNid.Size = new System.Drawing.Size(46, 22);
            this.lbNid.TabIndex = 25;
            this.lbNid.Text = "NID ";
            // 
            // LastName
            // 
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.Location = new System.Drawing.Point(184, 144);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(318, 24);
            this.LastName.TabIndex = 28;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.BackColor = System.Drawing.Color.Snow;
            this.lbAddress.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbAddress.Location = new System.Drawing.Point(568, 185);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(77, 22);
            this.lbAddress.TabIndex = 26;
            this.lbAddress.Text = "Address";
            // 
            // FirstName
            // 
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.Location = new System.Drawing.Point(184, 105);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(318, 24);
            this.FirstName.TabIndex = 27;
            // 
            // dgvEmployeeList
            // 
            this.dgvEmployeeList.AllowUserToAddRows = false;
            this.dgvEmployeeList.AllowUserToDeleteRows = false;
            this.dgvEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvEmployeeList.Location = new System.Drawing.Point(0, 354);
            this.dgvEmployeeList.MultiSelect = false;
            this.dgvEmployeeList.Name = "dgvEmployeeList";
            this.dgvEmployeeList.ReadOnly = true;
            this.dgvEmployeeList.RowHeadersWidth = 51;
            this.dgvEmployeeList.RowTemplate.Height = 24;
            this.dgvEmployeeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployeeList.Size = new System.Drawing.Size(1088, 267);
            this.dgvEmployeeList.TabIndex = 2;
            // 
            // EmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 621);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EmployeeList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.EmloyeeList_Load);
            this.panel1.ResumeLayout(false);
            this.Panel_info.ResumeLayout(false);
            this.Panel_info.PerformLayout();
            this.Panel_gender.ResumeLayout(false);
            this.Panel_gender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvEmployeeList;
        private System.Windows.Forms.Panel Panel_info;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cbVacancy;
        private System.Windows.Forms.Panel Panel_gender;
        private System.Windows.Forms.RadioButton RbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lbVacancy;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.DateTimePicker Dob;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.Label lbDob;
        private System.Windows.Forms.TextBox Nid;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Label lbNid;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox Salary;
        private System.Windows.Forms.Label lbSalary;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Label lbID;
    }
}