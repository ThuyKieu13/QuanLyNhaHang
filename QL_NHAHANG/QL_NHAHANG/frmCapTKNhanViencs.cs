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
    public partial class frmCapTKNhanViencs : Form
    {
        public frmCapTKNhanViencs()
        {
            InitializeComponent();
            loadCboNguoiDung();
        }
        private void frmCapTKNhanViencs_Load(object sender, EventArgs e)
        {
        }
        private void btnCapTK_Click(object sender, EventArgs e)
        {
            if (txtTenDN.Text.Length == 0)
            {
                MessageBox.Show("Tên đăng nhập không được thiếu");
                txtTenDN.Focus();
                return;
            }
            if (txtTenHT.Text.Length == 0)
            {
                MessageBox.Show("Tên hiển thị phải được nhập");
                txtTenHT.Focus();
                return;
            }
            if (txtMK.Text.Length == 0)
            {
                MessageBox.Show("Mật khẩu không được trống");
                txtMK.Focus();
                return;
            }
            if (DAO_QL_NguoiDung.KTTenDN(txtTenDN.Text.Trim()) == 1)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại");
                return;
            }
            int idKieunguoidung = int.Parse(cboLoaiTK.SelectedValue.ToString());
            string userName = txtTenDN.Text.Trim();
            string displayName = txtTenHT.Text.Trim();
            string passWord = txtMK.Text.Trim();
            if (DAO_QL_NguoiDung.ThemTaiKhoan(idKieunguoidung, displayName, userName, passWord))
            {
                MessageBox.Show("Cấp tài khoản " + userName + " thành công\n Mật khẩu là: " + passWord);
            }
        }
        public void loadCboNguoiDung()
        {
            cboLoaiTK.DataSource = DAO_QL_NguoiDung.LoadKieuNguoiDung();
            cboLoaiTK.DisplayMember = "tenKieunguoidung";
            cboLoaiTK.ValueMember = "idKieunguoidung";
        }
    }
}