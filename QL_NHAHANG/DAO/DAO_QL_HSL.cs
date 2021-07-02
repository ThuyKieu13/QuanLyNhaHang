using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
   public class DAO_QL_HSL
    {
        static SqlConnection con = KetNoiCSDL.cnn;
        public static DataTable loadHeSoLuong()
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM  HeSoLuong", con);
                da.Fill(dt);
                return dt;
            }
            catch
            {
            }
            finally 
            {
                con.Close(); 
            }
            return dt;
        }
    }
}
