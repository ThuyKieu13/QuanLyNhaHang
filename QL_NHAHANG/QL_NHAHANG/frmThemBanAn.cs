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
    public partial class frmThemBanAn : Form
    {
        public frmThemBanAn()
        {
            InitializeComponent();
        }
        private void frmThemBanAn_Load(object sender, EventArgs e)
        {           
        }
        private void btnThemBanMoi_Click(object sender, EventArgs e)
        {
            if (DAO_QL_BanAn.themBanMoi(txtTenBanMoi.Text.Trim()))
            {
                MessageBox.Show("Thêm  bàn mới thành công rồi nè", "Thông Báo");
                frmQuanLyBan frm = new frmQuanLyBan();
                frm.loadTable();
            }
            else
            {
                MessageBox.Show("Thêm không thành công mời bạn kiểm tra lại ", "Thông Báo");
            }
        }
        private void btnXoaThemBanMoi_Click(object sender, EventArgs e)
        {
            
            if (DAO_QL_BanAn.xoaban(txtTenBanMoi.Text.Trim()))
            {
                MessageBox.Show("Xóa  bàn mới thành công rồi nè", "Thông Báo");
            }
            else
            {
                MessageBox.Show("Xóa không thành công mời bạn kiểm tra lại ", "Thông Báo");
            }
        }
        private void frmThemBanAn_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thoát", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (r == DialogResult.No || r == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
