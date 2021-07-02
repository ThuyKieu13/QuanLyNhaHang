using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DAO;
using DTO;

namespace QL_NHAHANG
{
    public partial class frmQuanLyBan : Form
    {
        private DAO_QL_MonAn mon;
        private DAO_QL_HoaDon hoaDon;
        private DAO_QL_NguoiDung nguoiDung;
        private DAO_QL_BanAn Ban;
        public frmQuanLyBan()
        {
            InitializeComponent();
            //this.nguoiDung = nguoiDung;
            mon = new DAO_QL_MonAn();
            hoaDon = new DAO_QL_HoaDon();
            Ban = new DAO_QL_BanAn();           
        }
        //Hiển thị danh sách bàn
        public void loadTable()
        {
            DAO_QL_BanAn dAO_Ban = new DAO_QL_BanAn();
            List<DTO_QL_BanAn> tl = dAO_Ban.getTableList();
            foreach (DTO_QL_BanAn item in tl)
            {
                Button btn = new Button()
                {
                    Width = 85,
                    Height = 80
                };
                btn.Text = item.TenBan;
                btn.Font = new Font("Times New Roman", 12);
                btn.Click += btnBan_Click;
                btn.Tag = item;// gán thẻ
                switch (item.TinhTrang) // ktra tình trạng( nếu 0 không có ng thì màu vàng  ngược lại màu xanh)
                {
                    case 0:
                        btn.BackColor = Color.White;
                        break;
                    case 1:
                        btn.BackColor = Color.Aqua;
                        break;
                }
                btn.ForeColor = Color.Black;
                floDanhSachBan.Controls.Add(btn);// add vào flow layout panel 
            }
            lblThanhTien.Text = string.Format("{0:0,0 VNĐ}", 0);// gán thánh tiền 0
        }
        //Load danh sách bàn chuyển bàn vào cobombox chuyển bàn
        public void LoadDSCBOBanAN()
        {
            cboChuyenBan.DisplayMember = "tenBan";                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   
            cboChuyenBan.ValueMember = "idBan";
            cboChuyenBan.DataSource = DAO_QL_BanAn.LoadDSCBOBanAN();
        }
        //Lấy sự kiện click của các button bàn
        private void btnBan_Click(object sender, EventArgs e)
        {
            int idBan = ((sender as Button).Tag as DTO_QL_BanAn).IdBan;//  gán idban  thông qua sự kiện click vào button bàn 
            string tenBan = ((sender as Button).Tag as DTO_QL_BanAn).TenBan;
            lstvThongTinBan.Tag = (sender as Button).Tag;// gán thẻ (button gán vào list)
            txtTenBan.Text = tenBan;
            HienThiHDTheoBan(idBan);
        }
        //Lấy chi tiết hóa đơn theo mã bàn
        public void HienThiHDTheoBan(int idBan)
        {
            int tongtien = 0;
            DataTable dt = DAO_QL_HoaDon.LayChiTietHoaDon(idBan);
            lstvThongTinBan.Clear();
            lstvThongTinBan.View = View.Details;// hiển thị chi tiết
            lstvThongTinBan.Columns.Add("Tên Món").Width = 90;
            lstvThongTinBan.Columns.Add("Đơn Giá").Width = 120;
            lstvThongTinBan.Columns.Add("Số Lương").Width = 120;
            lstvThongTinBan.Columns.Add("Thành Tiền").Width = 120;
            lstvThongTinBan.GridLines = true;
            lstvThongTinBan.FullRowSelect = true;// hiện tât cả
            int i = 0;
            foreach (DataRow dr in dt.Rows)
            {
                lstvThongTinBan.Items.Add(dr["tenMon"].ToString());
                lstvThongTinBan.Items[i].SubItems.Add(dr["donGia"].ToString());
                lstvThongTinBan.Items[i].SubItems.Add(dr["soLuong"].ToString());
                lstvThongTinBan.Items[i].SubItems.Add(dr["thanhTien"].ToString());
                tongtien += int.Parse(dr["thanhTien"].ToString());
                i++;
            }
            lblThanhTien.Text = string.Format("{0:0,0}", tongtien);
        }   
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            DTO_QL_BanAn BanAn = lstvThongTinBan.Tag as DTO_QL_BanAn;// ép kiểu là dto ban 
            if (BanAn == null)
            {
                MessageBox.Show("Bạn chưa chọn bàn mời bạn chọn bàn","Thông Báo");
                return;
            }
            int idBan = BanAn.IdBan;
            int idHoaDon = 0;
            idHoaDon = DAO_QL_HoaDon.LayIdHoaDon(idBan);
            int tongtien = DAO_QL_HoaDon.LayTongTienTheoHoaDon(idHoaDon);
            int giamgia = int.Parse(txtGiamGia.Text);
            if (giamgia > tongtien)
            {
                MessageBox.Show("Giảm giá phải nhỏ hơn tổng số tiền", "Thông báo");
                txtGiamGia.Focus();
            }
             int thanhToan = tongtien - giamgia;
            txtThanhToan.Text = string.Format("{0:0,0 đ}", thanhToan);
            if (MessageBox.Show("Bạn có chắc muốn thanh toán  không?", "Thông Báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                DAO_QL_HoaDon.UPDATEHoaDon(idHoaDon, (DAO_QL_HoaDon.LayTongTienTheoHoaDon(idHoaDon) - int.Parse(txtGiamGia.Text)));// cập bàn này đã thanh toán 
                DAO_QL_HoaDon.UPDATETinhTrangBan0(idBan);// cập nhật trạng bàn khi đã thanh toán = 0;
                floDanhSachBan.Controls.Clear();
                loadBan();
                loadTable();
            }
            txtGiamGia.Text = "0";
            txtThanhToan.Clear();
        }
        private void btnLau_Click(object sender, EventArgs e)
        {
            cboMon.DisplayMember = "tenMon";
            cboMon.ValueMember = "idMon";
            cboMon.DataSource=DAO_QL_MonAn.loadDsMonTheoDM(1);
        }
        private void btnCom_Click(object sender, EventArgs e)
        {
            cboMon.DisplayMember = "tenMon";
            cboMon.ValueMember = "idMon";
            cboMon.DataSource = DAO_QL_MonAn.loadDsMonTheoDM(3);
        }
        private void btnHap_Click(object sender, EventArgs e)
        {
            cboMon.DisplayMember = "tenMon";
            cboMon.ValueMember = "idMon";
            cboMon.DataSource = DAO_QL_MonAn.loadDsMonTheoDM(4);
        }
        private void btnNuocUong_Click(object sender, EventArgs e)
        {
            cboMon.DisplayMember = "tenMon";
            cboMon.ValueMember = "idMon";
            cboMon.DataSource = DAO_QL_MonAn.loadDsMonTheoDM(5);
        }
        private void btnKhac_Click(object sender, EventArgs e)
        {
            cboMon.DisplayMember = "tenMon";
            cboMon.ValueMember = "idMon";
            cboMon.DataSource = DAO_QL_MonAn.loadDsMonTheoDM(6);
        }
        // order món 
        private void btnOrder_Click(object sender, EventArgs e)
        {
            DTO_QL_BanAn  BanAn = lstvThongTinBan.Tag as DTO_QL_BanAn;
            if (BanAn == null)
            {
                MessageBox.Show("Bạn chưa chọn bàn mời bạn chọn bàn", "Thông Báo");
                return;
            }
            else if (cboMon.SelectedValue == null)
            {
                MessageBox.Show("Bạn chưa chọn món  mời bạn chọn món", "Thông Báo");
                return;
            }
            int idBan = BanAn.IdBan;
            int idHoaDon = 0;
            int idMon = int.Parse(cboMon.SelectedValue.ToString());
            int soLuong = int.Parse(numSL.Value.ToString());
            idHoaDon = DAO_QL_HoaDon.LayIdHoaDon(idBan);
            if (DAO_QL_HoaDon.KTTinhTrangBan(idBan) == 0)// chưa có thì ktra tình trạng  bàn có người hay chưa 
            {
                if (idHoaDon == -1)// có hay chưa
                {
                  
                    DAO_QL_HoaDon.ThemHoaDon(idBan);
                    DAO_QL_HoaDon.UPDATETinhTrangBan1(idBan);
                    DAO_QL_HoaDon.ThemChiTietHoaDon(DAO_QL_HoaDon.LayIdHoaDon(idBan),idMon,soLuong);
                    floDanhSachBan.Controls.Clear();
                    loadBan();
                    loadTable();
                    HienThiHDTheoBan(idBan);
                }
            }
            else
            {
                DAO_QL_HoaDon.ThemChiTietHoaDon(idHoaDon,idMon,soLuong);
                HienThiHDTheoBan(idBan);
            }
        }
        //Lấy tên món ăn đưa vào text box thông qua sự kiện click vào listView chi tiết hóa đơn
        private void lstvThongTinBan_SelectedIndexChanged(object sender, EventArgs e)
        {           
            ListView lsv = sender as ListView;
            if (lstvThongTinBan.SelectedItems.Count > 0)
            {
                ListViewItem item = lsv.SelectedItems[0];
                txtTenMon.Text = item.Text;
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DTO_QL_BanAn BanAn = lstvThongTinBan.Tag as DTO_QL_BanAn;
            if (BanAn == null)
            {
                MessageBox.Show("Bạn chưa chọn bàn mời bạn chon", "Thông Báo");
                return;
            }
            if (txtTenMon.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn món mời bạn chon", "Thông Báo");
                return;
            }
            int idBan = BanAn.IdBan;
            int idHoaDon = 0;
            idHoaDon = DAO_QL_HoaDon.LayIdHoaDon(idBan);
            DAO_QL_HoaDon.XoaMonKhoiHoaDon(idHoaDon, txtTenMon.Text);
            HienThiHDTheoBan(idBan);
        }       
        private void btnChuyenBan_Click(object sender, EventArgs e)
        {
            DTO_QL_BanAn BanAn = lstvThongTinBan.Tag as DTO_QL_BanAn;
            int idBan1 = BanAn.IdBan;
            int idBan2 = int.Parse(cboChuyenBan.SelectedValue.ToString());
            if (BanAn == null)
            {
                MessageBox.Show("Bạn chưa chọn bàn mời bạn chọn", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show(string.Format("Bạn có chắc chắn chuyến từ {0} sang bàn {1} hay không????", BanAn.TenBan, idBan2 - 1), "Thông Báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (DAO_QL_BanAn.chuyenBan(idBan1, idBan2))
                {
                    DAO_QL_BanAn.chuyenBan(idBan1, idBan2);
                    DAO_QL_HoaDon.UPDATETinhTrangBan0(idBan1);
                    DAO_QL_HoaDon.UPDATETinhTrangBan1(idBan2);
                    floDanhSachBan.Controls.Clear();
                    loadTable();
                }
                else
                {
                    MessageBox.Show("Không thể chuyển được");
                }
            }
        }           
        private void btnDoNuong_Click(object sender, EventArgs e)
        {
            cboMon.DisplayMember = "tenMon";            
            cboMon.ValueMember = "idMon";
            cboMon.DataSource = DAO_QL_MonAn.loadDsMonTheoDM(2);
        }     
        private void txtGiamGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void btn_Click(object sender, EventArgs e)
        {
            int idBan = ((sender as Button).Tag as DTO_QL_BanAn).IdBan;
            string tenBan = ((sender as Button).Tag as DTO_QL_BanAn).TenBan;
            lstvThongTinBan.Tag = (sender as Button).Tag;
            lblTenBan.Text = tenBan;
            HienThiHDTheoBan(idBan);
        }
        public void loadBan()
        {
            //flowBan.Controls.Clear();
            int width = 133;
            DAO_QL_BanAn dAO_Ban = new DAO_QL_BanAn();
            List<DTO_QL_BanAn> bans = dAO_Ban.getTableList();
            foreach (DTO_QL_BanAn ban in bans)
            {
                Button btn = new Button() { Width = width, Height = 119, };
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 1;
                btn.ForeColor = Color.DarkBlue;
                //Button btn = new Button() { Width = (int)140F, Height = (int)130F, };
                btn.Text = ban.TenBan;
                btn.Font = new Font("Times New Roman", 14);
                btn.Click += btn_Click;
                btn.Tag = ban;
                switch (ban.TinhTrang)
                {
                    case 1:
                        btn.BackColor = Color.Crimson;
                        break;
                    case 0:
                        btn.BackColor = Color.White;
                        break;
                }
                //flowBan.Controls.Add(btn);
            }
            txtThanhToan.Text = string.Format("{0:0,0 VNĐ}", 0);
        }
        private void frmQuanLyBan_Load(object sender, EventArgs e)
        {           
            loadTable();
            LoadDSCBOBanAN();
        }      
    }
}
