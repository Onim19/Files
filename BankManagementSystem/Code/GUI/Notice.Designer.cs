namespace BankManagementSystem.Code.GUI
{
    partial class Notice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notice));
            this.lbTitle = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.lbMessege = new System.Windows.Forms.Label();
            this.tbMessege = new System.Windows.Forms.TextBox();
            this.btSend = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.PanelMakeAnouncement = new System.Windows.Forms.Panel();
            this.PanelNotice = new System.Windows.Forms.Panel();
            this.lbnoticetitle = new System.Windows.Forms.Label();
            this.tbNoticeTitle = new System.Windows.Forms.TextBox();
            this.tbNotice = new System.Windows.Forms.TextBox();
            this.PanelMakeAnouncement.SuspendLayout();
            this.PanelNotice.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(5, 64);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(96, 20);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Title          :";
            // 
            // tbTitle
            // 
            this.tbTitle.AcceptsReturn = true;
            this.tbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitle.Location = new System.Drawing.Point(134, 64);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(377, 24);
            this.tbTitle.TabIndex = 1;
            // 
            // lbMessege
            // 
            this.lbMessege.AutoSize = true;
            this.lbMessege.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessege.Location = new System.Drawing.Point(5, 111);
            this.lbMessege.Name = "lbMessege";
            this.lbMessege.Size = new System.Drawing.Size(97, 20);
            this.lbMessege.TabIndex = 2;
            this.lbMessege.Text = "Messege   :";
            // 
            // tbMessege
            // 
            this.tbMessege.AcceptsReturn = true;
            this.tbMessege.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMessege.Location = new System.Drawing.Point(134, 111);
            this.tbMessege.Multiline = true;
            this.tbMessege.Name = "tbMessege";
            this.tbMessege.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMessege.Size = new System.Drawing.Size(377, 165);
            this.tbMessege.TabIndex = 3;
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(151, 299);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(75, 23);
            this.btSend.TabIndex = 4;
            this.btSend.Text = "Send";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(267, 299);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 5;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(375, 299);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(75, 23);
            this.btBack.TabIndex = 6;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // PanelMakeAnouncement
            // 
            this.PanelMakeAnouncement.Controls.Add(this.tbMessege);
            this.PanelMakeAnouncement.Controls.Add(this.btBack);
            this.PanelMakeAnouncement.Controls.Add(this.lbTitle);
            this.PanelMakeAnouncement.Controls.Add(this.btClear);
            this.PanelMakeAnouncement.Controls.Add(this.tbTitle);
            this.PanelMakeAnouncement.Controls.Add(this.btSend);
            this.PanelMakeAnouncement.Controls.Add(this.lbMessege);
            this.PanelMakeAnouncement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMakeAnouncement.Location = new System.Drawing.Point(0, 0);
            this.PanelMakeAnouncement.Name = "PanelMakeAnouncement";
            this.PanelMakeAnouncement.Size = new System.Drawing.Size(529, 356);
            this.PanelMakeAnouncement.TabIndex = 7;
            // 
            // PanelNotice
            // 
            this.PanelNotice.Controls.Add(this.lbnoticetitle);
            this.PanelNotice.Controls.Add(this.tbNoticeTitle);
            this.PanelNotice.Controls.Add(this.tbNotice);
            this.PanelNotice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelNotice.Location = new System.Drawing.Point(0, 0);
            this.PanelNotice.Name = "PanelNotice";
            this.PanelNotice.Size = new System.Drawing.Size(529, 356);
            this.PanelNotice.TabIndex = 0;
            this.PanelNotice.Visible = false;
            // 
            // lbnoticetitle
            // 
            this.lbnoticetitle.AutoSize = true;
            this.lbnoticetitle.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnoticetitle.Location = new System.Drawing.Point(37, 77);
            this.lbnoticetitle.Name = "lbnoticetitle";
            this.lbnoticetitle.Size = new System.Drawing.Size(87, 23);
            this.lbnoticetitle.TabIndex = 6;
            this.lbnoticetitle.Text = "Title :";
            // 
            // tbNoticeTitle
            // 
            this.tbNoticeTitle.AcceptsReturn = true;
            this.tbNoticeTitle.Enabled = false;
            this.tbNoticeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNoticeTitle.Location = new System.Drawing.Point(145, 69);
            this.tbNoticeTitle.Multiline = true;
            this.tbNoticeTitle.Name = "tbNoticeTitle";
            this.tbNoticeTitle.ReadOnly = true;
            this.tbNoticeTitle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbNoticeTitle.Size = new System.Drawing.Size(360, 31);
            this.tbNoticeTitle.TabIndex = 5;
            // 
            // tbNotice
            // 
            this.tbNotice.AcceptsReturn = true;
            this.tbNotice.Enabled = false;
            this.tbNotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNotice.Location = new System.Drawing.Point(41, 130);
            this.tbNotice.Multiline = true;
            this.tbNotice.Name = "tbNotice";
            this.tbNotice.ReadOnly = true;
            this.tbNotice.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbNotice.Size = new System.Drawing.Size(464, 179);
            this.tbNotice.TabIndex = 4;
            // 
            // Notice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(529, 356);
            this.Controls.Add(this.PanelMakeAnouncement);
            this.Controls.Add(this.PanelNotice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Notice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Make Anouncement";
            this.PanelMakeAnouncement.ResumeLayout(false);
            this.PanelMakeAnouncement.PerformLayout();
            this.PanelNotice.ResumeLayout(false);
            this.PanelNotice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label lbMessege;
        private System.Windows.Forms.TextBox tbMessege;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Panel PanelMakeAnouncement;
        private System.Windows.Forms.Panel PanelNotice;
        private System.Windows.Forms.TextBox tbNoticeTitle;
        private System.Windows.Forms.TextBox tbNotice;
        private System.Windows.Forms.Label lbnoticetitle;
    }
}