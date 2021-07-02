namespace QL_NHAHANG
{
    partial class frmThuNgan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThuNgan));
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.ribQL_Mon = new System.Windows.Forms.RibbonTab();
            this.riboQL_Mon = new System.Windows.Forms.RibbonPanel();
            this.btnQL_Mon = new System.Windows.Forms.RibbonButton();
            this.ribBanAn = new System.Windows.Forms.RibbonTab();
            this.ribOrder = new System.Windows.Forms.RibbonPanel();
            this.btnOrder = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.btnThemBan = new System.Windows.Forms.RibbonButton();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribLoiNhuan = new System.Windows.Forms.RibbonPanel();
            this.btnLoiNhuan = new System.Windows.Forms.RibbonButton();
            this.ribTienBan = new System.Windows.Forms.RibbonPanel();
            this.btnTienBan = new System.Windows.Forms.RibbonButton();
            this.ribbonButton2 = new System.Windows.Forms.RibbonButton();
            this.ribLienHe = new System.Windows.Forms.RibbonTab();
            this.ribLienHeTN = new System.Windows.Forms.RibbonPanel();
            this.btnLienHeTN = new System.Windows.Forms.RibbonButton();
            this.btnLienHe = new System.Windows.Forms.RibbonButton();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.riboDangXuat = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.btnDangXuat = new System.Windows.Forms.RibbonButton();
            this.tabThuNgan = new MdiTabControl.TabControl();
            this.SuspendLayout();
            // 
            // ribbon1
            // 
            this.ribbon1.BackColor = System.Drawing.Color.Azure;
            this.ribbon1.CaptionBarVisible = false;
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 72);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2010_Extended;
            this.ribbon1.OrbText = "Thu Ngân";
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(1591, 130);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.ribQL_Mon);
            this.ribbon1.Tabs.Add(this.ribBanAn);
            this.ribbon1.Tabs.Add(this.ribbonTab1);
            this.ribbon1.Tabs.Add(this.ribLienHe);
            this.ribbon1.Tabs.Add(this.riboDangXuat);
            this.ribbon1.TabSpacing = 3;
            this.ribbon1.Text = "ribbon1";
            // 
            // ribQL_Mon
            // 
            this.ribQL_Mon.Name = "ribQL_Mon";
            this.ribQL_Mon.Panels.Add(this.riboQL_Mon);
            this.ribQL_Mon.Text = "QL_Món";
            // 
            // riboQL_Mon
            // 
            this.riboQL_Mon.Items.Add(this.btnQL_Mon);
            this.riboQL_Mon.Name = "riboQL_Mon";
            this.riboQL_Mon.Text = "QL_Món";
            this.riboQL_Mon.Click += new System.EventHandler(this.riboQL_Mon_Click);
            // 
            // btnQL_Mon
            // 
            this.btnQL_Mon.Image = global::QL_NHAHANG.Properties.Resources.breakfast__1_1;
            this.btnQL_Mon.LargeImage = global::QL_NHAHANG.Properties.Resources.breakfast__1_1;
            this.btnQL_Mon.Name = "btnQL_Mon";
            this.btnQL_Mon.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnQL_Mon.SmallImage")));
            this.btnQL_Mon.Text = "";
            // 
            // ribBanAn
            // 
            this.ribBanAn.Name = "ribBanAn";
            this.ribBanAn.Panels.Add(this.ribOrder);
            this.ribBanAn.Panels.Add(this.ribbonPanel2);
            this.ribBanAn.Text = "QL_Bàn Ăn";
            // 
            // ribOrder
            // 
            this.ribOrder.Items.Add(this.btnOrder);
            this.ribOrder.Name = "ribOrder";
            this.ribOrder.Text = "Order";
            // 
            // btnOrder
            // 
            this.btnOrder.Image = global::QL_NHAHANG.Properties.Resources.food_serving__1_1;
            this.btnOrder.LargeImage = global::QL_NHAHANG.Properties.Resources.food_serving__1_1;
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnOrder.SmallImage")));
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Items.Add(this.btnThemBan);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Text = "Thêm Bàn";
            // 
            // btnThemBan
            // 
            this.btnThemBan.Image = global::QL_NHAHANG.Properties.Resources.plus2;
            this.btnThemBan.LargeImage = global::QL_NHAHANG.Properties.Resources.plus2;
            this.btnThemBan.Name = "btnThemBan";
            this.btnThemBan.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnThemBan.SmallImage")));
            this.btnThemBan.Text = "";
            this.btnThemBan.Click += new System.EventHandler(this.btnThemBan_Click);
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Panels.Add(this.ribLoiNhuan);
            this.ribbonTab1.Panels.Add(this.ribTienBan);
            this.ribbonTab1.Text = "QL_Doanh Thu";
            // 
            // ribLoiNhuan
            // 
            this.ribLoiNhuan.Items.Add(this.btnLoiNhuan);
            this.ribLoiNhuan.Name = "ribLoiNhuan";
            this.ribLoiNhuan.Text = "Lợi Nhuận";
            // 
            // btnLoiNhuan
            // 
            this.btnLoiNhuan.Image = global::QL_NHAHANG.Properties.Resources.money_bag__1_1;
            this.btnLoiNhuan.LargeImage = global::QL_NHAHANG.Properties.Resources.money_bag__1_1;
            this.btnLoiNhuan.Name = "btnLoiNhuan";
            this.btnLoiNhuan.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnLoiNhuan.SmallImage")));
            // 
            // ribTienBan
            // 
            this.ribTienBan.Items.Add(this.btnTienBan);
            this.ribTienBan.Name = "ribTienBan";
            this.ribTienBan.Text = "Tiền Bán";
            // 
            // btnTienBan
            // 
            this.btnTienBan.DropDownItems.Add(this.ribbonButton2);
            this.btnTienBan.Image = global::QL_NHAHANG.Properties.Resources.money_bag2;
            this.btnTienBan.LargeImage = global::QL_NHAHANG.Properties.Resources.money_bag2;
            this.btnTienBan.Name = "btnTienBan";
            this.btnTienBan.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnTienBan.SmallImage")));
            this.btnTienBan.Click += new System.EventHandler(this.btnTienBan_Click);
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.Image = global::QL_NHAHANG.Properties.Resources.money_bag;
            this.ribbonButton2.LargeImage = global::QL_NHAHANG.Properties.Resources.money_bag;
            this.ribbonButton2.Name = "ribbonButton2";
            this.ribbonButton2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.SmallImage")));
            // 
            // ribLienHe
            // 
            this.ribLienHe.Name = "ribLienHe";
            this.ribLienHe.Panels.Add(this.ribLienHeTN);
            this.ribLienHe.Text = "Liên Hệ";
            // 
            // ribLienHeTN
            // 
            this.ribLienHeTN.Items.Add(this.btnLienHeTN);
            this.ribLienHeTN.Name = "ribLienHeTN";
            this.ribLienHeTN.Text = "Liên Hệ";
            // 
            // btnLienHeTN
            // 
            this.btnLienHeTN.DropDownItems.Add(this.btnLienHe);
            this.btnLienHeTN.Image = global::QL_NHAHANG.Properties.Resources.admin__2_;
            this.btnLienHeTN.LargeImage = global::QL_NHAHANG.Properties.Resources.admin__2_;
            this.btnLienHeTN.Name = "btnLienHeTN";
            this.btnLienHeTN.SmallImage = global::QL_NHAHANG.Properties.Resources.communicate1;
            this.btnLienHeTN.Click += new System.EventHandler(this.btnLienHeTN_Click);
            // 
            // btnLienHe
            // 
            this.btnLienHe.DropDownItems.Add(this.ribbonButton1);
            this.btnLienHe.Image = global::QL_NHAHANG.Properties.Resources.communicate;
            this.btnLienHe.LargeImage = global::QL_NHAHANG.Properties.Resources.communicate;
            this.btnLienHe.Name = "btnLienHe";
            this.btnLienHe.SmallImage = global::QL_NHAHANG.Properties.Resources.communicate1;
            this.btnLienHe.Text = "Liên Hệ";
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.Image = global::QL_NHAHANG.Properties.Resources.communicate;
            this.ribbonButton1.LargeImage = global::QL_NHAHANG.Properties.Resources.communicate;
            this.ribbonButton1.Name = "ribbonButton1";
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            // 
            // riboDangXuat
            // 
            this.riboDangXuat.Name = "riboDangXuat";
            this.riboDangXuat.Panels.Add(this.ribbonPanel1);
            this.riboDangXuat.Text = "Đăng Xuất";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Items.Add(this.btnDangXuat);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Text = "Đăng Xuất";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Image = global::QL_NHAHANG.Properties.Resources.log_out3;
            this.btnDangXuat.LargeImage = global::QL_NHAHANG.Properties.Resources.log_out3;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.SmallImage = global::QL_NHAHANG.Properties.Resources.log_out2;
            this.btnDangXuat.Text = "";
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // tabThuNgan
            // 
            this.tabThuNgan.AutoSize = true;
            this.tabThuNgan.BackColor = System.Drawing.Color.MintCream;
            this.tabThuNgan.Location = new System.Drawing.Point(0, 107);
            this.tabThuNgan.MenuRenderer = null;
            this.tabThuNgan.Name = "tabThuNgan";
            this.tabThuNgan.Size = new System.Drawing.Size(1591, 780);
            this.tabThuNgan.TabCloseButtonImage = null;
            this.tabThuNgan.TabCloseButtonImageDisabled = null;
            this.tabThuNgan.TabCloseButtonImageHot = null;
            this.tabThuNgan.TabIndex = 4;
            this.tabThuNgan.Load += new System.EventHandler(this.tabThuNgan_Load);
            // 
            // frmThuNgan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1591, 749);
            this.Controls.Add(this.tabThuNgan);
            this.Controls.Add(this.ribbon1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmThuNgan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thu Ngân";
            this.Load += new System.EventHandler(this.frmThuNgan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab ribQL_Mon;
        private System.Windows.Forms.RibbonTab ribBanAn;
        private System.Windows.Forms.RibbonPanel ribOrder;
        private System.Windows.Forms.RibbonButton btnOrder;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonTab ribLienHe;
        private System.Windows.Forms.RibbonPanel ribLoiNhuan;
        private System.Windows.Forms.RibbonButton btnLoiNhuan;
        private System.Windows.Forms.RibbonPanel ribTienBan;
        private System.Windows.Forms.RibbonButton btnTienBan;
        private System.Windows.Forms.RibbonPanel ribLienHeTN;
        private System.Windows.Forms.RibbonButton btnLienHeTN;
        private System.Windows.Forms.RibbonButton btnLienHe;
        private System.Windows.Forms.RibbonButton ribbonButton1;
        private System.Windows.Forms.RibbonButton ribbonButton2;
        private MdiTabControl.TabControl tabThuNgan;
        private System.Windows.Forms.RibbonPanel riboQL_Mon;
        private System.Windows.Forms.RibbonButton btnQL_Mon;
        private System.Windows.Forms.RibbonTab riboDangXuat;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonButton btnDangXuat;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonButton btnThemBan;
    }
}