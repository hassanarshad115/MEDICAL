using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MEDICAL
{
    public partial class Company : Form
    {
        DS.DS_COMPANY.CompanyMst_SelectDataTable CDT = new MEDICAL.DS.DS_COMPANY.CompanyMst_SelectDataTable();
        DS.DS_COMPANYTableAdapters.CompanyMst_SelectTableAdapter CAdapter = new MEDICAL.DS.DS_COMPANYTableAdapters.CompanyMst_SelectTableAdapter();
        public string strmenu;
        public Company(string strmnu)
        {
            strmenu = strmnu;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ist = CAdapter.Insert(txtname.Text, txtpersn.Text, txtadd.Text, txtmobile.Text);
            MessageBox.Show("Company Detail Addedd !!", "Medical System");

            txtname.Text = "";
            txtpersn.Text = "";
            txtadd.Text = "";
            txtmobile.Text = "";
            txtname.Focus();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            { 
            
            }
            else if (tabControl1.SelectedIndex == 1)
            {

                CDT = CAdapter.SelectComapny();
                comboBox1.DataSource = CDT;
                comboBox1.DisplayMember = "Cname";
                comboBox1.ValueMember = "CID";
                comboBox1.Text = "SELECT";
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                CDT = CAdapter.SelectComapny();
                dataGridView1.DataSource = CDT;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure !! You want to Delete !!", "Medical system", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int del = CAdapter.Delete(Convert.ToInt32(comboBox1.SelectedValue));
                MessageBox.Show("Delete Company !!", "Medical System");
                CDT = CAdapter.SelectComapny();
                comboBox1.DataSource = CDT;
                comboBox1.DisplayMember = "Cname";
                comboBox1.ValueMember = "CID";
                comboBox1.Text = "SELECT";

            }

        }

        private void Company_Load(object sender, EventArgs e)
        {
            if (strmenu == "Add")
            {
                tabControl1.SelectedIndex = 0;
            }
            else if (strmenu == "Delete")
            {
                tabControl1.SelectedIndex = 1;
            
            }
            else if (strmenu == "View")
            {
                tabControl1.SelectedIndex = 2;
            }

        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtpersn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtmobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
