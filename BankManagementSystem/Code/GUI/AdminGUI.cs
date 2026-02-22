using BankManagementSystem.Code.DataBaseExecution;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace BankManagementSystem.Code.GUI
{
    public partial class AdminGUI : Form
    {
        private Login lg;
        private DataAccess da;
        private string id;

        public string Id
        {
            get;set;
        }

        public DataAccess Da
        {
            get { return this.da; }
            set { this.da = value; }
        }

        public Login Lg { get; set; }
        public AdminGUI()
        {
            InitializeComponent();
            this.da=new DataAccess();
        }
        public AdminGUI(Login lg,string id)
        {
            InitializeComponent();
            this.Lg = lg;
            this.da = new DataAccess();
            this.Id = id;
        }

        public void convertInfo(string id)
        {
            try
            {
                string query = "Select * from Employee where employeeId='" + id + "'";
                DataTable dt = new DataTable();
                dt = Da.ExecuteQueryTable(query);
                lbEmpName.Text = dt.Rows[0]["FirstName"].ToString() + " " + dt.Rows[0]["LastName"].ToString();
                EmpID.Text = dt.Rows[0]["EmployeeId"].ToString();
                EmpName.Text = dt.Rows[0]["FirstName"].ToString() + " " + dt.Rows[0]["LastName"].ToString();
                EmpGender.Text = dt.Rows[0]["Gender"].ToString();
                EmpDob.Text = Convert.ToDateTime(dt.Rows[0]["Dob"]).ToString("dd-MM-yyyy");
                EmpPhone.Text = dt.Rows[0]["Phone"].ToString();
                EmpEmail.Text = dt.Rows[0]["Email"].ToString();
                EmpNid.Text = dt.Rows[0]["Nid"].ToString();
                EmpAddress.Text = dt.Rows[0]["Address"].ToString();
                EmpVacancy.Text = dt.Rows[0]["Vacancy"].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong in this frame.\nTry again later!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Hide();
                Lg.Show();
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            CreateAccount cr = new CreateAccount(this);
            this.Hide();
            cr.Show();
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            new Loan(Id).Show();
        }

        private void btnTransections_Click(object sender, EventArgs e)
        {
            new Transactions(Id).Show();
        }



        private void lbLogOut_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Confirm Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (r == DialogResult.Yes)
            {
                HomeScreen hs = new HomeScreen(this);
                this.Hide();
                hs.Show();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearchCustomer.Text))
            {
                MessageBox.Show("Enter customer account number!");
                return;
            }
            try
            {
                DataTable dt= new DataTable();
                string query = "Select AcNumber from Customer where AcNumber='" + tbSearchCustomer.Text + "'";
                dt=Da.ExecuteQueryTable(query);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Customer Found!");
                    this.Hide();
                    new UserInterface(this, tbSearchCustomer.Text, Id).Show();
                }
                else
                {
                    MessageBox.Show("Customer not found!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong!\n" + ex.Message);
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Hide();
            tableLayoutPanel4.Show();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            tableLayoutPanel4.Hide();
            tableLayoutPanel1.Show();
        }

        private void btnUserList_Click(object sender, EventArgs e)
        {
            new CustomerList(Id).Show();
        }

        private void AdminGUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee a=new AddEmployee(this);
            this.Hide();
            a.Show();
        }

        private void lbNotice_Click(object sender, EventArgs e)
        {
            Notice n = new Notice(this);
            n.Show();
        }

        private void lbUpdatePass_Click(object sender, EventArgs e)
        {
            new Password(Id).Show();
        }

        private void AdminGUI_Load(object sender, EventArgs e)
        {
            convertInfo(Id);
        }

        private void btnEmployeeList_Click(object sender, EventArgs e)
        {
            new EmployeeList(this).Show();

        }

        private void btnBankBolt_Click(object sender, EventArgs e)
        {
            new BankBolt(Id).Show();
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            new Graphs().Show();
        }
    }
}
