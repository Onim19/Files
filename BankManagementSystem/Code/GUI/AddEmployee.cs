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
    public partial class AddEmployee : Form
    {

        private AdminGUI admin;
        private DataAccess da;

        public AdminGUI Admin { get; set; }
        public DataAccess Da
        {
            get { return this.da; }
            set { this.da = value; }
        }
        public AddEmployee()
        {
            InitializeComponent();
        }

        public AddEmployee(AdminGUI admin) {
            InitializeComponent();
            this.Admin = admin;
            this.da = new DataAccess();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Panel_info.Hide();
            panel1.Show();
            if (cbVacancy.Text == "Admin")
            {
                Id.Text = "A-" + generateID();
            }
            else
            {
                Id.Text = "E-" + generateID();
            }
        }



        private void btnConfirm_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(cbVacancy.Text) || string.IsNullOrEmpty(FirstName.Text) || string.IsNullOrEmpty(LastName.Text)
               || string.IsNullOrEmpty(Phone.Text) || string.IsNullOrEmpty(Email.Text) || string.IsNullOrEmpty(Nid.Text) ||
               string.IsNullOrEmpty(Address.Text) || string.IsNullOrEmpty(tbSalary.Text))
            {
                MessageBox.Show("Please fill the all fields");
                return;
            }
            else if (rbMale.Checked == false && RbFemale.Checked == false)
            {
                MessageBox.Show("Please fill the all fields");
                return;
            }

            try
            {
                string Gender;
                if (rbMale.Checked == true) {
                    Gender = "Male";
                }
                else
                {
                    Gender = "Female";
                }
                var query = "insert into Employee (EmployeeId,FirstName,LastName,Dob,Gender,Phone,Email,Nid,Address,Salary,Vacancy) values('" + Id.Text + "','" + FirstName.Text + "','" + LastName.Text + "','" + Dob.Text + "','" +Gender+ "','" + Phone.Text + "','" + Email.Text + "','" + Nid.Text + "','" + Address.Text + "'," + tbSalary.Text + ",'" + cbVacancy.Text + "');";
                Da.ExecuteQuery(query);

                DialogResult result = MessageBox.Show("Employee added successfully\n" + "Add another employee?", "Confirmation",MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes) {
                    clearAll();
                    panel1.Hide();
                    Panel_info.Show();
                }
                else
                {
                    this.Hide();
                    Admin.Show();  
                }
            }

            catch (Exception ex) {
                {
                    MessageBox.Show("Something went wrong\n" + ex.Message);

                }

            }
        }
        public void clearAll()
        {
            cbVacancy.Text = string.Empty;
            FirstName.Clear();
            LastName.Clear();
            rbMale.Checked = false;
            RbFemale.Checked = false;
            Phone.Clear();
            Email.Clear();  
            Nid .Clear();
            Address .Clear();   
            tbSalary .Clear();
        }

        public string generateID()
        {
            int currentID = 1001;
            try
            {
                string query = "SELECT MAX(CAST(SUBSTRING(EmployeeID, CHARINDEX('-', EmployeeID) + 1, LEN(EmployeeID)) AS INT)) AS MaxEmpID FROM Employee;";
                DataTable tb = new DataTable();
                tb = Da.ExecuteQueryTable(query);
                if (tb.Rows.Count > 0 && tb.Rows[0][0] != DBNull.Value)
                {
                    currentID = Convert.ToInt32(tb.Rows[0][0]) + 1;
                }
                Da.Sqlcon.Close();
                return Convert.ToString(currentID);

            }
            catch (Exception E){
                return Convert.ToString(currentID);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            Panel_info.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin.Show();
        }

        private void AddEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void AddEmployee_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(this.ActiveControl is TextBox tb && tb.Multiline)
                {
                    return;
                }

                e.SuppressKeyPress=true;
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }
    }
}
