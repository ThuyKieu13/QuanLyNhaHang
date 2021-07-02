using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
   public class DAO_QL_DoanhThu
    {
       static SqlConnection con = KetNoiCSDL.cnn;
       public static DataTable loadHoaDonTheoNgay(int ngay, int thang, int nam)
       {
           DataTable dt = new DataTable();
           try
           {
               con.Open();
               SqlCommand cmd = new SqlCommand("sp_TienBanNgay", con);
               cmd.CommandType = CommandType.StoredProcedure;
               SqlParameter par1 = new SqlParameter("@ngay", SqlDbType.Int);
               par1.Value = ngay;
               SqlParameter par2 = new SqlParameter("@thang", SqlDbType.Int);
               par2.Value = thang;
               SqlParameter par3 = new SqlParameter("@nam", SqlDbType.Int);
               par3.Value = nam;
               cmd.Parameters.Add(par1);
               cmd.Parameters.Add(par2);
               cmd.Parameters.Add(par3);
               SqlDataAdapter da = new SqlDataAdapter(cmd);
               da.Fill(dt);
               return dt;
           }
           catch { }
           finally { con.Close(); }
           return dt;
       }
       public static DataTable LoadHoaDonTheoThang(int thang, int nam)
       {
           DataTable dt = new DataTable();
           try
           {
              
               con.Open();
               SqlCommand cmd = new SqlCommand("sp_TienBanThang", con);
               cmd.CommandType = CommandType.StoredProcedure;
               SqlParameter par2 = new SqlParameter("@thang", SqlDbType.Int);
               par2.Value = thang;
               SqlParameter par3 = new SqlParameter("@nam", SqlDbType.Int);
               par3.Value = nam;
               cmd.Parameters.Add(par2);
               cmd.Parameters.Add(par3);
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
       public static DataTable loadHoaDonTheoBan(int idBan, int ngay, int thang, int nam)
       {
           DataTable dt = new DataTable();
           try
           {
               con.Open();
               SqlCommand cmd = new SqlCommand("sp_TienBanTheoBan", con);
               cmd.CommandType = CommandType.StoredProcedure;
               SqlParameter par0 = new SqlParameter("@idBan", SqlDbType.Int);
               par0.Value = idBan;
               SqlParameter par1 = new SqlParameter("@ngay", SqlDbType.Int);
               par1.Value = ngay;
               SqlParameter par2 = new SqlParameter("@thang", SqlDbType.Int);
               par2.Value = thang;
               SqlParameter par3 = new SqlParameter("@nam", SqlDbType.Int);
               par3.Value = nam;
               cmd.Parameters.Add(par0);
               cmd.Parameters.Add(par1);
               cmd.Parameters.Add(par2);
               cmd.Parameters.Add(par3);
               SqlDataAdapter da = new SqlDataAdapter(cmd);
               da.Fill(dt);
               return dt;
           }
           catch { }
           finally { con.Close(); }
           return dt;
       }
        public static int layDoanhThuNgay(int ngay, int thang, int nam)
        {
            try
            {
                con.Open();
                int kq = 0;
                SqlCommand cmd = new SqlCommand("sp_TongDoanhThuNgay", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter par1 = new SqlParameter("@ngay", SqlDbType.Int);
                par1.Value = ngay;
                SqlParameter par2 = new SqlParameter("@thang", SqlDbType.Int);
                par2.Value = thang;
                SqlParameter par3 = new SqlParameter("@nam", SqlDbType.Int);
                par3.Value = nam;
                SqlParameter par4 = new SqlParameter("@DoanhThu", SqlDbType.Int);
                par4.Direction = ParameterDirection.Output;
                par4.Value = kq;
                cmd.Parameters.Add(par1);
                cmd.Parameters.Add(par2);
                cmd.Parameters.Add(par3);
                cmd.Parameters.Add(par4);
                cmd.ExecuteNonQuery();
                return (int)par4.Value;
            }
            catch { return 0; }
            finally { con.Close(); }
        }
        public static int layDoanhThuNgayTheoBan(int idBan, int ngay, int thang, int nam)
        {
            try
            {
                con.Open();
                int kq = 0;
                SqlCommand cmd = new SqlCommand("sp_TongDoanhThuNgayTheoBan", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter par0 = new SqlParameter("@idBan", SqlDbType.Int);
                par0.Value = idBan;
                SqlParameter par1 = new SqlParameter("@ngay", SqlDbType.Int);
                par1.Value = ngay;
                SqlParameter par2 = new SqlParameter("@thang", SqlDbType.Int);
                par2.Value = thang;
                SqlParameter par3 = new SqlParameter("@nam", SqlDbType.Int);
                par3.Value = nam;
                SqlParameter par4 = new SqlParameter("@DoanhThu", SqlDbType.Int);
                par4.Direction = ParameterDirection.Output;
                par4.Value = kq;
                cmd.Parameters.Add(par0);
                cmd.Parameters.Add(par1);
                cmd.Parameters.Add(par2);
                cmd.Parameters.Add(par3);
                cmd.Parameters.Add(par4);
                cmd.ExecuteNonQuery();
                return (int)par4.Value;
            }
            catch { return 0; }
            finally { con.Close(); }
        }
        public static int LayDoanhThuThang(int thang, int nam)
        {
            try
            {
                con.Open();
                int kq = 0;
                SqlCommand cmd = new SqlCommand("sp_TongDoanhThuThang", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pa2 = new SqlParameter("@thang", SqlDbType.Int);
                pa2.Value = thang;
                SqlParameter pa3 = new SqlParameter("@nam", SqlDbType.Int);
                pa3.Value = nam;
                SqlParameter pa4 = new SqlParameter("@DoanhThu", SqlDbType.Int);
                pa4.Direction = ParameterDirection.Output;
                pa4.Value = kq;
                cmd.Parameters.Add(pa2);
                cmd.Parameters.Add(pa3);
                cmd.Parameters.Add(pa4);
                cmd.ExecuteNonQuery();
                return (int)pa4.Value;
            }
            catch { return 0; }
            finally { con.Close(); }
        }  
    }
}
