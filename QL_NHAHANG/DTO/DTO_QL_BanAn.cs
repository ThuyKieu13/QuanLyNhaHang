using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class DTO_QL_BanAn
    {
        int idBan;
        string tenBan;
        int tinhTrang;
        public int IdBan
        {
            get { return idBan; }
            set { idBan = value; }
        }
        public string TenBan
        {
            get { return tenBan; }
            set { tenBan = value; }
        }
        public int TinhTrang
        {
            get { return tinhTrang; }
            set { tinhTrang = value; }
        }
        public  DTO_QL_BanAn(string tenBan, int tinhTrang)
        {
            this.tenBan = tenBan;
            this.tinhTrang = tinhTrang;

        }
        public DTO_QL_BanAn()
        {
        }
        public DTO_QL_BanAn(DataRow dr)
        {
            this.idBan = (int)dr["idBan"];
            this.tenBan = dr["tenBan"].ToString();
            this.tinhTrang = (int)dr["tinhTrang"];
        }
    }
}
