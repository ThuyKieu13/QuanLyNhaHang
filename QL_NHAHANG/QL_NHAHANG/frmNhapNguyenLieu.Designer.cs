
namespace QL_NHAHANG
{
    partial class frmNhapNguyenLieu
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblPhieuDat = new System.Windows.Forms.Label();
            this.btnChonLai = new System.Windows.Forms.Button();
            this.btnChon = new System.Windows.Forms.Button();
            this.cbbPhieuDat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvTT = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnNhap = new System.Windows.Forms.Button();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenNL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtgvND = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTT)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvND)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(528, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 38);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nhập Nguyên Liệu";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblPhieuDat);
            this.groupBox3.Controls.Add(this.btnChonLai);
            this.groupBox3.Controls.Add(this.btnChon);
            this.groupBox3.Controls.Add(this.cbbPhieuDat);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(9, 68);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox3.Size = new System.Drawing.Size(663, 226);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chọn phiếu đặt";
            // 
            // lblPhieuDat
            // 
            this.lblPhieuDat.AutoSize = true;
            this.lblPhieuDat.ForeColor = System.Drawing.Color.Black;
            this.lblPhieuDat.Location = new System.Drawing.Point(155, 44);
            this.lblPhieuDat.Name = "lblPhieuDat";
            this.lblPhieuDat.Size = new System.Drawing.Size(103, 27);
            this.lblPhieuDat.TabIndex = 9;
            this.lblPhieuDat.Text = "Phiếu đặt";
            // 
            // btnChonLai
            // 
            this.btnChonLai.BackColor = System.Drawing.Color.White;
            this.btnChonLai.ForeColor = System.Drawing.Color.Black;
            this.btnChonLai.Location = new System.Drawing.Point(418, 161);
            this.btnChonLai.Name = "btnChonLai";
            this.btnChonLai.Size = new System.Drawing.Size(234, 49);
            this.btnChonLai.TabIndex = 8;
            this.btnChonLai.Text = "Chọn Lại Phiếu Đặt";
            this.btnChonLai.UseVisualStyleBackColor = false;
            this.btnChonLai.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnChon
            // 
            this.btnChon.BackColor = System.Drawing.Color.White;
            this.btnChon.ForeColor = System.Drawing.Color.Black;
            this.btnChon.Location = new System.Drawing.Point(144, 161);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(234, 49);
            this.btnChon.TabIndex = 7;
            this.btnChon.Text = "Xác Nhận Phiếu Đặt";
            this.btnChon.UseVisualStyleBackColor = false;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // cbbPhieuDat
            // 
            this.cbbPhieuDat.FormattingEnabled = true;
            this.cbbPhieuDat.Location = new System.Drawing.Point(144, 41);
            this.cbbPhieuDat.Name = "cbbPhieuDat";
            this.cbbPhieuDat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbbPhieuDat.Size = new System.Drawing.Size(508, 34);
            this.cbbPhieuDat.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(23, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phiếu đặt:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvTT);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(9, 297);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 374);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu đặt";
            // 
            // dtgvTT
            // 
            this.dtgvTT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dtgvTT.Location = new System.Drawing.Point(7, 33);
            this.dtgvTT.Name = "dtgvTT";
            this.dtgvTT.ReadOnly = true;
            this.dtgvTT.RowHeadersWidth = 51;
            this.dtgvTT.RowTemplate.Height = 24;
            this.dtgvTT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvTT.Size = new System.Drawing.Size(645, 341);
            this.dtgvTT.TabIndex = 0;
            this.dtgvTT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTT_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "tenNguyenlieu";
            this.Column1.HeaderText = "Tên nguyên liệu";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "soLuong";
            this.Column2.FillWeight = 50F;
            this.Column2.HeaderText = "Số lượng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "donGianhap";
            this.Column3.FillWeight = 50F;
            this.Column3.HeaderText = "Đơn giá";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnNhap);
            this.groupBox2.Controls.Add(this.txtSL);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtTenNL);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(701, 65);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox2.Size = new System.Drawing.Size(690, 229);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập nguyên liệu";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Image = global::QL_NHAHANG.Properties.Resources.btnDelete;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(514, 164);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(131, 52);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnNhap
            // 
            this.btnNhap.BackColor = System.Drawing.Color.White;
            this.btnNhap.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhap.ForeColor = System.Drawing.Color.Black;
            this.btnNhap.Image = global::QL_NHAHANG.Properties.Resources.btnAdd;
            this.btnNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhap.Location = new System.Drawing.Point(232, 161);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(131, 55);
            this.btnNhap.TabIndex = 4;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhap.UseVisualStyleBackColor = false;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(232, 79);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(413, 34);
            this.txtSL.TabIndex = 3;
            this.txtSL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(23, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 27);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số lượng:";
            // 
            // txtTenNL
            // 
            this.txtTenNL.Location = new System.Drawing.Point(232, 40);
            this.txtTenNL.Name = "txtTenNL";
            this.txtTenNL.ReadOnly = true;
            this.txtTenNL.Size = new System.Drawing.Size(413, 34);
            this.txtTenNL.TabIndex = 1;
            this.txtTenNL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(23, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên nguyên liệu:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtgvND);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Red;
            this.groupBox4.Location = new System.Drawing.Point(701, 297);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox4.Size = new System.Drawing.Size(690, 374);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Nội dung nhập";
            // 
            // dtgvND
            // 
            this.dtgvND.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvND.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvND.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5});
            this.dtgvND.Location = new System.Drawing.Point(4, 31);
            this.dtgvND.Name = "dtgvND";
            this.dtgvND.ReadOnly = true;
            this.dtgvND.RowHeadersWidth = 51;
            this.dtgvND.RowTemplate.Height = 24;
            this.dtgvND.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvND.Size = new System.Drawing.Size(686, 343);
            this.dtgvND.TabIndex = 0;
            this.dtgvND.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvND_CellContentClick);
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "tenNguyenlieu";
            this.Column4.HeaderText = "Tên nguyên liệu";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "soLuong";
            this.Column5.FillWeight = 50F;
            this.Column5.HeaderText = "Số lượng";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // frmNhapNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1473, 703);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label2);
            this.Name = "frmNhapNguyenLieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNhapNguyenLieu";
            this.Load += new System.EventHandler(this.frmNhapNguyenLieu_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTT)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvND)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbbPhieuDat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvTT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenNL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dtgvND;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnChonLai;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Label lblPhieuDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}