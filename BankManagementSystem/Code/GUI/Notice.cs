using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagementSystem.Code.GUI
{
    public partial class Notice : Form
    {
        private AdminGUI admin;
        private EmployeeGUI emp;
        private string ConnectionString = "Data Source=ONIM_HASSAN\\SQLEXPRESS;Initial Catalog=MyDB;Integrated Security=True";
        public AdminGUI Admin { get; set; }
        public EmployeeGUI Emp { get; set; }
        public Notice()
        {
            InitializeComponent();
        }

        public Notice(AdminGUI admin)
        {
            InitializeComponent();
            this.Admin= admin;
            this.Text = "Make Anouncement";
            PanelMakeAnouncement.Show();
            PanelNotice.Hide();
        }

        public Notice(EmployeeGUI emp)
        {
            InitializeComponent();
            this.Emp = emp;
            this.Text = "Notice";
            PanelMakeAnouncement.Hide();
            PanelNotice.Show();
            ReadNotice();
        }
        
        private void ReadNotice()
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();
                string query = "select title,message from Message where no=(SELECT MAX(no) FROM Message);";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) 
                {
                    tbNoticeTitle.Text = reader["title"].ToString();     
                    tbNotice.Text = reader["message"].ToString(); 
                }

                conn.Close();
                if (string.IsNullOrEmpty(tbNotice.Text) || string.IsNullOrEmpty(tbNoticeTitle.Text))
                {
                    tbNoticeTitle.Text = "No messages";
                    tbNotice.Text = "No messages";
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Something went wrong\n"+ex.Message);
                this.Hide();
            }
        }
        private void btSend_Click(object sender, EventArgs e)
        {
            string title = tbTitle.Text, messege = tbMessege.Text;
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(messege))
            {
                MessageBox.Show("Fields are empty");
                return;
            }
            try
            {
                int currentNo = GenerateMessegeNo();
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();
                var Query = "insert into Message(No,title,message) values("+currentNo.ToString()+",'" + title + "','" + messege + "');";
                SqlCommand cmd = new SqlCommand(Query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Anouncement has been sent");
                this.Hide();
            }
            catch (Exception E)
            {
                MessageBox.Show("Something went wrong. Error 909\n" + E.Message);
            }
        }

        private int GenerateMessegeNo()
        {
            int nextNo = 1;
            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();
                string query = "Select Max(no)+1 from Message;";
                SqlCommand cmd = new SqlCommand(query, conn);
                nextNo = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();
                return nextNo;

            }
            catch (Exception E)
            {
                return nextNo;
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            tbTitle.Clear();
            tbMessege.Clear();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
