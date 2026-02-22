namespace BankManagementSystem.Code.GUI
{
    partial class BankBolt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankBolt));
            this.PanelBody = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.Amount = new System.Windows.Forms.Label();
            this.lbTotalBalance = new System.Windows.Forms.Label();
            this.btnAddMoney = new System.Windows.Forms.Button();
            this.lbRemarks = new System.Windows.Forms.Label();
            this.tbRemarks = new System.Windows.Forms.TextBox();
            this.lbAmount = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.dgvTransHistory = new System.Windows.Forms.DataGridView();
            this.PanelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelBody
            // 
            this.PanelBody.BackColor = System.Drawing.Color.Transparent;
            this.PanelBody.Controls.Add(this.btnRemove);
            this.PanelBody.Controls.Add(this.Amount);
            this.PanelBody.Controls.Add(this.lbTotalBalance);
            this.PanelBody.Controls.Add(this.btnAddMoney);
            this.PanelBody.Controls.Add(this.lbRemarks);
            this.PanelBody.Controls.Add(this.tbRemarks);
            this.PanelBody.Controls.Add(this.lbAmount);
            this.PanelBody.Controls.Add(this.tbAmount);
            this.PanelBody.Controls.Add(this.lbSearch);
            this.PanelBody.Controls.Add(this.tbSearch);
            this.PanelBody.Controls.Add(this.dgvTransHistory);
            this.PanelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBody.Location = new System.Drawing.Point(0, 0);
            this.PanelBody.Name = "PanelBody";
            this.PanelBody.Size = new System.Drawing.Size(1052, 582);
            this.PanelBody.TabIndex = 0;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.SeaGreen;
            this.btnRemove.ForeColor = System.Drawing.SystemColors.Info;
            this.btnRemove.Location = new System.Drawing.Point(913, 152);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(94, 33);
            this.btnRemove.TabIndex = 56;
            this.btnRemove.TabStop = false;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.BackColor = System.Drawing.Color.Transparent;
            this.Amount.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.ForeColor = System.Drawing.Color.Black;
            this.Amount.Location = new System.Drawing.Point(394, 105);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(174, 22);
            this.Amount.TabIndex = 55;
            this.Amount.Text = "100000000000 Taka";
            // 
            // lbTotalBalance
            // 
            this.lbTotalBalance.AutoSize = true;
            this.lbTotalBalance.BackColor = System.Drawing.Color.Transparent;
            this.lbTotalBalance.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalBalance.ForeColor = System.Drawing.Color.Black;
            this.lbTotalBalance.Location = new System.Drawing.Point(286, 105);
            this.lbTotalBalance.Name = "lbTotalBalance";
            this.lbTotalBalance.Size = new System.Drawing.Size(92, 22);
            this.lbTotalBalance.TabIndex = 54;
            this.lbTotalBalance.Text = "Balance   :";
            // 
            // btnAddMoney
            // 
            this.btnAddMoney.BackColor = System.Drawing.Color.Red;
            this.btnAddMoney.ForeColor = System.Drawing.SystemColors.Info;
            this.btnAddMoney.Location = new System.Drawing.Point(813, 152);
            this.btnAddMoney.Name = "btnAddMoney";
            this.btnAddMoney.Size = new System.Drawing.Size(94, 33);
            this.btnAddMoney.TabIndex = 53;
            this.btnAddMoney.TabStop = false;
            this.btnAddMoney.Text = "Add";
            this.btnAddMoney.UseVisualStyleBackColor = false;
            this.btnAddMoney.Click += new System.EventHandler(this.btnAddMoney_Click);
            // 
            // lbRemarks
            // 
            this.lbRemarks.AutoSize = true;
            this.lbRemarks.BackColor = System.Drawing.Color.Transparent;
            this.lbRemarks.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRemarks.ForeColor = System.Drawing.Color.Black;
            this.lbRemarks.Location = new System.Drawing.Point(409, 157);
            this.lbRemarks.Name = "lbRemarks";
            this.lbRemarks.Size = new System.Drawing.Size(82, 22);
            this.lbRemarks.TabIndex = 52;
            this.lbRemarks.Text = "Remarks";
            this.lbRemarks.Click += new System.EventHandler(this.lbRemarks_Click);
            // 
            // tbRemarks
            // 
            this.tbRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRemarks.Location = new System.Drawing.Point(503, 155);
            this.tbRemarks.Name = "tbRemarks";
            this.tbRemarks.Size = new System.Drawing.Size(262, 24);
            this.tbRemarks.TabIndex = 51;
            this.tbRemarks.TextChanged += new System.EventHandler(this.tbRemarks_TextChanged);
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.BackColor = System.Drawing.Color.Transparent;
            this.lbAmount.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmount.ForeColor = System.Drawing.Color.Black;
            this.lbAmount.Location = new System.Drawing.Point(35, 157);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(78, 22);
            this.lbAmount.TabIndex = 50;
            this.lbAmount.Text = "Amount";
            this.lbAmount.Click += new System.EventHandler(this.lbAmount_Click);
            // 
            // tbAmount
            // 
            this.tbAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAmount.Location = new System.Drawing.Point(129, 155);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(258, 24);
            this.tbAmount.TabIndex = 49;
            this.tbAmount.TextChanged += new System.EventHandler(this.tbAmount_TextChanged);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.BackColor = System.Drawing.Color.Transparent;
            this.lbSearch.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearch.ForeColor = System.Drawing.Color.Black;
            this.lbSearch.Location = new System.Drawing.Point(510, 32);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(67, 22);
            this.lbSearch.TabIndex = 48;
            this.lbSearch.Text = "Search";
            this.lbSearch.Click += new System.EventHandler(this.lbSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(604, 30);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(374, 24);
            this.tbSearch.TabIndex = 47;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // dgvTransHistory
            // 
            this.dgvTransHistory.AllowUserToAddRows = false;
            this.dgvTransHistory.AllowUserToDeleteRows = false;
            this.dgvTransHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransHistory.Location = new System.Drawing.Point(32, 197);
            this.dgvTransHistory.Name = "dgvTransHistory";
            this.dgvTransHistory.ReadOnly = true;
            this.dgvTransHistory.RowHeadersWidth = 51;
            this.dgvTransHistory.RowTemplate.Height = 24;
            this.dgvTransHistory.Size = new System.Drawing.Size(984, 354);
            this.dgvTransHistory.TabIndex = 46;
            // 
            // BankBolt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1052, 582);
            this.Controls.Add(this.PanelBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BankBolt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BankBolt";
            this.Load += new System.EventHandler(this.BankBolt_Load);
            this.PanelBody.ResumeLayout(false);
            this.PanelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelBody;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.DataGridView dgvTransHistory;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label lbRemarks;
        private System.Windows.Forms.TextBox tbRemarks;
        private System.Windows.Forms.Button btnAddMoney;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.Label lbTotalBalance;
        private System.Windows.Forms.Button btnRemove;
    }
}