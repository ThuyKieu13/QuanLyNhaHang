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
    public partial class frmQuanLyNL : Form
    {
        public frmQuanLyNL()
        {
            InitializeComponent();
        }
        void ReLoad()
        {
            dataGridView1.DataSource = DAO_QL_NguyenLieu.LoadDanhSachNguyenLieu();
        }
        private void frmQuanLyNL_Load(object sender, EventArgs e)
        {           
            dataGridView1.DataSource = DAO_QL_NguyenLieu.LoadDanhSachNguyenLieu();
        }        
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenNL.Text.Length == 0 && txtDVT.Text.Length == 0 && textBoxSoLuong.Text.Length == 0)
            {
                MessageBox.Show("Bạn cần nhập đủ thông tin tên, số lượng, đơn vị tính để thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string tenNguyenlieu = txtTenNL.Text.ToString().Trim();
            int soLuong = int.Parse(textBoxSoLuong.Text.ToString().Trim());
            string dvt = txtDVT.Text.ToString().Trim();           
            try
            {
                if (DAO_QL_NguyenLieu.KTNguyenLieu(tenNguyenlieu) == 0)
                {
                    if (DAO_QL_NguyenLieu.ThemNguyenLieu(tenNguyenlieu, dvt, soLuong))
                    {
                        MessageBox.Show("Thêm nguyên liêu thành công ", "Thông Báo");
                        ReLoad();
                    }
                    else
                    {
                        MessageBox.Show("Thêm nguyên liệu không thành công ", "Thông Báo");
                    }
                }
                else
                {
                    MessageBox.Show("Nguyên liệu đã tồn tại", "Thông Báo");
                }
            }
            catch
            {
                MessageBox.Show("Thêm nguyên liêu thành công ", "Thông Báo");
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTenNL.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxSoLuong.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtDVT.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn nguyên liệu mời bạn chọn", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            int idNguyenlieu = int.Parse(textBox1.Text);
            if(DAO_QL_NguyenLieu.xoaNguyenLieu(idNguyenlieu))
            {
                MessageBox.Show("Xóa thành công", "Thông Báo");
                ReLoad();
            }
            else
            {
                MessageBox.Show("Xóa thất bại", "Thông Báo");
            }           
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn nguyên liệu mời bạn chọn", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            int idNguyenlieu = int.Parse(textBox1.Text);
            string tenNguyenlieu = txtTenNL.Text;
            int soLuong = int.Parse(textBoxSoLuong.Text);
            string dvt = txtDVT.Text;
            if (DAO_QL_NguyenLieu.capNhatNguyenLieu(idNguyenlieu,tenNguyenlieu,soLuong,dvt))
            {
                MessageBox.Show("Sửa thành công", "Thông Báo");
                ReLoad();
            }
            else
            {
                MessageBox.Show("Sửa thất bại", "Thông Báo");
            }
        }
        private void btnrefresh_Click(object sender, EventArgs e)
        {
            ReLoad();
            textBox1.Clear();
            txtTenNL.Clear();
            textBoxSoLuong.Clear();
            txtDVT.Clear();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Length == 0)
            {
                MessageBox.Show("Nhập tên nguyên liệu cần tìm !", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }           
            string tenNguyenlieu = txtTimKiem.Text;          
            dataGridView1.DataSource = DAO_QL_NguyenLieu.timKiemNguyenLieuTheoTen(tenNguyenlieu);
        }
    }
}
