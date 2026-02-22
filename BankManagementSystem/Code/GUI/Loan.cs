using BankManagementSystem.Code.DataBaseExecution;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace BankManagementSystem.Code.GUI
{ 
    public partial class Loan : Form
    {
        private DataAccess da;
        private string acNumber;
        private static string bankId = "5302821";
        private string id;

        public string Id
        {
            get;set;
        }


        public string BankId
        {
            get { return bankId; }
            set { bankId = value; }
        }

        public DataAccess Da{
            get {  return da; }
            set { da = value; } 
        }

        public string AcNumber
        {
            get;
            set;
        }
        public Loan()
        {
            InitializeComponent();
            this.Da=new DataAccess();
        }

        public Loan(string id)
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
                string query = "Select * from Customer where AccType='Loan';";
                dt = Da.ExecuteQueryTable(query);
                dgvLoanList.DataSource = dt;
                dgvLoanList.ClearSelection();
                dgvLoanList.CurrentCell = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong!\n" + ex.Message);
            }
        }
        private void Loan_Load(object sender, EventArgs e)
        {
            showGridView();
            clearall();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string query = "Select * from customer where (AcNumber like '%"
                               + tbSearch.Text + "%' or Phone like '%"
                               + tbSearch.Text + "%' or FirstName like '%"
                               + tbSearch.Text + "%' or LastName like '%"
                               + tbSearch.Text + "%') and AccType='Loan'";
                DataTable dt = new DataTable();
                dt = Da.ExecuteQueryTable(query);
                dgvLoanList.DataSource = dt;
                dgvLoanList.ClearSelection();
                dgvLoanList.CurrentCell = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong!\n" + ex.Message);
            }
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
        private void dgvLoanList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvLoanList.Rows[e.RowIndex];
            tbAmount.Text= (Convert.ToDouble(row.Cells["Balance"].Value.ToString())*0.12).ToString();
            tbRemarks.Text = "Loan Interest applied";
            lbAccNum.Text = row.Cells["AcNumber"].Value.ToString();
            this.AcNumber=lbAccNum.Text;
        }
        public void clearall()
        {
            tbRemarks.Text=String.Empty;
            lbAccNum.Text=String.Empty;
            tbAmount.Text=String.Empty;
        }
        private void btnApplyInterest_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lbAccNum.Text))
            {
                MessageBox.Show("Please select a row first!");
                return;
            }
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();

            double amount =  Convert.ToDouble(tbAmount.Text);
            try
            {
                string q1 = "SELECT FirstName, LastName, Balance FROM Customer WHERE AcNumber='" + AcNumber + "'";
                string q2 = "SELECT FirstName, LastName FROM Employee WHERE EmployeeId='" + Id + "'";
                dt1 = Da.ExecuteQueryTable(q1);
                dt2 = Da.ExecuteQueryTable(q2);
                string query = "Select * from BankDetails where BankId='" + BankId + "'";
                DataTable dt = new DataTable();
                dt = Da.ExecuteQueryTable(query);
                double newBalance = Convert.ToDouble(dt.Rows[0]["Balance"].ToString()) + amount;
                Da.ExecuteQuery("Update BankDetails set Balance=" + newBalance + " where BankId='" + BankId + "'");
                string transId = generateTransId();
                string userName = dt1.Rows[0]["FirstName"].ToString() + " " + dt1.Rows[0]["LastName"].ToString();
                double balance = Convert.ToDouble(dt1.Rows[0]["Balance"]) - amount;
                string empname = dt2.Rows[0]["FirstName"].ToString() + " " + dt2.Rows[0]["LastName"].ToString();
                string q3 = "INSERT INTO Transactions (TransId, AcNumber, UserName, Amount, Operation, EmployeeId, EmployeeName, TransDate) " +
    "VALUES ('" + transId + "', '" + AcNumber + "', '" + userName + "', " + amount + ", 'DEPOSITE', '" + Id + "',' " + empname + "', GETDATE())";
                Da.ExecuteQuery(q3);
                Da.ExecuteQuery("Update Customer set balance=" + balance + " where AcNumber='" + AcNumber + "'");
                MessageBox.Show("Interest applied Successfully");
                showGridView();
                dgvLoanList.ClearSelection();
                dgvLoanList.CurrentCell = null;
                clearall();

            }
            catch (Exception ex)
            {
               MessageBox.Show("Something went wrong\n" + ex.Message);
            }
        }
    }
}
