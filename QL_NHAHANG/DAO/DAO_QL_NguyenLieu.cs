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
    public class DAO_QL_NguyenLieu
    {
        static SqlConnection con = KetNoiCSDL.cnn;
        public static DataTable LoadDanhSachNguyenLieu()
        {
            SqlConnection con = KetNoiCSDL.cnn;
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dbo.NguyenLieu", con);
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
        public static bool ThemNguyenLieu(string tenNguyenlieu, string dvt, int soLuong)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText ="INSERT INTO NguyenLieu(tenNguyenlieu, DVT, soLuong)VALUES(N'"+ tenNguyenlieu + "', N'"+ dvt + "', "+soLuong+")";
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
        public static bool capNhatNguyenLieu(int idNguyenlieu, string tenNguyenlieu, int soLuong, string dvt)
        {

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "UPDATE NguyenLieu SET tenNguyenlieu = N'" + tenNguyenlieu + "', soLuong = " + soLuong + ", DVT = N'" + dvt + "' WHERE idNguyenlieu ='" + idNguyenlieu + "'";
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
        public static DataTable timKiemNguyenLieuTheoTen(string tenNguyenLieu)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM dbo.NguyenLieu WHERE tenNguyenlieu LIKE N'%" + tenNguyenLieu + "%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch
            { }
            finally
            {
                con.Close();
            }
            return dt;
        }
        public static bool xoaNguyenLieu(int idNguyenlieu)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "DELETE FROM Nguyenlieu WHERE idNguyenlieu = " + idNguyenlieu;
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
        public static int KTNguyenLieu(string tenNguyenlieu)
        {
            try
            {               
                con.Open();
                string sql = " SELECT COUNT(*) FROM  dbo.NguyenLieu WHERE  tenNguyenlieu = '" + tenNguyenlieu + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                int kq = (int)cmd.ExecuteScalar();
                return kq;              
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
        public static List<DTO_QL_NguyenLieu> LoadThongTinNguyenLieu(int idNguyenlieu)
        {
            List<DTO_QL_NguyenLieu> listNguyenLieu = new List<DTO_QL_NguyenLieu>();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_HienThiNguyeLieuTheoId", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pa1 = new SqlParameter("@idNguyenlieu", SqlDbType.Int);
                pa1.Value = idNguyenlieu;
                cmd.Parameters.Add(pa1);
                using (DataTable dt = new DataTable())
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                        foreach (DataRow item in dt.Rows)
                        {
                            DTO_QL_NguyenLieu Nguyenlieu = new DTO_QL_NguyenLieu(item);
                            listNguyenLieu.Add(Nguyenlieu);
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
            return listNguyenLieu;
        }
    }
}
