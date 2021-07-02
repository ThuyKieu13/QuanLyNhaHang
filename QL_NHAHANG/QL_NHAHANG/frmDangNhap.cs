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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }      
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thoát", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (r == DialogResult.No || r == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            if (txtTenDangNhap.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên mời bạn nhập");
                txtTenDangNhap.Focus();
                return;
            }
            if (txtMatKhau.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu mời bạn nhập");
                txtMatKhau.Focus();
                return;
            }
            else
            {
                try
                {
                    string userName = txtTenDangNhap.Text;
                    string passWord = txtMatKhau.Text;
                    txtMatKhau.Clear();
                    if (DAO_QL_NguoiDung.sp_KiemTraDangNhap(userName, passWord) == 1)
                    {
                        if (DAO_QL_NguoiDung.KTLoaiTaiKhoan(userName) == 1)
                        {                                                     
                            frmQuanLyNhaHang f1 = new frmQuanLyNhaHang();
                            f1.tenDN = userName;
                            this.Hide();
                            f1.ShowDialog();
                            this.Show();
                        }
                        if (DAO_QL_NguoiDung.KTLoaiTaiKhoan(userName) == 2)
                        {

                        }
                        if (DAO_QL_NguoiDung.KTLoaiTaiKhoan(userName) == 3)
                        {
                            frmThuNgan f2 = new frmThuNgan();
                            this.Hide();
                            f2.ShowDialog();
                            this.Show();
                        }                        
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai mời bạn nhập lại!", "Thông báo");
                        txtTenDangNhap.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Đăng nhập không thành công  mời bạn nhập lại!", "Thông báo");
                }
            }
        }
        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtTenDangNhap.Text.Length == 0)
                {
                    MessageBox.Show("Bạn chưa nhập tên mời bạn nhập ");
                    txtMatKhau.Focus();
                    return;
                }
                if (txtMatKhau.Text.Length == 0)
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu mời bạn nhập");
                    txtMatKhau.Focus();
                    return;
                }
                else
                {
                    try
                    {
                        string userName = txtTenDangNhap.Text;
                        string passWord = txtMatKhau.Text;
                        txtMatKhau.Clear();
                        if (DAO_QL_NguoiDung.sp_KiemTraDangNhap(userName, passWord) == 1)
                        {
                            if (DAO_QL_NguoiDung.KTLoaiTaiKhoan(userName) == 1)
                            {
                                frmQuanLyNhaHang f1 = new frmQuanLyNhaHang();
                                this.Hide();
                                f1.ShowDialog();
                                this.Show();
                            }
                            if (DAO_QL_NguoiDung.KTLoaiTaiKhoan(userName) == 2)
                            {

                            }
                            if (DAO_QL_NguoiDung.KTLoaiTaiKhoan(userName) == 3)
                            {
                                frmThuNgan f2 = new frmThuNgan();
                                this.Hide();
                                f2.ShowDialog();
                                this.Show();
                            }                            
                        }
                        else
                        {
                            MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai!", "Thông báo");
                            txtTenDangNhap.Focus();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Đăng nhập không thành công!", "Thông báo");
                    }
                }
            }
        }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {            
        }
    }
}
