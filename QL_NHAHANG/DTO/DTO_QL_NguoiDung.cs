using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class DTO_QL_NguoiDung
    {
        string tenDangNhap;
        string matKhau;
        string tenHienThi;
        int idKieuNguoiDung;
        public string TenDangNhap
        {
            get { return tenDangNhap; }
            set { tenDangNhap = value; }
        }     
        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }       
        public string TenHienThi
        {
            get { return tenHienThi; }
            set { tenHienThi = value; }
        }       
        public int IdKieuNguoiDung
        {
            get { return idKieuNguoiDung; }
            set { idKieuNguoiDung = value; }
        }
    }
}
