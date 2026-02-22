using BankManagementSystem.Code.DataBaseExecution;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagementSystem.Code.GUI
{
    public partial class Transactions : Form
    {
        private DataAccess da;
        private string id;

        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public DataAccess Da
        {
            get { return this.da; }
            set { this.da = value; }
        }
        
        public Transactions(string id)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.Id = id;
        }
        public void showGridView()
        {
            try
            {
                DataTable dt = new DataTable();
                string query = "Select * from transactions;";
                dt = Da.ExecuteQueryTable(query);
                dgvTransHistory.DataSource = dt;
                dgvTransHistory.ClearSelection();
                dgvTransHistory.CurrentCell = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong!\n" + ex.Message);
            }
        }

        private void Transactions_Load(object sender, EventArgs e)
        {
            showGridView();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string query = "Select * from Transactions where AcNumber like '%"
                               + tbSearch.Text + "%' or TransId like '%"
                               + tbSearch.Text + "%' or AcNumber like '%"
                               + tbSearch.Text + "%' or EmployeeId like '%"
                               + tbSearch.Text + "%' or EmployeeName like '%"
                               + tbSearch.Text + "%' or UserName like '%"
                               + tbSearch.Text + "%' or Operation like '%"
                               + tbSearch.Text + "%'";
                DataTable dt = new DataTable();
                dt = Da.ExecuteQueryTable(query);
                dgvTransHistory.DataSource = dt;
                dgvTransHistory.ClearSelection();
                dgvTransHistory.CurrentCell = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong!\n" + ex.Message);
            }
        }
    }
}
