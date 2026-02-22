namespace BankManagementSystem.Code.GUI
{
    partial class AddEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployee));
            this.Panel_info = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbVacancy = new System.Windows.Forms.ComboBox();
            this.Panel_gender = new System.Windows.Forms.Panel();
            this.RbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.lbGender = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.AccInfo = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.lbSalary = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.Label();
            this.lbEmployeeId = new System.Windows.Forms.Label();
            this.Panel_info.SuspendLayout();
            this.Panel_gender.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_info
            // 
            this.Panel_info.BackColor = System.Drawing.Color.Transparent;
            this.Panel_info.Controls.Add(this.btnClear);
            this.Panel_info.Controls.Add(this.cbVacancy);
            this.Panel_info.Controls.Add(this.Panel_gender);
            this.Panel_info.Controls.Add(this.lbGender);
            this.Panel_info.Controls.Add(this.btnBack);
            this.Panel_info.Controls.Add(this.AccInfo);
            this.Panel_info.Controls.Add(this.btnNext);
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
            this.Panel_info.Location = new System.Drawing.Point(3, 6);
            this.Panel_info.Name = "Panel_info";
            this.Panel_info.Size = new System.Drawing.Size(522, 520);
            this.Panel_info.TabIndex = 38;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(324, 452);
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
            this.cbVacancy.Location = new System.Drawing.Point(164, 68);
            this.cbVacancy.Name = "cbVacancy";
            this.cbVacancy.Size = new System.Drawing.Size(318, 28);
            this.cbVacancy.TabIndex = 2;
            // 
            // Panel_gender
            // 
            this.Panel_gender.BackColor = System.Drawing.Color.Transparent;
            this.Panel_gender.Controls.Add(this.RbFemale);
            this.Panel_gender.Controls.Add(this.rbMale);
            this.Panel_gender.Location = new System.Drawing.Point(164, 228);
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
            this.RbFemale.TabStop = true;
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
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = false;
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.BackColor = System.Drawing.Color.Snow;
            this.lbGender.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGender.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbGender.Location = new System.Drawing.Point(13, 237);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(72, 22);
            this.lbGender.TabIndex = 37;
            this.lbGender.Text = "Gender";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(184, 452);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 39);
            this.btnBack.TabIndex = 36;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AccInfo
            // 
            this.AccInfo.AutoSize = true;
            this.AccInfo.BackColor = System.Drawing.Color.White;
            this.AccInfo.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccInfo.Location = new System.Drawing.Point(160, 12);
            this.AccInfo.Name = "AccInfo";
            this.AccInfo.Size = new System.Drawing.Size(184, 41);
            this.AccInfo.TabIndex = 18;
            this.AccInfo.Text = "Information";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(45, 452);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(120, 39);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lbVacancy
            // 
            this.lbVacancy.AutoSize = true;
            this.lbVacancy.BackColor = System.Drawing.Color.Snow;
            this.lbVacancy.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVacancy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbVacancy.Location = new System.Drawing.Point(13, 71);
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
            this.lbFirstName.Location = new System.Drawing.Point(13, 111);
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
            this.Dob.Location = new System.Drawing.Point(164, 191);
            this.Dob.Name = "Dob";
            this.Dob.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Dob.Size = new System.Drawing.Size(318, 24);
            this.Dob.TabIndex = 13;
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.BackColor = System.Drawing.Color.Snow;
            this.lbLastName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLastName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbLastName.Location = new System.Drawing.Point(13, 151);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(98, 22);
            this.lbLastName.TabIndex = 21;
            this.lbLastName.Text = "Last Name";
            // 
            // Phone
            // 
            this.Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.Location = new System.Drawing.Point(164, 277);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(318, 24);
            this.Phone.TabIndex = 9;
            // 
            // lbDob
            // 
            this.lbDob.AutoSize = true;
            this.lbDob.BackColor = System.Drawing.Color.Snow;
            this.lbDob.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDob.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbDob.Location = new System.Drawing.Point(13, 191);
            this.lbDob.Name = "lbDob";
            this.lbDob.Size = new System.Drawing.Size(116, 22);
            this.lbDob.TabIndex = 22;
            this.lbDob.Text = "Date of Birth";
            // 
            // Nid
            // 
            this.Nid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nid.Location = new System.Drawing.Point(164, 359);
            this.Nid.Name = "Nid";
            this.Nid.Size = new System.Drawing.Size(318, 24);
            this.Nid.TabIndex = 11;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.BackColor = System.Drawing.Color.Snow;
            this.lbPhone.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbPhone.Location = new System.Drawing.Point(13, 279);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(64, 22);
            this.lbPhone.TabIndex = 23;
            this.lbPhone.Text = "Phone";
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(164, 317);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(318, 24);
            this.Email.TabIndex = 10;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.BackColor = System.Drawing.Color.Snow;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbEmail.Location = new System.Drawing.Point(13, 319);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(62, 22);
            this.lbEmail.TabIndex = 24;
            this.lbEmail.Text = "E-mail";
            // 
            // Address
            // 
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(164, 399);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(318, 24);
            this.Address.TabIndex = 12;
            // 
            // lbNid
            // 
            this.lbNid.AutoSize = true;
            this.lbNid.BackColor = System.Drawing.Color.Snow;
            this.lbNid.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbNid.Location = new System.Drawing.Point(13, 359);
            this.lbNid.Name = "lbNid";
            this.lbNid.Size = new System.Drawing.Size(46, 22);
            this.lbNid.TabIndex = 25;
            this.lbNid.Text = "NID ";
            // 
            // LastName
            // 
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.Location = new System.Drawing.Point(164, 151);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(318, 24);
            this.LastName.TabIndex = 8;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.BackColor = System.Drawing.Color.Snow;
            this.lbAddress.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbAddress.Location = new System.Drawing.Point(13, 400);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(77, 22);
            this.lbAddress.TabIndex = 26;
            this.lbAddress.Text = "Address";
            // 
            // FirstName
            // 
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.Location = new System.Drawing.Point(164, 112);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(318, 24);
            this.FirstName.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnConfirm);
            this.panel1.Controls.Add(this.tbSalary);
            this.panel1.Controls.Add(this.lbSalary);
            this.panel1.Controls.Add(this.Id);
            this.panel1.Controls.Add(this.lbEmployeeId);
            this.panel1.Location = new System.Drawing.Point(27, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 187);
            this.panel1.TabIndex = 39;
            this.panel1.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(172, 134);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 30);
            this.btnCancel.TabIndex = 42;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(33, 136);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(91, 30);
            this.btnConfirm.TabIndex = 39;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // tbSalary
            // 
            this.tbSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSalary.Location = new System.Drawing.Point(156, 83);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(209, 24);
            this.tbSalary.TabIndex = 39;
            // 
            // lbSalary
            // 
            this.lbSalary.AutoSize = true;
            this.lbSalary.BackColor = System.Drawing.Color.Snow;
            this.lbSalary.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalary.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbSalary.Location = new System.Drawing.Point(3, 85);
            this.lbSalary.Name = "lbSalary";
            this.lbSalary.Size = new System.Drawing.Size(121, 22);
            this.lbSalary.TabIndex = 41;
            this.lbSalary.Text = "Salary              :";
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.BackColor = System.Drawing.Color.Snow;
            this.Id.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Id.Location = new System.Drawing.Point(152, 27);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(70, 22);
            this.Id.TabIndex = 40;
            this.Id.Text = "200280";
            // 
            // lbEmployeeId
            // 
            this.lbEmployeeId.AutoSize = true;
            this.lbEmployeeId.BackColor = System.Drawing.Color.Snow;
            this.lbEmployeeId.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmployeeId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbEmployeeId.Location = new System.Drawing.Point(3, 21);
            this.lbEmployeeId.Name = "lbEmployeeId";
            this.lbEmployeeId.Size = new System.Drawing.Size(121, 22);
            this.lbEmployeeId.TabIndex = 39;
            this.lbEmployeeId.Text = "Employee ID :";
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(836, 532);
            this.Controls.Add(this.Panel_info);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "AddEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Employee";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddEmployee_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddEmployee_KeyDown);
            this.Panel_info.ResumeLayout(false);
            this.Panel_info.PerformLayout();
            this.Panel_gender.ResumeLayout(false);
            this.Panel_gender.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_info;
        private System.Windows.Forms.Panel Panel_gender;
        private System.Windows.Forms.RadioButton RbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label AccInfo;
        private System.Windows.Forms.Button btnNext;
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
        private System.Windows.Forms.ComboBox cbVacancy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.Label lbEmployeeId;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.Label lbSalary;
        private System.Windows.Forms.Button btnClear;
    }
}