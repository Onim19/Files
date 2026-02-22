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
    public partial class Password : Form
    {
        private string id;
        private Login lg;
        private DataAccess da;

        public string Id
        {
            get { return id; }  
            set { id = value; }
        }
        public DataAccess Da
        {
            get { return this.da; }
            set { this.da = value; }
        }
        public Login Lg { get; set; }
        public Password()
        {
            InitializeComponent();
            this.da=new DataAccess();
        }

        public Password(Login lg)
        {
            InitializeComponent();
            this.Lg = lg;
            this.da = new DataAccess();
            this.Text = "Forgot Password";
            panel_UpdatePass.Hide();

            panel_forgotPass.Show();

        }

        public Password(string id)
        {
            InitializeComponent();
            this.da = new DataAccess();
            this.Id = id;
            this.Text = "Update Password";
            panel_forgotPass.Hide();
            panel_UpdatePass.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lg.Show();
        }

        public void clearAll()
        {
            tbConfirmPass.Clear();
            tbID.Clear();
            tbNewPass.Clear();
            tbPhone.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbConfirmPass.Text) || string.IsNullOrEmpty(tbPhone.Text)
                || string.IsNullOrEmpty(tbID.Text) || string.IsNullOrEmpty(tbNewPass.Text))
            {
                MessageBox.Show("Please fill the fields!");
                return;
            }
            if (tbNewPass.Text != tbConfirmPass.Text)
            {
                MessageBox.Show("Password not matched!");
                return;
            }
            try
            {
                string query = "Select Password from employee where employeeId='" + tbID.Text + "' and phone='"+tbPhone.Text+"'";
                DataTable dt = new DataTable();
                dt = Da.ExecuteQueryTable(query);
                if (dt.Rows.Count == 1 && dt.Rows[0][0] != DBNull.Value)
                {
                    query="Update Employee set password='"+tbNewPass.Text+"' where employeeId='"+tbID.Text+"'";
                    Da.ExecuteQuery(query);
                    MessageBox.Show("Password Changed", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearAll();
                }
                else if (dt.Rows.Count == 1 && dt.Rows[0][0] == DBNull.Value)
                {
                    MessageBox.Show("Account not created yet!");
                }
                else
                {
                    MessageBox.Show("Information not valid\nTry again!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong!"+ex.Message);
            }
        }

        private void btnUConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbUnewPass.Text) || string.IsNullOrEmpty(tbUConfirmPass.Text))
            {
                MessageBox.Show("Please fill the fields!");
                return;
            }

            if (tbUnewPass.Text != tbUConfirmPass.Text)
            {
                MessageBox.Show("Password not matched!");
                return;
            }

            try
            {
                string query = "Update Employee set Password='" + tbUnewPass.Text + "' where EmployeeId='" + Id + "'";
                Da.ExecuteQuery(query);
                MessageBox.Show("Password Changed", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception ex) {
                MessageBox.Show("Something went wrong!" + ex.Message);
            }
        }

        private void btnUCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
