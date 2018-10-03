using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MEDICAL
{
    public partial class SELL : Form
    {
        DS.DS_SALES.SALES_SELECT_SUM_TOTALDataTable SUMDT = new MEDICAL.DS.DS_SALES.SALES_SELECT_SUM_TOTALDataTable();
        DS.DS_SALESTableAdapters.SALES_SELECT_SUM_TOTALTableAdapter SUMAdapter = new MEDICAL.DS.DS_SALESTableAdapters.SALES_SELECT_SUM_TOTALTableAdapter();

        DS.DS_CLIENT.ClientMst_SelectDataTable CDT = new MEDICAL.DS.DS_CLIENT.ClientMst_SelectDataTable();
        DS.DS_CLIENTTableAdapters.ClientMst_SelectTableAdapter CAdapter = new MEDICAL.DS.DS_CLIENTTableAdapters.ClientMst_SelectTableAdapter();
        
        DS.DS_SALES.SALES_SELECTDataTable SDT = new MEDICAL.DS.DS_SALES.SALES_SELECTDataTable();
        DS.DS_SALESTableAdapters.SALES_SELECTTableAdapter SAdapter = new MEDICAL.DS.DS_SALESTableAdapters.SALES_SELECTTableAdapter();
       
        DS.DS_ITEM.StockInMst_SelectDataTable IDT = new MEDICAL.DS.DS_ITEM.StockInMst_SelectDataTable();
        DS.DS_ITEMTableAdapters.StockInMst_SelectTableAdapter IAdapter = new MEDICAL.DS.DS_ITEMTableAdapters.StockInMst_SelectTableAdapter();

        DS.DS_STOCK.StockMst_SelectDataTable StockDT = new MEDICAL.DS.DS_STOCK.StockMst_SelectDataTable();
        DS.DS_STOCKTableAdapters.StockMst_SelectTableAdapter StockAdapter = new MEDICAL.DS.DS_STOCKTableAdapters.StockMst_SelectTableAdapter();

        DS.DS_SOUT.StockOutMst_SelectDataTable SOotDT = new MEDICAL.DS.DS_SOUT.StockOutMst_SelectDataTable();
        DS.DS_SOUTTableAdapters.StockOutMst_SelectTableAdapter SOutAdapter = new MEDICAL.DS.DS_SOUTTableAdapters.StockOutMst_SelectTableAdapter();
        public SELL()
        {
            InitializeComponent();
        }
        private void SELL_Load(object sender, EventArgs e)
        {
            int del = SAdapter.Delete();
            SqlConnection con = new SqlConnection("Data Source='DESKTOP-2D42C0P';Integrated Security='true';Initial Catalog='MEDICAL'");
            SqlCommand cmd = new SqlCommand("SELECT I_name FROM StockInMst", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            AutoCompleteStringCollection SCollection = new AutoCompleteStringCollection();
            while (reader.Read())
            {
                SCollection.Add(reader.GetString(0));
            }
            txtiname.AutoCompleteCustomSource = SCollection;
            con.Close();
            CDT = CAdapter.SelectClient();
            comboBox1.DataSource = CDT;
            comboBox1.DisplayMember = "cu_name";
            comboBox1.ValueMember = "cu_id";
        }

        private void gvsales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (gvsales.Rows[e.RowIndex].Cells[4].Selected == true)
                {


                    string namee = gvsales.Rows[e.RowIndex].Cells[0].Value.ToString();
                    SAdapter.SALES_DELETE_by_name(namee);
                  //  STADapter.DeleteById(Convert.ToInt32(m));
                   // BindGrid();

                    SDT = SAdapter.SelectBy_PNAME(txtpname.Text);
                    gpdispatch.Visible = true;
                    gvsales.AutoGenerateColumns = false;
                    gvsales.DataSource = SDT;

                    SUMDT = SUMAdapter.SelectTotla();
                    lblqnt.Text = SUMDT.Rows[0]["qnt"].ToString();
                    lbltprice.Text = SUMDT.Rows[0]["Tprice"].ToString();
                }

            }
            catch (Exception )
            { }
        }

        private void txtiname_Leave(object sender, EventArgs e)
        {
            //if (txtiname.Text != "")
            //{
            //    label8.Text = txtiname.Text;
            //    StockDT = StockAdapter.SelectBY_INAME(txtiname.Text);
            //    IDT = IAdapter.SelectByINmae(txtiname.Text);
            //    if (StockDT.Rows.Count > 0)
            //    {
            //        if (StockDT.Rows[0]["AvailableQuantity"].ToString() == "0")
            //        {
            //            MessageBox.Show("No Enought Quantity !!", "Medical System");
            //        }
            //        else
            //        {

            //            SDT = SAdapter.SelectBY_NAME(txtiname.Text);
            //            if (SDT.Rows.Count > 0)
            //            {
            //                int quentity = Convert.ToInt32(txtq.Text);
            //                SDT = SAdapter.SelectBY_NAME(txtiname.Text);

            //                int exiqnt = Convert.ToInt32(SDT.Rows[0]["Quantity"].ToString());
            //                if (Convert.ToInt32(StockDT.Rows[0]["AvailableQuantity"].ToString()) > exiqnt)
            //                {
            //                    int QNT = Convert.ToInt32(SDT.Rows[0]["Quantity"].ToString() + quentity);
            //                    double TPRICE = Convert.ToInt32(SDT.Rows[0]["Price"].ToString()) * QNT;
            //                    int existsalseupdate = SAdapter.Update(txtiname.Text, QNT.ToString(), TPRICE);

            //                }
            //                else
            //                {
            //                    MessageBox.Show("No Enought Quantity", "Medical system");
            //                }

            //            }
            //            else
            //            {
            //                lblq.Text = StockDT.Rows[0]["AvailableQuantity"].ToString();
            //                lblp.Text = IDT.Rows[0]["I_Price"].ToString();
            //                lbll.Text = IDT.Rows[0]["I_location"].ToString();
            //                txtq.Text = "2";

            //                double tprice = Convert.ToDouble(IDT.Rows[0]["I_Price"].ToString());
            //                int abc = Convert.ToInt32(qnnt.Text);
            //                double total = tprice * abc;
            //                int salinst = SAdapter.Insert(txtpname.Text, txtiname.Text, total, abc, total);
            //            }
            //            SDT = SAdapter.SelectBy_PNAME(txtpname.Text);
            //            gpdispatch.Visible = true;
            //            gvsales.AutoGenerateColumns = false;
            //            gvsales.DataSource = SDT;

            //            SUMDT = SUMAdapter.SelectTotla();
            //            lblqnt.Text = SUMDT.Rows[0]["qnt"].ToString();
            //            lbltprice.Text = SUMDT.Rows[0]["Tprice"].ToString();

            //        }
            //        gpdispatch.Visible = true;
            //    }
            //    else
            //    {
            //        MessageBox.Show("Item Not Available !!", "Medical System");
            //    }
            //}
            ////  txtiname.Text = "";
            //// txtiname.Focus();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtpname.Text = comboBox1.Text;
        }
        private void txtq_Leave(object sender, EventArgs e)
        {
            if (txtq.Text != "")
            {
                StockDT = StockAdapter.SelectBY_INAME(label8.Text);
                IDT = IAdapter.SelectByINmae(label8.Text);
                if (StockDT.Rows.Count > 0)
                {

                    if (StockDT.Rows[0]["AvailableQuantity"].ToString() == "0")
                    {
                        MessageBox.Show("No Enought Quantity !!", "Medical System");
                    }
                    else
                    {

                        SDT = SAdapter.SelectBY_NAME(label8.Text);
                        if (SDT.Rows.Count > 0)
                        {
                            SDT = SAdapter.SelectBY_NAME(label8.Text);
                            
                            int exiqnt = Convert.ToInt32(SDT.Rows[0]["Quantity"].ToString());
                            int qntt = exiqnt + Convert.ToInt32(txtq.Text);
                            if (Convert.ToInt32(StockDT.Rows[0]["AvailableQuantity"].ToString()) > qntt)
                            {
                                // int QNT = Convert.ToInt32(SDT.Rows[0]["Quantity"].ToString()) + 1;
                                double TPRICE = Convert.ToInt32(SDT.Rows[0]["Price"].ToString()) * qntt;
                                int existsalseupdate = SAdapter.Update(label8.Text, qntt.ToString(), TPRICE);
                                SDT = SAdapter.SelectBy_PNAME(txtpname.Text);
                                gpdispatch.Visible = true;
                                gvsales.AutoGenerateColumns = false;
                                gvsales.DataSource = SDT;
                                SUMDT = SUMAdapter.SelectTotla();
                                lblqnt.Text = SUMDT.Rows[0]["qnt"].ToString();
                                lbltprice.Text = SUMDT.Rows[0]["Tprice"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No Enought Quantity", "Medical system");
                            }
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure !! You want to Confirm this Order !!", "Medical system", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (gvsales.Rows.Count == 0)
                {
                    MessageBox.Show("Enter Some Item First !!");
                }
                else
                { 
                    SDT = SAdapter.SelectBy_PNAME(txtpname.Text);


                        for (int i = 0; i < SDT.Rows.Count; i++)
                        {
                            int sout = SOutAdapter.Insert(txtpname.Text, SDT.Rows[i]["IName"].ToString(), Convert.ToInt32(SDT.Rows[i]["Quantity"].ToString()), Convert.ToDouble(SDT.Rows[i]["Price"].ToString()), Convert.ToDouble(SDT.Rows[i]["TPrice"].ToString()), 0, System.DateTime.Now.Date);
                            StockAdapter.StockMst_SELL_Update_Quantity(Convert.ToInt32(SDT.Rows[i]["Quantity"].ToString()), Convert.ToDouble(SDT.Rows[i]["TPrice"].ToString()),SDT.Rows[i]["IName"].ToString());
                        }

                        int del = SAdapter.Delete();

                        MessageBox.Show("Your Order has been Submitted !!", "Medical System");
                        
                        gvsales.DataSource= null;
                }
                gpdispatch.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure !! You want to Cancel this Order !!", "Medical system", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int del = SAdapter.Delete();
                gpdispatch.Visible = false;

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtiname.Text != "")
            {
                //int xiqnt = Convert.ToInt32(SDT.Rows[0]["Quantity"].ToString());
                label8.Text = txtiname.Text;
                StockDT = StockAdapter.SelectBY_INAME(txtiname.Text);
                IDT = IAdapter.SelectByINmae(txtiname.Text);
                if (StockDT.Rows.Count > 0)
                {
                    if (StockDT.Rows[0]["AvailableQuantity"].ToString() == "0")
                    {
                        MessageBox.Show("No Enought Quantity !!", "Medical System");
                    }
                    else
                    {

                        SDT = SAdapter.SelectBY_NAME(txtiname.Text);
                        if (SDT.Rows.Count > 0)
                        {
                            int quentity = Convert.ToInt32(txtq.Text);
                            SDT = SAdapter.SelectBY_NAME(txtiname.Text);

                            int exiqnt = Convert.ToInt32(SDT.Rows[0]["Quantity"].ToString());
                            if (Convert.ToInt32(StockDT.Rows[0]["AvailableQuantity"].ToString()) > exiqnt)
                            {
                                int QNT = Convert.ToInt32(SDT.Rows[0]["Quantity"].ToString() + quentity);
                                double TPRICE = Convert.ToInt32(SDT.Rows[0]["Price"].ToString()) * QNT;
                                int existsalseupdate = SAdapter.Update(txtiname.Text, QNT.ToString(), TPRICE);

                            }
                            else
                            {
                                MessageBox.Show("No Enought Quantity", "Medical system");
                            }

                        }
                        else
                        {
                            lblq.Text = StockDT.Rows[0]["AvailableQuantity"].ToString();
                            lblp.Text = IDT.Rows[0]["I_Price"].ToString();
                            lbll.Text = IDT.Rows[0]["I_location"].ToString();
                            txtq.Text = "2";
                            double tprice = Convert.ToDouble(IDT.Rows[0]["I_Price"].ToString());
                            int abc = Convert.ToInt32(qnnt.Text);
                            double total = tprice * abc;
                            int salinst = SAdapter.Insert(txtpname.Text, txtiname.Text, total, abc, total);
                        }
                        SDT = SAdapter.SelectBy_PNAME(txtpname.Text);
                        gpdispatch.Visible = true;
                        gvsales.AutoGenerateColumns = false;
                        gvsales.DataSource = SDT;
                        SUMDT = SUMAdapter.SelectTotla();
                        lblqnt.Text = SUMDT.Rows[0]["qnt"].ToString();
                        lbltprice.Text = SUMDT.Rows[0]["Tprice"].ToString();

                    }
                    gpdispatch.Visible = true;
                }
                else
                {
                    MessageBox.Show("Item Not Available !!", "Medical System");
                }
            }
            //  txtiname.Text = "";
            // txtiname.Focus();
        }
    }
}
