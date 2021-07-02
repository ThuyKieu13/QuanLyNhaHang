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
    public partial class frmDatNguyenLieu : Form
    {
        public string TenDN = "";
        public frmDatNguyenLieu()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
            string tenphieu = txtTenP.Text;
            string ngaylap = txtNgayLap.Text;
            int nguoilap = DAO_QL_DatNguyenLieu.LayIDNV(TenDN);
            int NCC = int.Parse(cbbNCC.SelectedValue.ToString());
            if (txtTenP.Text.Length ==0 )
            {
                MessageBox.Show("Bạn chưa nhập tên phiếu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
            else
            {
                try
                {
                    if(DAO_QL_DatNguyenLieu.TaoPhieu(tenphieu, ngaylap, nguoilap, NCC))
                    {
                        MessageBox.Show("Tạo phiếu thành công", "Thông báo", MessageBoxButtons.OK);
                        int phieu = DAO_QL_DatNguyenLieu.LayIDPhieuDatVuaTao();
                        dtgvTT.DataSource = DAO_QL_DatNguyenLieu.LoadPhieuDat(phieu);
                        dtgvND.DataSource = DAO_QL_DatNguyenLieu.LoadThongTinPhieuDat(phieu);
                    }   
                    else
                    {
                        MessageBox.Show("Tạo phiếu thất bại", "Thông báo", MessageBoxButtons.OK);
                    }                        
                }
                catch
                {
                    MessageBox.Show("Tạo phiếu thất bại", "Thông báo", MessageBoxButtons.OK);
                }
            }               
        }
        public void LayDSNCC()
        {
            cbbNCC.DataSource = DAO_QL_DatNguyenLieu.Loadncc();
            cbbNCC.DisplayMember = "tenNCC";
            cbbNCC.ValueMember = "idNCC";
        }
        public void LayNgayHienTai()
        {
            txtNgayLap.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        public void LayTenNV()
        {           
            txtNguoiLap.Text = DAO_QL_DatNguyenLieu.LayTenNV(TenDN);        
        }
        public void LayDSNL()
        {
            cbbTenNL.DataSource = DAO_QL_DatNguyenLieu.LayTenNL();
            cbbTenNL.DisplayMember = "tenNguyenlieu";
            cbbTenNL.ValueMember = "idNguyenlieu";
        }
        private void frmDatNL_Load(object sender, EventArgs e)
        {
            groupBox1.Hide();
            LayDSNCC();
            LayNgayHienTai();
            LayTenNV();
            LayDSNL();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            int phieu = DAO_QL_DatNguyenLieu.LayIDPhieuDatVuaTao();
            int nguyenlieu = int.Parse(cbbTenNL.SelectedValue.ToString());
            int soluong = int.Parse(txtSL.Value.ToString());
            int gianhap = int.Parse(txtGia.Text);
            if (txtGia.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập giá nguyên liệu!! Hãy nhập giá theo thỏa thuận với ncc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if(DAO_QL_DatNguyenLieu.ThemNguyenLieu(phieu, nguyenlieu, soluong, gianhap))
                    {
                        MessageBox.Show("Thêm nguyên liệu vào phiếu thành công", "Thông báo", MessageBoxButtons.OK);
                        dtgvND.DataSource = DAO_QL_DatNguyenLieu.LoadThongTinPhieuDat(phieu);
                        dtgvTT.DataSource = DAO_QL_DatNguyenLieu.LoadPhieuDat(phieu);
                    } 
                    else
                    {
                        MessageBox.Show("Thêm nguyên liệu vào phiếu thất bại", "Thông báo", MessageBoxButtons.OK);
                    }    
                }
                catch
                {
                    MessageBox.Show("Thêm nguyên liệu vào phiếu thất bại", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int phieu = DAO_QL_DatNguyenLieu.LayIDPhieuDatVuaTao();
            int idNguyenLieu = DAO_QL_DatNguyenLieu.LayIDNguyeLieu(cbbTenNL.Text.ToString());
            try
            {
                if(DAO_QL_DatNguyenLieu.XoaNguyenLieu(phieu, idNguyenLieu))
                {
                    MessageBox.Show("Xóa nguyên liệu trong phiếu thành công", "Thông báo", MessageBoxButtons.OK);
                    dtgvND.DataSource = DAO_QL_DatNguyenLieu.LoadThongTinPhieuDat(phieu);
                    dtgvTT.DataSource = DAO_QL_DatNguyenLieu.LoadPhieuDat(phieu);
                }    
                else
                {
                    MessageBox.Show("Xóa nguyên liệu trong phiếu thất bại", "Thông báo", MessageBoxButtons.OK);
                }                  
            }
            catch
            {
                MessageBox.Show("Xóa nguyên liệu trong phiếu thất bại", "Thông báo", MessageBoxButtons.OK);
            }
        }
        private void dtgvND_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbbTenNL.Text = dtgvND.CurrentRow.Cells[0].Value.ToString();
            txtSL.Text = dtgvND.CurrentRow.Cells[1].Value.ToString();
            txtGia.Text = dtgvND.CurrentRow.Cells[2].Value.ToString();

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            int phieu = DAO_QL_DatNguyenLieu.LayIDPhieuDatVuaTao();
            int idNguyenLieu = DAO_QL_DatNguyenLieu.LayIDNguyeLieu(cbbTenNL.Text.ToString());
            int soluong = int.Parse(txtSL.Text.ToString());
            int gia = int.Parse(txtGia.Text.ToString());
            try
            {
                if (DAO_QL_DatNguyenLieu.capNhatNguyenLieu(phieu, idNguyenLieu, soluong, gia ))
                {
                    MessageBox.Show("Sửa thông tin nguyên liệu trong phiếu thành công", "Thông báo", MessageBoxButtons.OK);
                    dtgvND.DataSource = DAO_QL_DatNguyenLieu.LoadThongTinPhieuDat(phieu);
                    dtgvTT.DataSource = DAO_QL_DatNguyenLieu.LoadPhieuDat(phieu);
                }
                else
                {
                    MessageBox.Show("Sửa thông tin nguyên liệu trong phiếu thất bại", "Thông báo", MessageBoxButtons.OK);
                }
            }
            catch
            {
                MessageBox.Show("Sửa thông tin nguyên liệu trong phiếu thất bại", "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}
