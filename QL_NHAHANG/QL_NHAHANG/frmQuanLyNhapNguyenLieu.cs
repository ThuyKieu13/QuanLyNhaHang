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
    public partial class frmQuanLyNhapNguyenLieu : Form
    {
        public frmQuanLyNhapNguyenLieu()
        {
            InitializeComponent();
        }
        public string TenDN = "";
        private void frmNhapNguyenLieu_Load(object sender, EventArgs e)
        {           
            dtgvDS.DataSource = DAO_QL_NhapNguyenLieu.LoadDanhSachPhieuNhap();
        }
        private void dtgvDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgvTT.Show();
            int idPhieu = int.Parse(dtgvDS.CurrentRow.Cells[0].Value.ToString());
            dtgvTT.DataSource = DAO_QL_NhapNguyenLieu.LoadThongTinPhieuNhap(idPhieu);
        }
        private void btnNhap_Click(object sender, EventArgs e)
        {
            frmNhapNguyenLieu frm = new frmNhapNguyenLieu();
            frm.TenDN = TenDN;
            frm.ShowDialog();
        }
        private void btnReLoad_Click(object sender, EventArgs e)
        {
            dtgvDS.DataSource = DAO_QL_NhapNguyenLieu.LoadDanhSachPhieuNhap();
            dtgvTT.Hide();
        }    
    }
}
