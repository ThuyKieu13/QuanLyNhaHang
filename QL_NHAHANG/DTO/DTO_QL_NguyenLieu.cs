using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class DTO_QL_NguyenLieu
    {
        int idNguyenlieu;
        string tenNguyenlieu;
        int soLuong;
        string dvt;
        public int IdNguyenLieu
        {
            get { return idNguyenlieu; }
            set { idNguyenlieu = value; }
        }
        public string TenNguyenLieu
        {
            get { return tenNguyenlieu; }
            set { tenNguyenlieu = value; }
        }
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        public string DVT
        {
            get { return dvt; }
            set { dvt = value; }
        }
        public DTO_QL_NguyenLieu(string tenNguyenlieu, int soLuong, string dvt)
        {
            this.tenNguyenlieu = tenNguyenlieu;
            this.soLuong = soLuong;
            this.dvt = dvt;

        }
        public DTO_QL_NguyenLieu()
        {
        }
        public DTO_QL_NguyenLieu(DataRow dr)
        {
            this.idNguyenlieu = (int)dr["idNguyenlieu"];
            this.tenNguyenlieu = dr["tenNguyenlieu"].ToString();
            this.soLuong = (int)dr["soLuong"];
            this.dvt = dr["DVT"].ToString();
        }
    }
}
