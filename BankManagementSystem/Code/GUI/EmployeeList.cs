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
    public partial class EmployeeList : Form
    {
        private DataAccess da;
        private AdminGUI adm;

        public AdminGUI Adm
        {
            get {  return adm; }
            set { adm = value; }
        }

        public DataAccess Da
        {
            get { return this.da; }
            set { this.da = value; } 
        }
        public EmployeeList()
        {
            InitializeComponent();
            this.da = new DataAccess();
            this.Adm = adm;
        }

        public EmployeeList(AdminGUI adm)
        {
            InitializeComponent();
            this.da = new DataAccess();
        }

        public void showGridView()
        {
            try
            {
                DataTable dt = new DataTable();
                string query = "Select EmployeeID,FirstName,LastName,Dob,Gender,Phone,Email,Nid,Address,Salary,Vacancy from Employee;";
                dt = Da.ExecuteQueryTable(query);
                dgvEmployeeList.DataSource = dt;
                dgvEmployeeList.ClearSelection();
                dgvEmployeeList.CurrentCell = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong!\n" + ex.Message);
            }
        }

        private void EmloyeeList_Load(object sender, EventArgs e)
        {
            showGridView();
            clearAll();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string query = "Select EmployeeID,FirstName,LastName,Dob,Gender,Phone,Email,Nid,Address,Salary,Vacancy from Employee where EmployeeID like '%"
                               + tbSearch.Text + "%' or Phone like '%"
                               + tbSearch.Text + "%' or FirstName like '%"
                               + tbSearch.Text + "%' or LastName like '%"
                               + tbSearch.Text + "%'";
                DataTable dt=new DataTable();
                dt = Da.ExecuteQueryTable(query);
                dgvEmployeeList.DataSource = dt;
                dgvEmployeeList.ClearSelection();
                dgvEmployeeList.CurrentCell = null;
            }
            catch (Exception ex){
                MessageBox.Show("Something went wrong!\n" + ex.Message);
            }
        }

        private void dgvEmployeeList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

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
            Nid.Clear();
            Address.Clear();
            Salary.Clear();
            cbVacancy.Text= string.Empty;
            lbID.Text = string.Empty;
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
            dgvEmployeeList.ClearSelection();
            dgvEmployeeList.CurrentCell = null;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lbID.Text))
            {
                MessageBox.Show("Please select a row first!");
                return;
            }
            try
            {
                string query = "Delete from Employee where EmployeeId='" + lbID.Text +"'";
                Da.ExecuteQuery(query);
                MessageBox.Show("Deletion Complete!", "Employee Deleted!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showGridView();
                clearAll(); 
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error 420\n" + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lbID.Text))
            {
                MessageBox.Show("Please select a row first!");
                return;
            }
            try
            {
                string gender="";
                if (rbMale.Checked) {
                    gender = "Male";
                }
                else if (RbFemale.Checked)
                {
                    gender = "Female";
                }
                string query = "UPDATE Employee SET " +
                               "FirstName='" + FirstName.Text + "', " +
                               "LastName='" + LastName.Text + "', " +
                               "Dob='" + Dob.Text + "', " +
                               "Gender='" + gender + "', " +
                               "Phone='" + Phone.Text + "', " +
                               "Email='" + Email.Text + "', " +
                               "Nid='" + Nid.Text + "', " +
                               "Address='" + Address.Text + "', " +
                               "Salary='" + Salary.Text + "', " +
                               "Vacancy='" + cbVacancy.Text + "' " +
                               "WHERE EmployeeID='" + lbID.Text + "'"; 
                Da.ExecuteQuery(query);
                MessageBox.Show("Details Updated!", "Update",MessageBoxButtons.OK, MessageBoxIcon.Information);
                showGridView();
                clearAll();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error 420\n" + ex.Message);
            }
        }
    }
}
