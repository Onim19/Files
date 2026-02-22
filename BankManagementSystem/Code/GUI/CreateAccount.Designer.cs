namespace BankManagementSystem.Code.GUI
{
    partial class CreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount));
            this.btnNext = new System.Windows.Forms.Button();
            this.Panel_fdr_savings = new System.Windows.Forms.Panel();
            this.rbLoan = new System.Windows.Forms.RadioButton();
            this.RbFDR = new System.Windows.Forms.RadioButton();
            this.RbSavings = new System.Windows.Forms.RadioButton();
            this.Dob = new System.Windows.Forms.DateTimePicker();
            this.Phone = new System.Windows.Forms.TextBox();
            this.Nid = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.AccAddress = new System.Windows.Forms.Label();
            this.AccNid = new System.Windows.Forms.Label();
            this.AccEmail = new System.Windows.Forms.Label();
            this.AccPhone = new System.Windows.Forms.Label();
            this.AccDob = new System.Windows.Forms.Label();
            this.AccLastName = new System.Windows.Forms.Label();
            this.AccFirstName = new System.Windows.Forms.Label();
            this.AccType = new System.Windows.Forms.Label();
            this.AccInfo = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.Panel_info = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.Panel_gender = new System.Windows.Forms.Panel();
            this.RbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.AccGender = new System.Windows.Forms.Label();
            this.AccNum = new System.Windows.Forms.Label();
            this.AccountNumber = new System.Windows.Forms.Label();
            this.Deposite_Amount = new System.Windows.Forms.Label();
            this.DepositeAmount = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.PassBack = new System.Windows.Forms.Button();
            this.Panel_Pass = new System.Windows.Forms.Panel();
            this.Panel_fdr_savings.SuspendLayout();
            this.Panel_info.SuspendLayout();
            this.Panel_gender.SuspendLayout();
            this.Panel_Pass.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(19, 452);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(120, 39);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Panel_fdr_savings
            // 
            this.Panel_fdr_savings.BackColor = System.Drawing.Color.Transparent;
            this.Panel_fdr_savings.Controls.Add(this.rbLoan);
            this.Panel_fdr_savings.Controls.Add(this.RbFDR);
            this.Panel_fdr_savings.Controls.Add(this.RbSavings);
            this.Panel_fdr_savings.Location = new System.Drawing.Point(164, 63);
            this.Panel_fdr_savings.Name = "Panel_fdr_savings";
            this.Panel_fdr_savings.Size = new System.Drawing.Size(219, 43);
            this.Panel_fdr_savings.TabIndex = 5;
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
            // Dob
            // 
            this.Dob.CustomFormat = "yyyy-MM-dd";
            this.Dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dob.Location = new System.Drawing.Point(164, 191);
            this.Dob.Name = "Dob";
            this.Dob.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Dob.Size = new System.Drawing.Size(200, 24);
            this.Dob.TabIndex = 6;
            // 
            // Phone
            // 
            this.Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.Location = new System.Drawing.Point(164, 277);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(207, 24);
            this.Phone.TabIndex = 7;
            // 
            // Nid
            // 
            this.Nid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nid.Location = new System.Drawing.Point(164, 359);
            this.Nid.Name = "Nid";
            this.Nid.Size = new System.Drawing.Size(207, 24);
            this.Nid.TabIndex = 9;
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(164, 317);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(207, 24);
            this.Email.TabIndex = 8;
            // 
            // Address
            // 
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(164, 399);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(207, 24);
            this.Address.TabIndex = 10;
            // 
            // LastName
            // 
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.Location = new System.Drawing.Point(164, 151);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(207, 24);
            this.LastName.TabIndex = 5;
            // 
            // FirstName
            // 
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.Location = new System.Drawing.Point(164, 112);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(207, 24);
            this.FirstName.TabIndex = 4;
            // 
            // AccAddress
            // 
            this.AccAddress.AutoSize = true;
            this.AccAddress.BackColor = System.Drawing.Color.Snow;
            this.AccAddress.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccAddress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AccAddress.Location = new System.Drawing.Point(13, 400);
            this.AccAddress.Name = "AccAddress";
            this.AccAddress.Size = new System.Drawing.Size(77, 22);
            this.AccAddress.TabIndex = 26;
            this.AccAddress.Text = "Address";
            // 
            // AccNid
            // 
            this.AccNid.AutoSize = true;
            this.AccNid.BackColor = System.Drawing.Color.Snow;
            this.AccNid.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccNid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AccNid.Location = new System.Drawing.Point(13, 359);
            this.AccNid.Name = "AccNid";
            this.AccNid.Size = new System.Drawing.Size(46, 22);
            this.AccNid.TabIndex = 25;
            this.AccNid.Text = "NID ";
            // 
            // AccEmail
            // 
            this.AccEmail.AutoSize = true;
            this.AccEmail.BackColor = System.Drawing.Color.Snow;
            this.AccEmail.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AccEmail.Location = new System.Drawing.Point(13, 319);
            this.AccEmail.Name = "AccEmail";
            this.AccEmail.Size = new System.Drawing.Size(62, 22);
            this.AccEmail.TabIndex = 24;
            this.AccEmail.Text = "E-mail";
            // 
            // AccPhone
            // 
            this.AccPhone.AutoSize = true;
            this.AccPhone.BackColor = System.Drawing.Color.Snow;
            this.AccPhone.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccPhone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AccPhone.Location = new System.Drawing.Point(13, 279);
            this.AccPhone.Name = "AccPhone";
            this.AccPhone.Size = new System.Drawing.Size(64, 22);
            this.AccPhone.TabIndex = 23;
            this.AccPhone.Text = "Phone";
            // 
            // AccDob
            // 
            this.AccDob.AutoSize = true;
            this.AccDob.BackColor = System.Drawing.Color.Snow;
            this.AccDob.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccDob.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AccDob.Location = new System.Drawing.Point(13, 191);
            this.AccDob.Name = "AccDob";
            this.AccDob.Size = new System.Drawing.Size(116, 22);
            this.AccDob.TabIndex = 22;
            this.AccDob.Text = "Date of Birth";
            // 
            // AccLastName
            // 
            this.AccLastName.AutoSize = true;
            this.AccLastName.BackColor = System.Drawing.Color.Snow;
            this.AccLastName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccLastName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AccLastName.Location = new System.Drawing.Point(13, 151);
            this.AccLastName.Name = "AccLastName";
            this.AccLastName.Size = new System.Drawing.Size(98, 22);
            this.AccLastName.TabIndex = 21;
            this.AccLastName.Text = "Last Name";
            // 
            // AccFirstName
            // 
            this.AccFirstName.AutoSize = true;
            this.AccFirstName.BackColor = System.Drawing.Color.Snow;
            this.AccFirstName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccFirstName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AccFirstName.Location = new System.Drawing.Point(13, 111);
            this.AccFirstName.Name = "AccFirstName";
            this.AccFirstName.Size = new System.Drawing.Size(100, 22);
            this.AccFirstName.TabIndex = 20;
            this.AccFirstName.Text = "First Name";
            // 
            // AccType
            // 
            this.AccType.AutoSize = true;
            this.AccType.BackColor = System.Drawing.Color.Snow;
            this.AccType.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AccType.Location = new System.Drawing.Point(13, 71);
            this.AccType.Name = "AccType";
            this.AccType.Size = new System.Drawing.Size(124, 22);
            this.AccType.TabIndex = 19;
            this.AccType.Text = "Account Type";
            // 
            // AccInfo
            // 
            this.AccInfo.AutoSize = true;
            this.AccInfo.BackColor = System.Drawing.Color.White;
            this.AccInfo.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccInfo.Location = new System.Drawing.Point(95, 15);
            this.AccInfo.Name = "AccInfo";
            this.AccInfo.Size = new System.Drawing.Size(184, 41);
            this.AccInfo.TabIndex = 18;
            this.AccInfo.Text = "Information";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(157, 452);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 39);
            this.btnBack.TabIndex = 36;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Panel_info
            // 
            this.Panel_info.BackColor = System.Drawing.Color.Transparent;
            this.Panel_info.Controls.Add(this.btnClear);
            this.Panel_info.Controls.Add(this.Panel_gender);
            this.Panel_info.Controls.Add(this.AccGender);
            this.Panel_info.Controls.Add(this.Panel_fdr_savings);
            this.Panel_info.Controls.Add(this.btnBack);
            this.Panel_info.Controls.Add(this.AccInfo);
            this.Panel_info.Controls.Add(this.btnNext);
            this.Panel_info.Controls.Add(this.AccType);
            this.Panel_info.Controls.Add(this.AccFirstName);
            this.Panel_info.Controls.Add(this.Dob);
            this.Panel_info.Controls.Add(this.AccLastName);
            this.Panel_info.Controls.Add(this.Phone);
            this.Panel_info.Controls.Add(this.AccDob);
            this.Panel_info.Controls.Add(this.Nid);
            this.Panel_info.Controls.Add(this.AccPhone);
            this.Panel_info.Controls.Add(this.Email);
            this.Panel_info.Controls.Add(this.AccEmail);
            this.Panel_info.Controls.Add(this.Address);
            this.Panel_info.Controls.Add(this.AccNid);
            this.Panel_info.Controls.Add(this.LastName);
            this.Panel_info.Controls.Add(this.AccAddress);
            this.Panel_info.Controls.Add(this.FirstName);
            this.Panel_info.Location = new System.Drawing.Point(6, 0);
            this.Panel_info.Name = "Panel_info";
            this.Panel_info.Size = new System.Drawing.Size(421, 520);
            this.Panel_info.TabIndex = 37;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(294, 452);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 39);
            this.btnClear.TabIndex = 38;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Panel_gender
            // 
            this.Panel_gender.BackColor = System.Drawing.SystemColors.Window;
            this.Panel_gender.Controls.Add(this.RbFemale);
            this.Panel_gender.Controls.Add(this.rbMale);
            this.Panel_gender.Location = new System.Drawing.Point(164, 228);
            this.Panel_gender.Name = "Panel_gender";
            this.Panel_gender.Size = new System.Drawing.Size(207, 43);
            this.Panel_gender.TabIndex = 35;
            // 
            // RbFemale
            // 
            this.RbFemale.AutoSize = true;
            this.RbFemale.Location = new System.Drawing.Point(130, 10);
            this.RbFemale.Name = "RbFemale";
            this.RbFemale.Size = new System.Drawing.Size(74, 20);
            this.RbFemale.TabIndex = 1;
            this.RbFemale.TabStop = true;
            this.RbFemale.Text = "Female";
            this.RbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(3, 10);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(58, 20);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // AccGender
            // 
            this.AccGender.AutoSize = true;
            this.AccGender.BackColor = System.Drawing.Color.Snow;
            this.AccGender.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccGender.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AccGender.Location = new System.Drawing.Point(13, 237);
            this.AccGender.Name = "AccGender";
            this.AccGender.Size = new System.Drawing.Size(72, 22);
            this.AccGender.TabIndex = 37;
            this.AccGender.Text = "Gender";
            // 
            // AccNum
            // 
            this.AccNum.AutoSize = true;
            this.AccNum.BackColor = System.Drawing.Color.White;
            this.AccNum.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccNum.Location = new System.Drawing.Point(12, 52);
            this.AccNum.Name = "AccNum";
            this.AccNum.Size = new System.Drawing.Size(165, 22);
            this.AccNum.TabIndex = 37;
            this.AccNum.Text = "Account Number : ";
            // 
            // AccountNumber
            // 
            this.AccountNumber.AutoSize = true;
            this.AccountNumber.BackColor = System.Drawing.Color.White;
            this.AccountNumber.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountNumber.Location = new System.Drawing.Point(197, 52);
            this.AccountNumber.Name = "AccountNumber";
            this.AccountNumber.Size = new System.Drawing.Size(150, 22);
            this.AccountNumber.TabIndex = 38;
            this.AccountNumber.Text = "16749849874657";
            // 
            // Deposite_Amount
            // 
            this.Deposite_Amount.AutoSize = true;
            this.Deposite_Amount.BackColor = System.Drawing.Color.White;
            this.Deposite_Amount.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deposite_Amount.Location = new System.Drawing.Point(12, 100);
            this.Deposite_Amount.Name = "Deposite_Amount";
            this.Deposite_Amount.Size = new System.Drawing.Size(165, 22);
            this.Deposite_Amount.TabIndex = 39;
            this.Deposite_Amount.Text = "Deposite Amount :";
            // 
            // DepositeAmount
            // 
            this.DepositeAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepositeAmount.Location = new System.Drawing.Point(201, 100);
            this.DepositeAmount.Name = "DepositeAmount";
            this.DepositeAmount.Size = new System.Drawing.Size(207, 24);
            this.DepositeAmount.TabIndex = 37;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(93, 152);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(93, 32);
            this.btnConfirm.TabIndex = 39;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // PassBack
            // 
            this.PassBack.Location = new System.Drawing.Point(231, 152);
            this.PassBack.Name = "PassBack";
            this.PassBack.Size = new System.Drawing.Size(93, 32);
            this.PassBack.TabIndex = 42;
            this.PassBack.Text = "Back";
            this.PassBack.UseVisualStyleBackColor = true;
            this.PassBack.Click += new System.EventHandler(this.PassBack_Click);
            // 
            // Panel_Pass
            // 
            this.Panel_Pass.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Pass.Controls.Add(this.PassBack);
            this.Panel_Pass.Controls.Add(this.btnConfirm);
            this.Panel_Pass.Controls.Add(this.DepositeAmount);
            this.Panel_Pass.Controls.Add(this.Deposite_Amount);
            this.Panel_Pass.Controls.Add(this.AccountNumber);
            this.Panel_Pass.Controls.Add(this.AccNum);
            this.Panel_Pass.Location = new System.Drawing.Point(-5, 151);
            this.Panel_Pass.Name = "Panel_Pass";
            this.Panel_Pass.Size = new System.Drawing.Size(432, 242);
            this.Panel_Pass.TabIndex = 38;
            this.Panel_Pass.Visible = false;
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BankManagementSystem.Properties.Resources.CreateAccount;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(836, 532);
            this.Controls.Add(this.Panel_info);
            this.Controls.Add(this.Panel_Pass);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Account";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateAccount_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CreateAccount_KeyDown);
            this.Panel_fdr_savings.ResumeLayout(false);
            this.Panel_fdr_savings.PerformLayout();
            this.Panel_info.ResumeLayout(false);
            this.Panel_info.PerformLayout();
            this.Panel_gender.ResumeLayout(false);
            this.Panel_gender.PerformLayout();
            this.Panel_Pass.ResumeLayout(false);
            this.Panel_Pass.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel Panel_fdr_savings;
        private System.Windows.Forms.RadioButton RbFDR;
        private System.Windows.Forms.RadioButton RbSavings;
        private System.Windows.Forms.DateTimePicker Dob;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.TextBox Nid;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.Label AccAddress;
        private System.Windows.Forms.Label AccNid;
        private System.Windows.Forms.Label AccEmail;
        private System.Windows.Forms.Label AccPhone;
        private System.Windows.Forms.Label AccDob;
        private System.Windows.Forms.Label AccLastName;
        private System.Windows.Forms.Label AccFirstName;
        private System.Windows.Forms.Label AccType;
        private System.Windows.Forms.Label AccInfo;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel Panel_info;
        private System.Windows.Forms.Panel Panel_gender;
        private System.Windows.Forms.RadioButton RbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label AccGender;
        private System.Windows.Forms.Label AccNum;
        private System.Windows.Forms.Label AccountNumber;
        private System.Windows.Forms.Label Deposite_Amount;
        private System.Windows.Forms.TextBox DepositeAmount;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button PassBack;
        private System.Windows.Forms.Panel Panel_Pass;
        private System.Windows.Forms.RadioButton rbLoan;
        private System.Windows.Forms.Button btnClear;
    }
}