using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace DTO
{
   public class DTO_QL_MonAn
    {
        int idMon;
        int idDanhmuc;
        string tenMon;
        int dongia;
        int tinhtrang;
        public int IdMon
        {
            get { return idMon; }
            set { idMon = value; }
        }
        public int IdDanhmuc
        {
            get { return idDanhmuc; }
            set { idDanhmuc = value; }
        }
        public string TenMon
        {
            get { return tenMon; }
            set { tenMon = value; }
        }    
        public int Dongia
        {
            get { return dongia; }
            set { dongia = value; }
        }       
        public int Tinhtrang
        {
            get { return tinhtrang; }
            set { tinhtrang = value; }
        }
        public DTO_QL_MonAn(string tenMon)
        {
        }
        public DTO_QL_MonAn(DataRow dr)
        {
            this.idMon = (int)(dr["idMon"]);
            this.tenMon = dr["tenMon"].ToString();
            this.dongia=(int)dr["donGia"];
            this.tinhtrang = (int)(dr["tinhTrangMon"]);
        }
    }
}
