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
    public partial class frmChamCong : Form
    {
        DataColumn[] primaryKey;
        DataTable dtcc;
        public frmChamCong()
        {
            InitializeComponent();
            primaryKey = new DataColumn[1];
            dtcc = new DataTable();
        }
        public void loadData()
        {
            dtcc = DAO_QL_ChamCong.LoadDSChamCong();
            primaryKey[0] = dtcc.Columns[0];
            dtcc.PrimaryKey = primaryKey;
            DataBinding(dtcc);
        }
        public void DataBinding(DataTable dt)
        {
            txtMaCC.DataBindings.Clear();
            Binding b1 = new Binding("Text", dt, "idChamcong", true, DataSourceUpdateMode.Never);
            txtMaCC.DataBindings.Add(b1);

            txtSNL.DataBindings.Clear();
            Binding b2 = new Binding("Text", dt, "soNgaylamviec", true, DataSourceUpdateMode.Never);
            txtSNL.DataBindings.Add(b2);

            txtThang.DataBindings.Clear();
            Binding b3 = new Binding("Text", dt, "thang", true, DataSourceUpdateMode.Never);
            txtThang.DataBindings.Add(b3);
        }
        public void load_Grid_DSCC()
        {
            gribDSChamCong.DataSource = dtcc;
            gribDSChamCong.Columns[0].HeaderText = "ID Chấm công";
            gribDSChamCong.Columns[0].Width = 170;
            gribDSChamCong.Columns[1].HeaderText = "Số ngày công";
            gribDSChamCong.Columns[1].Width = 170;
            gribDSChamCong.Columns[2].HeaderText = "Tháng";
            gribDSChamCong.Columns[2].Width = 170;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtSNL.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập vào số ngày công");
                txtSNL.Focus();
                return;
            }
            if (txtThang.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tháng vào ô nhập tháng");
                txtThang.Focus();
                return;
            }
            int soNgaylamviec = int.Parse(txtSNL.Text.Trim());
            int thang = int.Parse(txtThang.Text.Trim());
            if (DAO_QL_ChamCong.themChamCong(soNgaylamviec, thang))
            {
                loadData();
                load_Grid_DSCC();
            }
            else
            {
                MessageBox.Show("Thêm không thành công");
            }
        }
        private void frmChamCong_Load(object sender, EventArgs e)
        {
            loadData();
            load_Grid_DSCC();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaCC.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn mã chấm công");
                return;
            }
            if (DAO_QL_ChamCong.XoaChamCong(txtMaCC.Text))
            {
                loadData();
                load_Grid_DSCC();
            }
            else
            {
                MessageBox.Show("Xóa không thành công");
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaCC.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn mã chấm công");
                return;
            }
            if (txtSNL.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập vào số ngày công");
                txtSNL.Focus();
                return;
            }
            if (txtThang.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tháng vào ô nhập tháng");
                txtThang.Focus();
                return;
            }
            if (DAO_QL_ChamCong.UPDATEChamCong(txtMaCC.Text, txtSNL.Text, txtThang.Text))
            {
                loadData();
                load_Grid_DSCC();
            }
            else
            {
                MessageBox.Show("Sửa không thành công");
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSNL.Clear();
            txtThang.Clear();
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtThang.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tháng vào ô nhập tháng");
                txtThang.Focus();
                return;
            }
            if (DAO_QL_ChamCong.UPDETThang(txtThang.Text.Trim()))
            {
                loadData();
                load_Grid_DSCC();
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công");
            }
        }
        private void txtSNL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtThang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSNL_Leave(object sender, EventArgs e)
        {
            int snc = int.Parse(txtSNL.Text.Trim());
            if (snc > 31)
            {
                MessageBox.Show("Ngày công phải ít hơn 31 nhé");
                txtSNL.Focus();
            }
        }
        private void txtThang_Leave(object sender, EventArgs e)
        {
            int thang = int.Parse(txtThang.Text.Trim());
            if (thang > 12)
            {
                MessageBox.Show("Tháng không nhiều hơn 12 nhé");
                txtThang.Focus();
            }
        }
        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (txtMaCC.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn mã chấm công");
                return;
            }
            if (DAO_QL_ChamCong.XoaChamCong(txtMaCC.Text))
            {
                loadData();
                load_Grid_DSCC();
            }
            else
            {
                MessageBox.Show("Xóa không thành công");
            }
        }
        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            txtSNL.Clear();
            txtThang.Clear();
        }
    }
}