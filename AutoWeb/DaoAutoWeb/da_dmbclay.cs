using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace DaoAutoWeb
{
    public class da_dmbclay
    {
        public DataTable DanhSachBuuCuc(SqlConnection conn)
        {
            conn.Open();
            string sql = "select mabuucuc,buucuc from dbo.dmbclay ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 72000;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            try
            {               
                da.Fill(ds, "DanhSach");
                return ds.Tables["DanhSach"];
            }
            catch
            {
                throw;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
                conn.Dispose();
            }

        }

        public DataTable DanhSachBuuCucKhongsoLieu(SqlConnection conn,string ngay)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_dmbclay_khongsolieu", conn);
            cmd.CommandType = CommandType.StoredProcedure;           
            cmd.CommandTimeout = 72000;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            try
            {
                cmd.Parameters.AddWithValue("@ngay", ngay);
                da.Fill(ds, "DanhSach");
                return ds.Tables["DanhSach"];
            }
            catch
            {
                throw;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
                conn.Dispose();
            }

        }

    }
}
