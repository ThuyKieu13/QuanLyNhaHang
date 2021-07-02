using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
namespace DAO
{
   public class DAO_QL_BanAn
    {
       static SqlConnection con = KetNoiCSDL.cnn;
       public List<DTO_QL_BanAn> getTableList() // lấy dannh sách bàn trong  csdl trả về kiểu list  dto bàn
       {
           List<DTO_QL_BanAn> tl = new List<DTO_QL_BanAn>(); // khởi tạo 1 list 
           try
           {
               con.Open();
               SqlCommand cmd = new SqlCommand("sp_HienThiBan", con);
               cmd.CommandType = CommandType.StoredProcedure;
               using (DataTable data = new DataTable()) //sd DataTable 
               {
                   using (SqlDataAdapter da = new SqlDataAdapter(cmd)) // sd SqlDataAdapter
                   {
                       da.Fill(data);// đổ dữ liệu
                       foreach (DataRow item in data.Rows)// duyệt từng dòng  lây dữ liệu
                       {
                           DTO_QL_BanAn Ban = new DTO_QL_BanAn(item);
                           tl.Add(Ban);
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
           return tl;
       }
       public static DataTable LoadDSCBOBanAN()
       {
           DataTable dt = new DataTable();
           try
           {
               SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Ban", con);
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
       public static bool chuyenBan(int idBan1, int idBan2)
       {
           try
           {
               con.Open();
               SqlCommand cmd = new SqlCommand("sp_chuyenBan", con);
               cmd.CommandType = CommandType.StoredProcedure;
               SqlParameter par1 = new SqlParameter("@idBan1", SqlDbType.Int);// khởi tạp 1 cái SqlParameter  có tên iban1 khai báo kiểu là int
               par1.Value = idBan1;// gán giá trị
               SqlParameter par2 = new SqlParameter("@idBan2", SqlDbType.Int);
               par2.Value = idBan2;
               cmd.Parameters.Add(par1);
               cmd.Parameters.Add(par2);
               cmd.ExecuteNonQuery();// thực thi
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
       public static bool themBanMoi(string tenBan)
       {
           try
           {
               con.Open();
               string sql = "insert into dbo.Ban(tenBan,tinhTrang) values(N'" + tenBan + "',0)";
               SqlCommand cmd = new SqlCommand();
               cmd.Connection = con;
               cmd.CommandText = sql;
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
       public static bool xoaban(string tenBan)
       {
           try
           {
               con.Open();
               string sql = "DELETE dbo.Ban where tenban='"+tenBan+"'";
               SqlCommand cmd = new SqlCommand();
               cmd.Connection = con;
               cmd.CommandText = sql;
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
        public bool kiemTraTinhTrangBan(int idBan)
        {
            try
            {
                int kq = 0;
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_KiemTraTinhTrangBan", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter par1 = new SqlParameter("@idBan", System.Data.SqlDbType.Int);
                par1.Value = idBan;
                SqlParameter par3 = new SqlParameter("@kq", System.Data.SqlDbType.Int);
                par3.Value = kq;
                par3.Direction = System.Data.ParameterDirection.Output;
                par3.Value = kq;
                cmd.Parameters.Add(par1);
                cmd.Parameters.Add(par3);
                cmd.ExecuteNonQuery();
                if ((int)par3.Value == 1)
                    return true;
                else
                    return false;
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
