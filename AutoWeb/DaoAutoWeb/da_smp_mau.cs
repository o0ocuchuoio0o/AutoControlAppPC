using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DaoAutoWeb
{
    public class da_smp_mau
    {
        public void CapNhat(SqlConnection conn, DataTable DuLieu, string  ngay,string mabuucuc)
        {
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("sp_them_smp_thang2019", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandTimeout = 72000;
            try
            {
                sqlCommand.Parameters.AddWithValue("@bang", DuLieu);
                sqlCommand.Parameters.AddWithValue("@ngay", ngay);
                sqlCommand.Parameters.AddWithValue("@mabuucuc", mabuucuc);
                sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                sqlCommand.Dispose();
                conn.Close();
                conn.Dispose();
            }
        }

    }
}
