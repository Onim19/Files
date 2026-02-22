namespace BankManagementSystem.Code.GUI
{
    partial class HomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCreateAcc = new System.Windows.Forms.Button();
            this.panel_createAccount = new System.Windows.Forms.Panel();
            this.tbConfirmPass = new System.Windows.Forms.TextBox();
            this.lbConfirmPass = new System.Windows.Forms.Label();
            this.tbNewPass = new System.Windows.Forms.TextBox();
            this.lbPass = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.tbEmpID = new System.Windows.Forms.TextBox();
            this.lbEmpId = new System.Windows.Forms.Label();
            this.panel_createAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Silver;
            this.btnLogin.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(540, 320);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(208, 41);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.TabStop = false;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCreateAcc
            // 
            this.btnCreateAcc.BackColor = System.Drawing.Color.Silver;
            this.btnCreateAcc.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAcc.Location = new System.Drawing.Point(540, 387);
            this.btnCreateAcc.Name = "btnCreateAcc";
            this.btnCreateAcc.Size = new System.Drawing.Size(208, 41);
            this.btnCreateAcc.TabIndex = 2;
            this.btnCreateAcc.TabStop = false;
            this.btnCreateAcc.Text = "Create Account";
            this.btnCreateAcc.UseVisualStyleBackColor = false;
            this.btnCreateAcc.Click += new System.EventHandler(this.btnCreateAcc_Click);
            // 
            // panel_createAccount
            // 
            this.panel_createAccount.BackColor = System.Drawing.SystemColors.Menu;
            this.panel_createAccount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_createAccount.BackgroundImage")));
            this.panel_createAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_createAccount.Controls.Add(this.tbConfirmPass);
            this.panel_createAccount.Controls.Add(this.lbConfirmPass);
            this.panel_createAccount.Controls.Add(this.tbNewPass);
            this.panel_createAccount.Controls.Add(this.lbPass);
            this.panel_createAccount.Controls.Add(this.Next);
            this.panel_createAccount.Controls.Add(this.btnBack);
            this.panel_createAccount.Controls.Add(this.tbEmpID);
            this.panel_createAccount.Controls.Add(this.lbEmpId);
            this.panel_createAccount.Location = new System.Drawing.Point(161, 166);
            this.panel_createAccount.Name = "panel_createAccount";
            this.panel_createAccount.Size = new System.Drawing.Size(497, 262);
            this.panel_createAccount.TabIndex = 3;
            this.panel_createAccount.Visible = false;
            // 
            // tbConfirmPass
            // 
            this.tbConfirmPass.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConfirmPass.Location = new System.Drawing.Point(270, 163);
            this.tbConfirmPass.Name = "tbConfirmPass";
            this.tbConfirmPass.Size = new System.Drawing.Size(204, 32);
            this.tbConfirmPass.TabIndex = 7;
            this.tbConfirmPass.UseSystemPasswordChar = true;
            // 
            // lbConfirmPass
            // 
            this.lbConfirmPass.AutoSize = true;
            this.lbConfirmPass.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfirmPass.Location = new System.Drawing.Point(20, 166);
            this.lbConfirmPass.Name = "lbConfirmPass";
            this.lbConfirmPass.Size = new System.Drawing.Size(210, 23);
            this.lbConfirmPass.TabIndex = 6;
            this.lbConfirmPass.Text = "Confirm Password :";
            // 
            // tbNewPass
            // 
            this.tbNewPass.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewPass.Location = new System.Drawing.Point(270, 116);
            this.tbNewPass.Name = "tbNewPass";
            this.tbNewPass.Size = new System.Drawing.Size(204, 32);
            this.tbNewPass.TabIndex = 5;
            this.tbNewPass.UseSystemPasswordChar = true;
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.Location = new System.Drawing.Point(20, 118);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(214, 23);
            this.lbPass.TabIndex = 4;
            this.lbPass.Text = "New Password       :";
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(245, 221);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 3;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(345, 221);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tbEmpID
            // 
            this.tbEmpID.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmpID.Location = new System.Drawing.Point(270, 71);
            this.tbEmpID.Name = "tbEmpID";
            this.tbEmpID.Size = new System.Drawing.Size(204, 32);
            this.tbEmpID.TabIndex = 1;
            // 
            // lbEmpId
            // 
            this.lbEmpId.AutoSize = true;
            this.lbEmpId.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpId.Location = new System.Drawing.Point(21, 74);
            this.lbEmpId.Name = "lbEmpId";
            this.lbEmpId.Size = new System.Drawing.Size(211, 23);
            this.lbEmpId.TabIndex = 0;
            this.lbEmpId.Text = "Employee ID         :";
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(836, 532);
            this.Controls.Add(this.panel_createAccount);
            this.Controls.Add(this.btnCreateAcc);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AIUB Bank";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomeScreen_FormClosed);
            this.panel_createAccount.ResumeLayout(false);
            this.panel_createAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCreateAcc;
        private System.Windows.Forms.Panel panel_createAccount;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox tbEmpID;
        private System.Windows.Forms.Label lbEmpId;
        private System.Windows.Forms.TextBox tbConfirmPass;
        private System.Windows.Forms.Label lbConfirmPass;
        private System.Windows.Forms.TextBox tbNewPass;
        private System.Windows.Forms.Label lbPass;
    }
}