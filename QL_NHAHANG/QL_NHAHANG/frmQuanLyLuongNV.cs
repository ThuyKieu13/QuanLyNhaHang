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
    public partial class frmQuanLyLuongNV : Form
    {
        DataTable dt;
        public frmQuanLyLuongNV()
        {
            InitializeComponent();
            dt = new DataTable();
        }
        public void loadData()
        {
            dt = DAO_QL_Luong.LoadLuongMacDinh();
            gridNhanVien.DataSource = dt;
            DataBinding(dt);
        }
        public void loadData(int thang, int nam)
        {
            dt = DAO_QL_Luong.loadLuong(thang, nam);
            gridNhanVien.DataSource = dt;
            DataBinding(dt);
        }
        public void loadGridLuong()
        {
            gridNhanVien.Columns[0].HeaderText = "Mã NV";
            gridNhanVien.Columns[0].Width = 50;
            gridNhanVien.Columns[1].HeaderText = "Họ&Tên";
            gridNhanVien.Columns[1].Width = 50;
            gridNhanVien.Columns[2].HeaderText = "Chức vụ";
            gridNhanVien.Columns[2].Width = 50;
            gridNhanVien.Columns[3].HeaderText = "HSL";
            gridNhanVien.Columns[3].Width = 50;
            gridNhanVien.Columns[4].HeaderText = "Phụ cấp";
            gridNhanVien.Columns[4].Width = 50;
            gridNhanVien.Columns[5].HeaderText = "Mã chấm công";
            gridNhanVien.Columns[5].Width = 50;
            gridNhanVien.Columns[6].HeaderText = "Tháng";
            gridNhanVien.Columns[6].Width = 50;
            gridNhanVien.Columns[7].HeaderText = "Năm";
            gridNhanVien.Columns[7].Width = 50;
            gridNhanVien.Columns[8].HeaderText = "Tiền lương";
            gridNhanVien.Columns[8].Width = 50;
        }
        public void DataBinding(DataTable dttb)
        {
            txtHoTen.DataBindings.Clear();
            Binding b1 = new Binding("Text", dttb, "tenNhanvien", true);
            txtHoTen.DataBindings.Add(b1);

            txtChucVu.DataBindings.Clear();
            Binding b2 = new Binding("Text", dttb, "tenChucvu", true);
            txtChucVu.DataBindings.Add(b2);

            txtHSL.DataBindings.Clear();
            Binding b3 = new Binding("Text", dttb, "heSoluong", true);
            txtHSL.DataBindings.Add(b3);

            txtPhuCap.DataBindings.Clear();
            Binding b4 = new Binding("Text", dttb, "tienPhucap", true);
            txtPhuCap.DataBindings.Add(b4);

            txtMaChamCong.DataBindings.Clear();
            Binding b5 = new Binding("Text", dttb, "idChamcong", true);
            txtMaChamCong.DataBindings.Add(b5);

            txtLuong.DataBindings.Clear();
            Binding b6 = new Binding("Text", dttb, "luong", true);
            txtLuong.DataBindings.Add(b6);

            txtThang.DataBindings.Clear();
            Binding b7 = new Binding("Text", dttb, "thang", true);
            txtThang.DataBindings.Add(b7);

            txtNam.DataBindings.Clear();
            Binding b8 = new Binding("Text", dttb, "nam", true);
            txtNam.DataBindings.Add(b8);

            txtMaNV.DataBindings.Clear();
            Binding b9 = new Binding("Text", dttb, "idNhanvien", true);
            txtMaNV.DataBindings.Add(b9);
        }
        private void frmQuanLyLuongNV_Load(object sender, EventArgs e)
        {
        }
        private void btnLocNV_Click(object sender, EventArgs e)
        {
            int thang = int.Parse(cboThang.SelectedItem.ToString());
            int nam = int.Parse(cboNam.SelectedItem.ToString());
            loadData(thang, nam);
        }
        private void btnCapNhatLuong_Click(object sender, EventArgs e)
        {
            if (txtMaChamCong.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn nhân viên");
                return;
            }
            int idNhanvien = int.Parse(txtMaNV.Text.Trim());
            int thang = int.Parse(txtThang.Text.Trim());
            int nam = int.Parse(txtNam.Text.Trim());
            int luong = int.Parse(txtLuong.Text.Trim());
            if (MessageBox.Show("Bạn có chắc chắc muốn cập nhật lương cho nhân viên " + txtHoTen.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                DAO_QL_Luong.UPDATELuong(luong, idNhanvien, thang, nam);
                loadData();
            }
        }
        private void txtLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
