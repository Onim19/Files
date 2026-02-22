namespace BankManagementSystem.Code.GUI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LabelUser = new System.Windows.Forms.Label();
            this.UserId = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.LabelPass = new System.Windows.Forms.Label();
            this.lbForgetPass = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelUser
            // 
            this.LabelUser.AutoSize = true;
            this.LabelUser.BackColor = System.Drawing.Color.Transparent;
            this.LabelUser.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUser.Location = new System.Drawing.Point(12, 245);
            this.LabelUser.Name = "LabelUser";
            this.LabelUser.Size = new System.Drawing.Size(87, 27);
            this.LabelUser.TabIndex = 0;
            this.LabelUser.Text = "User ID";
            // 
            // UserId
            // 
            this.UserId.BackColor = System.Drawing.SystemColors.Menu;
            this.UserId.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserId.Location = new System.Drawing.Point(140, 242);
            this.UserId.Name = "UserId";
            this.UserId.Size = new System.Drawing.Size(213, 33);
            this.UserId.TabIndex = 1;
            this.UserId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserId_KeyPress);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.SystemColors.Menu;
            this.Password.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(140, 298);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(213, 33);
            this.Password.TabIndex = 3;
            this.Password.UseSystemPasswordChar = true;
            // 
            // LabelPass
            // 
            this.LabelPass.AutoSize = true;
            this.LabelPass.BackColor = System.Drawing.Color.Transparent;
            this.LabelPass.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPass.Location = new System.Drawing.Point(12, 301);
            this.LabelPass.Name = "LabelPass";
            this.LabelPass.Size = new System.Drawing.Size(108, 27);
            this.LabelPass.TabIndex = 2;
            this.LabelPass.Text = "Password";
            // 
            // lbForgetPass
            // 
            this.lbForgetPass.AutoSize = true;
            this.lbForgetPass.BackColor = System.Drawing.Color.Transparent;
            this.lbForgetPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbForgetPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbForgetPass.ForeColor = System.Drawing.Color.DarkRed;
            this.lbForgetPass.Location = new System.Drawing.Point(174, 411);
            this.lbForgetPass.Name = "lbForgetPass";
            this.lbForgetPass.Size = new System.Drawing.Size(109, 16);
            this.lbForgetPass.TabIndex = 5;
            this.lbForgetPass.Text = "Forget Password";
            this.lbForgetPass.Click += new System.EventHandler(this.lbForgetPass_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBack.Location = new System.Drawing.Point(719, 490);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(83, 30);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogin.Location = new System.Drawing.Point(189, 367);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(83, 30);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BankManagementSystem.Properties.Resources.Login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(836, 532);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbForgetPass);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.LabelPass);
            this.Controls.Add(this.UserId);
            this.Controls.Add(this.LabelUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelUser;
        private System.Windows.Forms.TextBox UserId;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label LabelPass;
        private System.Windows.Forms.Label lbForgetPass;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLogin;
    }
}