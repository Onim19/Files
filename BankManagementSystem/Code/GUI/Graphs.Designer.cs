namespace BankManagementSystem.Code.GUI
{
    partial class Graphs
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Graphs));
            this.panel_Body = new System.Windows.Forms.Panel();
            this.cWithdraw = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cDeposite = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cWithdraw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDeposite)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Body
            // 
            this.panel_Body.AutoScroll = true;
            this.panel_Body.BackColor = System.Drawing.Color.White;
            this.panel_Body.Controls.Add(this.cWithdraw);
            this.panel_Body.Controls.Add(this.cDeposite);
            this.panel_Body.Location = new System.Drawing.Point(-2, 72);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(954, 509);
            this.panel_Body.TabIndex = 0;
            // 
            // cWithdraw
            // 
            chartArea1.Name = "ChartArea1";
            this.cWithdraw.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.cWithdraw.Legends.Add(legend1);
            this.cWithdraw.Location = new System.Drawing.Point(3, 372);
            this.cWithdraw.Name = "cWithdraw";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.cWithdraw.Series.Add(series1);
            this.cWithdraw.Size = new System.Drawing.Size(930, 308);
            this.cWithdraw.TabIndex = 1;
            this.cWithdraw.Text = "chart2";
            // 
            // cDeposite
            // 
            chartArea2.Name = "ChartArea1";
            this.cDeposite.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.cDeposite.Legends.Add(legend2);
            this.cDeposite.Location = new System.Drawing.Point(3, 36);
            this.cDeposite.Name = "cDeposite";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Deposite";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.cDeposite.Series.Add(series2);
            this.cDeposite.Size = new System.Drawing.Size(930, 300);
            this.cDeposite.TabIndex = 0;
            this.cDeposite.Text = "chart1";
            // 
            // Graphs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(951, 572);
            this.Controls.Add(this.panel_Body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Graphs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graphs";
            this.Load += new System.EventHandler(this.Graphs_Load);
            this.panel_Body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cWithdraw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDeposite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Body;
        private System.Windows.Forms.DataVisualization.Charting.Chart cWithdraw;
        private System.Windows.Forms.DataVisualization.Charting.Chart cDeposite;
    }
}