using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
   public class DAO_QL_PhuCap
    {
       static SqlConnection con = KetNoiCSDL.cnn;
       public static DataTable LoadPhuCap()
       {
           DataTable dt = new DataTable();
           try
           {
               con.Open();
               SqlCommand cmd = new SqlCommand();
               cmd.CommandText = "SELECT * FROM PhuCap";
               cmd.Connection = con;
               SqlDataAdapter da = new SqlDataAdapter(cmd);
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
