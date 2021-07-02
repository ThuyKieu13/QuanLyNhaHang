using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_QL_ChamCong
    {
        static SqlConnection con = KetNoiCSDL.cnn;
        public static DataTable LoadDSChamCong()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM dbo.ChamCong";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public static bool themChamCong(int soNgaylamviec, int thang)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_ThemChamCong", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pa1 = new SqlParameter("@soNgaylamviec", SqlDbType.Int);
                pa1.Value = soNgaylamviec;
                SqlParameter pa2 = new SqlParameter("@thang", SqlDbType.Int);
                pa2.Value = thang;
                cmd.Parameters.Add(pa1);
                cmd.Parameters.Add(pa2);
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
         public static bool XoaChamCong(string maCC)
        {
            try
            {
                con.Open();
                string sql = "DELETE  FROM dbo.ChamCong WHERE idChamcong='"+maCC+"'";
                SqlCommand cmd = new SqlCommand(sql,con);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally { 
                con.Close(); 
            }
        }
        public static bool UPDATEChamCong(string maCC,string ngay,string thang)
        {
            try
            {
                con.Open();
                string sql = " UPDATE dbo.ChamCong SET  soNgaylamviec="+ngay+"WHERE idChamcong='"+maCC+"'";
                SqlCommand cmd = new SqlCommand(sql,con);
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
        public static bool UPDETThang(string thang)
        {
            try
            {
                con.Open();
                string sql = " UPDATE dbo.Chamcong SET thang ="+thang;
                SqlCommand cmd = new SqlCommand(sql,con);
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
    }
}
