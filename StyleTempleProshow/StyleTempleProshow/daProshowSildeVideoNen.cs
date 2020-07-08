using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace StyleTempleProshow
{
    public class daProshowSildeVideoNen
    {
        public DataTable DanhSachStyle(SqlConnection conn)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_ProshowSildeVideoNen_DanhSachStyle", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 72000;          
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                //dt.Load(cmd.ExecuteReader(CommandBehavior.CloseConnection));
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
        public DataTable ThongTinStyle(SqlConnection conn,int id)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_ProshowSildeVideoNen_ThongTinTheoID", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 72000;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                cmd.Parameters.AddWithValue("@ID",id);
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

        public void ThemStyle(SqlConnection conn, DataTable dulieu)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_ProshowSildeVideoNen_Them", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 72000;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                cmd.Parameters.AddWithValue("@DuLieu", dulieu);
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
        public void XoaStyle(SqlConnection conn, int id)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_ProshowSildeVideoNen_Xoa", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 72000;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                cmd.Parameters.AddWithValue("@ID", id);
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
