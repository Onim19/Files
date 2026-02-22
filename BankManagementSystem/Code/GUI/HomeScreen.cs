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
    public partial class HomeScreen : Form
    {
        private EmployeeGUI emp;
        private AdminGUI adm;
        private DataAccess da;

        public DataAccess Da
        {
            get { return this.da; } 
            set { this.da = value; }
        }

        public EmployeeGUI Emp { get; set; }

        public AdminGUI Admin { get; set; }
        public HomeScreen()
        {
            InitializeComponent();
            this.da=new DataAccess();
        }

        public HomeScreen(EmployeeGUI emp)
        {
            InitializeComponent();
            this.da = new DataAccess();
            this.Emp = emp;
        }

        public HomeScreen(AdminGUI adm)
        {
            InitializeComponent();
            this.Admin=adm;
            this.da = new DataAccess();
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login lg= new Login(this);
            lg.Show();
            this.Hide();
        }

        private void HomeScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            panel_createAccount.Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            panel_createAccount.Visible = false;
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbEmpID.Text) || string.IsNullOrEmpty(tbNewPass.Text) || string.IsNullOrEmpty(tbConfirmPass.Text))
            {
                MessageBox.Show("Fill the fileds");
                return;
            }
            if (tbNewPass.Text != tbConfirmPass.Text)
            {
                MessageBox.Show("Passwords do not match");
                return;
            }
            try
            {
                DataTable dt = new DataTable();
                var query = "Select Password from Employee where employeeid='" + tbEmpID.Text+"'";
                dt = Da.ExecuteQueryTable(query);
                if (dt.Rows.Count >= 1 && dt.Rows[0][0] == DBNull.Value)
                {
                    query = "Update Employee set password='" + tbConfirmPass.Text + "' where employeeid='" + tbEmpID.Text + "'";
                    da.ExecuteQuery(query);
                    MessageBox.Show("Accoount created Successfully!", "Confirmation");
                    panel_createAccount.Hide();
                    tbConfirmPass.Clear();
                    tbEmpID.Clear();
                    tbNewPass.Clear();
                }
                else if (dt.Rows.Count >= 1 && dt.Rows[0][0] != DBNull.Value)
                {
                    MessageBox.Show("Account already exists!");
                }
                else
                {
                    MessageBox.Show("ID not found");

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Something went wrong\n"+ex.Message);
            }
        }
    }
}
