using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DaoKiemSoatCuoiNgay
{
    public class daIPServer
    {
        public DataTable ThongTinServer(SqlConnection conn,string mabuucuc)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from IP_SERVER where Ma_bc="+mabuucuc, conn);
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
    }
}
