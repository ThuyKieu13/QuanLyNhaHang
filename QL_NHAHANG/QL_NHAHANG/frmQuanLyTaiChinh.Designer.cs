namespace QL_NHAHANG
{
    partial class frmQuanLyTaiChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyTaiChinh));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.NgayBan = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHDNam = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHDThang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHDNgay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboNam = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTheoBan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnLocBan = new System.Windows.Forms.Button();
            this.cboBan = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLocThang = new System.Windows.Forms.Button();
            this.btnLocNgay = new System.Windows.Forms.Button();
            this.gridHoaDon = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 27);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tháng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ngày:";
            // 
            // cboThang
            // 
            this.cboThang.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboThang.FormattingEnabled = true;
            this.cboThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cboThang.Location = new System.Drawing.Point(146, 165);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(152, 34);
            this.cboThang.TabIndex = 9;
            // 
            // NgayBan
            // 
            this.NgayBan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayBan.Location = new System.Drawing.Point(145, 107);
            this.NgayBan.Name = "NgayBan";
            this.NgayBan.Size = new System.Drawing.Size(378, 34);
            this.NgayBan.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHDNam);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtHDThang);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtHDNgay);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(12, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 188);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tổng tiền theo ngày - tháng - năm";
            // 
            // txtHDNam
            // 
            this.txtHDNam.ForeColor = System.Drawing.Color.Crimson;
            this.txtHDNam.Location = new System.Drawing.Point(134, 132);
            this.txtHDNam.Name = "txtHDNam";
            this.txtHDNam.ReadOnly = true;
            this.txtHDNam.Size = new System.Drawing.Size(377, 34);
            this.txtHDNam.TabIndex = 5;
            this.txtHDNam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(14, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 27);
            this.label7.TabIndex = 4;
            this.label7.Text = "Năm";
            // 
            // txtHDThang
            // 
            this.txtHDThang.ForeColor = System.Drawing.Color.Crimson;
            this.txtHDThang.Location = new System.Drawing.Point(133, 82);
            this.txtHDThang.Name = "txtHDThang";
            this.txtHDThang.ReadOnly = true;
            this.txtHDThang.Size = new System.Drawing.Size(378, 34);
            this.txtHDThang.TabIndex = 3;
            this.txtHDThang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(14, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 27);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tháng";
            // 
            // txtHDNgay
            // 
            this.txtHDNgay.ForeColor = System.Drawing.Color.Crimson;
            this.txtHDNgay.Location = new System.Drawing.Point(133, 28);
            this.txtHDNgay.Name = "txtHDNgay";
            this.txtHDNgay.ReadOnly = true;
            this.txtHDNgay.Size = new System.Drawing.Size(378, 34);
            this.txtHDNgay.TabIndex = 1;
            this.txtHDNgay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(14, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 27);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 27);
            this.label1.TabIndex = 15;
            this.label1.Text = "Năm:";
            // 
            // cboNam
            // 
            this.cboNam.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNam.FormattingEnabled = true;
            this.cboNam.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033"});
            this.cboNam.Location = new System.Drawing.Point(371, 165);
            this.cboNam.Name = "cboNam";
            this.cboNam.Size = new System.Drawing.Size(152, 34);
            this.cboNam.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTheoBan);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnLocBan);
            this.groupBox2.Controls.Add(this.cboBan);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(12, 409);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(526, 119);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lọc theo bàn";
            // 
            // txtTheoBan
            // 
            this.txtTheoBan.ForeColor = System.Drawing.Color.Crimson;
            this.txtTheoBan.Location = new System.Drawing.Point(134, 73);
            this.txtTheoBan.Name = "txtTheoBan";
            this.txtTheoBan.ReadOnly = true;
            this.txtTheoBan.Size = new System.Drawing.Size(208, 34);
            this.txtTheoBan.TabIndex = 4;
            this.txtTheoBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(14, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 27);
            this.label9.TabIndex = 3;
            this.label9.Text = "Theo bàn:";
            // 
            // btnLocBan
            // 
            this.btnLocBan.BackColor = System.Drawing.Color.White;
            this.btnLocBan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocBan.ForeColor = System.Drawing.Color.Black;
            this.btnLocBan.Image = global::QL_NHAHANG.Properties.Resources.loc;
            this.btnLocBan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocBan.Location = new System.Drawing.Point(404, 47);
            this.btnLocBan.Name = "btnLocBan";
            this.btnLocBan.Size = new System.Drawing.Size(107, 60);
            this.btnLocBan.TabIndex = 2;
            this.btnLocBan.Text = "Lọc";
            this.btnLocBan.UseVisualStyleBackColor = false;
            this.btnLocBan.Click += new System.EventHandler(this.btnLocBan_Click);
            // 
            // cboBan
            // 
            this.cboBan.FormattingEnabled = true;
            this.cboBan.Location = new System.Drawing.Point(133, 30);
            this.cboBan.Name = "cboBan";
            this.cboBan.Size = new System.Drawing.Size(208, 34);
            this.cboBan.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(18, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 27);
            this.label8.TabIndex = 0;
            this.label8.Text = "Bàn:";
            // 
            // btnLocThang
            // 
            this.btnLocThang.BackColor = System.Drawing.Color.White;
            this.btnLocThang.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocThang.ForeColor = System.Drawing.Color.Black;
            this.btnLocThang.Image = global::QL_NHAHANG.Properties.Resources.loc;
            this.btnLocThang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocThang.Location = new System.Drawing.Point(336, 567);
            this.btnLocThang.Name = "btnLocThang";
            this.btnLocThang.Size = new System.Drawing.Size(202, 62);
            this.btnLocThang.TabIndex = 17;
            this.btnLocThang.Text = "Lọc theo tháng";
            this.btnLocThang.UseVisualStyleBackColor = false;
            this.btnLocThang.Click += new System.EventHandler(this.btnLocThang_Click);
            // 
            // btnLocNgay
            // 
            this.btnLocNgay.BackColor = System.Drawing.Color.White;
            this.btnLocNgay.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocNgay.ForeColor = System.Drawing.Color.Black;
            this.btnLocNgay.Image = global::QL_NHAHANG.Properties.Resources.loc;
            this.btnLocNgay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocNgay.Location = new System.Drawing.Point(12, 567);
            this.btnLocNgay.Name = "btnLocNgay";
            this.btnLocNgay.Size = new System.Drawing.Size(202, 62);
            this.btnLocNgay.TabIndex = 16;
            this.btnLocNgay.Text = "Lọc theo ngày";
            this.btnLocNgay.UseVisualStyleBackColor = false;
            this.btnLocNgay.Click += new System.EventHandler(this.btnLocNgay_Click);
            // 
            // gridHoaDon
            // 
            this.gridHoaDon.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHoaDon.Location = new System.Drawing.Point(548, 107);
            this.gridHoaDon.Name = "gridHoaDon";
            this.gridHoaDon.RowTemplate.Height = 24;
            this.gridHoaDon.Size = new System.Drawing.Size(913, 522);
            this.gridHoaDon.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(541, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(376, 37);
            this.label4.TabIndex = 20;
            this.label4.Text = "DANH SÁCH HÓA ĐƠN";
            // 
            // frmQuanLyTaiChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1473, 703);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gridHoaDon);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnLocThang);
            this.Controls.Add(this.btnLocNgay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboNam);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboThang);
            this.Controls.Add(this.NgayBan);
            this.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanLyTaiChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản  Lý Tài Chính";
            this.Load += new System.EventHandler(this.frmQuanLyTaiChinh_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.DateTimePicker NgayBan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtHDNam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHDThang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHDNgay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboNam;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTheoBan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnLocBan;
        private System.Windows.Forms.ComboBox cboBan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLocThang;
        private System.Windows.Forms.Button btnLocNgay;
        private System.Windows.Forms.DataGridView gridHoaDon;
        private System.Windows.Forms.Label label4;
    }
}