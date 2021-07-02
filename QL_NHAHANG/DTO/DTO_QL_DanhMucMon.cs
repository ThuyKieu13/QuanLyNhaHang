using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public  class DTO_QL_DanhMucMon
    {
        int idDanhmuc;
        string tenDanhmuc;
        public int IdDanhmuc
        {
            get { return idDanhmuc; }
            set { idDanhmuc = value; }
        }
        public string TenDanhmuc
        {
            get { return tenDanhmuc; }
            set { tenDanhmuc = value; }
        }
        public DTO_QL_DanhMucMon(int idDanhmuc, string tenDanhmuc)
        {
            this.tenDanhmuc = tenDanhmuc;
            this.idDanhmuc = idDanhmuc;
        }     
    }
}
