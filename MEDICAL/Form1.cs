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
    
    public partial class Form1 : Form
    {
        DS.DS_USER.UserMst_SelectDataTable UDT = new DS.DS_USER.UserMst_SelectDataTable();
        DS.DS_USERTableAdapters.UserMst_SelectTableAdapter UAdapter = new MEDICAL.DS.DS_USERTableAdapters.UserMst_SelectTableAdapter();
        public string username;
        public Form1()
        {
            InitializeComponent();
            txtpass.Text = "";
            txtpass.PasswordChar = '*';
            txtpass.MaxLength = 5;
            //Form1.Attributes.Add("bgcolor", "green");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
           
            
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    System.Windows.Forms.Control Mdi = (MdiClient)ctl;

                    
                }
                catch (Exception ex)
                {
                    
                }
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            {

                MessageBox.Show("Enter Login Name !", "Medical System");
            }
            else if (txtpass.Text == "")
            {
                MessageBox.Show("Enter Login Password !", "Medical System");
            }
            else
            {
                UDT = UAdapter.SelectForLOGIN(txtname.Text, txtpass.Text);
                if(UDT.Rows.Count>0)
                { /*lblname.Text = "welcome " + txtname.Text;*/
                    username = txtname.Text;
                    txtname.Text = "";
                    txtpass.Text = "";
                    gplogin.Visible = false;
                    menulogout.Visible = true;
                    mENUToolStripMenuItem.Enabled = true;
                    sELLToolStripMenuItem.Enabled = true;
                    cLIENTSToolStripMenuItem.Enabled = true;
                    rEPORTSToolStripMenuItem.Enabled = true;
                    mANAGEUSERToolStripMenuItem.Enabled = true;
                    cOMPANYToolStripMenuItem.Enabled = true;   
                    }
                else
                {
                    MessageBox.Show("Invalid LoginName OR Password !", "Medical System");
                }
            }
        }

        private void menulogout_Click(object sender, EventArgs e)
        {
            closeExistingForm();
            gplogin.Visible = true;
            menulogout.Visible = false;
            mENUToolStripMenuItem.Enabled = false;
            sELLToolStripMenuItem.Enabled = false;
            cLIENTSToolStripMenuItem.Enabled = false;
            rEPORTSToolStripMenuItem.Enabled = false;
            mANAGEUSERToolStripMenuItem.Enabled = false;
            cOMPANYToolStripMenuItem.Enabled = false;
            //pnlName.Visible = false;
            lblname.Text = "";
        }

        private void nEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeExistingForm();
            Form additem = new ADDItem(username, "STOCK");
            additem.MdiParent = this;
            additem.Show();
        }
        private void closeExistingForm()
        {
            try
            {
                this.ActiveMdiChild.Close();
            }
            catch (Exception)
            {

            }

        }
        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aDDNEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeExistingForm();
            Form additem = new UserMst(username,"Add");
            additem.MdiParent = this;
            additem.Show();
        }

        private void aDDNEWToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            closeExistingForm();
            Form additem = new Company("Add");
            additem.MdiParent = this;
            additem.Show();

        }

        private void aDDNEWToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            closeExistingForm();
            Form additem = new Client("Add");
            additem.MdiParent = this;
            additem.Show();

        }

        private void sELLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DS.DS_SALES.SALES_SELECTDataTable SDT = new MEDICAL.DS.DS_SALES.SALES_SELECTDataTable();
            DS.DS_SALESTableAdapters.SALES_SELECTTableAdapter SAdapter = new MEDICAL.DS.DS_SALESTableAdapters.SALES_SELECTTableAdapter();
            int del = SAdapter.Delete();
            closeExistingForm();
            Form additem = new SELL();
            additem.MdiParent = this;
            additem.Show();
        }
        private void stockReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeExistingForm();
            Form srpt = new StockReport();
            srpt.MdiParent = this;
            srpt.Show();
        }

        private void sellReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeExistingForm();
            Form sellrpt = new SellReport();
            sellrpt.MdiParent = this;
            sellrpt.Show();
        }

        private void updateStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeExistingForm();
            Form additem = new ADDItem(username,"Update");
            additem.MdiParent = this;
            additem.Show();
        }

        private void totalStockReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeExistingForm();
            Form tsrpt = new TotalStockReport();
            tsrpt.MdiParent = this;
            tsrpt.Show();

        }

        private void deleteStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeExistingForm();
            Form additem = new ADDItem(username, "Delete");
            additem.MdiParent = this;
            additem.Show();
        }

        private void repotsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeExistingForm();
            Form additem = new ADDItem(username, "View");
            additem.MdiParent = this;
            additem.Show();
        }

        private void dELETEToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            closeExistingForm();
            Form additem = new Client("Delete");
            additem.MdiParent = this;
            additem.Show();
        }

        private void vIEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeExistingForm();
            Form additem = new Client("View");
            additem.MdiParent = this;
            additem.Show();
        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeExistingForm();
            Form additem = new UserMst(username, "Delete");
            additem.MdiParent = this;
            additem.Show();
        }

        private void rEPORTSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            closeExistingForm();
            Form additem = new UserMst(username, "View");
            additem.MdiParent = this;
            additem.Show();
        }

        private void cHNAEGPASSWORDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeExistingForm();
            Form additem = new UserMst(username, "Password");
            additem.MdiParent = this;
            additem.Show();
        }

        private void dELETEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            closeExistingForm();
            Form additem = new Company("Delete");
            additem.MdiParent = this;
            additem.Show();
        }

        private void rEPORTSToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            closeExistingForm();
            Form additem = new Company("View");
            additem.MdiParent = this;
            additem.Show();
        }

      

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Password")
            {
                txtpass.Text = "";
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "Password";
            }
        }

        private void txtname_Enter(object sender, EventArgs e)
        {
            if(txtname.Text=="User Name")
            {
                txtname.Text = "";
            }
        }
        private void txtname_Leave(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            {
                txtname.Text = "User Name";
            }
        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
