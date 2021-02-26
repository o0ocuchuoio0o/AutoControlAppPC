using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace DaoAutoWeb
{
    public class da_dmkhachhangmcs
    {
        public DataTable DanhSachkhachhangmcs(SqlConnection conn)
        {
            conn.Open();
            string sql = "select distinct * from temp2 where DaGanPNS=0 order by idcaptren desc ";
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
        public void DaTruyen(SqlConnection conn,string macrm,string sodienthoai)
        {
            conn.Open();
            string sql = "update temp2 set DaGanPNS=1 where macrm='"+macrm+"' and DienThoai='"+sodienthoai+"'" ;
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 72000;
            
            try
            {
                cmd.ExecuteNonQuery();
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
