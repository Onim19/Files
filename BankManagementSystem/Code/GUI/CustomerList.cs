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

namespace BankManagementSystem.Code.GUI
{
    public partial class CustomerList : Form
    {
        private DataAccess da;

        private string adminID;

        public string AdminID
        {
            get { return adminID; }
            set { adminID = value; }
        }

        public DataAccess Da
        {
            get { return da; }
            set { da = value; }
        }
        public CustomerList()
        {
            InitializeComponent();
            this.da = new DataAccess();
        }
        public CustomerList(string adminID)
        {
            InitializeComponent();
            this.da = new DataAccess();
            this.AdminID = adminID;
        }
        public void showGridView()
        {
            try
            {
                DataTable dt=new DataTable();
                string query = "Select * from Customer;";
                dt=Da.ExecuteQueryTable(query);
                dgvCustomerList.DataSource = dt;
                dgvCustomerList.ClearSelection();
                dgvCustomerList.CurrentCell = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong!\n" + ex.Message);
            }
        }
        private void CustomerList_Load(object sender, EventArgs e)
        {
            showGridView();
            clearAll();
        }

        private void dgvCustomerList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvCustomerList.Rows[e.RowIndex];
            lbAccNum.Text = row.Cells["AcNumber"].Value.ToString();
            FirstName.Text = row.Cells["FirstName"].Value.ToString();
            LastName.Text = row.Cells["LastName"].Value.ToString();
            Dob.Text = row.Cells["Dob"].Value.ToString();
            Phone.Text = row.Cells["Phone"].Value.ToString();
            Email.Text = row.Cells["Email"].Value.ToString();
            Balance.Text = row.Cells["Balance"].Value.ToString();
            Address.Text = row.Cells["Address"].Value.ToString();
            Nid.Text = row.Cells["Nid"].Value.ToString();

            string gender = row.Cells["Gender"].Value.ToString().Trim();
            string acctype= row.Cells["AccType"].Value.ToString().Trim();
            rbLoan.Checked = (acctype == "Loan");
            RbFDR.Checked = (acctype == "FDR");
            RbSavings.Checked = (acctype == "Savings");
            rbMale.Checked = (gender == "Male");
            RbFemale.Checked = (gender == "Female");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lbAccNum.Text))
            {
                MessageBox.Show("Select a row first!", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string gender = "";
                if (rbMale.Checked)
                {
                    gender = "Male";
                }
                else if (RbFemale.Checked)
                {
                    gender = "Female";
                }

                string acctype = " ";
                if (rbLoan.Checked)
                {
                    acctype = "Loan";
                }
                else if (RbSavings.Checked)
                {
                    acctype = "Savings";
                }
                else if (RbFDR.Checked)
                {
                    acctype = "FDR";
                }
                string query = "UPDATE Customer SET " +
                               "FirstName='" + FirstName.Text + "', " +
                               "LastName='" + LastName.Text + "', " +
                               "Dob='" + Dob.Text + "', " +
                               "Gender='" + gender + "', " +
                               "Phone='" + Phone.Text + "', " +
                               "Email='" + Email.Text + "', " +
                               "Nid='" + Nid.Text + "', " +
                               "Address='" + Address.Text + "', " +
                               "Balance='" + Balance.Text + "', " +
                               "Acctype='" + acctype + "' " +
                               "WHERE AcNumber='" + lbAccNum.Text + "'";
                Da.ExecuteQuery(query);
                MessageBox.Show("Details Updated!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showGridView();
                clearAll();
                
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error 420\n" + ex.Message);
            }
        }

       
        public void clearAll()
        {
            rbLoan.Checked = false;
            RbFDR.Checked = false;
            RbSavings.Checked = false;
            FirstName.Clear();
            LastName.Clear();
            rbMale.Checked = false;
            RbFemale.Checked = false;
            Phone.Clear();
            Email.Clear();
            Nid.Clear();
            Address.Clear();
            Balance.Clear();
            lbAccNum.Text = string.Empty;
        }
        

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
            dgvCustomerList.ClearSelection();
            dgvCustomerList.CurrentCell = null;
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string query = "Select * from customer where AcNumber like '%"
                               + tbSearch.Text + "%' or Phone like '%"
                               + tbSearch.Text + "%' or FirstName like '%"
                               + tbSearch.Text + "%' or LastName like '%"
                               + tbSearch.Text + "%'";
                DataTable dt = new DataTable();
                dt = Da.ExecuteQueryTable(query);
                dgvCustomerList.DataSource = dt;
                dgvCustomerList.ClearSelection();
                dgvCustomerList.CurrentCell = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong!\n" + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lbAccNum.Text))
            {
                MessageBox.Show("Please select a row first!");
                return;
            }
            try
            {
                string query = "Delete from Customer where AcNumber='" + lbAccNum.Text + "'";
                Da.ExecuteQuery(query);
                MessageBox.Show("Customer Deleted!", "Customer Deleted!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showGridView();
                clearAll();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error 420\n" + ex.Message);
            }
        }

        private void dgvCustomerList_DoubleClick(object sender, EventArgs e)
        {
            if (dgvCustomerList.CurrentRow == null || dgvCustomerList.CurrentRow.Index < 0)
                return;

            DataGridViewRow row = dgvCustomerList.CurrentRow;
            string accnum = row.Cells["AcNumber"].Value.ToString();
            new UserInterface(this,accnum, AdminID).Show();
            this.Hide();

        }

        private void lbSearch_Click(object sender, EventArgs e)
        {

        }

        private void lbPhone_Click(object sender, EventArgs e)
        {

        }
    }
}
