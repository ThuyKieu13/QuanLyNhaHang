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
    public partial class frmQuanLyTaiChinh : Form
    {
        DataTable dt;
        public frmQuanLyTaiChinh()
        {
            InitializeComponent();
            dt = new DataTable();
            LoadCBoBan();
        }
        public void LoadCBoBan()
        {
            cboBan.DataSource = DAO_QL_BanAn.LoadDSCBOBanAN();
            cboBan.DisplayMember = "tenBan";
            cboBan.ValueMember = "idBan";
        }
        public void LoadData(int ngay, int thang, int nam)
        {
            dt = DAO_QL_DoanhThu.loadHoaDonTheoNgay(ngay, thang, nam);
            gridHoaDon.DataSource = dt;
            LoadGridTienBan();
        }
        public void LoadData(int thang, int nam)
        {
            dt = DAO_QL_DoanhThu.LoadHoaDonTheoThang(thang, nam);
            gridHoaDon.DataSource = dt;
            LoadGridTienBan();
        }
        public void LoadData(int idBan, int ngay, int thang, int nam)
        {
            dt = DAO_QL_DoanhThu.loadHoaDonTheoBan(idBan, ngay, thang, nam);
            gridHoaDon.DataSource = dt;
            LoadGridTienBan();
        }
        public void LoadGridTienBan()
        {
            gridHoaDon.Columns[0].HeaderText = "Mã HD";
            gridHoaDon.Columns[0].Width = 90;
            gridHoaDon.Columns[1].HeaderText = "Mã bàn";
            gridHoaDon.Columns[1].Width = 90;
            gridHoaDon.Columns[2].HeaderText = "Ngày nhập";
            gridHoaDon.Columns[2].Width = 230;
            gridHoaDon.Columns[3].HeaderText = "Ngày xuất";
            gridHoaDon.Columns[3].Width = 230;
            gridHoaDon.Columns[4].HeaderText = "Tình trạng";
            gridHoaDon.Columns[4].Width = 100;
            gridHoaDon.Columns[5].HeaderText = "Tổng tiền";
            gridHoaDon.Columns[5].Width = 200;
        }
        private void frmQuanLyTaiChinh_Load(object sender, EventArgs e)
        {
            cboThang.SelectedIndex = 0;
            cboNam.SelectedIndex = 0;
        }
        private void btnLocBan_Click(object sender, EventArgs e)
        {
            DateTime dt = NgayBan.Value;
            int ngay = dt.Day;
            int thang = dt.Month;
            int nam = dt.Year;
            int ban = int.Parse(cboBan.SelectedValue.ToString());
            LoadData(ban, ngay, thang, nam);
            int tienBan = DAO_QL_DoanhThu.layDoanhThuNgayTheoBan(ban, ngay, thang, nam);
            txtTheoBan.Text = string.Format("{0:0,0 VNĐ}", tienBan);
        }
        private void btnLocNgay_Click(object sender, EventArgs e)
        {
            DateTime dt = NgayBan.Value;
            int ngay = dt.Day;
            int thang = dt.Month;
            int nam = dt.Year;
            LoadData(ngay, thang, nam);
            int tienBan = DAO_QL_DoanhThu.layDoanhThuNgay(ngay, thang, nam);
            txtHDNgay.Text = string.Format("{0:0,0 VNĐ}", tienBan);
        }
        private void btnLocThang_Click(object sender, EventArgs e)
        {
            DateTime dt = NgayBan.Value;
            int ngay = dt.Day;
            int thang = int.Parse(cboThang.Text);
            int nam = dt.Year;
            LoadData(thang, nam);
            int tienBan = DAO_QL_DoanhThu.LayDoanhThuThang(thang, nam);
            txtHDThang.Text = string.Format("{0:0,0 VNĐ}", tienBan);
        }
    }
}
