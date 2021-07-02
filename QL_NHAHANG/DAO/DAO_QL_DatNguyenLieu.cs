using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DAO_QL_DatNguyenLieu
    {
        static SqlConnection con = KetNoiCSDL.cnn;
        public static DataTable LoadDanhSachPhieuDat()
        {
            SqlConnection con = KetNoiCSDL.cnn;
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT idPhieuDat, tenPhieuDat, ngayTao, tongTien, NV.tenNhanvien, NCC.tenNCC FROM dbo.PhieuDat PD, dbo.NhanVien NV, NCC NCC WHERE PD.idNhanVien = NV.idNhanvien AND PD.idNCC = NCC.idNCC Order by idPhieuDat DESC", con);
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
        public static DataTable LoadPhieuDat(int idPhieu)
        {
            SqlConnection con = KetNoiCSDL.cnn;
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT idPhieuDat, tenPhieuDat, ngayTao, tongTien, NV.tenNhanvien, NCC.tenNCC FROM dbo.PhieuDat PD, dbo.NhanVien NV, NCC NCC WHERE PD.idNhanVien = NV.idNhanvien AND PD.idNCC = NCC.idNCC AND PD.idPhieuDat = "+ idPhieu + "", con);
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
        public static int LayIDPhieuDatVuaTao()
        {
            try
            {
                con.Open();
                string sql = "SELECT TOP 1 idPhieuDat FROM PhieuDat ORDER BY idPhieuDat DESC";
                SqlCommand cmd = new SqlCommand(sql, con);
                int kq = (int)cmd.ExecuteScalar();
                return kq;
            }
            catch
            {
                return 1;
            }
            finally
            {
                con.Close();
            }
        }

        public static bool TaoPhieu(string tenPhieu, string ngayLap, int nguoiLap, int NCC)
        {
            try
            {
                int tongTien = 0;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO PhieuDat(tenPhieuDat, ngayTao, idNhanvien, idNCC, tongTien)VALUES(N'" + tenPhieu + "', N'" + ngayLap + "', " + nguoiLap + ", " + NCC + ", "+tongTien+")";
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
        public static DataTable LoadThongTinPhieuDat(int idPhieu)
        {
            SqlConnection con = KetNoiCSDL.cnn;
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT NL.tenNguyenlieu, CT.soLuong, CT.donGianhap, CT.thanhTien FROM dbo.PhieuDat PD, dbo.CT_PhieuDat CT, NguyenLieu NL WHERE PD.idPhieuDat = CT.idPhieuDat and CT.idNguyenlieu = NL.idNguyenlieu AND PD.idPhieuDat =" + idPhieu + "", con);
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
        public static DataTable Loadncc()
        {
            SqlConnection con = KetNoiCSDL.cnn;
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NCC", con);
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
        public static string LayTenNV(string tenDN)
        {
            try
            {
                con.Open();
                string sql = "SELECT NV.tenNhanvien FROM NguoiDung ND, NhanVien NV WHERE ND.idNhanvien = NV.idNhanvien AND ND.tenDangnhap = '" + tenDN + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                string kq = (string)cmd.ExecuteScalar();
                return kq;
            }
            catch
            {
                return "";
            }
            finally
            {
                con.Close();
            }            
        }
        public static int LayIDNV(string tenDN)
        {
            try
            {
                con.Open();
                string sql = "SELECT NV.idNhanVien FROM NguoiDung ND, NhanVien NV WHERE ND.idNhanvien = NV.idNhanvien AND ND.tenDangnhap = '" + tenDN + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                int kq = (int)cmd.ExecuteScalar();
                return kq;
            }
            catch
            {
                return 1;
            }
            finally
            {
                con.Close();
            }
        }
        public static DataTable LayTenNL()
        {
            SqlConnection con = KetNoiCSDL.cnn;
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT idNguyenlieu, tenNguyenlieu FROM NguyenLieu", con);
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
        public static bool ThemNguyenLieu(int idPhieuDat, int idNguyenlieu, int soLuong, int donGianhap)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO CT_PhieuDat (idPhieuDat, idNguyenlieu, soLuong, donGianhap) VALUES (" + idPhieuDat + ", " + idNguyenlieu + ", " + soLuong + ", "+ donGianhap + ")";
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
        public static bool XoaNguyenLieu(int idPhieu, int idNguyenlieu)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "DELETE FROM CT_PhieuDat WHERE idNguyenlieu = " + idNguyenlieu+ " AND idPhieuDat = " + idPhieu +"";
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
        public static int LayIDNguyeLieu(string tenNL)
        {
            try
            {
                con.Open();
                string sql = "SELECT idNguyenlieu FROM NguyenLieu WHERE tenNguyenlieu = '"+tenNL+"'";
                SqlCommand cmd = new SqlCommand(sql, con);
                int kq = (int)cmd.ExecuteScalar();
                return kq;
            }
            catch
            {
                return 1;
            }
            finally
            {
                con.Close();
            }
        }
        public static bool capNhatNguyenLieu(int idPhieu, int idNguyenlieu, int soLuong, int gia)
        {

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "UPDATE CT_PhieuDat SET soLuong = " + soLuong + " , donGianhap = " + gia + " WHERE idNguyenlieu = " + idNguyenlieu + " AND idPhieuDat = " + idPhieu + "";
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            { con.Close(); }
        }
    }
}
