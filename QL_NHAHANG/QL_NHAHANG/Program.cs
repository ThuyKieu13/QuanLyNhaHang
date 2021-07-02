using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NHAHANG
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmDangNhap());
            //Application.Run(new frmCapTKNhanViencs());
            //Application.Run(new frmChamCong());
            //Application.Run(new frmQuanLyLuongNV());
            //Application.Run(new frmQuanLyMonAn());
            //Application.Run(new frmQuanLyNhanVien());
            //Application.Run(new frmQuanLyTaiChinh());
            //Application.Run(new frmThemBanAn());
            //Application.Run(new frmThongTinLienHe());
            //Application.Run(new frmQuanLyNhaHang());
            //Application.Run(new frmQuanLyTonKho());
        }
    }
}
