using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DAO_QL_MonAn
    {
        static SqlConnection con = KetNoiCSDL.cnn;
        public static int ThemMon(string tenMon, int donGia, int idDanhmuc, int tinhTrangMon)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_ThemMon", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pa1 = new SqlParameter("@tenMon", SqlDbType.NVarChar);
                pa1.Value = tenMon;
                SqlParameter pa2 = new SqlParameter("@donGia", SqlDbType.Int);
                pa2.Value = donGia;
                SqlParameter pa3 = new SqlParameter("@idDanhmuc", SqlDbType.Int);
                pa3.Value = idDanhmuc;
                SqlParameter pa4 = new SqlParameter("@tinhTrangMon", SqlDbType.Int);
                pa4.Value = tinhTrangMon;
                cmd.Parameters.Add(pa1);
                cmd.Parameters.Add(pa2);
                cmd.Parameters.Add(pa3);
                cmd.Parameters.Add(pa4);
                cmd.ExecuteNonQuery();
                return 1;
            }
            catch
            { 
                return -1;
            }
            finally 
            { 
                con.Close();
            }
        }
        public static DataTable LoadDanhSachMonAn()
        {
            SqlConnection con = KetNoiCSDL.cnn;
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dbo.Mon", con);
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
        public static int KTMonAn(string tenMon)
        {
            try
            {
                int kq = 0;
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_KiemTraMon", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pa1 = new SqlParameter("@tenMon", SqlDbType.NVarChar);
                pa1.Value = tenMon;
                SqlParameter pa2 = new SqlParameter("@kq", SqlDbType.Int);
                pa2.Value = kq;
                pa2.Direction = ParameterDirection.Output;
                pa2.Value = kq;
                cmd.Parameters.Add(pa1);
                cmd.Parameters.Add(pa2);
                cmd.ExecuteNonQuery();
                return (int)pa2.Value;
            }
            catch
            {
            }
            finally
            {
                con.Close();
            }
            return -1;
        }
        public static List<DTO_QL_MonAn>  LoadThongTinMon(int idMon)
        {
            List<DTO_QL_MonAn> listMonAn = new List<DTO_QL_MonAn>();
            
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_HienThiMonAnTheoId", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pa1 = new SqlParameter("@idMon", SqlDbType.Int);
                pa1.Value = idMon;
                cmd.Parameters.Add(pa1);
                using (DataTable dt = new DataTable())
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                        foreach (DataRow item in dt.Rows)
                        {
                           DTO_QL_MonAn MonAn = new DTO_QL_MonAn(item);
                           listMonAn.Add(MonAn);
                        }
                    }
                }
            }
            catch
            {
            }
            finally
            {
                con.Close();
            }
            return listMonAn;
        }
        public static DataTable loadDsMonTheoDM(int idDanhmuc)
        {
            DataTable dt = new DataTable();
           
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Mon WHERE idDanhmuc = " + idDanhmuc + "and tinhTrangMon = 1", con);
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
        public static void capNhatMon(int idMon, string tenMon, int donGia, int idDanhmuc, int tinhTrangmon)
        {
             
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_CapNhatMon", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter par1 = new SqlParameter("@idMon", SqlDbType.Int);
                par1.Value = idMon;
                SqlParameter par2 = new SqlParameter("@tenMon", SqlDbType.NVarChar);
                par2.Value = tenMon;
                SqlParameter par3 = new SqlParameter("@donGia", SqlDbType.Int);
                par3.Value = donGia;
                SqlParameter par4 = new SqlParameter("@idDanhmuc", SqlDbType.Int);
                par4.Value = idDanhmuc;
                SqlParameter par5 = new SqlParameter("@tinhTrangmon", SqlDbType.Int);
                par5.Value = tinhTrangmon;
                cmd.Parameters.Add(par1);
                cmd.Parameters.Add(par2);
                cmd.Parameters.Add(par3);
                cmd.Parameters.Add(par4);
                cmd.Parameters.Add(par5);
                cmd.ExecuteNonQuery();
            }
            catch
            {
            }
            finally
            { con.Close(); }
        }
        public static DataTable timKiemMonAnTheoTen(string tenMon)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM dbo.Mon WHERE tenMon LIKE N'" + tenMon + "%'";
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
        public static void xoaMon(int idMon)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "DELETE FROM dbo.Mon WHERE idMon = " + idMon;
                cmd.ExecuteNonQuery();
            }
            catch
            {
            }
            finally
            { 
                con.Close();
            }
        }
    }
}
