
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NHAHANG
{
    public partial class frmQuanLyNhaHang : Form
    {
        public frmQuanLyNhaHang()
        {
            InitializeComponent();
        }
        public string tenDN = "";
        private void frmQuanLyNhaHang_Load(object sender, EventArgs e)
        
        {
            frmQuanLyBan frm = (frmQuanLyBan)Application.OpenForms["frmQuanLyBan"];
            if (frm == null)
            {
                frm = new frmQuanLyBan();
                tabControl1.TabPages.Add(frm);
            }
            else
            {
                tabControl1.TabPages[frm].Select();
            }
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            frmQuanLyBan frm = (frmQuanLyBan)Application.OpenForms["frmQuanLyBan"];
            if (frm == null)
            {
                frm = new frmQuanLyBan();
                tabControl1.TabPages.Add(frm);
            }
            else
            {
                tabControl1.TabPages[frm].Select();
            }
        }
        private void btnThemBan_Click(object sender, EventArgs e)
        {
            frmThemBanAn frmThemBanAn= (frmThemBanAn)Application.OpenForms["frmThemBanAn"];
            if (frmThemBanAn == null)
            {
                frmThemBanAn = new frmThemBanAn();
                tabControl1.TabPages.Add(frmThemBanAn);
            }
            else
            {
                tabControl1.TabPages[frmThemBanAn].Select();
            }
        }
        private void btnQl_Mon_Click(object sender, EventArgs e)
        {
            frmQuanLyMonAn frm = (frmQuanLyMonAn)Application.OpenForms["frmQuanLyMonAn"];
            if (frm == null)
            {
                frm = new frmQuanLyMonAn();
                tabControl1.TabPages.Add(frm);
            }
            else
            {
                tabControl1.TabPages[frm].Select();
            }
        }
        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            frmQuanLyNhanVien frm = (frmQuanLyNhanVien)Application.OpenForms["frmQuanLyNhanVien"];
            if (frm == null)
            {
                frm = new frmQuanLyNhanVien();
                tabControl1.TabPages.Add(frm);
            }
            else
            {
                tabControl1.TabPages[frm].Select();
            }
        }
        private void btnXemLuong_Click(object sender, EventArgs e)
        {
            frmQuanLyLuongNV frm = (frmQuanLyLuongNV)Application.OpenForms["frmQuanLyLuongNV"];
            if (frm == null)
            {
                frm = new frmQuanLyLuongNV();
                tabControl1.TabPages.Add(frm);
            }
            else
            {
                tabControl1.TabPages[frm].Select();
            }
        }
        private void btnCapTK_Click(object sender, EventArgs e)
        {
            frmCapTKNhanViencs frm = (frmCapTKNhanViencs)Application.OpenForms["frmCapTKNhanViencs"];
            if (frm == null)
            {
                frm = new frmCapTKNhanViencs();
                tabControl1.TabPages.Add(frm);
            }
            else
            {
                tabControl1.TabPages[frm].Select();
            }
        }
        private void btnChamCong_Click(object sender, EventArgs e)
        {
            frmChamCong frm = (frmChamCong)Application.OpenForms["frmChamCong"];
            if (frm == null)
            {
                frm = new frmChamCong();
                tabControl1.TabPages.Add(frm);
            }
            else
            {
                tabControl1.TabPages[frm].Select();
            }
        }
        private void btnLienHe_Click(object sender, EventArgs e)
        {
            frmThongTinLienHe frm = (frmThongTinLienHe)Application.OpenForms["frmThongTinLienHe"];
            if (frm == null)
            {
                frm = new frmThongTinLienHe();
                tabControl1.TabPages.Add(frm);
            }
            else
            {
                tabControl1.TabPages[frm].Select();
            }
        }
        private void btnTienBan_Click(object sender, EventArgs e)
        {
            frmQuanLyTaiChinh frm = (frmQuanLyTaiChinh)Application.OpenForms["frmQuanLyTaiChinh"];
            if (frm == null)
            {
                frm = new frmQuanLyTaiChinh();
                tabControl1.TabPages.Add(frm);
            }
            else
            {
                tabControl1.TabPages[frm].Select();
            }
        }
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();            
        }
        private void rbQLKho_Click(object sender, EventArgs e)
        {
            frmQuanLyDatNguyenLieu frm = (frmQuanLyDatNguyenLieu)Application.OpenForms["frmQuanLyTonKho"];
            if (frm == null)
            {
                frm = new frmQuanLyDatNguyenLieu();
                frm.tenDN = tenDN;
                tabControl1.TabPages.Add(frm);
            }
            else
            {
                tabControl1.TabPages[frm].Select();
            }
        }
        private void rbQLNL_Click(object sender, EventArgs e)
        {
            frmQuanLyNL frm = (frmQuanLyNL)Application.OpenForms["frmQuanLyTonKho"];
            if (frm == null)
            {
                frm = new frmQuanLyNL();
                tabControl1.TabPages.Add(frm);
            }
            else
            {
                tabControl1.TabPages[frm].Select();
            }
        }
        private void rbNhapNL_Click(object sender, EventArgs e)
        {
            frmQuanLyNhapNguyenLieu frm = (frmQuanLyNhapNguyenLieu)Application.OpenForms["frmNhapNguyenLieu"];
            if (frm == null)
            {
                frm = new frmQuanLyNhapNguyenLieu();
                frm.TenDN = tenDN;
                tabControl1.TabPages.Add(frm);
            }
            else
            {
                tabControl1.TabPages[frm].Select();
            }
        }
    }
}
