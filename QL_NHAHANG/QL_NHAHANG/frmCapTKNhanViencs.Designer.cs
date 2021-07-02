namespace QL_NHAHANG
{
    partial class frmCapTKNhanViencs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCapTKNhanViencs));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboLoaiTK = new System.Windows.Forms.ComboBox();
            this.txtTenHT = new System.Windows.Forms.TextBox();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.btnCapTK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại tài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên hiển thị:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 272);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên đăng nhập:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 353);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mật khẩu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(556, 29);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(442, 42);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cấp Tài Khoản Nhân Viên";
            // 
            // cboLoaiTK
            // 
            this.cboLoaiTK.FormattingEnabled = true;
            this.cboLoaiTK.Location = new System.Drawing.Point(548, 118);
            this.cboLoaiTK.Name = "cboLoaiTK";
            this.cboLoaiTK.Size = new System.Drawing.Size(463, 31);
            this.cboLoaiTK.TabIndex = 6;
            // 
            // txtTenHT
            // 
            this.txtTenHT.Location = new System.Drawing.Point(548, 191);
            this.txtTenHT.Name = "txtTenHT";
            this.txtTenHT.Size = new System.Drawing.Size(463, 32);
            this.txtTenHT.TabIndex = 7;
            // 
            // txtTenDN
            // 
            this.txtTenDN.Location = new System.Drawing.Point(548, 265);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(463, 32);
            this.txtTenDN.TabIndex = 8;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(548, 346);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(463, 32);
            this.txtMK.TabIndex = 9;
            // 
            // btnCapTK
            // 
            this.btnCapTK.BackColor = System.Drawing.Color.White;
            this.btnCapTK.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapTK.ForeColor = System.Drawing.Color.Black;
            this.btnCapTK.Location = new System.Drawing.Point(722, 475);
            this.btnCapTK.Name = "btnCapTK";
            this.btnCapTK.Size = new System.Drawing.Size(289, 53);
            this.btnCapTK.TabIndex = 10;
            this.btnCapTK.Text = "Cấp tài khoản";
            this.btnCapTK.UseVisualStyleBackColor = false;
            this.btnCapTK.Click += new System.EventHandler(this.btnCapTK_Click);
            // 
            // frmCapTKNhanViencs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1473, 703);
            this.Controls.Add(this.btnCapTK);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTenDN);
            this.Controls.Add(this.txtTenHT);
            this.Controls.Add(this.cboLoaiTK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCapTKNhanViencs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cấp Tài Khoản Nhân Viên";
            this.Load += new System.EventHandler(this.frmCapTKNhanViencs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboLoaiTK;
        private System.Windows.Forms.TextBox txtTenHT;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Button btnCapTK;
    }
}