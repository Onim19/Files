using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btn1_Click(object sender, EventArgs e)
        {
            if (!tbDisplay.Enabled)
            {
                MessageBox.Show("Calculator is not turned on yet!");
                return;
            }
            tbDisplay.Text = tbDisplay.Text + "1";

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if(!tbDisplay.Enabled)
            {
                MessageBox.Show("Calculator is not turned on yet!");
                return;
            }
            tbDisplay.Text = tbDisplay.Text + "2";

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if(!tbDisplay.Enabled)
            {
                MessageBox.Show("Calculator is not turned on yet!");
                return;
            }
            tbDisplay.Text = tbDisplay.Text + "3";

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if(!tbDisplay.Enabled)
            {
                MessageBox.Show("Calculator is not turned on yet!");
                return;
            }
            tbDisplay.Text = tbDisplay.Text + "4";

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (!tbDisplay.Enabled)
            {
                MessageBox.Show("Calculator is not turned on yet!");
                return;
            }
            tbDisplay.Text = tbDisplay.Text + "5";

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (!tbDisplay.Enabled)
            {
                MessageBox.Show("Calculator is not turned on yet!");
                return;
            }
            tbDisplay.Text = tbDisplay.Text + "6";

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (!tbDisplay.Enabled)
            {
                MessageBox.Show("Calculator is not turned on yet!");
                return;
            }
            tbDisplay.Text = tbDisplay.Text + "0";

        }

        private void btnpoint_Click(object sender, EventArgs e)
        {
            if (!tbDisplay.Enabled)
            {
                MessageBox.Show("Calculator is not turned on yet!");
                return;
            }
            tbDisplay.Text = tbDisplay.Text + ".";

        }

        private void BtnOn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Calculator turned on!");
            tbDisplay.Text=string.Empty;
            tbDisplay.Enabled = true;
        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = string.Empty;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbDisplay.Text))
            {
                tbDisplay.Text = tbDisplay.Text.Substring(0, tbDisplay.Text.Length - 1);
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                string text = tbDisplay.Text;

                if (text.Contains("+"))
                {
                    string[] parts = text.Split('+');
                    double sum = 0;

                    foreach (string part in parts)
                    {
                        sum += Convert.ToDouble(part);
                    }

                    tbDisplay.Text = sum.ToString();
                }
            }

            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return;
            }

        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            if (!tbDisplay.Enabled)
            {
                MessageBox.Show("Calculator is not turned on yet!");
                return;
            }
            tbDisplay.Text = tbDisplay.Text + "+";

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (!tbDisplay.Enabled)
            {
                MessageBox.Show("Calculator is not turned on yet!");
                return;
            }
            tbDisplay.Text = tbDisplay.Text + "7";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (!tbDisplay.Enabled)
            {
                MessageBox.Show("Calculator is not turned on yet!");
                return;
            }
            tbDisplay.Text = tbDisplay.Text + "9";

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (!tbDisplay.Enabled)
            {
                MessageBox.Show("Calculator is not turned on yet!");
                return;
            }
            tbDisplay.Text = tbDisplay.Text + "8";

        }
    }
}
