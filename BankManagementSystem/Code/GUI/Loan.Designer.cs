namespace BankManagementSystem.Code.GUI
{
    partial class Loan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loan));
            this.dgvLoanList = new System.Windows.Forms.DataGridView();
            this.btnApplyInterest = new System.Windows.Forms.Button();
            this.lbRemarks = new System.Windows.Forms.Label();
            this.tbRemarks = new System.Windows.Forms.TextBox();
            this.lbAmount = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lbAccNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLoanList
            // 
            this.dgvLoanList.AllowUserToAddRows = false;
            this.dgvLoanList.AllowUserToDeleteRows = false;
            this.dgvLoanList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoanList.Location = new System.Drawing.Point(26, 191);
            this.dgvLoanList.MultiSelect = false;
            this.dgvLoanList.Name = "dgvLoanList";
            this.dgvLoanList.ReadOnly = true;
            this.dgvLoanList.RowHeadersWidth = 51;
            this.dgvLoanList.RowTemplate.Height = 24;
            this.dgvLoanList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoanList.Size = new System.Drawing.Size(894, 314);
            this.dgvLoanList.TabIndex = 1;
            this.dgvLoanList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoanList_CellClick);
            // 
            // btnApplyInterest
            // 
            this.btnApplyInterest.BackColor = System.Drawing.Color.Red;
            this.btnApplyInterest.ForeColor = System.Drawing.SystemColors.Info;
            this.btnApplyInterest.Location = new System.Drawing.Point(725, 120);
            this.btnApplyInterest.Name = "btnApplyInterest";
            this.btnApplyInterest.Size = new System.Drawing.Size(195, 33);
            this.btnApplyInterest.TabIndex = 63;
            this.btnApplyInterest.TabStop = false;
            this.btnApplyInterest.Text = "Apply Interest";
            this.btnApplyInterest.UseVisualStyleBackColor = false;
            this.btnApplyInterest.Click += new System.EventHandler(this.btnApplyInterest_Click);
            // 
            // lbRemarks
            // 
            this.lbRemarks.AutoSize = true;
            this.lbRemarks.BackColor = System.Drawing.Color.Transparent;
            this.lbRemarks.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRemarks.ForeColor = System.Drawing.Color.Black;
            this.lbRemarks.Location = new System.Drawing.Point(321, 125);
            this.lbRemarks.Name = "lbRemarks";
            this.lbRemarks.Size = new System.Drawing.Size(82, 22);
            this.lbRemarks.TabIndex = 62;
            this.lbRemarks.Text = "Remarks";
            // 
            // tbRemarks
            // 
            this.tbRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRemarks.Location = new System.Drawing.Point(415, 123);
            this.tbRemarks.Name = "tbRemarks";
            this.tbRemarks.Size = new System.Drawing.Size(262, 24);
            this.tbRemarks.TabIndex = 61;
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.BackColor = System.Drawing.Color.Transparent;
            this.lbAmount.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmount.ForeColor = System.Drawing.Color.Black;
            this.lbAmount.Location = new System.Drawing.Point(26, 125);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(78, 22);
            this.lbAmount.TabIndex = 60;
            this.lbAmount.Text = "Amount";
            // 
            // tbAmount
            // 
            this.tbAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAmount.Location = new System.Drawing.Point(120, 123);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(195, 24);
            this.tbAmount.TabIndex = 59;
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.BackColor = System.Drawing.Color.Transparent;
            this.lbSearch.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearch.ForeColor = System.Drawing.Color.Black;
            this.lbSearch.Location = new System.Drawing.Point(452, 31);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(67, 22);
            this.lbSearch.TabIndex = 58;
            this.lbSearch.Text = "Search";
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(546, 29);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(374, 24);
            this.tbSearch.TabIndex = 57;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // lbAccNum
            // 
            this.lbAccNum.AutoSize = true;
            this.lbAccNum.BackColor = System.Drawing.Color.Snow;
            this.lbAccNum.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccNum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbAccNum.Location = new System.Drawing.Point(26, 84);
            this.lbAccNum.Name = "lbAccNum";
            this.lbAccNum.Size = new System.Drawing.Size(81, 22);
            this.lbAccNum.TabIndex = 65;
            this.lbAccNum.Text = "AccNum";
            this.lbAccNum.Visible = false;
            // 
            // Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(953, 538);
            this.Controls.Add(this.lbAccNum);
            this.Controls.Add(this.btnApplyInterest);
            this.Controls.Add(this.lbRemarks);
            this.Controls.Add(this.tbRemarks);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.dgvLoanList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Loan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan";
            this.Load += new System.EventHandler(this.Loan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLoanList;
        private System.Windows.Forms.Button btnApplyInterest;
        private System.Windows.Forms.Label lbRemarks;
        private System.Windows.Forms.TextBox tbRemarks;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lbAccNum;
    }
}