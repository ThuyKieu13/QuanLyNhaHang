using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
  public  class DAO_QL_Luong
    {
       static SqlConnection con = KetNoiCSDL.cnn;
       public DataSet ds = new DataSet();
       public static DataTable loadLuong(int thang,int nam)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_HienThiLuongNhanVien",con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pa1 = new SqlParameter("@thang",SqlDbType.Int);
                pa1.Value = thang;
                SqlParameter pa2 = new SqlParameter("@nam",SqlDbType.Int);
                pa2.Value = nam;
                cmd.Parameters.Add(pa1);
                cmd.Parameters.Add(pa2);
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
            return dt ;
        }
       public static bool UPDATELuong(int luong, int idNV, int thang, int nam)
       {
           try
           {
               con.Open();
               string sql = "UPDATE dbo.Luong SET luong = " + luong + " WHERE  idNhanvien=" + idNV + " AND thang=" + thang + " and nam= " + nam;
               SqlCommand cmd = new SqlCommand(sql, con);
               cmd.ExecuteNonQuery();
               return true;
           }
           catch
           {
               return false;
           }
           finally
           {
               con.Close();
           }
       }  
        public static DataTable LoadLuongMacDinh()
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_HienThiLuongNhanVienDefault", con);
                cmd.CommandType = CommandType.StoredProcedure;
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
