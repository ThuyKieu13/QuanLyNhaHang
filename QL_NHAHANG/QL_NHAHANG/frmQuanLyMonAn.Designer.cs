namespace QL_NHAHANG
{
    partial class frmQuanLyMonAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyMonAn));
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiemMonAn = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rdoHet = new System.Windows.Forms.RadioButton();
            this.rdoCon = new System.Windows.Forms.RadioButton();
            this.label28 = new System.Windows.Forms.Label();
            this.lblThongBaoMon = new System.Windows.Forms.Label();
            this.txtIDMon = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.cboDanhMucMon = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.listDanhSachMonAn = new System.Windows.Forms.ListView();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel14.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(601, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Món Ăn";
            // 
            // txtTimKiemMonAn
            // 
            this.txtTimKiemMonAn.Location = new System.Drawing.Point(1122, 17);
            this.txtTimKiemMonAn.Name = "txtTimKiemMonAn";
            this.txtTimKiemMonAn.Size = new System.Drawing.Size(339, 32);
            this.txtTimKiemMonAn.TabIndex = 1;
            this.txtTimKiemMonAn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimKiemMonAn_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.txtIDMon);
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Controls.Add(this.panel16);
            this.groupBox3.Controls.Add(this.panel15);
            this.groupBox3.Controls.Add(this.panel14);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(9, 39);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox3.Size = new System.Drawing.Size(596, 486);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thêm món ăn";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rdoHet);
            this.groupBox5.Controls.Add(this.rdoCon);
            this.groupBox5.Controls.Add(this.label28);
            this.groupBox5.Controls.Add(this.lblThongBaoMon);
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.Red;
            this.groupBox5.Location = new System.Drawing.Point(14, 360);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(576, 108);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Cập nhật tình trạng món ăn";
            // 
            // rdoHet
            // 
            this.rdoHet.AutoSize = true;
            this.rdoHet.ForeColor = System.Drawing.Color.Black;
            this.rdoHet.Location = new System.Drawing.Point(322, 42);
            this.rdoHet.Name = "rdoHet";
            this.rdoHet.Size = new System.Drawing.Size(68, 31);
            this.rdoHet.TabIndex = 12;
            this.rdoHet.Text = "Hết";
            this.rdoHet.UseVisualStyleBackColor = true;
            // 
            // rdoCon
            // 
            this.rdoCon.AutoSize = true;
            this.rdoCon.Checked = true;
            this.rdoCon.ForeColor = System.Drawing.Color.Black;
            this.rdoCon.Location = new System.Drawing.Point(152, 42);
            this.rdoCon.Name = "rdoCon";
            this.rdoCon.Size = new System.Drawing.Size(73, 31);
            this.rdoCon.TabIndex = 11;
            this.rdoCon.TabStop = true;
            this.rdoCon.Text = "Còn";
            this.rdoCon.UseVisualStyleBackColor = true;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.ForeColor = System.Drawing.Color.Black;
            this.label28.Location = new System.Drawing.Point(18, 42);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(117, 27);
            this.label28.TabIndex = 10;
            this.label28.Text = "Tình Trạng";
            // 
            // lblThongBaoMon
            // 
            this.lblThongBaoMon.AutoSize = true;
            this.lblThongBaoMon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBaoMon.ForeColor = System.Drawing.Color.Crimson;
            this.lblThongBaoMon.Location = new System.Drawing.Point(18, 42);
            this.lblThongBaoMon.Name = "lblThongBaoMon";
            this.lblThongBaoMon.Size = new System.Drawing.Size(0, 22);
            this.lblThongBaoMon.TabIndex = 9;
            // 
            // txtIDMon
            // 
            this.txtIDMon.Location = new System.Drawing.Point(166, 296);
            this.txtIDMon.Name = "txtIDMon";
            this.txtIDMon.ReadOnly = true;
            this.txtIDMon.Size = new System.Drawing.Size(424, 34);
            this.txtIDMon.TabIndex = 10;
            this.txtIDMon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.ForeColor = System.Drawing.Color.Black;
            this.label29.Location = new System.Drawing.Point(17, 303);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(85, 27);
            this.label29.TabIndex = 9;
            this.label29.Text = "ID món";
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.cboDanhMucMon);
            this.panel16.Controls.Add(this.label18);
            this.panel16.Location = new System.Drawing.Point(14, 214);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(579, 63);
            this.panel16.TabIndex = 2;
            // 
            // cboDanhMucMon
            // 
            this.cboDanhMucMon.DisplayMember = "tenDanhmuc";
            this.cboDanhMucMon.FormattingEnabled = true;
            this.cboDanhMucMon.Location = new System.Drawing.Point(152, 14);
            this.cboDanhMucMon.Name = "cboDanhMucMon";
            this.cboDanhMucMon.Size = new System.Drawing.Size(424, 34);
            this.cboDanhMucMon.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(3, 21);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(111, 27);
            this.label18.TabIndex = 0;
            this.label18.Text = "Danh mục";
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.txtDonGia);
            this.panel15.Controls.Add(this.label17);
            this.panel15.Location = new System.Drawing.Point(14, 121);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(579, 63);
            this.panel15.TabIndex = 1;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(152, 18);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(424, 34);
            this.txtDonGia.TabIndex = 2;
            this.txtDonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGia_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(3, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(88, 27);
            this.label17.TabIndex = 0;
            this.label17.Text = "Đơn giá";
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.txtTenMon);
            this.panel14.Controls.Add(this.label16);
            this.panel14.Location = new System.Drawing.Point(14, 30);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(579, 63);
            this.panel14.TabIndex = 0;
            // 
            // txtTenMon
            // 
            this.txtTenMon.Location = new System.Drawing.Point(152, 18);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(424, 34);
            this.txtTenMon.TabIndex = 1;
            this.txtTenMon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(3, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 27);
            this.label16.TabIndex = 0;
            this.label16.Text = "Tên món";
            // 
            // listDanhSachMonAn
            // 
            this.listDanhSachMonAn.HideSelection = false;
            this.listDanhSachMonAn.Location = new System.Drawing.Point(608, 53);
            this.listDanhSachMonAn.Name = "listDanhSachMonAn";
            this.listDanhSachMonAn.Size = new System.Drawing.Size(853, 581);
            this.listDanhSachMonAn.TabIndex = 14;
            this.listDanhSachMonAn.UseCompatibleStateImageBehavior = false;
            this.listDanhSachMonAn.SelectedIndexChanged += new System.EventHandler(this.listDanhSachMonAn_SelectedIndexChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.MintCream;
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTimKiem.Image = global::QL_NHAHANG.Properties.Resources.search;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(960, 17);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(142, 34);
            this.btnTimKiem.TabIndex = 15;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.BackColor = System.Drawing.Color.White;
            this.btnrefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnrefresh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefresh.Image = global::QL_NHAHANG.Properties.Resources.images__11_2;
            this.btnrefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrefresh.Location = new System.Drawing.Point(479, 567);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(120, 67);
            this.btnrefresh.TabIndex = 13;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnrefresh.UseVisualStyleBackColor = false;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = global::QL_NHAHANG.Properties.Resources.btnUpdate;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(327, 567);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(120, 67);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::QL_NHAHANG.Properties.Resources.btnDelete;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(175, 567);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(120, 67);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Image = global::QL_NHAHANG.Properties.Resources.btnAdd;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(23, 567);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 67);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmQuanLyMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1473, 703);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.listDanhSachMonAn);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtTimKiemMonAn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanLyMonAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Món Ăn ";
            this.Load += new System.EventHandler(this.frmQuanLyMonAn_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimKiemMonAn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rdoHet;
        private System.Windows.Forms.RadioButton rdoCon;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label lblThongBaoMon;
        private System.Windows.Forms.TextBox txtIDMon;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.ComboBox cboDanhMucMon;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.ListView listDanhSachMonAn;
        private System.Windows.Forms.Button btnTimKiem;
    }
}