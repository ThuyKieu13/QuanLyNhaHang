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
    public partial class frmThuNgan : Form
    {
        public frmThuNgan()
        {
            InitializeComponent();
        }
        private void frmThuNgan_Load(object sender, EventArgs e)
        {
            frmQuanLyBan frm = (frmQuanLyBan)Application.OpenForms["frmQuanLyBan"];
            if (frm == null)
            {
                frm = new frmQuanLyBan();
                tabThuNgan.TabPages.Add(frm);
            }
            else
            {
                tabThuNgan.TabPages[frm].Select();
            }
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            frmQuanLyBan frm = (frmQuanLyBan)Application.OpenForms["frmQuanLyBan"];
            if (frm == null)
            {
                frm = new frmQuanLyBan();
                tabThuNgan.TabPages.Add(frm);
            }
            else
            {
                tabThuNgan.TabPages[frm].Select();
            }
        }
        private void tabThuNgan_Load(object sender, EventArgs e)
        {
        }
        private void riboQL_Mon_Click(object sender, EventArgs e)
        {
            frmQuanLyMonAn frm = (frmQuanLyMonAn)Application.OpenForms["frmQuanLyMonAn"];
            if (frm == null)
            {
                frm = new frmQuanLyMonAn();
                tabThuNgan.TabPages.Add(frm);
            }
            else
            {
                tabThuNgan.TabPages[frm].Select();
            }
        }
        private void btnLienHeTN_Click(object sender, EventArgs e)
        {
            frmThongTinLienHe frm = (frmThongTinLienHe)Application.OpenForms["frmThongTinLienHe"];
            if (frm == null)
            {
                frm = new frmThongTinLienHe();
                tabThuNgan.TabPages.Add(frm);
            }
            else
            {
                tabThuNgan.TabPages[frm].Select();
            }
        }
        private void btnTienBan_Click(object sender, EventArgs e)
        {
            frmQuanLyTaiChinh frm = (frmQuanLyTaiChinh)Application.OpenForms["frmQuanLyTaiChinh"];
            if (frm == null)
            {
                frm = new frmQuanLyTaiChinh();
                tabThuNgan.TabPages.Add(frm);
            }
            else
            {
                tabThuNgan.TabPages[frm].Select();
            }
        }
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnThemBan_Click(object sender, EventArgs e)
        {
            frmThemBanAn frm = (frmThemBanAn)Application.OpenForms["frmThemBanAn"];
            if (frm == null)
            {
                frm = new frmThemBanAn();
                tabThuNgan.TabPages.Add(frm);
            }
            else
            {
                tabThuNgan.TabPages[frm].Select();
            }
        }
    }
}
