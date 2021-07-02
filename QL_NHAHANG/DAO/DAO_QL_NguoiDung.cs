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
    public class DAO_QL_NguoiDung
    {
        static SqlConnection con = KetNoiCSDL.cnn;
        public static int sp_KiemTraDangNhap(string tenDangnhap, string matKhau)
        {
            try
            {
                int kq = 0;
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_KiemTraDangNhap", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter pa1 = new SqlParameter("@tenDangnhap", System.Data.SqlDbType.NVarChar);
                pa1.Value = tenDangnhap;
                SqlParameter pa2 = new SqlParameter("@Matkhau", System.Data.SqlDbType.NVarChar);
                pa2.Value = matKhau;
                SqlParameter pa3 = new SqlParameter("@Kq", System.Data.SqlDbType.Int);
                pa3.Value = kq;
                pa3.Direction = System.Data.ParameterDirection.Output;
                pa3.Value = kq;
                cmd.Parameters.Add(pa1);
                cmd.Parameters.Add(pa2);
                cmd.Parameters.Add(pa3);
                cmd.ExecuteNonQuery();
                return (int)pa3.Value;
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
        public static int KTLoaiTaiKhoan(string tenDN)
        {
            int kq = 0;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spKiemTraTaiKhoanId", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pa1 = new SqlParameter("@tenDangnhap", SqlDbType.NVarChar);
                pa1.Value = tenDN;
                SqlParameter pa2 = new SqlParameter("@kq", con);
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
            return 0;
        }
        public static DataTable LoadKieuNguoiDung()
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                string sql = "SELECT * FROM dbo.KieuNguoiDung";
                SqlCommand cmd = new SqlCommand(sql, con);
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
        public static bool ThemTaiKhoan(int kieuND, string tenHienThi, string tenDN, string matKhau)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_ThemNguoiDung", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pa1 = new SqlParameter("@idKieunguoidung", SqlDbType.Int);
                pa1.Value = kieuND;
                SqlParameter pa2 = new SqlParameter("@tenHienthi", SqlDbType.NVarChar);
                pa2.Value = tenHienThi;
                SqlParameter pa3 = new SqlParameter("@tenDangnhap", SqlDbType.NVarChar);
                pa3.Value = tenDN;
                SqlParameter pa4 = new SqlParameter("@matKhau", SqlDbType.NVarChar);
                pa4.Value = matKhau;
                cmd.Parameters.Add(pa1);
                cmd.Parameters.Add(pa2);
                cmd.Parameters.Add(pa3);
                cmd.Parameters.Add(pa4);
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
        public static int KTTenDN(string tenDN)
        {
            try
            {
                con.Open();
                string sql = "SELECT COUNT(*) FROM dbo.NguoiDung WHERE tenDangnhap='" + tenDN + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                int kq = (int)cmd.ExecuteScalar();
                return kq;
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
    } 
}
