using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAO
{
   public class DAO_QL_NhanVien
    {
       static SqlConnection con = KetNoiCSDL.cnn;
       DataSet ds = new DataSet();
       public static DataTable LoadThongTinNhanVien()
       {
           DataTable dt = new DataTable();
           con.Open();
           SqlCommand cmd = new SqlCommand("sp_HienThiThongTinNV", con);
           cmd.CommandType = CommandType.StoredProcedure;
           SqlDataAdapter da = new SqlDataAdapter(cmd);
           da.Fill(dt);
           con.Close();
           return dt;
       }
     public static DataTable LoadThongTinNhanVien(string tenNhanVien)
        {
            DataTable dt = new DataTable();
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_TimKiemNhanVien", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter pa1 = new SqlParameter("@tenNhanvien",SqlDbType.NVarChar);
            pa1.Value = tenNhanVien;
            cmd.Parameters.Add(pa1);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public static DataTable LocNhanVienTheoChucVu(int idChucvu)
        {
            DataTable dt = new DataTable();
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_HienThiThongTinNV_ChucVu",con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter pa1 = new SqlParameter("@idChucvu",SqlDbType.Int);
            pa1.Value = idChucvu;
            cmd.Parameters.Add(pa1);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public static bool ThemNhanVien(string tenNV, string diaChi, string gioiTinh, string ngaySinh, string sdt, int idChucvu, int idHSL, int idPhuCap, int idChamcong)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_ThemNhanVien", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pa1 = new SqlParameter("@tenNhanvien", SqlDbType.NVarChar);
                pa1.Value = tenNV;
                SqlParameter pa2 = new SqlParameter("@diaChi", SqlDbType.NVarChar);
                pa2.Value = diaChi;
                SqlParameter pa3 = new SqlParameter("@gioiTinh", SqlDbType.NVarChar);
                pa3.Value = gioiTinh;
                SqlParameter pa4 = new SqlParameter("@ngaySinh", SqlDbType.NVarChar);
                pa4.Value = ngaySinh;
                SqlParameter pa5 = new SqlParameter("@soDienthoai", SqlDbType.NVarChar);
                pa5.Value = sdt;
                SqlParameter pa6 = new SqlParameter("@idChucvu", SqlDbType.Int);
                pa6.Value = idChucvu;
                SqlParameter pa7 = new SqlParameter("@idHesoluong", SqlDbType.Int);
                pa7.Value = idHSL;
                SqlParameter pa8 = new SqlParameter("@idPhucap", SqlDbType.Int);
                pa8.Value = idPhuCap;
                SqlParameter pa9 = new SqlParameter("@idChamcong", SqlDbType.Int);
                pa9.Value = idChamcong;
                cmd.Parameters.Add(pa1);
                cmd.Parameters.Add(pa2);
                cmd.Parameters.Add(pa3);
                cmd.Parameters.Add(pa4);
                cmd.Parameters.Add(pa5);
                cmd.Parameters.Add(pa6);
                cmd.Parameters.Add(pa7);
                cmd.Parameters.Add(pa8);
                cmd.Parameters.Add(pa9);
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
        public static void XoaNhanVien(int idNhanvien)
        {
            try
            {
                con.Open();
                string sql = "DELETE from NhanVien where idNhanvien=" + idNhanvien;
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            }
            catch
            {
            }
            finally { con.Close(); }
        }
        public static bool SuaNhanVien(int idNhanvien, string tenNV, string diaChi, string gioiTinh, string ngaySinh, string sdt, int idChucvu, int idHSL, int idPhuCap, int idChamcong)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_CapNhatNhanVien", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pa1 = new SqlParameter("@idNhanvien", SqlDbType.Int);
                pa1.Value = idNhanvien;
                SqlParameter pa2 = new SqlParameter("@tenNhanvien", SqlDbType.NVarChar);
                pa2.Value = tenNV;
                SqlParameter pa3 = new SqlParameter("@diaChi", SqlDbType.NVarChar);
                pa3.Value = diaChi;
                SqlParameter pa4 = new SqlParameter("@gioiTinh", SqlDbType.NVarChar);
                pa4.Value = gioiTinh;
                SqlParameter pa5 = new SqlParameter("@ngaySinh", SqlDbType.NVarChar);
                pa5.Value = ngaySinh;
                SqlParameter pa6 = new SqlParameter("@soDienthoai", SqlDbType.NVarChar);
                pa6.Value = sdt;
                SqlParameter pa7 = new SqlParameter("@idChucvu", SqlDbType.Int);
                pa7.Value = idChucvu;
                SqlParameter pa8 = new SqlParameter("@idHesoluong", SqlDbType.Int);
                pa8.Value = idHSL;
                SqlParameter pa9 = new SqlParameter("@idPhucap", SqlDbType.Int);
                pa9.Value = idPhuCap;
                SqlParameter pa10 = new SqlParameter("@idChamcong", SqlDbType.Int);
                pa10.Value = idChamcong;
                cmd.Parameters.Add(pa1);
                cmd.Parameters.Add(pa2);
                cmd.Parameters.Add(pa3);
                cmd.Parameters.Add(pa4);
                cmd.Parameters.Add(pa5);
                cmd.Parameters.Add(pa6);
                cmd.Parameters.Add(pa7);
                cmd.Parameters.Add(pa8);
                cmd.Parameters.Add(pa9);
                cmd.Parameters.Add(pa10);
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
        public static int KTMaChamCong(int idChamCong)
        {
            try
            {
                con.Open();
                string sql = " SELECT COUNT(*) FROM  dbo.NhanVien WHERE  idChamcong = '" + idChamCong + "'";
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
        public static int KTLuong(int maNV, int thang, int nam)
        {
            try
            {
                con.Open();
                string sql = " SELECT COUNT(*) FROM  dbo.Luong WHERE  idNhanvien='" + maNV + "' AND  thang=" + thang + " AND " + "nam = " + nam;
                SqlCommand cmd = new SqlCommand(sql, con);
                return (int)cmd.ExecuteScalar();
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
        public static int TinhLuongNhanVien(int maNV,int thuong,int thang,int nam)
        {
            try
            {
                con.Open();
                int luong = 0;
                int luong2 = 0;
                SqlCommand cmd = new SqlCommand("sp_TinhLuongNhanVien",con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pa1 = new SqlParameter("@idNhanvien",SqlDbType.Int);
                pa1.Value = maNV;
                SqlParameter pa2 = new SqlParameter("@Thuong",SqlDbType.Int);
                pa2.Value = thuong;
                SqlParameter pa3 = new SqlParameter("@Luong",SqlDbType.Int);
                pa3.Value = luong;
                pa3.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pa1);
                cmd.Parameters.Add(pa2);
                cmd.Parameters.Add(pa3);
                cmd.ExecuteNonQuery();
                luong2 = (int)pa3.Value;
                string sql = " INSERT INTO dbo.Luong(idNhanvien,thang,nam,luong)  VALUES ('" + maNV + "'," + thang + "," + nam + "," + luong2 + ")";
                SqlCommand cmd2 = new SqlCommand(sql,con);
                cmd2.ExecuteNonQuery();
                return luong2;
            }
            catch
            { 
                return 0;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
