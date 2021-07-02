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
    public partial class frmQuanLyNhanVien : Form
    {
        DataColumn[] khoachinh;
        DataTable dt;
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
            khoachinh = new DataColumn[1];
            dt = new DataTable();
        }
        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if (txtTenNhanVien.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtDiaChi.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtSoDienThoai.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtNgaySinh.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtMaChamCong.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã chấm công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (DAO_QL_NhanVien.KTMaChamCong(int.Parse(txtMaChamCong.Text.Trim())) == 1)
            {
                MessageBox.Show("Mã chấm công đã thuộc về ai khác rồi!");
                return;
            }
            string tenNV = txtTenNhanVien.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string gioiTinh = cboGioiTinh.Text.Trim();
            string ngaySinh = txtNgaySinh.Text.Trim();
            string sdt = txtSoDienThoai.Text.Trim();
            int idChucvu = (int)cboChucVu.SelectedValue;
            int idHesoluong = (int)cboHeSoLuong.SelectedValue;
            int idPhucap = (int)cboPhuCap.SelectedValue;
            int idChamcong = int.Parse(txtMaChamCong.Text.Trim());
            if (DAO_QL_NhanVien.ThemNhanVien(tenNV, diaChi, gioiTinh, ngaySinh, sdt, idChucvu, idHesoluong, idPhucap, idChamcong))
            {
                load_Data();
                load_Grid_DSNV();
            }
            else
            {
                MessageBox.Show("Thêm không thành công");
            }
        }
        // load dữ liệu vào DataTable nhân viên theo idChucvu
        public void load_Data(int idChucvu)
        {
            dt = DAO_QL_NhanVien.LocNhanVienTheoChucVu(idChucvu);
            khoachinh[0] = dt.Columns[0];
            dt.PrimaryKey = khoachinh;
            DataBinding(dt);
        }
        //Load dữ liệu tìm kiếm
        public void load_Data(string tenNV)
        {
            dt = DAO_QL_NhanVien.LoadThongTinNhanVien(tenNV);
            khoachinh[0] = dt.Columns[0];
            dt.PrimaryKey = khoachinh;
            DataBinding(dt);
        }
        // load dữ liệu vào DataTable nhân viên
        public void load_Data()
        {
            dt = DAO_QL_NhanVien.LoadThongTinNhanVien();
            khoachinh[0] = dt.Columns[0];
            dt.PrimaryKey = khoachinh;
            DataBinding(dt);
        }
        //Binding dữu liệu từ datatable sang textbox
        public void DataBinding(DataTable dt)
        {
            txtMaNhanVien.DataBindings.Clear();
            Binding b1 = new Binding("Text", dt, "idNhanvien", true, DataSourceUpdateMode.Never);
            txtMaNhanVien.DataBindings.Add(b1);

            txtTenNhanVien.DataBindings.Clear();
            Binding b2 = new Binding("Text", dt, "tenNhanvien", true, DataSourceUpdateMode.Never);
            txtTenNhanVien.DataBindings.Add(b2);

            txtDiaChi.DataBindings.Clear();
            Binding b3 = new Binding("Text", dt, "diaChi", true, DataSourceUpdateMode.Never);
            txtDiaChi.DataBindings.Add(b3);

            txtNgaySinh.DataBindings.Clear();
            Binding b4 = new Binding("Text", dt, "ngaySinh", true, DataSourceUpdateMode.Never);
            txtNgaySinh.DataBindings.Add(b4);

            txtSoDienThoai.DataBindings.Clear();
            Binding b5 = new Binding("Text", dt, "soDienthoai", true, DataSourceUpdateMode.Never);
            txtSoDienThoai.DataBindings.Add(b5);

            txtMaChamCong.DataBindings.Clear();
            Binding b6 = new Binding("Text", dt, "idChamcong", true, DataSourceUpdateMode.Never);
            txtMaChamCong.DataBindings.Add(b6);
        }
        public void load_CboChucVu()
        {
            cboChucVu.DataSource = DAO_QL_ChucVu.LoadChucVu();
            cboChucVuNhanVien.DataSource = DAO_QL_ChucVu.LoadChucVu();
            cboChucVu.DisplayMember = "tenChucvu";
            cboChucVu.ValueMember = "idChucvu";
            cboChucVuNhanVien.DisplayMember = "tenChucvu";
            cboChucVuNhanVien.ValueMember = "idChucvu";
        }
        public void load_CboHeSL()
        {
            cboHeSoLuong.DataSource = DAO_QL_HSL.loadHeSoLuong();
            cboHeSoLuong.DisplayMember = "heSoluong";
            cboHeSoLuong.ValueMember = "idHesoluong";
        }
        public void load_CboPhuCap()
        {
            cboPhuCap.DataSource = DAO_QL_PhuCap.LoadPhuCap();
            cboPhuCap.DisplayMember = "tienPhucap";
            cboPhuCap.ValueMember = "idPhucap";
        }
        public void load_Grid_DSNV()
        {
            gridDSNV.DataSource = dt;
            gridDSNV.Columns[0].HeaderText = "ID";
            gridDSNV.Columns[0].Width = 50;
            gridDSNV.Columns[1].HeaderText = "Tên NV";
            gridDSNV.Columns[1].Width = 150;
            gridDSNV.Columns[2].HeaderText = "Địa chỉ";
            gridDSNV.Columns[2].Width = 150;
            gridDSNV.Columns[3].HeaderText = "Giới tính";
            gridDSNV.Columns[3].Width = 80;
            gridDSNV.Columns[4].HeaderText = "Ngày sinh";
            gridDSNV.Columns[4].Width = 100;
            gridDSNV.Columns[5].HeaderText = "SĐT";
            gridDSNV.Columns[5].Width = 130;
            gridDSNV.Columns[6].HeaderText = "Chức vụ";
            gridDSNV.Columns[6].Width = 80;
            gridDSNV.Columns[7].HeaderText = "HSL";
            gridDSNV.Columns[7].Width = 80;
            gridDSNV.Columns[8].HeaderText = "Phụ cấp";
            gridDSNV.Columns[8].Width = 100;
            gridDSNV.Columns[9].HeaderText = "ID chấm công";
            gridDSNV.Columns[9].Width = 50;
        }
        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int idNhanVien = int.Parse(txtMaNhanVien.Text);
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                DAO_QL_NhanVien.XoaNhanVien(idNhanVien);
                load_Data();
                load_Grid_DSNV();
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            load_Data();
            load_Grid_DSNV();
            txtTenNhanVien.Clear();
            txtDiaChi.Clear();
            txtNgaySinh.Clear();
            txtSoDienThoai.Clear();
            txtMaChamCong.Clear();
            txtMaNhanVien.Clear();
        }
        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            if (txtTenNhanVien.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtDiaChi.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtSoDienThoai.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtNgaySinh.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtMaChamCong.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã chấm công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string tenNV = txtTenNhanVien.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string gioiTinh = cboGioiTinh.Text.Trim();
            string ngaySinh = txtNgaySinh.Text.Trim();
            string sdt = txtSoDienThoai.Text.Trim();
            int idChucvu = (int)cboChucVu.SelectedValue;
            int idHesoluong = (int)cboHeSoLuong.SelectedValue;
            int idPhucap = (int)cboPhuCap.SelectedValue;
            int idChamcong = int.Parse(txtMaChamCong.Text.Trim());
            int idNhanvien = int.Parse(txtMaNhanVien.Text.Trim());
            if (DAO_QL_NhanVien.SuaNhanVien(idNhanvien, tenNV, diaChi, gioiTinh, ngaySinh, sdt, idChucvu, idHesoluong, idPhucap, idChamcong))
            {
                MessageBox.Show("Chỉnh sửa thành công");
                load_Data();
                load_Grid_DSNV();
            }
            else
            {
                MessageBox.Show("Chỉnh sửa không thành công");
            }
        }
        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            if (txtMaNhanVien.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn nhân viên");
                return;
            }
            if (txtThuong.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập vào thưởng");
                return;
            }
            int idNhanvien = int.Parse(txtMaNhanVien.Text.Trim());
            int thuong = int.Parse(txtThuong.Text.Trim());
            int thang = now.Month;
            int nam = now.Year;
            if (thang == 1)
            {
                thang = 12;
                nam = nam - 1;
            }
            thang = thang - 1;
            int luong;
            if (DAO_QL_NhanVien.KTLuong(idNhanvien, thang, nam) == 1)
            {

                MessageBox.Show("Lương của nhân viên " + txtTenNhanVien.Text + " đã tồn tại");
                return;
            }
            luong = DAO_QL_NhanVien.TinhLuongNhanVien(idNhanvien, thuong, thang, nam);
            MessageBox.Show("Lương của nhân viên " + txtTenNhanVien.Text.Trim() + " đã được cập nhật: " + luong);
        }
        private void btnLocNV_Click(object sender, EventArgs e)
        {
            load_Data(int.Parse(cboChucVuNhanVien.SelectedValue.ToString()));
            load_Grid_DSNV();
        }
        private void btnTimKiemNV_Click(object sender, EventArgs e)
        {
            load_Data(txtTimKiem.Text.Trim());
            load_Grid_DSNV();
        }
        private void txtMaChamCong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtThuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            load_Data();
            cboGioiTinh.SelectedIndex = 0;
            load_CboChucVu();
            load_CboHeSL();
            load_CboPhuCap();
            load_Grid_DSNV();
        }
    }
}