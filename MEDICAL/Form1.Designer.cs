namespace MEDICAL
{
    partial class Form1
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hOMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menulogout = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sELLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOMPANYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDNEWToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETEToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTSToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIENTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDNEWToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETEToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.vIEWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalStockReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mANAGEUSERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDNEWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTSToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cHNAEGPASSWORDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblname = new System.Windows.Forms.Label();
            this.gplogin = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtname = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.gplogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hOMEToolStripMenuItem,
            this.mENUToolStripMenuItem,
            this.sELLToolStripMenuItem,
            this.cOMPANYToolStripMenuItem,
            this.cLIENTSToolStripMenuItem,
            this.rEPORTSToolStripMenuItem,
            this.mANAGEUSERToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1284, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hOMEToolStripMenuItem
            // 
            this.hOMEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menulogout,
            this.eXITToolStripMenuItem});
            this.hOMEToolStripMenuItem.Name = "hOMEToolStripMenuItem";
            this.hOMEToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.hOMEToolStripMenuItem.Text = "HOME";
            // 
            // menulogout
            // 
            this.menulogout.Name = "menulogout";
            this.menulogout.Size = new System.Drawing.Size(121, 22);
            this.menulogout.Text = "LOGOUT";
            this.menulogout.Visible = false;
            this.menulogout.Click += new System.EventHandler(this.menulogout_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // mENUToolStripMenuItem
            // 
            this.mENUToolStripMenuItem.Enabled = false;
            this.mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            this.mENUToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.mENUToolStripMenuItem.Text = "STOCK";
            this.mENUToolStripMenuItem.Click += new System.EventHandler(this.repotsToolStripMenuItem_Click);
            // 
            // sELLToolStripMenuItem
            // 
            this.sELLToolStripMenuItem.Enabled = false;
            this.sELLToolStripMenuItem.Name = "sELLToolStripMenuItem";
            this.sELLToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.sELLToolStripMenuItem.Text = "SELL";
            this.sELLToolStripMenuItem.Click += new System.EventHandler(this.sELLToolStripMenuItem_Click);
            // 
            // cOMPANYToolStripMenuItem
            // 
            this.cOMPANYToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDNEWToolStripMenuItem1,
            this.dELETEToolStripMenuItem1,
            this.rEPORTSToolStripMenuItem2});
            this.cOMPANYToolStripMenuItem.Enabled = false;
            this.cOMPANYToolStripMenuItem.Name = "cOMPANYToolStripMenuItem";
            this.cOMPANYToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.cOMPANYToolStripMenuItem.Text = "COMPANY";
            // 
            // aDDNEWToolStripMenuItem1
            // 
            this.aDDNEWToolStripMenuItem1.Name = "aDDNEWToolStripMenuItem1";
            this.aDDNEWToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.aDDNEWToolStripMenuItem1.Text = "ADD NEW";
            this.aDDNEWToolStripMenuItem1.Click += new System.EventHandler(this.aDDNEWToolStripMenuItem1_Click);
            // 
            // dELETEToolStripMenuItem1
            // 
            this.dELETEToolStripMenuItem1.Name = "dELETEToolStripMenuItem1";
            this.dELETEToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.dELETEToolStripMenuItem1.Text = "DELETE";
            this.dELETEToolStripMenuItem1.Click += new System.EventHandler(this.dELETEToolStripMenuItem1_Click);
            // 
            // rEPORTSToolStripMenuItem2
            // 
            this.rEPORTSToolStripMenuItem2.Name = "rEPORTSToolStripMenuItem2";
            this.rEPORTSToolStripMenuItem2.Size = new System.Drawing.Size(127, 22);
            this.rEPORTSToolStripMenuItem2.Text = "REPORTS";
            this.rEPORTSToolStripMenuItem2.Click += new System.EventHandler(this.rEPORTSToolStripMenuItem2_Click);
            // 
            // cLIENTSToolStripMenuItem
            // 
            this.cLIENTSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDNEWToolStripMenuItem2,
            this.dELETEToolStripMenuItem2,
            this.vIEWToolStripMenuItem});
            this.cLIENTSToolStripMenuItem.Enabled = false;
            this.cLIENTSToolStripMenuItem.Name = "cLIENTSToolStripMenuItem";
            this.cLIENTSToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.cLIENTSToolStripMenuItem.Text = "CLIENTS";
            // 
            // aDDNEWToolStripMenuItem2
            // 
            this.aDDNEWToolStripMenuItem2.Name = "aDDNEWToolStripMenuItem2";
            this.aDDNEWToolStripMenuItem2.Size = new System.Drawing.Size(127, 22);
            this.aDDNEWToolStripMenuItem2.Text = "ADD NEW";
            this.aDDNEWToolStripMenuItem2.Click += new System.EventHandler(this.aDDNEWToolStripMenuItem2_Click);
            // 
            // dELETEToolStripMenuItem2
            // 
            this.dELETEToolStripMenuItem2.Name = "dELETEToolStripMenuItem2";
            this.dELETEToolStripMenuItem2.Size = new System.Drawing.Size(127, 22);
            this.dELETEToolStripMenuItem2.Text = "DELETE ";
            this.dELETEToolStripMenuItem2.Click += new System.EventHandler(this.dELETEToolStripMenuItem2_Click);
            // 
            // vIEWToolStripMenuItem
            // 
            this.vIEWToolStripMenuItem.Name = "vIEWToolStripMenuItem";
            this.vIEWToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.vIEWToolStripMenuItem.Text = "VIEW";
            this.vIEWToolStripMenuItem.Click += new System.EventHandler(this.vIEWToolStripMenuItem_Click);
            // 
            // rEPORTSToolStripMenuItem
            // 
            this.rEPORTSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockReportToolStripMenuItem,
            this.sellReportToolStripMenuItem,
            this.totalStockReportToolStripMenuItem});
            this.rEPORTSToolStripMenuItem.Enabled = false;
            this.rEPORTSToolStripMenuItem.Name = "rEPORTSToolStripMenuItem";
            this.rEPORTSToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.rEPORTSToolStripMenuItem.Text = "REPORTS";
            // 
            // stockReportToolStripMenuItem
            // 
            this.stockReportToolStripMenuItem.Name = "stockReportToolStripMenuItem";
            this.stockReportToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.stockReportToolStripMenuItem.Text = "StockIn Report";
            this.stockReportToolStripMenuItem.Click += new System.EventHandler(this.stockReportToolStripMenuItem_Click);
            // 
            // sellReportToolStripMenuItem
            // 
            this.sellReportToolStripMenuItem.Name = "sellReportToolStripMenuItem";
            this.sellReportToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.sellReportToolStripMenuItem.Text = "Sales Report";
            this.sellReportToolStripMenuItem.Click += new System.EventHandler(this.sellReportToolStripMenuItem_Click);
            // 
            // totalStockReportToolStripMenuItem
            // 
            this.totalStockReportToolStripMenuItem.Name = "totalStockReportToolStripMenuItem";
            this.totalStockReportToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.totalStockReportToolStripMenuItem.Text = "Total Stock Report";
            this.totalStockReportToolStripMenuItem.Click += new System.EventHandler(this.totalStockReportToolStripMenuItem_Click);
            // 
            // mANAGEUSERToolStripMenuItem
            // 
            this.mANAGEUSERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDNEWToolStripMenuItem,
            this.dELETEToolStripMenuItem,
            this.rEPORTSToolStripMenuItem1,
            this.cHNAEGPASSWORDToolStripMenuItem});
            this.mANAGEUSERToolStripMenuItem.Enabled = false;
            this.mANAGEUSERToolStripMenuItem.Name = "mANAGEUSERToolStripMenuItem";
            this.mANAGEUSERToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.mANAGEUSERToolStripMenuItem.Text = "MANAGE USER";
            // 
            // aDDNEWToolStripMenuItem
            // 
            this.aDDNEWToolStripMenuItem.Name = "aDDNEWToolStripMenuItem";
            this.aDDNEWToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.aDDNEWToolStripMenuItem.Text = "ADD NEW";
            this.aDDNEWToolStripMenuItem.Click += new System.EventHandler(this.aDDNEWToolStripMenuItem_Click);
            // 
            // dELETEToolStripMenuItem
            // 
            this.dELETEToolStripMenuItem.Name = "dELETEToolStripMenuItem";
            this.dELETEToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.dELETEToolStripMenuItem.Text = "DELETE";
            this.dELETEToolStripMenuItem.Click += new System.EventHandler(this.dELETEToolStripMenuItem_Click);
            // 
            // rEPORTSToolStripMenuItem1
            // 
            this.rEPORTSToolStripMenuItem1.Name = "rEPORTSToolStripMenuItem1";
            this.rEPORTSToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.rEPORTSToolStripMenuItem1.Text = "REPORTS";
            this.rEPORTSToolStripMenuItem1.Click += new System.EventHandler(this.rEPORTSToolStripMenuItem1_Click);
            // 
            // cHNAEGPASSWORDToolStripMenuItem
            // 
            this.cHNAEGPASSWORDToolStripMenuItem.Name = "cHNAEGPASSWORDToolStripMenuItem";
            this.cHNAEGPASSWORDToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.cHNAEGPASSWORDToolStripMenuItem.Text = "CHNAEG PASSWORD";
            this.cHNAEGPASSWORDToolStripMenuItem.Click += new System.EventHandler(this.cHNAEGPASSWORDToolStripMenuItem_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblname.Location = new System.Drawing.Point(1078, 119);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(0, 20);
            this.lblname.TabIndex = 23;
            // 
            // gplogin
            // 
            this.gplogin.BackColor = System.Drawing.Color.White;
            this.gplogin.BackgroundImage = global::MEDICAL.Properties.Resources.signin_bg_3;
            this.gplogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gplogin.Controls.Add(this.checkBox1);
            this.gplogin.Controls.Add(this.txtpass);
            this.gplogin.Controls.Add(this.label3);
            this.gplogin.Controls.Add(this.btnlogin);
            this.gplogin.Controls.Add(this.panel1);
            this.gplogin.Controls.Add(this.txtname);
            this.gplogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gplogin.ForeColor = System.Drawing.Color.White;
            this.gplogin.Location = new System.Drawing.Point(338, 177);
            this.gplogin.Name = "gplogin";
            this.gplogin.Size = new System.Drawing.Size(635, 350);
            this.gplogin.TabIndex = 16;
            this.gplogin.TabStop = false;
            this.gplogin.Text = "Login";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Location = new System.Drawing.Point(315, 229);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(130, 21);
            this.checkBox1.TabIndex = 58;
            this.checkBox1.Text = "Remember Me";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.Honeydew;
            this.txtpass.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(315, 187);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(252, 26);
            this.txtpass.TabIndex = 2;
            this.txtpass.Text = "Password";
            this.txtpass.UseSystemPasswordChar = true;
            this.txtpass.Enter += new System.EventHandler(this.txtpass_Enter);
            this.txtpass.Leave += new System.EventHandler(this.txtpass_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Forte", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(255, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 38);
            this.label3.TabIndex = 57;
            this.label3.Text = "WELCOME";
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.Honeydew;
            this.btnlogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnlogin.Image = global::MEDICAL.Properties.Resources._2000px_Signin_font_awesome1;
            this.btnlogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogin.Location = new System.Drawing.Point(374, 274);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(115, 38);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::MEDICAL.Properties.Resources.orange_open_lock_icon_30702;
            this.panel1.Location = new System.Drawing.Point(49, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 230);
            this.panel1.TabIndex = 25;
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.Honeydew;
            this.txtname.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(315, 144);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(252, 26);
            this.txtname.TabIndex = 2;
            this.txtname.Text = "User Name";
            this.txtname.Enter += new System.EventHandler(this.txtname_Enter);
            this.txtname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtname_KeyPress);
            this.txtname.Leave += new System.EventHandler(this.txtname_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1284, 438);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.gplogin);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gplogin.ResumeLayout(false);
            this.gplogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hOMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menulogout;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.GroupBox gplogin;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.ToolStripMenuItem sELLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLIENTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEPORTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mANAGEUSERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDNEWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dELETEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEPORTSToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cHNAEGPASSWORDToolStripMenuItem;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.ToolStripMenuItem cOMPANYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDNEWToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dELETEToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rEPORTSToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aDDNEWToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem dELETEToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem vIEWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalStockReportToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
    }
}

