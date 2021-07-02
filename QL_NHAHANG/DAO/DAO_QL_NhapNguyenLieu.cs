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
    public class DAO_QL_NhapNguyenLieu
    {
        static SqlConnection con = KetNoiCSDL.cnn;
        public static DataTable LoadDanhSachPhieuDat()
        {   
            SqlConnection con = KetNoiCSDL.cnn;
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT idPhieuDat, tenPhieuDat FROM dbo.PhieuDat ORDER BY idPhieuDat DESC", con);
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
        public static DataTable LoadDanhSachPhieuNhap()
        {
            SqlConnection con = KetNoiCSDL.cnn;
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT idPhieuNhap, ngayLap, NV.tenNhanVien FROM PhieuNhap PN, NhanVien NV WHERE PN.idNhanVien = NV.idNhanVien ORDER BY idPhieuNhap DESC", con);
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
        public static DataTable LoadThongTinPhieuNhap(int idPhieu)
        {
            SqlConnection con = KetNoiCSDL.cnn;
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT NL.tenNguyenlieu, CT.soLuong FROM CT_PhieuNhap CT, NguyenLieu NL WHERE CT.idNguyenlieu = NL.idNguyenlieu AND idPhieuNhap = " + idPhieu + "", con);
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
        public static DataTable LoadThongTinPhieuDat(int idPhieu)
        {
            SqlConnection con = KetNoiCSDL.cnn;
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT NL.tenNguyenlieu, CT.soLuong, CT.donGianhap FROM dbo.PhieuDat PD, dbo.CT_PhieuDat CT, NguyenLieu NL WHERE PD.idPhieuDat = CT.idPhieuDat and CT.idNguyenlieu = NL.idNguyenlieu AND PD.idPhieuDat =" + idPhieu + "", con);
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
        public static bool TaoPhieu(string ngayLap, int nguoiLap, int idPhieuDat)
        {
            try
            {
                int tongTien = 0;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO PhieuNhap (ngayLap, idNhanvien, idPhieuDat) VALUES (N'" + ngayLap + "', " + nguoiLap + ", " + idPhieuDat + ")";
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
        public static int LayIDPhieuNhapVuaTao()
        {
            try
            {
                con.Open();
                string sql = "SELECT TOP 1 idPhieuNhap FROM PhieuNhap ORDER BY idPhieuNhap DESC";
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
        public static int LayIDNguyeLieu(string tenNL)
        {
            try
            {
                con.Open();
                string sql = "SELECT idNguyenlieu FROM NguyenLieu WHERE tenNguyenlieu = N'" + tenNL + "'";
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
        public static int LaySLNguyeLieu(string tenNL)
        {
            try
            {
                con.Open();
                string sql = "SELECT soLuong FROM NguyenLieu WHERE tenNguyenlieu = N'" + tenNL + "'";
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
        public static bool NhapNguyenLieu(int idPhieuNhap, int idNguyenlieu, int soLuong)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO CT_PhieuNhap (idPhieuNhap, idNguyenlieu, soLuong) VALUES (" + idPhieuNhap + ", " + idNguyenlieu + ", " + soLuong + ")";
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
        public static bool UpdateNguyenLieu(int idNguyenlieu, int soLuong)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "UPDATE NguyenLieu SET soLuong = " + soLuong + " WHERE idNguyenlieu = " + idNguyenlieu + "";
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
                cmd.CommandText = "DELETE FROM CT_PhieuNhap WHERE idNguyenlieu = " + idNguyenlieu + " AND idPhieuNhap = " + idPhieu + "";
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
