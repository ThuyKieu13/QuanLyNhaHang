namespace QL_NHAHANG
{
    partial class frmThemBanAn
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
            this.txtTenBanMoi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoaThemBanMoi = new System.Windows.Forms.Button();
            this.btnThemBanMoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(225, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên bàn:";
            // 
            // txtTenBanMoi
            // 
            this.txtTenBanMoi.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenBanMoi.Location = new System.Drawing.Point(426, 148);
            this.txtTenBanMoi.Margin = new System.Windows.Forms.Padding(5);
            this.txtTenBanMoi.Name = "txtTenBanMoi";
            this.txtTenBanMoi.Size = new System.Drawing.Size(352, 39);
            this.txtTenBanMoi.TabIndex = 6;
            this.txtTenBanMoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(428, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "THÊM  BÀN ĂN MỚI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnXoaThemBanMoi
            // 
            this.btnXoaThemBanMoi.BackColor = System.Drawing.Color.White;
            this.btnXoaThemBanMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoaThemBanMoi.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaThemBanMoi.ForeColor = System.Drawing.Color.Black;
            this.btnXoaThemBanMoi.Image = global::QL_NHAHANG.Properties.Resources.btnDelete;
            this.btnXoaThemBanMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaThemBanMoi.Location = new System.Drawing.Point(660, 294);
            this.btnXoaThemBanMoi.Margin = new System.Windows.Forms.Padding(5);
            this.btnXoaThemBanMoi.Name = "btnXoaThemBanMoi";
            this.btnXoaThemBanMoi.Size = new System.Drawing.Size(118, 59);
            this.btnXoaThemBanMoi.TabIndex = 9;
            this.btnXoaThemBanMoi.Text = "Xóa";
            this.btnXoaThemBanMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaThemBanMoi.UseVisualStyleBackColor = false;
            this.btnXoaThemBanMoi.Click += new System.EventHandler(this.btnXoaThemBanMoi_Click);
            // 
            // btnThemBanMoi
            // 
            this.btnThemBanMoi.BackColor = System.Drawing.Color.White;
            this.btnThemBanMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThemBanMoi.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemBanMoi.ForeColor = System.Drawing.Color.Black;
            this.btnThemBanMoi.Image = global::QL_NHAHANG.Properties.Resources.btnAdd;
            this.btnThemBanMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemBanMoi.Location = new System.Drawing.Point(426, 294);
            this.btnThemBanMoi.Margin = new System.Windows.Forms.Padding(5);
            this.btnThemBanMoi.Name = "btnThemBanMoi";
            this.btnThemBanMoi.Size = new System.Drawing.Size(118, 58);
            this.btnThemBanMoi.TabIndex = 8;
            this.btnThemBanMoi.Text = "Thêm";
            this.btnThemBanMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemBanMoi.UseVisualStyleBackColor = false;
            this.btnThemBanMoi.Click += new System.EventHandler(this.btnThemBanMoi_Click);
            // 
            // frmThemBanAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1174, 535);
            this.Controls.Add(this.btnXoaThemBanMoi);
            this.Controls.Add(this.btnThemBanMoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenBanMoi);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmThemBanAn";
            this.Text = "Thêm Bàn Ăn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmThemBanAn_FormClosing);
            this.Load += new System.EventHandler(this.frmThemBanAn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoaThemBanMoi;
        private System.Windows.Forms.Button btnThemBanMoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenBanMoi;
        private System.Windows.Forms.Label label1;
    }
}