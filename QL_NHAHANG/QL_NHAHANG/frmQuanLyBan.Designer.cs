namespace QL_NHAHANG
{
    partial class frmQuanLyBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyBan));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenBan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.floDanhSachBan = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstvThongTinBan = new System.Windows.Forms.ListView();
            this.cboMon = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numSL = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnKhac = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnCom = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnNuocUong = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDoNuong = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnHap = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLau = new System.Windows.Forms.Button();
            this.grbChuyenBan = new System.Windows.Forms.GroupBox();
            this.btnChuyenBan = new System.Windows.Forms.Button();
            this.cboChuyenBan = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnOrder = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtThanhToan = new System.Windows.Forms.TextBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grbChuyenBan.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bàn bạn đang chọn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(1045, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Danh sách món";
            // 
            // txtTenBan
            // 
            this.txtTenBan.Location = new System.Drawing.Point(219, 24);
            this.txtTenBan.Name = "txtTenBan";
            this.txtTenBan.Size = new System.Drawing.Size(234, 30);
            this.txtTenBan.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(604, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 37);
            this.label4.TabIndex = 4;
            this.label4.Text = "Thông tin bàn ăn";
            // 
            // floDanhSachBan
            // 
            this.floDanhSachBan.AutoScroll = true;
            this.floDanhSachBan.Location = new System.Drawing.Point(1, 75);
            this.floDanhSachBan.Name = "floDanhSachBan";
            this.floDanhSachBan.Size = new System.Drawing.Size(597, 596);
            this.floDanhSachBan.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstvThongTinBan);
            this.panel1.Location = new System.Drawing.Point(608, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 390);
            this.panel1.TabIndex = 6;
            // 
            // lstvThongTinBan
            // 
            this.lstvThongTinBan.HideSelection = false;
            this.lstvThongTinBan.Location = new System.Drawing.Point(3, 0);
            this.lstvThongTinBan.Name = "lstvThongTinBan";
            this.lstvThongTinBan.Size = new System.Drawing.Size(422, 389);
            this.lstvThongTinBan.TabIndex = 0;
            this.lstvThongTinBan.UseCompatibleStateImageBehavior = false;
            this.lstvThongTinBan.SelectedIndexChanged += new System.EventHandler(this.lstvThongTinBan_SelectedIndexChanged);
            // 
            // cboMon
            // 
            this.cboMon.FormattingEnabled = true;
            this.cboMon.Location = new System.Drawing.Point(1188, 63);
            this.cboMon.Name = "cboMon";
            this.cboMon.Size = new System.Drawing.Size(282, 30);
            this.cboMon.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1047, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Danh sách món:";
            // 
            // numSL
            // 
            this.numSL.Location = new System.Drawing.Point(1188, 113);
            this.numSL.Name = "numSL";
            this.numSL.Size = new System.Drawing.Size(282, 30);
            this.numSL.TabIndex = 9;
            this.numSL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numSL.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1047, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Số lượng:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel7);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(1042, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 231);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh mục món";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnKhac);
            this.panel7.Location = new System.Drawing.Point(308, 128);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(123, 97);
            this.panel7.TabIndex = 5;
            // 
            // btnKhac
            // 
            this.btnKhac.BackgroundImage = global::QL_NHAHANG.Properties.Resources.unnamed1;
            this.btnKhac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKhac.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhac.ForeColor = System.Drawing.Color.White;
            this.btnKhac.Location = new System.Drawing.Point(3, 3);
            this.btnKhac.Name = "btnKhac";
            this.btnKhac.Size = new System.Drawing.Size(117, 91);
            this.btnKhac.TabIndex = 2;
            this.btnKhac.Text = "Khác";
            this.btnKhac.UseVisualStyleBackColor = true;
            this.btnKhac.Click += new System.EventHandler(this.btnKhac_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnCom);
            this.panel5.Location = new System.Drawing.Point(308, 25);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(123, 97);
            this.panel5.TabIndex = 3;
            // 
            // btnCom
            // 
            this.btnCom.BackgroundImage = global::QL_NHAHANG.Properties.Resources.unnamed__1_;
            this.btnCom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCom.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCom.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnCom.Location = new System.Drawing.Point(3, 4);
            this.btnCom.Name = "btnCom";
            this.btnCom.Size = new System.Drawing.Size(117, 90);
            this.btnCom.TabIndex = 2;
            this.btnCom.Text = "Cơm ";
            this.btnCom.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCom.UseVisualStyleBackColor = true;
            this.btnCom.Click += new System.EventHandler(this.btnCom_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnNuocUong);
            this.panel6.Location = new System.Drawing.Point(159, 128);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(129, 97);
            this.panel6.TabIndex = 4;
            // 
            // btnNuocUong
            // 
            this.btnNuocUong.BackgroundImage = global::QL_NHAHANG.Properties.Resources.nuocgiaikhat;
            this.btnNuocUong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuocUong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuocUong.ForeColor = System.Drawing.Color.White;
            this.btnNuocUong.Location = new System.Drawing.Point(3, 3);
            this.btnNuocUong.Name = "btnNuocUong";
            this.btnNuocUong.Size = new System.Drawing.Size(123, 91);
            this.btnNuocUong.TabIndex = 2;
            this.btnNuocUong.Text = "Nước Uống";
            this.btnNuocUong.UseVisualStyleBackColor = true;
            this.btnNuocUong.Click += new System.EventHandler(this.btnNuocUong_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnDoNuong);
            this.panel4.Location = new System.Drawing.Point(159, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(129, 97);
            this.panel4.TabIndex = 2;
            // 
            // btnDoNuong
            // 
            this.btnDoNuong.BackgroundImage = global::QL_NHAHANG.Properties.Resources.unnamed;
            this.btnDoNuong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDoNuong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoNuong.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnDoNuong.Location = new System.Drawing.Point(3, 3);
            this.btnDoNuong.Name = "btnDoNuong";
            this.btnDoNuong.Size = new System.Drawing.Size(123, 90);
            this.btnDoNuong.TabIndex = 2;
            this.btnDoNuong.Text = "Đồ Nướng";
            this.btnDoNuong.UseVisualStyleBackColor = true;
            this.btnDoNuong.Click += new System.EventHandler(this.btnDoNuong_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnHap);
            this.panel3.Location = new System.Drawing.Point(6, 128);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(129, 97);
            this.panel3.TabIndex = 1;
            // 
            // btnHap
            // 
            this.btnHap.BackgroundImage = global::QL_NHAHANG.Properties.Resources.be_hap_bia_06_flrg;
            this.btnHap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHap.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHap.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnHap.Location = new System.Drawing.Point(3, 3);
            this.btnHap.Name = "btnHap";
            this.btnHap.Size = new System.Drawing.Size(123, 91);
            this.btnHap.TabIndex = 2;
            this.btnHap.Text = "Món Hấp";
            this.btnHap.UseVisualStyleBackColor = true;
            this.btnHap.Click += new System.EventHandler(this.btnHap_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLau);
            this.panel2.Location = new System.Drawing.Point(6, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(129, 97);
            this.panel2.TabIndex = 0;
            // 
            // btnLau
            // 
            this.btnLau.BackColor = System.Drawing.Color.Aqua;
            this.btnLau.BackgroundImage = global::QL_NHAHANG.Properties.Resources.cach_nau_lau_thap_cam_hai_san_chua_cay_lau_thap_cam_gom_nhung_gi_1;
            this.btnLau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLau.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLau.ForeColor = System.Drawing.Color.White;
            this.btnLau.Location = new System.Drawing.Point(3, 4);
            this.btnLau.Name = "btnLau";
            this.btnLau.Size = new System.Drawing.Size(123, 90);
            this.btnLau.TabIndex = 1;
            this.btnLau.Text = "Lẩu";
            this.btnLau.UseVisualStyleBackColor = false;
            this.btnLau.Click += new System.EventHandler(this.btnLau_Click);
            // 
            // grbChuyenBan
            // 
            this.grbChuyenBan.Controls.Add(this.btnChuyenBan);
            this.grbChuyenBan.Controls.Add(this.cboChuyenBan);
            this.grbChuyenBan.Controls.Add(this.label9);
            this.grbChuyenBan.ForeColor = System.Drawing.Color.Red;
            this.grbChuyenBan.Location = new System.Drawing.Point(1042, 517);
            this.grbChuyenBan.Name = "grbChuyenBan";
            this.grbChuyenBan.Size = new System.Drawing.Size(437, 131);
            this.grbChuyenBan.TabIndex = 12;
            this.grbChuyenBan.TabStop = false;
            this.grbChuyenBan.Text = "Chuyển bàn";
            // 
            // btnChuyenBan
            // 
            this.btnChuyenBan.BackColor = System.Drawing.Color.White;
            this.btnChuyenBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenBan.ForeColor = System.Drawing.Color.Black;
            this.btnChuyenBan.Image = global::QL_NHAHANG.Properties.Resources.ban;
            this.btnChuyenBan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChuyenBan.Location = new System.Drawing.Point(291, 82);
            this.btnChuyenBan.Name = "btnChuyenBan";
            this.btnChuyenBan.Size = new System.Drawing.Size(140, 42);
            this.btnChuyenBan.TabIndex = 21;
            this.btnChuyenBan.Text = "Chuyển Bàn";
            this.btnChuyenBan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChuyenBan.UseVisualStyleBackColor = false;
            this.btnChuyenBan.Click += new System.EventHandler(this.btnChuyenBan_Click);
            // 
            // cboChuyenBan
            // 
            this.cboChuyenBan.FormattingEnabled = true;
            this.cboChuyenBan.Location = new System.Drawing.Point(194, 14);
            this.cboChuyenBan.Name = "cboChuyenBan";
            this.cboChuyenBan.Size = new System.Drawing.Size(237, 30);
            this.cboChuyenBan.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(6, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 22);
            this.label9.TabIndex = 18;
            this.label9.Text = "Chọn bàn chuyển:";
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Location = new System.Drawing.Point(752, 509);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(284, 30);
            this.txtGiamGia.TabIndex = 20;
            this.txtGiamGia.Text = "0";
            this.txtGiamGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGiamGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiamGia_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(607, 521);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 22);
            this.label8.TabIndex = 17;
            this.label8.Text = "Giảm giá:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnOrder);
            this.panel8.Location = new System.Drawing.Point(1236, 432);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(94, 61);
            this.panel8.TabIndex = 14;
            // 
            // btnOrder
            // 
            this.btnOrder.BackgroundImage = global::QL_NHAHANG.Properties.Resources.images;
            this.btnOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOrder.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.Red;
            this.btnOrder.Location = new System.Drawing.Point(3, 3);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(88, 56);
            this.btnOrder.TabIndex = 13;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnXoa);
            this.panel9.Location = new System.Drawing.Point(1381, 432);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(92, 61);
            this.panel9.TabIndex = 15;
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = global::QL_NHAHANG.Properties.Resources.TrashIt_icon_trnspt;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Red;
            this.btnXoa.Location = new System.Drawing.Point(4, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 58);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1047, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 22);
            this.label7.TabIndex = 16;
            this.label7.Text = "Món chọn:";
            // 
            // txtTenMon
            // 
            this.txtTenMon.Location = new System.Drawing.Point(1188, 159);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(285, 30);
            this.txtTenMon.TabIndex = 17;
            this.txtTenMon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(607, 484);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 22);
            this.label10.TabIndex = 24;
            this.label10.Text = "Thành tiền:";
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Location = new System.Drawing.Point(970, 484);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(66, 22);
            this.lblThanhTien.TabIndex = 25;
            this.lblThanhTien.Text = "0 VNĐ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(607, 557);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 22);
            this.label11.TabIndex = 26;
            this.label11.Text = "Thanh toán:";
            // 
            // txtThanhToan
            // 
            this.txtThanhToan.Location = new System.Drawing.Point(752, 549);
            this.txtThanhToan.Name = "txtThanhToan";
            this.txtThanhToan.Size = new System.Drawing.Size(284, 30);
            this.txtThanhToan.TabIndex = 27;
            this.txtThanhToan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.White;
            this.btnThanhToan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.Black;
            this.btnThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("btnThanhToan.Image")));
            this.btnThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan.Location = new System.Drawing.Point(896, 596);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(140, 45);
            this.btnThanhToan.TabIndex = 23;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // frmQuanLyBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1491, 653);
            this.Controls.Add(this.txtThanhToan);
            this.Controls.Add(this.txtGiamGia);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblThanhTien);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.txtTenMon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.grbChuyenBan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numSL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboMon);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.floDanhSachBan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenBan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanLyBan";
            this.Text = "Quản Lý Bàn";
            this.Load += new System.EventHandler(this.frmQuanLyBan_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.grbChuyenBan.ResumeLayout(false);
            this.grbChuyenBan.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenBan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel floDanhSachBan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboMon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numSL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnKhac;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnNuocUong;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnCom;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDoNuong;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnHap;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLau;
        private System.Windows.Forms.GroupBox grbChuyenBan;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnChuyenBan;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.ComboBox cboChuyenBan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.Label lblTenBan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtThanhToan;
        private System.Windows.Forms.ListView lstvThongTinBan;
        private System.Windows.Forms.FlowLayoutPanel flowBan;

    }
}