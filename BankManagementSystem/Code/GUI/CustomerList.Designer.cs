namespace BankManagementSystem.Code.GUI
{
    partial class CustomerList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Panel_info = new System.Windows.Forms.Panel();
            this.Panel_fdr_savings = new System.Windows.Forms.Panel();
            this.rbLoan = new System.Windows.Forms.RadioButton();
            this.RbFDR = new System.Windows.Forms.RadioButton();
            this.RbSavings = new System.Windows.Forms.RadioButton();
            this.AccType = new System.Windows.Forms.Label();
            this.lbAccNum = new System.Windows.Forms.Label();
            this.lbSearch = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.Balance = new System.Windows.Forms.TextBox();
            this.lbBalance = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.Panel_gender = new System.Windows.Forms.Panel();
            this.RbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.lbGender = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
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
            this.dgvCustomerList = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.Panel_info.SuspendLayout();
            this.Panel_fdr_savings.SuspendLayout();
            this.Panel_gender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Panel_info);
            this.panel1.Controls.Add(this.dgvCustomerList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1088, 621);
            this.panel1.TabIndex = 0;
            // 
            // Panel_info
            // 
            this.Panel_info.BackColor = System.Drawing.Color.Gainsboro;
            this.Panel_info.Controls.Add(this.Panel_fdr_savings);
            this.Panel_info.Controls.Add(this.AccType);
            this.Panel_info.Controls.Add(this.lbAccNum);
            this.Panel_info.Controls.Add(this.lbSearch);
            this.Panel_info.Controls.Add(this.tbSearch);
            this.Panel_info.Controls.Add(this.Balance);
            this.Panel_info.Controls.Add(this.lbBalance);
            this.Panel_info.Controls.Add(this.btnClear);
            this.Panel_info.Controls.Add(this.Panel_gender);
            this.Panel_info.Controls.Add(this.lbGender);
            this.Panel_info.Controls.Add(this.btnDelete);
            this.Panel_info.Controls.Add(this.btnUpdate);
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
            this.Panel_info.Size = new System.Drawing.Size(1088, 348);
            this.Panel_info.TabIndex = 40;
            // 
            // Panel_fdr_savings
            // 
            this.Panel_fdr_savings.BackColor = System.Drawing.Color.Transparent;
            this.Panel_fdr_savings.Controls.Add(this.rbLoan);
            this.Panel_fdr_savings.Controls.Add(this.RbFDR);
            this.Panel_fdr_savings.Controls.Add(this.RbSavings);
            this.Panel_fdr_savings.Location = new System.Drawing.Point(184, 56);
            this.Panel_fdr_savings.Name = "Panel_fdr_savings";
            this.Panel_fdr_savings.Size = new System.Drawing.Size(219, 43);
            this.Panel_fdr_savings.TabIndex = 46;
            // 
            // rbLoan
            // 
            this.rbLoan.AutoSize = true;
            this.rbLoan.Location = new System.Drawing.Point(82, 11);
            this.rbLoan.Name = "rbLoan";
            this.rbLoan.Size = new System.Drawing.Size(58, 20);
            this.rbLoan.TabIndex = 2;
            this.rbLoan.TabStop = true;
            this.rbLoan.Text = "Loan";
            this.rbLoan.UseVisualStyleBackColor = true;
            // 
            // RbFDR
            // 
            this.RbFDR.AutoSize = true;
            this.RbFDR.Location = new System.Drawing.Point(150, 11);
            this.RbFDR.Name = "RbFDR";
            this.RbFDR.Size = new System.Drawing.Size(56, 20);
            this.RbFDR.TabIndex = 1;
            this.RbFDR.TabStop = true;
            this.RbFDR.Text = "FDR";
            this.RbFDR.UseVisualStyleBackColor = true;
            // 
            // RbSavings
            // 
            this.RbSavings.AutoSize = true;
            this.RbSavings.Location = new System.Drawing.Point(3, 10);
            this.RbSavings.Name = "RbSavings";
            this.RbSavings.Size = new System.Drawing.Size(77, 20);
            this.RbSavings.TabIndex = 0;
            this.RbSavings.TabStop = true;
            this.RbSavings.Text = "Savings";
            this.RbSavings.UseVisualStyleBackColor = true;
            // 
            // AccType
            // 
            this.AccType.AutoSize = true;
            this.AccType.BackColor = System.Drawing.Color.Snow;
            this.AccType.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AccType.Location = new System.Drawing.Point(33, 64);
            this.AccType.Name = "AccType";
            this.AccType.Size = new System.Drawing.Size(124, 22);
            this.AccType.TabIndex = 45;
            this.AccType.Text = "Account Type";
            // 
            // lbAccNum
            // 
            this.lbAccNum.AutoSize = true;
            this.lbAccNum.BackColor = System.Drawing.Color.Snow;
            this.lbAccNum.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccNum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbAccNum.Location = new System.Drawing.Point(33, 19);
            this.lbAccNum.Name = "lbAccNum";
            this.lbAccNum.Size = new System.Drawing.Size(81, 22);
            this.lbAccNum.TabIndex = 44;
            this.lbAccNum.Text = "AccNum";
            this.lbAccNum.Visible = false;
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
            this.lbSearch.Click += new System.EventHandler(this.lbSearch_Click);
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
            // Balance
            // 
            this.Balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balance.Location = new System.Drawing.Point(719, 227);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(318, 24);
            this.Balance.TabIndex = 41;
            // 
            // lbBalance
            // 
            this.lbBalance.AutoSize = true;
            this.lbBalance.BackColor = System.Drawing.Color.Snow;
            this.lbBalance.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBalance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbBalance.Location = new System.Drawing.Point(568, 228);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(76, 22);
            this.lbBalance.TabIndex = 40;
            this.lbBalance.Text = "Balance";
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
            this.lbPhone.Click += new System.EventHandler(this.lbPhone_Click);
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
            // dgvCustomerList
            // 
            this.dgvCustomerList.AllowUserToAddRows = false;
            this.dgvCustomerList.AllowUserToDeleteRows = false;
            this.dgvCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCustomerList.Location = new System.Drawing.Point(0, 348);
            this.dgvCustomerList.MultiSelect = false;
            this.dgvCustomerList.Name = "dgvCustomerList";
            this.dgvCustomerList.ReadOnly = true;
            this.dgvCustomerList.RowHeadersWidth = 51;
            this.dgvCustomerList.RowTemplate.Height = 24;
            this.dgvCustomerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomerList.Size = new System.Drawing.Size(1088, 273);
            this.dgvCustomerList.TabIndex = 0;
            this.dgvCustomerList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerList_CellClick);
            this.dgvCustomerList.DoubleClick += new System.EventHandler(this.dgvCustomerList_DoubleClick);
            // 
            // CustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 621);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CustomerList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer ";
            this.Load += new System.EventHandler(this.CustomerList_Load);
            this.panel1.ResumeLayout(false);
            this.Panel_info.ResumeLayout(false);
            this.Panel_info.PerformLayout();
            this.Panel_fdr_savings.ResumeLayout(false);
            this.Panel_fdr_savings.PerformLayout();
            this.Panel_gender.ResumeLayout(false);
            this.Panel_gender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvCustomerList;
        private System.Windows.Forms.Panel Panel_info;
        private System.Windows.Forms.Label lbAccNum;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.TextBox Balance;
        private System.Windows.Forms.Label lbBalance;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel Panel_gender;
        private System.Windows.Forms.RadioButton RbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
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
        private System.Windows.Forms.Panel Panel_fdr_savings;
        private System.Windows.Forms.RadioButton rbLoan;
        private System.Windows.Forms.RadioButton RbFDR;
        private System.Windows.Forms.RadioButton RbSavings;
        private System.Windows.Forms.Label AccType;
    }
}