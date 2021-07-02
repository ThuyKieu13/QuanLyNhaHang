using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace QL_NHAHANG
{
    public partial class frmNhapNguyenLieu : Form
    {
        public frmNhapNguyenLieu()
        {
            InitializeComponent();
        }
        public string TenDN = "";
        void LayDSPhieuDat()
        {
            cbbPhieuDat.DataSource = DAO_QL_NhapNguyenLieu.LoadDanhSachPhieuDat();
            cbbPhieuDat.DisplayMember = "tenPhieuDat";
            cbbPhieuDat.ValueMember = "idPhieuDat";
        }
        private void frmNhapNguyenLieu_Load(object sender, EventArgs e)
        {
            lblPhieuDat.Visible = false;
            btnChonLai.Hide();
            LayDSPhieuDat();
        }    
        private void btnChon_Click(object sender, EventArgs e)
        {
            cbbPhieuDat.Visible = false;
            lblPhieuDat.Text = cbbPhieuDat.Text;
            lblPhieuDat.Visible = true;
            btnChonLai.Show();
            btnChon.Hide();
            string ngaylap = DateTime.Now.ToString("dd/MM/yyyy");
            int nguoilap = DAO_QL_NhapNguyenLieu.LayIDNV(TenDN);
            int phieu = int.Parse(cbbPhieuDat.SelectedValue.ToString());
            if (DAO_QL_NhapNguyenLieu.TaoPhieu(ngaylap, nguoilap, phieu))
            {
                MessageBox.Show("ô cê", "Thông báo", MessageBoxButtons.OK);
                int idphieu = DAO_QL_NhapNguyenLieu.LayIDPhieuNhapVuaTao();
                dtgvND.DataSource = DAO_QL_NhapNguyenLieu.LoadThongTinPhieuNhap(idphieu);
                dtgvTT.DataSource = DAO_QL_NhapNguyenLieu.LoadThongTinPhieuDat(phieu);
            }           
            
        }
        private void button1_Click(object sender, EventArgs e)
        {            
            lblPhieuDat.Visible = false;
            cbbPhieuDat.Visible = true;
            btnChon.Show();
            btnChonLai.Hide();
        }
        private void dtgvTT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenNL.Text = dtgvTT.CurrentRow.Cells[0].Value.ToString();
            txtSL.Text = dtgvTT.CurrentRow.Cells[1].Value.ToString();
        }
        private void btnNhap_Click(object sender, EventArgs e)
        {
            int phieu = DAO_QL_NhapNguyenLieu.LayIDPhieuNhapVuaTao();
            int nguyenlieu = DAO_QL_NhapNguyenLieu.LayIDNguyeLieu(txtTenNL.Text);
            int soluong = int.Parse(txtSL.Text.ToString());
            try
            {
                if (DAO_QL_NhapNguyenLieu.NhapNguyenLieu(phieu, nguyenlieu, soluong))
                {
                    MessageBox.Show("Nhâp thành công", "Thông báo", MessageBoxButtons.OK);
                    dtgvND.DataSource = DAO_QL_NhapNguyenLieu.LoadThongTinPhieuNhap(phieu);                   
                }
                else
                {
                    MessageBox.Show("Nhâp thất bại", "Thông báo", MessageBoxButtons.OK);
                }
            }
            catch
            {
                MessageBox.Show("Nhâp thất bại", "Thông báo", MessageBoxButtons.OK);
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int phieu = DAO_QL_NhapNguyenLieu.LayIDPhieuNhapVuaTao();
            int nguyenlieu = DAO_QL_NhapNguyenLieu.LayIDNguyeLieu(txtTenNL.Text);
            int soluongton = DAO_QL_NhapNguyenLieu.LaySLNguyeLieu(txtTenNL.Text);
            int soluong = soluongton - int.Parse(txtSL.Text);
            try
            {
                if(DAO_QL_NhapNguyenLieu.UpdateNguyenLieu(nguyenlieu, soluong))
                {
                    if(DAO_QL_NhapNguyenLieu.XoaNguyenLieu(phieu, nguyenlieu)) 
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);

                        dtgvND.DataSource = DAO_QL_NhapNguyenLieu.LoadThongTinPhieuNhap(phieu);
                    } 
                    else
                    {
                        MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK);
                    }    
                }    
            }
            catch
            {
                MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK);
            }
        }
        private void dtgvND_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenNL.Text = dtgvND.CurrentRow.Cells[0].Value.ToString();
            txtSL.Text = dtgvND.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
