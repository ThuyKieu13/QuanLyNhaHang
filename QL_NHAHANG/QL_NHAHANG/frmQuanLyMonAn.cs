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
using DTO;
namespace QL_NHAHANG
{
    public partial class frmQuanLyMonAn : Form
    {
        public frmQuanLyMonAn()
        {
            InitializeComponent();           
        }
        private void frmQuanLyMonAn_Load(object sender, EventArgs e)
        {
            LoadDanhSahMonAn();
            LoadDanhMucMonAn();            
        }
        //Hiển thị danh mục món đưa vào combobox danh mục món
        public void LoadDanhMucMonAn()
        {
            cboDanhMucMon.DisplayMember = "tenDanhMuc";
            cboDanhMucMon.ValueMember = "idDanhmuc";
            cboDanhMucMon.DataSource = DAO_QL_DanhMucMon.LoadDanhMucMon();
        }
        //Hiển thị danh sách món vào listView danh sách món
        public void LoadDanhSahMonAn()
        {
            DataTable dt = DAO_QL_MonAn.LoadDanhSachMonAn();
            listDanhSachMonAn.Clear();
            listDanhSachMonAn.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listDanhSachMonAn.View = View.Details;
            listDanhSachMonAn.Columns.Add("ID Món").Width = 90;
            listDanhSachMonAn.Columns.Add("Tên Món").Width = 270;
            listDanhSachMonAn.Columns.Add("Đơn Giá").Width = 150;
            listDanhSachMonAn.Columns.Add("ID Danh Mục").Width = 150;
            listDanhSachMonAn.Columns.Add("Tình Trạng Món").Width = 120;
            listDanhSachMonAn.GridLines = true;
            listDanhSachMonAn.FullRowSelect = true;
            int i = 0;
            foreach (DataRow dr in dt.Rows)
            {
                listDanhSachMonAn.Items.Add(dr["idMon"].ToString());
                listDanhSachMonAn.Items[i].SubItems.Add(dr["tenMon"].ToString());
                listDanhSachMonAn.Items[i].SubItems.Add(dr["donGia"].ToString());
                listDanhSachMonAn.Items[i].SubItems.Add(dr["idDanhmuc"].ToString());
                listDanhSachMonAn.Items[i].SubItems.Add(dr["tinhTrangMon"].ToString());
                i++;
            }          
        }
        //tìm kiếm món theo tên
        public void LoadDSMonTheoTen(string tenMon)
        {
            DataTable dt = DAO_QL_MonAn.timKiemMonAnTheoTen(tenMon);
            listDanhSachMonAn.Clear();
            listDanhSachMonAn.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listDanhSachMonAn.View = View.Details;
            listDanhSachMonAn.Columns.Add("ID Món").Width = 90;
            listDanhSachMonAn.Columns.Add("Tên Món").Width = 270;
            listDanhSachMonAn.Columns.Add("Đơn Giá").Width = 150;
            listDanhSachMonAn.Columns.Add("ID Danh Mục").Width = 150;
            listDanhSachMonAn.Columns.Add("Tình Trạng Món").Width = 120;
            listDanhSachMonAn.GridLines = true;
            listDanhSachMonAn.FullRowSelect = true;
            int i = 0;
            foreach (DataRow row in dt.Rows)
            {
                listDanhSachMonAn.Items.Add(row["idMon"].ToString());
                listDanhSachMonAn.Items[i].SubItems.Add(row["tenMon"].ToString());
                listDanhSachMonAn.Items[i].SubItems.Add(row["donGia"].ToString());
                listDanhSachMonAn.Items[i].SubItems.Add(row["idDanhmuc"].ToString());
                listDanhSachMonAn.Items[i].SubItems.Add(row["tinhTrangMon"].ToString());
                i++;
            }
        }
        //Thêm món vào danh sách món
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenMon.Text.Length == 0 || txtDonGia.Text.Length == 0 || cboDanhMucMon.SelectedValue.ToString().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập món mời bạn nhập món mà bạn muốn thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string tenMon = txtTenMon.Text;
            int donGia = int.Parse(txtDonGia.Text);
            int tinhTrangMon = 1;
            int idDanhmuc = int.Parse(cboDanhMucMon.SelectedValue.ToString());
            try
            {
                if (DAO_QL_MonAn.KTMonAn(tenMon) == 0)
                {
                    if (DAO_QL_MonAn.ThemMon(tenMon, donGia, idDanhmuc, tinhTrangMon) == 1)
                    {
                        LoadDanhSahMonAn();
                    }
                    else
                    {
                        MessageBox.Show("Thêm món ăn không thành công ", "Thông Báo");
                    }
                }
                else
                {
                    MessageBox.Show("Món  ăn này đã có rồi  ", "Thông Báo");
                }
            }
            catch
            {
                MessageBox.Show("Thêm món ăn  thành công ", "Thông Báo");
            }
        }
        //xóa món ăn khỏi danh sách
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtIDMon.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn món mời bạn chọn", "Thông Báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                return;
            }
            int idMon = int.Parse(txtIDMon.Text);
            DAO_QL_MonAn.xoaMon(idMon);
            LoadDanhSahMonAn();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtIDMon.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn món mời bạn chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int idMon = int.Parse(txtIDMon.Text);
            string tenMon = txtTenMon.Text;
            int donGia = int.Parse(txtDonGia.Text);
            int idDanhmuc = int.Parse(cboDanhMucMon.SelectedValue.ToString());
            if (rdoCon.Checked)
            {
                DAO_QL_MonAn.capNhatMon(idMon, tenMon, donGia, idDanhmuc, 1);
            }
            else if (rdoHet.Checked)
            {
                DAO_QL_MonAn.capNhatMon(idMon, tenMon, donGia, idDanhmuc, 0);
            }
            LoadDanhSahMonAn();
        }
        private void btnrefresh_Click(object sender, EventArgs e)
        {
            txtIDMon.Clear();
            txtDonGia.Clear();
        }
        //tìm kiếm món ăn
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tenMon = txtTimKiemMonAn.Text;
            LoadDSMonTheoTen(tenMon);
        }
        //lấy sự kiện enter trong textbox
        private void txtTimKiemMonAn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                string tenMon = txtTimKiemMonAn.Text;
                LoadDSMonTheoTen(tenMon);
            }
        }
        //chặn người dùng nhập chữ vào textbox đơn giá

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        // lấy id món và dữ liệu đưa vào các textbox
        private void listDanhSachMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lv = sender as ListView;
            if (listDanhSachMonAn.SelectedItems.Count > 0)
            {
                ListViewItem listv = lv.SelectedItems[0];
                txtIDMon.Text = listv.Text;
            }
            List<DTO_QL_MonAn> dsMon = DAO_QL_MonAn.LoadThongTinMon(int.Parse(txtIDMon.Text.ToString()));
            foreach (DTO_QL_MonAn mon in dsMon)
            {
                txtTenMon.Text = mon.TenMon.ToString();
                txtDonGia.Text = mon.Dongia.ToString();
            }
        }
    }
}
