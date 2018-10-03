using System.Windows.Forms;

namespace MEDICAL
{
    partial class ADDItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateexpire = new System.Windows.Forms.DateTimePicker();
            this.txtlocation = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbdompany = new System.Windows.Forms.ComboBox();
            this.txtiprice = new System.Windows.Forms.TextBox();
            this.txtiqnt = new System.Windows.Forms.TextBox();
            this.txtidetail = new System.Windows.Forms.TextBox();
            this.txtiname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.txtcurentqnt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtnewqnt = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDescripDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iExDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewDeleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.stockInMstBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mEDICALDataSet = new MEDICAL.MEDICALDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.stockInMstTableAdapter = new MEDICAL.MEDICALDataSetTableAdapters.StockInMstTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockInMstBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICALDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateexpire);
            this.groupBox1.Controls.Add(this.txtlocation);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cmbdompany);
            this.groupBox1.Controls.Add(this.txtiprice);
            this.groupBox1.Controls.Add(this.txtiqnt);
            this.groupBox1.Controls.Add(this.txtidetail);
            this.groupBox1.Controls.Add(this.txtiname);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(102, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1139, 146);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADD Stock";
            // 
            // dateexpire
            // 
            this.dateexpire.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateexpire.Location = new System.Drawing.Point(155, 110);
            this.dateexpire.Name = "dateexpire";
            this.dateexpire.Size = new System.Drawing.Size(160, 24);
            this.dateexpire.TabIndex = 11;
            // 
            // txtlocation
            // 
            this.txtlocation.BackColor = System.Drawing.Color.Honeydew;
            this.txtlocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlocation.Location = new System.Drawing.Point(511, 60);
            this.txtlocation.Name = "txtlocation";
            this.txtlocation.Size = new System.Drawing.Size(167, 24);
            this.txtlocation.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(23, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 19);
            this.label12.TabIndex = 13;
            this.label12.Text = "Expire Date :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(396, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 19);
            this.label11.TabIndex = 12;
            this.label11.Text = "Location :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(511, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 33);
            this.button1.TabIndex = 12;
            this.button1.Text = "ADD STOCK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbdompany
            // 
            this.cmbdompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbdompany.FormattingEnabled = true;
            this.cmbdompany.Location = new System.Drawing.Point(878, 62);
            this.cmbdompany.Name = "cmbdompany";
            this.cmbdompany.Size = new System.Drawing.Size(180, 26);
            this.cmbdompany.TabIndex = 9;
            // 
            // txtiprice
            // 
            this.txtiprice.BackColor = System.Drawing.Color.Honeydew;
            this.txtiprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtiprice.Location = new System.Drawing.Point(155, 67);
            this.txtiprice.Name = "txtiprice";
            this.txtiprice.Size = new System.Drawing.Size(160, 24);
            this.txtiprice.TabIndex = 7;
            // 
            // txtiqnt
            // 
            this.txtiqnt.BackColor = System.Drawing.Color.Honeydew;
            this.txtiqnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtiqnt.Location = new System.Drawing.Point(878, 27);
            this.txtiqnt.Name = "txtiqnt";
            this.txtiqnt.Size = new System.Drawing.Size(180, 24);
            this.txtiqnt.TabIndex = 8;
            // 
            // txtidetail
            // 
            this.txtidetail.BackColor = System.Drawing.Color.Honeydew;
            this.txtidetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidetail.Location = new System.Drawing.Point(511, 24);
            this.txtidetail.Name = "txtidetail";
            this.txtidetail.Size = new System.Drawing.Size(167, 24);
            this.txtidetail.TabIndex = 6;
            // 
            // txtiname
            // 
            this.txtiname.BackColor = System.Drawing.Color.Honeydew;
            this.txtiname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtiname.Location = new System.Drawing.Point(155, 28);
            this.txtiname.Name = "txtiname";
            this.txtiname.Size = new System.Drawing.Size(160, 24);
            this.txtiname.TabIndex = 5;
            this.txtiname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtiname_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(728, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 19);
            this.label10.TabIndex = 4;
            this.label10.Text = "Company Name :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(776, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 19);
            this.label9.TabIndex = 3;
            this.label9.Text = "Qauntity :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(32, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 19);
            this.label8.TabIndex = 2;
            this.label8.Text = "Item Price :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(386, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Item Detail :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(32, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Item Name :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.txtcurentqnt);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.txtnewqnt);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Location = new System.Drawing.Point(102, 515);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1139, 112);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Stock";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(298, 68);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 30);
            this.button4.TabIndex = 13;
            this.button4.Text = "Select";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtcurentqnt
            // 
            this.txtcurentqnt.BackColor = System.Drawing.Color.Honeydew;
            this.txtcurentqnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcurentqnt.Location = new System.Drawing.Point(114, 73);
            this.txtcurentqnt.Name = "txtcurentqnt";
            this.txtcurentqnt.ReadOnly = true;
            this.txtcurentqnt.Size = new System.Drawing.Size(168, 24);
            this.txtcurentqnt.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(9, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 19);
            this.label13.TabIndex = 13;
            this.label13.Text = "Current Qnt :";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(114, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 26);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(400, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 34);
            this.button2.TabIndex = 16;
            this.button2.Text = "UPDATE STOCK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtnewqnt
            // 
            this.txtnewqnt.BackColor = System.Drawing.Color.Honeydew;
            this.txtnewqnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnewqnt.Location = new System.Drawing.Point(400, 30);
            this.txtnewqnt.Name = "txtnewqnt";
            this.txtnewqnt.Size = new System.Drawing.Size(168, 24);
            this.txtnewqnt.TabIndex = 15;
            this.txtnewqnt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnewqnt_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label16.Location = new System.Drawing.Point(296, 33);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 19);
            this.label16.TabIndex = 3;
            this.label16.Text = "Qauntity :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label19.Location = new System.Drawing.Point(16, 30);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(92, 19);
            this.label19.TabIndex = 0;
            this.label19.Text = "Item Name :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Location = new System.Drawing.Point(878, 521);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(363, 106);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delete Stock";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(104, 24);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(185, 26);
            this.comboBox2.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(104, 58);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 37);
            this.button3.TabIndex = 13;
            this.button3.Text = "DELETE STOCK";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label17.Location = new System.Drawing.Point(6, 24);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 19);
            this.label17.TabIndex = 0;
            this.label17.Text = "Item Name :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(102, 173);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1139, 342);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "View Stock";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iIdDataGridViewTextBoxColumn,
            this.iNameDataGridViewTextBoxColumn,
            this.iDescripDataGridViewTextBoxColumn,
            this.iQuantityDataGridViewTextBoxColumn,
            this.iPriceDataGridViewTextBoxColumn,
            this.cNameDataGridViewTextBoxColumn,
            this.iExDateDataGridViewTextBoxColumn,
            this.iLocationDataGridViewTextBoxColumn,
            this.dataGridViewDeleteButton});
            this.dataGridView1.DataSource = this.stockInMstBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkSeaGreen;
            this.dataGridView1.Location = new System.Drawing.Point(101, 19);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Purple;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.Size = new System.Drawing.Size(944, 311);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iIdDataGridViewTextBoxColumn
            // 
            this.iIdDataGridViewTextBoxColumn.DataPropertyName = "I_Id";
            this.iIdDataGridViewTextBoxColumn.HeaderText = "I_Id";
            this.iIdDataGridViewTextBoxColumn.Name = "iIdDataGridViewTextBoxColumn";
            this.iIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iNameDataGridViewTextBoxColumn
            // 
            this.iNameDataGridViewTextBoxColumn.DataPropertyName = "I_Name";
            this.iNameDataGridViewTextBoxColumn.HeaderText = "I_Name";
            this.iNameDataGridViewTextBoxColumn.Name = "iNameDataGridViewTextBoxColumn";
            // 
            // iDescripDataGridViewTextBoxColumn
            // 
            this.iDescripDataGridViewTextBoxColumn.DataPropertyName = "I_Descrip";
            this.iDescripDataGridViewTextBoxColumn.HeaderText = "I_Descrip";
            this.iDescripDataGridViewTextBoxColumn.Name = "iDescripDataGridViewTextBoxColumn";
            // 
            // iQuantityDataGridViewTextBoxColumn
            // 
            this.iQuantityDataGridViewTextBoxColumn.DataPropertyName = "I_Quantity";
            this.iQuantityDataGridViewTextBoxColumn.HeaderText = "I_Quantity";
            this.iQuantityDataGridViewTextBoxColumn.Name = "iQuantityDataGridViewTextBoxColumn";
            // 
            // iPriceDataGridViewTextBoxColumn
            // 
            this.iPriceDataGridViewTextBoxColumn.DataPropertyName = "I_Price";
            this.iPriceDataGridViewTextBoxColumn.HeaderText = "I_Price";
            this.iPriceDataGridViewTextBoxColumn.Name = "iPriceDataGridViewTextBoxColumn";
            // 
            // cNameDataGridViewTextBoxColumn
            // 
            this.cNameDataGridViewTextBoxColumn.DataPropertyName = "C_Name";
            this.cNameDataGridViewTextBoxColumn.HeaderText = "C_Name";
            this.cNameDataGridViewTextBoxColumn.Name = "cNameDataGridViewTextBoxColumn";
            // 
            // iExDateDataGridViewTextBoxColumn
            // 
            this.iExDateDataGridViewTextBoxColumn.DataPropertyName = "I_Ex_Date";
            this.iExDateDataGridViewTextBoxColumn.HeaderText = "I_Ex_Date";
            this.iExDateDataGridViewTextBoxColumn.Name = "iExDateDataGridViewTextBoxColumn";
            // 
            // iLocationDataGridViewTextBoxColumn
            // 
            this.iLocationDataGridViewTextBoxColumn.DataPropertyName = "I_Location";
            this.iLocationDataGridViewTextBoxColumn.HeaderText = "I_Location";
            this.iLocationDataGridViewTextBoxColumn.Name = "iLocationDataGridViewTextBoxColumn";
            // 
            // dataGridViewDeleteButton
            // 
            this.dataGridViewDeleteButton.HeaderText = "Delete";
            this.dataGridViewDeleteButton.Name = "dataGridViewDeleteButton";
            this.dataGridViewDeleteButton.Text = "Delete";
            this.dataGridViewDeleteButton.UseColumnTextForButtonValue = true;
            // 
            // stockInMstBindingSource
            // 
            this.stockInMstBindingSource.DataMember = "StockInMst";
            this.stockInMstBindingSource.DataSource = this.mEDICALDataSet;
            // 
            // mEDICALDataSet
            // 
            this.mEDICALDataSet.DataSetName = "MEDICALDataSet";
            this.mEDICALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(132, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(871, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "ADD / UPDATE / DELETE STOCK HERE !!";
            // 
            // stockInMstTableAdapter
            // 
            this.stockInMstTableAdapter.ClearBeforeFill = true;
            // 
            // ADDItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1225, 742);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "ADDItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ADDItem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ADDItem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockInMstBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICALDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbdompany;
        private System.Windows.Forms.TextBox txtiprice;
        private System.Windows.Forms.TextBox txtiqnt;
        private System.Windows.Forms.TextBox txtidetail;
        private System.Windows.Forms.TextBox txtiname;
        private System.Windows.Forms.DateTimePicker dateexpire;
        private System.Windows.Forms.TextBox txtlocation;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtcurentqnt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtnewqnt;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private MEDICALDataSet mEDICALDataSet;
        private System.Windows.Forms.BindingSource stockInMstBindingSource;
        private MEDICALDataSetTableAdapters.StockInMstTableAdapter stockInMstTableAdapter;
        private DataGridViewTextBoxColumn iIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iDescripDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iQuantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iExDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iLocationDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn dataGridViewDeleteButton;
    }
}