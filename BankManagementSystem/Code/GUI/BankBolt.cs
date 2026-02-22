using BankManagementSystem.Code.DataBaseExecution;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BankManagementSystem.Code.GUI
{
    public partial class BankBolt : Form
    {
        private DataAccess da;
        private string id;
        private static string bankId = "5302821";


        public string BankId
        {
            get { return bankId; }
            set { bankId = value; }
        }
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
        public BankBolt()
        {
            InitializeComponent();
            this.Da=new DataAccess();
        }

        public BankBolt(string id)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.Id = id;
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

        public void convertInfo()
        {
            try
            {
                string query = "Select * from BankDetails where BankId='" + BankId + "'";
                DataTable dt = new DataTable(); 
                dt = Da.ExecuteQueryTable(query);
                Amount.Text = dt.Rows[0]["Balance"].ToString() +" TAKA";
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);            }

        }

        private void BankBolt_Load(object sender, EventArgs e)
        {
            showGridView();
            convertInfo();
        }

        public string generateTransId()
        {
            long currentID = 50004649800001;
            try
            {
                string query = "Select max(TransId) from Transactions;";
                DataTable tb = new DataTable();
                tb = Da.ExecuteQueryTable(query);
                if (tb.Rows.Count > 0 && tb.Rows[0][0] != DBNull.Value)
                {
                    currentID = Convert.ToInt64(tb.Rows[0][0].ToString()) + 1;
                }
                Da.Sqlcon.Close();
                return Convert.ToString(currentID);

            }
            catch (Exception E)
            {
                return Convert.ToString(currentID);
            }
        }
        private void btnAddMoney_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbAmount.Text) || string.IsNullOrEmpty(tbRemarks.Text))
            {
                MessageBox.Show("Enter the fields please!");
                return;
            }
            try
            {
                string query = "Select * from BankDetails where BankId='" + BankId + "'";
                DataTable dt = new DataTable();
                dt = Da.ExecuteQueryTable(query);
                double newBalance=Convert.ToDouble(tbAmount.Text)+ Convert.ToDouble(dt.Rows[0]["Balance"].ToString());
                query = "Update BankDetails set Balance=" + newBalance + " where BankId='" + BankId + "'";
                Da.ExecuteQuery(query);
                string transId = generateTransId();
                dt = Da.ExecuteQueryTable("Select FirstName,LastName from Employee where EmployeeId='" + Id + "'");
                string empname = dt.Rows[0]["FirstName"].ToString() + " " + dt.Rows[0]["LastName"].ToString();
                query = "INSERT INTO Transactions (TransId, AcNumber, UserName, Amount, Operation, EmployeeId, EmployeeName, TransDate,Remarks) " +
            "VALUES ('" + transId + "', '" + BankId + "','AIUB BANK ACCOUNT', " + Convert.ToDouble(tbAmount.Text) + ", 'ADDING MONEY', '" + Id + "',' " + empname + "', GETDATE(),'"+tbRemarks.Text+"')";
                Da.ExecuteQuery(query);
                MessageBox.Show("Money Added to the Bolt!", "Success");
                convertInfo();
                showGridView();
                tbRemarks.Text = string.Empty;
                tbAmount.Text = string.Empty;
                dgvTransHistory.ClearSelection();
                dgvTransHistory.CurrentCell = null;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbAmount.Text) || string.IsNullOrEmpty(tbRemarks.Text))
            {
                MessageBox.Show("Enter the fields please!");
                return;
            }
            try
            {
                string query = "Select * from BankDetails where BankId='" + BankId + "'";
                DataTable dt = new DataTable();
                dt = Da.ExecuteQueryTable(query);
                double newBalance = Convert.ToDouble(dt.Rows[0]["Balance"].ToString()) - Convert.ToDouble(tbAmount.Text) ;
                if (newBalance <= 100)
                {
                    MessageBox.Show("Mimimum Balance 100");
                    return;
                }
                query = "Update BankDetails set Balance=" + newBalance + " where BankId='" + BankId + "'";
                Da.ExecuteQuery(query);
                string transId = generateTransId();
                dt = Da.ExecuteQueryTable("Select FirstName,LastName from Employee where EmployeeId='" + Id + "'");
                string empname = dt.Rows[0]["FirstName"].ToString() + " " + dt.Rows[0]["LastName"].ToString();
                query = "INSERT INTO Transactions (TransId, AcNumber, UserName, Amount, Operation, EmployeeId, EmployeeName, TransDate,Remarks) " +
            "VALUES ('" + transId + "', '" + BankId + "','AIUB BANK ACCOUNT', " + Convert.ToDouble(tbAmount.Text) + ", 'REMOVED MONEY', '" + Id + "',' " + empname + "', GETDATE(),'" + tbRemarks.Text + "')";
                Da.ExecuteQuery(query);
                MessageBox.Show("Money Removed From Bolt", "Success");
                convertInfo();
                tbRemarks.Text = string.Empty;
                tbAmount.Text=string.Empty;
                showGridView();
                dgvTransHistory.ClearSelection();
                dgvTransHistory.CurrentCell = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbRemarks_Click(object sender, EventArgs e)
        {

        }

        private void tbRemarks_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbAmount_Click(object sender, EventArgs e)
        {

        }

        private void lbSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
