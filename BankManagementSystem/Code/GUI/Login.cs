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
    public partial class Login : Form
    {
        HomeScreen hs;
        private DataAccess da;

        public DataAccess Da
        {
            get { return this.da; }
            set { this.da = value; }
        }

        public HomeScreen Hs {  get; set; }
          
        public Login()
        {
            InitializeComponent();
            this.da=new DataAccess();
        }

        public Login(HomeScreen hs)
        {
            InitializeComponent();
            this.Hs = hs;
            this.da = new DataAccess();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hs.Show();
            
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UserId.Text) || string.IsNullOrEmpty(Password.Text))
            {
                MessageBox.Show("Please fill the empty fields");
                return;
            }
            try
            {
                string query = "Select employeeid,Password from employee where employeeId='" + UserId.Text + "'";
                DataTable dt = new DataTable();
                dt=Da.ExecuteQueryTable(query);
                if (dt.Rows.Count > 0 && dt.Rows[0]["Password"] != DBNull.Value && Password.Text== dt.Rows[0]["Password"].ToString())
                {
                    if (UserId.Text[0] == 'A')
                    {
                        MessageBox.Show("Welcome Admin!");
                        this.Hide();
                        new AdminGUI(this,UserId.Text).Show();
                    }
                    else if(UserId.Text[0] =='E')
                    {
                        MessageBox.Show("Welcome Employee!");
                        this.Hide();
                        new EmployeeGUI(this,UserId.Text).Show();
                    }
                }
                else if (dt.Rows.Count > 0 && dt.Rows[0]["Password"] != DBNull.Value && Password.Text != dt.Rows[0]["Password"].ToString())
                {
                    MessageBox.Show("Incorrect password!\nTry Again.","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    Password.Clear();
                }

                else if (dt.Rows.Count > 0 && dt.Rows[0]["Password"] == DBNull.Value)
                {
                    MessageBox.Show("Account not created!");
                    return;
                        
                }
                else
                {
                    MessageBox.Show("ID not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong\n"+ex.Message);
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lbForgetPass_Click(object sender, EventArgs e)
        {
            new Password(this).Show();
        }

        private void UserId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
    }
}
