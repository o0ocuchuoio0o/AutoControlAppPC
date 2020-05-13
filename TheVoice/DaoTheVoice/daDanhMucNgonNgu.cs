using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace DaoTheVoice
{
    public class daDanhMucNgonNgu
    {
        public DataTable DanhSach(SqlConnection conn)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_tblDanhMucNgonNgu_DanhSach", conn);
            cmd.CommandType = CommandType.StoredProcedure;
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

    }
}
