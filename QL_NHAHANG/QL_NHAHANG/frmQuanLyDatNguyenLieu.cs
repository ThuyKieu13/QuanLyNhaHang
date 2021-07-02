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
    public partial class frmQuanLyDatNguyenLieu : Form
    {
        public frmQuanLyDatNguyenLieu()
        {
            InitializeComponent();
        }
        public string tenDN = "";
        private void frmDatNguyenLieu_Load(object sender, EventArgs e)
        {
            dtgvDsPhieuDat.DataSource = DAO_QL_DatNguyenLieu.LoadDanhSachPhieuDat();
        }
        private void dtgvDsPhieuDat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgvThongTinPhieuDat.Show();
            int idPhieu = int.Parse(dtgvDsPhieuDat.CurrentRow.Cells[0].Value.ToString());
            dtgvThongTinPhieuDat.DataSource = DAO_QL_DatNguyenLieu.LoadThongTinPhieuDat(idPhieu);
            txtTenNV.Text = dtgvDsPhieuDat.CurrentRow.Cells[4].Value.ToString();
            txtNgayLap.Text = dtgvDsPhieuDat.CurrentRow.Cells[2].Value.ToString();
            txtTongTien.Text = dtgvDsPhieuDat.CurrentRow.Cells[3].Value.ToString();
            txtNCC.Text = dtgvDsPhieuDat.CurrentRow.Cells[5].Value.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmDatNguyenLieu frmDatNL = new frmDatNguyenLieu();
            frmDatNL.TenDN = tenDN;
            frmDatNL.ShowDialog();
        }
        private void btnReLoad_Click(object sender, EventArgs e)
        {
            dtgvDsPhieuDat.DataSource = DAO_QL_DatNguyenLieu.LoadDanhSachPhieuDat();
            dtgvThongTinPhieuDat.Hide();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
