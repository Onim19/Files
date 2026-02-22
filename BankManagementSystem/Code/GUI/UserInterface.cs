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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace BankManagementSystem.Code.GUI
{
    public partial class UserInterface : Form
    {
        private EmployeeGUI emp;
        private AdminGUI admin;
        private CustomerList customerlist;
        private string acNumber, id;
        private DataAccess da;
        private static string bankId = "5302821";


        public string BankId
        {
            get { return bankId; }
            set { bankId = value; }
        }


        public CustomerList Customerlist
        {
            get { return customerlist; }
            set { customerlist = value; }
        }
        public DataAccess Da
        {
            get { return this.da; }
            set { this.da = value; }
        }

        public string AcNumber
        {
            get; set; 
        }

        public string Id
        {
            get;set;
        }

        public AdminGUI Admin { get; set; }

        public EmployeeGUI Emp { get; set; }
        public UserInterface()
        {
            InitializeComponent();
        }

        public UserInterface(EmployeeGUI emp,string acNumber,string id)
        {
            InitializeComponent();
            this.Emp = emp;
            this.AcNumber = acNumber;
            this.Id = id;
            this.da = new DataAccess();
            dgvTransHistory.DefaultCellStyle.ForeColor = Color.Black;
        }

        public UserInterface(AdminGUI admin,string acNumber,string id)
        {
            InitializeComponent();
            this.Admin = admin;
            this.AcNumber = acNumber;  
            this.Id = id;
            this.da= new DataAccess();
            dgvTransHistory.DefaultCellStyle.ForeColor = Color.Black;
        }

        public UserInterface(CustomerList customerlist, string acNumber, string id)
        {
            InitializeComponent();
            this.Customerlist = customerlist;
            this.AcNumber = acNumber;
            this.Id = id;
            this.da = new DataAccess();
            dgvTransHistory.DefaultCellStyle.ForeColor = Color.Black;

        }

        private void UserInterface_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            lbTransferAcc.Hide();
            tbTransferAcc.Hide();
            lbWithdrawDepoTransfer.Text = "Withdraw Amount :";
            panel3.Show();

            
        }

        private void btnDeposite_Click(object sender, EventArgs e)
        {
            lbTransferAcc.Hide();
            tbTransferAcc.Hide();
            lbWithdrawDepoTransfer.Text = "Deposite Amount :";
            panel3.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel3.Hide();
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
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DataTable dt1=new DataTable();
            DataTable dt2 = new DataTable();

            double amount = string.IsNullOrWhiteSpace(tbWithdrawDep.Text)
                         ? 0
                         : Convert.ToDouble(tbWithdrawDep.Text); 
            string line = lbWithdrawDepoTransfer.Text;
            if (line == "Deposite Amount :" || line == "Withdraw Amount :")
            {
                if (string.IsNullOrEmpty(tbWithdrawDep.Text) || amount<500)
                {
                    MessageBox.Show("Please enter the amount!\nMinimum amount 500");
                    return;
                }
                if(line== "Deposite Amount :")
                {
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
                        double balance = Convert.ToDouble(dt1.Rows[0]["Balance"]) + amount;
                        string empname = dt2.Rows[0]["FirstName"].ToString() + " " + dt2.Rows[0]["LastName"].ToString();
                        string q3 = "INSERT INTO Transactions (TransId, AcNumber, UserName, Amount, Operation, EmployeeId, EmployeeName, TransDate) " +
            "VALUES ('" + transId + "', '" + AcNumber + "', '" + userName + "', " + amount + ", 'DEPOSITE', '" + Id + "',' " + empname + "', GETDATE())";
                        Da.ExecuteQuery(q3);
                        Da.ExecuteQuery("Update Customer set balance=" + balance + " where AcNumber='" + AcNumber + "'");
                        MessageBox.Show("Deposite Successful");
                        convertInfo(AcNumber);
                        tbWithdrawDep.Clear();
                        showGridView();
                        dgvTransHistory.ClearSelection();
                        dgvTransHistory.CurrentCell = null;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                else if(line== "Withdraw Amount :")
                {
                    try
                    {
                        string q1 = "SELECT FirstName, LastName, Balance FROM Customer WHERE AcNumber='" + AcNumber + "'";
                        string q2 = "SELECT FirstName, LastName FROM Employee WHERE EmployeeId='" + Id + "'";
                        dt1 = Da.ExecuteQueryTable(q1);
                        dt2 = Da.ExecuteQueryTable(q2);
                        string query = "Select * from BankDetails where BankId='" + BankId + "'";
                        DataTable dt = new DataTable();
                        dt = Da.ExecuteQueryTable(query);
                        double newBalance = Convert.ToDouble(dt.Rows[0]["Balance"].ToString()) - amount;
                        if (newBalance <= 500)
                        {
                            MessageBox.Show("Not enough Money in Bolt");
                            return;
                        }
                        Da.ExecuteQuery("Update BankDetails set Balance=" + newBalance + " where BankId='" + BankId + "'");

                        string transId = generateTransId();
                        string userName = dt1.Rows[0]["FirstName"].ToString() + " " + dt1.Rows[0]["LastName"].ToString();
                        if (Convert.ToDouble(dt1.Rows[0]["Balance"]) < 500 || Convert.ToDouble(dt1.Rows[0]["Balance"])<amount || Convert.ToDouble(dt1.Rows[0]["Balance"])-amount<500)
                        {
                            MessageBox.Show("Balance to 500 required!");
                            return;
                        }
                        double balance = Convert.ToDouble(dt1.Rows[0]["Balance"]) - amount;
                        string empname = dt2.Rows[0]["FirstName"].ToString() + " " + dt2.Rows[0]["LastName"].ToString();
                        string q3 = "INSERT INTO Transactions (TransId, AcNumber, UserName, Amount, Operation, EmployeeId, EmployeeName, TransDate) " +
            "VALUES ('" + transId + "', '" + AcNumber + "', '" + userName + "', " + amount + ", 'WITHDRAW', '" + Id + "',' " + empname + "', GETDATE())";
                        Da.ExecuteQuery(q3);
                        Da.ExecuteQuery("Update Customer set balance=" + balance + " where AcNumber='" + AcNumber + "'");
                        MessageBox.Show("Withdraw Successful");
                        convertInfo(AcNumber);
                        tbWithdrawDep.Clear();
                        showGridView();
                        dgvTransHistory.ClearSelection();
                        dgvTransHistory.CurrentCell = null;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else if(line== "Transfer Amount :")
            {
                if(string.IsNullOrEmpty(tbWithdrawDep.Text) || string.IsNullOrEmpty(tbTransferAcc.Text))
                {
                    MessageBox.Show("Please enter the fields!");
                    return;
                }
                string q1 = "SELECT FirstName, LastName, Balance FROM Customer WHERE AcNumber='" + AcNumber + "'";
                string q2 = "SELECT FirstName, LastName FROM Employee WHERE EmployeeId='" + Id + "'";
                string receiver = "SELECT FirstName, LastName, Balance FROM Customer WHERE AcNumber='" + tbTransferAcc.Text + "'";
                dt1 = Da.ExecuteQueryTable(q1);
                dt2 = Da.ExecuteQueryTable(q2);
                DataTable dt3=new DataTable();
                dt3=Da.ExecuteQueryTable(receiver);
                if (dt3.Rows.Count > 0) 
                {
                    MessageBox.Show("Account found!\n" +
                        "Account Number   : "+tbTransferAcc.Text+
                        "\nName     : "+ dt3.Rows[0]["FirstName"].ToString() + " " + dt3.Rows[0]["LastName"].ToString());
                }
                else
                {
                    MessageBox.Show("Account not found");
                    return;
                }
                string query = "Select * from BankDetails where BankId='" + BankId + "'";
                DataTable dt = new DataTable();
                dt = Da.ExecuteQueryTable(query);
                double newBalance = Convert.ToDouble(dt.Rows[0]["Balance"].ToString()) - amount;
                if (newBalance <= 500)
                {
                    MessageBox.Show("Not enough Money in Bolt");
                    return;
                }

                string transId = generateTransId();
                string userName = dt1.Rows[0]["FirstName"].ToString() + " " + dt1.Rows[0]["LastName"].ToString();
                if (Convert.ToDouble(dt1.Rows[0]["Balance"]) < 500 || Convert.ToDouble(dt1.Rows[0]["Balance"]) < amount || Convert.ToDouble(dt1.Rows[0]["Balance"]) - amount < 500)
                {
                    MessageBox.Show("Balance to 500 required!");
                    return;
                }
                double balance = Convert.ToDouble(dt1.Rows[0]["Balance"]) - amount;
                string empname = dt2.Rows[0]["FirstName"].ToString() + " " + dt2.Rows[0]["LastName"].ToString();
                double receiverBalance = Convert.ToDouble(dt3.Rows[0]["Balance"]) + amount;
                string q3 = "INSERT INTO Transactions (TransId, AcNumber, UserName, Amount, Operation, EmployeeId, EmployeeName, TransDate,Remarks) " +
            "VALUES ('" + transId + "', '" + AcNumber + "', '" + userName + "', " + amount + ", 'Money Transfer', '" + Id + "',' " + empname + "', GETDATE(),'Transfered to "+tbTransferAcc.Text+"')";
                Da.ExecuteQuery(q3);
                Da.ExecuteQuery("Update Customer set balance=" + balance + " where AcNumber='" + AcNumber + "'");
                MessageBox.Show("Transfer Successful");
                Da.ExecuteQuery("Update Customer set balance =" + receiverBalance + " where AcNumber='" + tbTransferAcc.Text + "'");
                convertInfo(AcNumber);
                tbWithdrawDep.Clear();
                tbTransferAcc.Clear();
                showGridView();
                dgvTransHistory.ClearSelection();
                dgvTransHistory.CurrentCell = null;


            }
        }

        private void btnTranferMoney_Click(object sender, EventArgs e)
        {

            lbWithdrawDepoTransfer.Text = "Transfer Amount :";
            lbTransferAcc.Show();
            tbTransferAcc.Show();
            panel3.Show();

        }

        public void showGridView()
        {
            try
            {
                DataTable dt = new DataTable();
                string query = "Select TransId,Amount,UserName,Operation,TransDate,isNull(Remarks,'-')as Remarks from Transactions where AcNumber='"+AcNumber+"' or remarks='Transfered to "+AcNumber+"'";
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

        private void UserInterface_Load(object sender, EventArgs e)
        {
            convertInfo(AcNumber);
            showGridView();
        }
       
        public void convertInfo(string AcNumber)
        {
            try
            {
                DataTable dt = new DataTable();
                string query = "Select * from Customer where AcNumber='" + AcNumber + "'";
                dt=Da.ExecuteQueryTable(query);
                userAccType.Text = dt.Rows[0]["AccType"].ToString();
                UserAccNo.Text = dt.Rows[0]["AcNumber"].ToString();
                UserName.Text = dt.Rows[0]["FirstName"].ToString() + " " + dt.Rows[0]["LastName"].ToString();
                UserDob.Text= Convert.ToDateTime(dt.Rows[0]["Dob"]).ToString("dd-MM-yyyy");
                UserPhone.Text = dt.Rows[0]["Phone"].ToString();
                UserEmail.Text = dt.Rows[0]["Email"].ToString();
                UserNID.Text = dt.Rows[0]["Nid"].ToString();
                UserBalance.Text = dt.Rows[0]["Balance"].ToString();
                UserGender.Text = dt.Rows[0]["Gender"].ToString();
                UserAddress.Text = dt.Rows[0]["Address"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong 9090!\n"+ex.Message);
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            dgvTransHistory.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (Admin != null)
            {
                this.Hide();
                Admin.Show();
            }

            else if (Emp != null)
            {
                this.Hide();
                Emp.Show();
            }
            else if (Customerlist != null)
            {
                this.Hide();
                Customerlist.Show();
            }
        }
    }
}
