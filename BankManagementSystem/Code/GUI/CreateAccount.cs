using BankManagementSystem.Code.DataBaseExecution;
using System;
using System.Collections;
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
    public partial class CreateAccount : Form
    {
        private EmployeeGUI hs;
        private AdminGUI admin;
        private DataAccess da;

        public DataAccess Da
        {
            get { return this.da; }
            set { this.da = value; }
        }

        public AdminGUI Admin { get;set;  }

        public EmployeeGUI Hs { get; set; }
        public CreateAccount()
        {
            InitializeComponent();
            this.da = new DataAccess();
        }

        public CreateAccount(EmployeeGUI hs)
        {
            InitializeComponent();
            this.Hs = hs;
            this.da=new DataAccess();
        }

        public CreateAccount(AdminGUI admin)
        {
            InitializeComponent();
            this.Admin = admin;
            this.da=new DataAccess();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (Hs != null)
            {
                this.Hide();
                Hs.Show();
            }
            else if (Admin != null)
            {
                this.Hide();
                Admin.Show();
            }

        }

        public string generateAccNo()
        {
            long currentID= 20000234250001;
            try
            {
                string query = "Select max(AcNumber) from Customer;";
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

        private void btnNext_Click(object sender, EventArgs e)
        {
            
            Panel_info.Visible=false;
            Panel_Pass.Visible = true;
            AccountNumber.Text = generateAccNo();
        }

        

        private void PassBack_Click(object sender, EventArgs e)
        {
            Panel_Pass.Visible = false;
            Panel_info.Visible = true;
        }

        private void CreateAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
            DepositeAmount.Clear();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            if(rbLoan.Checked==false && RbFDR.Checked==false && RbSavings.Checked==false)
            {
                MessageBox.Show("Please select all the fields");
                return;
            }
            if(rbMale.Checked == false && RbFemale.Checked == false)
            {
                MessageBox.Show("Please select all the fields");
                return;
            }
            if (string.IsNullOrEmpty(FirstName.Text)||string.IsNullOrEmpty(LastName.Text)||string.IsNullOrEmpty(Phone.Text)||
                string.IsNullOrEmpty(Email.Text)||string.IsNullOrEmpty(Address.Text)||string.IsNullOrEmpty(Nid.Text)||
                string.IsNullOrEmpty(DepositeAmount.Text))
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }

            try
            {
                string acc_type="";
                string gender="";
                if (rbLoan.Checked == true)
                {
                    acc_type = rbLoan.Text;
                }
                else if (RbFDR.Checked == true)
                {
                    acc_type = RbFDR.Text;
                }
                else if (RbSavings.Checked == true) 
                {
                    acc_type=RbSavings.Text;
                }

                if(RbFemale.Checked == true)
                {
                    gender=RbFemale.Text;
                }
                else if(rbMale.Checked== true)
                {  
                    gender=rbMale.Text;
                }
                var query = @"INSERT INTO Customer (AcNumber,FirstName,LastName,Dob,Gender,Phone,Email,Nid,Address,AccType,Balance) VALUES ('" + AccountNumber.Text + "','" + FirstName.Text + "','" + LastName.Text + "','" + Dob.Text + "','" + gender + "','" + Phone.Text + "','" + Email.Text + "','" + Nid.Text + "','" + Address.Text + "','" + acc_type + "'," + DepositeAmount.Text + ")";
                Da.ExecuteQuery(query);
                DialogResult result = MessageBox.Show("Customer Added Successfully\n" + "Add another customer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    clearAll();
                    Panel_Pass.Hide();
                    Panel_info.Show();
                }
                else
                {
                    if (Admin != null)
                    {
                        this.Hide();
                        Admin.Show();
                    }
                    else if (Hs != null)
                    {
                        this.Hide();
                        Hs.Show();
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong\n" + ex.Message);

            }
        }

        private void CreateAccount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.ActiveControl is TextBox tb && tb.Multiline)
                {
                    return;
                }

                e.SuppressKeyPress = true;
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }
    }
}
