using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
   public class KetNoiCSDL
    {
       // static tĩnh   hk cần khởi tạo
        public static SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-MIKOLH7\\SQLEXPRESS;Initial Catalog=QL_NHAHANG;Integrated Security=True");
    }
}
