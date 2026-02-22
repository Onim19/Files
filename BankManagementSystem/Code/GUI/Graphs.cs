using BankManagementSystem.Code.DataBaseExecution;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BankManagementSystem.Code.GUI
{
    public partial class Graphs : Form
    {
        private DataAccess da;

        public DataAccess Da
        {
            get { return this.da; }
            set { this.da = value; }
        }

        public Graphs()
        {
            InitializeComponent();
            this.Da=new DataAccess();
        }

        public void LoadGraph()
        {
            try
            {
                cDeposite.Series.Clear();
                cDeposite.ChartAreas.Clear();
                cDeposite.Titles.Clear();

                ChartArea depositChartArea = new ChartArea();
                cDeposite.ChartAreas.Add(depositChartArea);

                string depositQuery = @"
            SELECT CAST(TransDate AS DATE) AS TransDate,
                   SUM(Amount) AS Amount
            FROM Transactions
            WHERE Operation = 'DEPOSITE'
            GROUP BY CAST(TransDate AS DATE)
            ORDER BY CAST(TransDate AS DATE)";

                DataTable depositDt = Da.ExecuteQueryTable(depositQuery);

                Series depositSeries = new Series("Deposits")
                {
                    ChartType = SeriesChartType.Line,
                    XValueType = ChartValueType.DateTime
                };

                foreach (DataRow row in depositDt.Rows)
                {
                    DateTime date = Convert.ToDateTime(row["TransDate"]);
                    decimal amount = Convert.ToDecimal(row["Amount"]);
                    depositSeries.Points.AddXY(date, amount);
                }

                cDeposite.Series.Add(depositSeries);

                depositChartArea.AxisX.Title = "Date";
                depositChartArea.AxisX.LabelStyle.Format = "dd-MMM";
                depositChartArea.AxisX.LabelStyle.Angle = -45;
                depositChartArea.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
                depositChartArea.AxisX.IntervalType = DateTimeIntervalType.Days;
                depositChartArea.AxisX.Interval = 1;

                depositChartArea.AxisY.Title = "Deposit Amount";
                depositChartArea.AxisY.Minimum = 0;


                cDeposite.Titles.Add("Daily Deposits Over Time");

                cWithdraw.Series.Clear();
                cWithdraw.ChartAreas.Clear();
                cWithdraw.Titles.Clear();

                ChartArea withdrawChartArea = new ChartArea();
                cWithdraw.ChartAreas.Add(withdrawChartArea);

                string withdrawQuery = @"
            SELECT CAST(TransDate AS DATE) AS TransDate,
                   SUM(Amount) AS Amount
            FROM Transactions
            WHERE Operation = 'WITHDRAW'
            GROUP BY CAST(TransDate AS DATE)
            ORDER BY CAST(TransDate AS DATE)";

                DataTable withdrawDt = Da.ExecuteQueryTable(withdrawQuery);

                Series withdrawSeries = new Series("Withdrawals")
                {
                    ChartType = SeriesChartType.Line,
                    XValueType = ChartValueType.DateTime
                };

                foreach (DataRow row in withdrawDt.Rows)
                {
                    DateTime date = Convert.ToDateTime(row["TransDate"]);
                    decimal amount = Convert.ToDecimal(row["Amount"]);
                    withdrawSeries.Points.AddXY(date, amount);
                }

                cWithdraw.Series.Add(withdrawSeries);

                withdrawChartArea.AxisX.Title = "Date";
                withdrawChartArea.AxisX.LabelStyle.Format = "dd-MMM";
                withdrawChartArea.AxisX.LabelStyle.Angle = -45;
                withdrawChartArea.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
                withdrawChartArea.AxisX.IntervalType = DateTimeIntervalType.Days;
                withdrawChartArea.AxisX.Interval = 1;

                withdrawChartArea.AxisY.Title = "Withdraw Amount";
                withdrawChartArea.AxisY.Minimum = 0;

                cWithdraw.Titles.Add("Daily Withdrawals Over Time");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load graph: " + ex.Message);
            }
        }


        private void Graphs_Load(object sender, EventArgs e)
        {
            LoadGraph();
        }
    }
}
