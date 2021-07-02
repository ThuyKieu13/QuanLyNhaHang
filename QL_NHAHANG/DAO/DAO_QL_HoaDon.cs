using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
   public class DAO_QL_HoaDon
    {
       static SqlConnection con = KetNoiCSDL.cnn;
       //Nếu kết quả trả về 0 thì bàn chưa có người ngồi 
        public static int KTTinhTrangBan(int idBan)
        {
            try
            {
                int kq = 0;
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_KiemTraTinhTrangBan", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pa1 = new SqlParameter("@idBan", SqlDbType.Int);
                pa1.Value = idBan;
                SqlParameter pa2 = new SqlParameter("@kq", SqlDbType.Int);
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
        //sau khi kiểm tra tình trạng bàn thì thêm hóa đơn mới vào bàn đó
        public static void ThemHoaDon(int idBan)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_ThemHoaDon", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter par1 = new SqlParameter("@idBan", SqlDbType.Int);
                par1.Value = idBan;
                cmd.Parameters.Add(par1);
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
        public static void UPDATETinhTrangBan0(int idBan)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_CapNhatTinhTrangBan0", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pa2 = new SqlParameter("@idBan", SqlDbType.Int);
                pa2.Value = idBan;
                cmd.Parameters.Add(pa2);
                cmd.ExecuteNonQuery();
            }
            catch
            { }
            finally
            { 
                con.Close(); 
            }
        }
        public static void UPDATETinhTrangBan1(int idBan)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_CapNhatTinhTrangBan1", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pa2 = new SqlParameter("@idBan", SqlDbType.Int);
                pa2.Value = idBan;
                cmd.Parameters.Add(pa2);
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
        //Chon mã hóa đơn theo idBan
        public static int LayIdHoaDon(int idBan)
        {
            try
            {
                int kq = 0;
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_LayIdHoaDon", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pa1 = new SqlParameter("@idBan", SqlDbType.Int);
                pa1.Value = idBan;
                SqlParameter pa2 = new SqlParameter("@kq", SqlDbType.Int);
                pa2.Value = kq;
                cmd.Parameters.Add(pa1);
                cmd.Parameters.Add(pa2);
                pa2.Direction = ParameterDirection.Output;
                pa2.Value = kq;
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
        //sau khi thêm hóa đơn thì vào chi tiết hóa đơn
        public static void ThemChiTietHoaDon(int idHoadon, int idMon, int soLuong)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_ThemChiTietHoaDon", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pa1 = new SqlParameter("@idHoadon", SqlDbType.Int);
                pa1.Value = idHoadon;
                SqlParameter pa2 = new SqlParameter("@idMon", SqlDbType.Int);
                pa2.Value = idMon;
                SqlParameter pa3 = new SqlParameter("@soLuong", SqlDbType.Int);
                pa3.Value = soLuong;
                cmd.Parameters.Add(pa1);
                cmd.Parameters.Add(pa2);
                cmd.Parameters.Add(pa3);
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
        public static DataTable LayChiTietHoaDon(int idBan)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_HienThiHoaDonTheoBan", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter par = new SqlParameter("@idBan", SqlDbType.Int);
                par.Value = idBan;
                cmd.Parameters.Add(par);
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
        public static int LayMaxIdHoaDon()
        {
            try
            {
                int kq = 0;
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_LayMaxIdHoaDon", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pa1 = new SqlParameter("@idBan", SqlDbType.Int);
                pa1.Value = kq;
                pa1.Direction = ParameterDirection.Output;
                pa1.Value = kq;
                cmd.Parameters.Add(pa1);
                cmd.ExecuteNonQuery();
                return (int)pa1.Value;
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
        public static void UPDATEHoaDon(int idHoaDon, int tongTien)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_CapNhatHoaDon", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pa1 = new SqlParameter("@idHoaDon", SqlDbType.Int);
                pa1.Value = idHoaDon;
                SqlParameter pa2 = new SqlParameter("@tongTien", SqlDbType.Int);
                pa2.Value = tongTien;
                cmd.Parameters.Add(pa1);
                cmd.Parameters.Add(pa2);
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
        public static int LayTongTienTheoHoaDon(int idHoaDon)
        {
            try
            {
                int kq = 0;
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_LayTongTien", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pa1 = new SqlParameter("@idHoaDon", SqlDbType.Int);
                pa1.Value = idHoaDon;
                SqlParameter pa2 = new SqlParameter("@kq", SqlDbType.Int);
                pa2.Value = kq;
                cmd.Parameters.Add(pa1);
                cmd.Parameters.Add(pa2);
                pa2.Direction = ParameterDirection.Output;
                pa2.Value = kq;
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
        public static void XoaMonKhoiHoaDon(int idHoaDon, string tenMon)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_XoaMonHoaDon", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pa1 = new SqlParameter("@idHoaDon", SqlDbType.Int);
                pa1.Value = idHoaDon;
                SqlParameter pa2 = new SqlParameter("@tenMon", SqlDbType.NVarChar);
                pa2.Value = tenMon;
                cmd.Parameters.Add(pa1);
                cmd.Parameters.Add(pa2);
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
