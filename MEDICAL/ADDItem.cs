using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MEDICAL
{
    public partial class ADDItem : Form
    {
        DS.DS_ITEM.StockInMst_SelectDataTable IDT = new MEDICAL.DS.DS_ITEM.StockInMst_SelectDataTable();
        DS.DS_ITEMTableAdapters.StockInMst_SelectTableAdapter IAdapter = new MEDICAL.DS.DS_ITEMTableAdapters.StockInMst_SelectTableAdapter();
        
        DS.DS_COMPANY.CompanyMst_SelectDataTable CDT = new MEDICAL.DS.DS_COMPANY.CompanyMst_SelectDataTable();
        DS.DS_COMPANYTableAdapters.CompanyMst_SelectTableAdapter CAdapter = new MEDICAL.DS.DS_COMPANYTableAdapters.CompanyMst_SelectTableAdapter();

        DS.DS_STOCK.StockMst_SelectDataTable SDT = new MEDICAL.DS.DS_STOCK.StockMst_SelectDataTable();
        DS.DS_STOCKTableAdapters.StockMst_SelectTableAdapter SAdapter = new MEDICAL.DS.DS_STOCKTableAdapters.StockMst_SelectTableAdapter();

        DS.DS_USER.UserMst_SelectDataTable UDT = new DS.DS_USER.UserMst_SelectDataTable();
        DS.DS_USERTableAdapters.UserMst_SelectTableAdapter UAdapter = new MEDICAL.DS.DS_USERTableAdapters.UserMst_SelectTableAdapter();
        public string username, strmenu;
        public ADDItem(string uname,string strmnu)
        {
            username = uname;
            strmenu = strmnu;
            InitializeComponent();
            
        }

        private void ADDItem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mEDICALDataSet.StockInMst' table. You can move, or remove it, as needed.
            this.stockInMstTableAdapter.Fill(this.mEDICALDataSet.StockInMst);
            groupBox3.Visible = false;

            //if (strmenu == "mENUToolStripMenuItem")
            //{

            //    tabControl1.SelectedIndex = 0;
            //    tabControl1.SelectedIndex = 1;
            //    tabControl1.SelectedIndex = 2;
            //    tabControl1.SelectedIndex = 0;
            //}
            //else if (strmenu == "Update")
            //{

            //}
            //else if (strmenu == "Delete")
            //{

            //}
            //else if (strmenu == "View")
            //{

            //}


            CDT = CAdapter.SelectComapny();
            cmbdompany.DataSource = CDT;
            cmbdompany.DisplayMember = "Cname";
            cmbdompany.ValueMember = "Cid";
            cmbdompany.Text = "SELECT";
            IDT = IAdapter.SelectItem();
            comboBox1.DataSource = IDT;
            comboBox1.DisplayMember = "I_name";
            comboBox1.ValueMember = "I_ID";
            comboBox1.Text = "SELECT";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((txtiname.Text == "") && (txtiprice.Text == ""))
            {
                MessageBox.Show("Please Enter the Data");
            }
            else
            {
                int inst = IAdapter.Insert(txtiname.Text, txtidetail.Text, Convert.ToInt16(txtiqnt.Text), Convert.ToDouble(txtiprice.Text), cmbdompany.Text, Convert.ToDateTime(dateexpire.Text), txtlocation.Text);

                double price = Convert.ToDouble(txtiqnt.Text) * Convert.ToDouble(txtiprice.Text);
                int addstock = SAdapter.Insert(txtiname.Text, Convert.ToDouble(txtiprice.Text), Convert.ToInt32(txtiqnt.Text), 0, Convert.ToInt32(txtiqnt.Text), price, 0, price, System.DateTime.Now.Date);

                MessageBox.Show("Item Added Successfully !!", "MEdical System");
                txtiname.Text = "";
                txtidetail.Text = "";
                txtiprice.Text = "";
                txtiqnt.Text = "";
                txtlocation.Text = "";
                cmbdompany.Text = "SELECT";
                formUpload();

            }
            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
       
                CDT = CAdapter.SelectComapny();
                cmbdompany.DataSource = CDT;
                cmbdompany.DisplayMember = "Cname";
                cmbdompany.ValueMember = "Cid";
              cmbdompany.Text = "SELECT";
        
                IDT = IAdapter.SelectItem();
                SDT = SAdapter.SelectStock();
               comboBox1.DataSource = SDT;
                comboBox1.DisplayMember = "Iname";
                comboBox1.ValueMember = "s_ID";
              comboBox1.Text = "SELECT";
        
               IDT = IAdapter.SelectItem();
                SDT = SAdapter.SelectStock();
                comboBox2.DataSource = SDT;
                comboBox2.DisplayMember = "Iname";
                comboBox2.ValueMember = "s_ID";
               comboBox2.Text = "SELECT";
            
      

                IDT = IAdapter.SelectItem();
                dataGridView1.DataSource = IDT;
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (comboBox1.SelectedText != "")
            //{
            //IDT = IAdapter.SelectBYID(Convert.ToInt32(comboBox1.SelectedValue));
           // txtcurentqnt.Text = IDT.Rows[0]["I_Quantity"].ToString();
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure !! You want to Update Stock !!", "Medical system", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                IDT = IAdapter.SelectByINmae(comboBox1.Text);
               // IAdapter.StockInMst_Updateitem(Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(txtnewqnt.Text));
                int inst = IAdapter.Insert(comboBox1.Text, IDT.Rows[0]["I_Descrip"].ToString(), Convert.ToInt32(txtnewqnt.Text), Convert.ToDouble(IDT.Rows[0]["I_Price"].ToString()), IDT.Rows[0]["c_name"].ToString(), Convert.ToDateTime(IDT.Rows[0]["I_Ex_date"].ToString()), IDT.Rows[0]["I_location"].ToString());

                

                double tprice = Convert.ToDouble(txtnewqnt.Text) * Convert.ToDouble(IDT.Rows[0]["I_Price"].ToString());
                SAdapter.StockMst_ADD_Update_Quantity(Convert.ToInt32(txtnewqnt.Text), tprice, comboBox1.Text);

                MessageBox.Show("Quantity Updated Successfully !!", "Medical System");
                txtnewqnt.Text = "";
                txtcurentqnt.Text = "";

                comboBox1.Text = "SELECT";
                formUpload();
            }
        }

        public void formUpload() {
            IDT = IAdapter.SelectItem();
            dataGridView1.DataSource = IDT;
          
        }
        //public void deleteFuntion()
        //{
        //    int del = SAdapter.Delete(Convert.ToInt32(comboBox2.SelectedValue));
        //    int dellitem = IAdapter.Delete(comboBox2.Text);
        //    SDT = SAdapter.SelectStock();
        //    comboBox2.DataSource = SDT;
        //    comboBox2.DisplayMember = "Iname";
        //    comboBox2.ValueMember = "s_ID";
        //    comboBox2.Text = "SELECT";
        //    formUpload();
        //}
        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure !! You want to Delete Stock !!", "Medical system", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                int del = SAdapter.Delete(Convert.ToInt32(comboBox2.SelectedValue));
                int dellitem = IAdapter.Delete(comboBox2.Text);
                MessageBox.Show("Item Deleted Successfully !!", "Medical System");
                SDT = SAdapter.SelectStock();
                comboBox2.DataSource = SDT;
                comboBox2.DisplayMember = "Iname";
                comboBox2.ValueMember = "s_ID";
                comboBox2.Text = "SELECT";
                formUpload();
            }

        }

        private void txtiname_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if(!char.IsControl(e.KeyChar)&& !char.IsLetter(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
        }

        private void txtiqnt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtnewqnt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (MessageBox.Show("Are you sure !! You want to Delete Stock !!", "Medical system", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {          
                 string del=dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                IAdapter.GetDataBy(del);
                MessageBox.Show("Item Deleted Successfully !!", "Medical System");
                formUpload();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SDT = SAdapter.SelectBY_INAME(comboBox1.Text);
            txtcurentqnt.Text = SDT.Rows[0]["totalQuantity"].ToString();
        }
    }
}
