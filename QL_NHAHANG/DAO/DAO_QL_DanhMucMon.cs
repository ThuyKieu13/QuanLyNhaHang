using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAO
{
    public class DAO_QL_DanhMucMon
    {
        static SqlConnection con = KetNoiCSDL.cnn;
        public static DataTable LoadDanhMucMon()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dbo.DanhMucMon", con);
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
