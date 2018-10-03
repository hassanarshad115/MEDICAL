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
    public partial class SellReport : Form
    {
        //DS.DS_STOCK.StockMst_SelectDataTable SDT = new DS.DS_STOCK.StockMst_SelectDataTable();
        //DS.DS_STOCKTableAdapters.StockMst_SelectTableAdapter SAdapter = new DS.DS_STOCKTableAdapters.StockMst_SelectTableAdapter();
        //DS.DS_ITEM.StockInMst_SelectDataTable IDT = new MEDICAL.DS.DS_ITEM.StockInMst_SelectDataTable();
        //DS.DS_ITEMTableAdapters.StockInMst_SelectTableAdapter IAdapter = new MEDICAL.DS.DS_ITEMTableAdapters.StockInMst_SelectTableAdapter();

        DS.DS_CLIENT.ClientMst_SelectDataTable CDT = new DS.DS_CLIENT.ClientMst_SelectDataTable();
        DS.DS_CLIENTTableAdapters.ClientMst_SelectTableAdapter CAdapter = new DS.DS_CLIENTTableAdapters.ClientMst_SelectTableAdapter();

        DS.DS_SOUT.StockOutMst_SelectDataTable SOotDT = new MEDICAL.DS.DS_SOUT.StockOutMst_SelectDataTable();
        DS.DS_SOUTTableAdapters.StockOutMst_SelectTableAdapter SOutAdapter = new MEDICAL.DS.DS_SOUTTableAdapters.StockOutMst_SelectTableAdapter();
        public SellReport()
        {
            InitializeComponent();
        }

        private void SellReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mEDICALDataSet1.StockOutMst' table. You can move, or remove it, as needed.
            this.stockOutMstTableAdapter.Fill(this.mEDICALDataSet1.StockOutMst);


            SqlConnection con = new SqlConnection("Data Source='DESKTOP-2D42C0P';Integrated Security='true';Initial Catalog='MEDICAL'");
            SqlCommand cmd = new SqlCommand("SELECT I_name FROM StockOutMst", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            AutoCompleteStringCollection SCollection = new AutoCompleteStringCollection();
            while (reader.Read())
            {
                SCollection.Add(reader.GetString(0));
            }
            txtiname.AutoCompleteCustomSource = SCollection;
            con.Close();

            SqlCommand cmdd = new SqlCommand("SELECT cu_name FROM clientmst", con);
            con.Open();
            SqlDataReader readerr = cmdd.ExecuteReader();
            AutoCompleteStringCollection SCollectionn = new AutoCompleteStringCollection();
            while (readerr.Read())
            {
                SCollectionn.Add(readerr.GetString(0));
            }
            txtcname.AutoCompleteCustomSource = SCollectionn;
            con.Close();
        }

        private void btncustsearch_Click(object sender, EventArgs e)
        {
            txtiname.Text = "";
            SOotDT = SOutAdapter.Select_by_Iname(txtcname.Text);
            GVReports.DataSource = SOotDT;
        }

        private void btnitemsearch_Click(object sender, EventArgs e)
        {
            txtcname.Text = "";
            SOotDT = SOutAdapter.Select_by_Clintname(txtiname.Text);
            GVReports.DataSource = SOotDT;
        }
    }
}
