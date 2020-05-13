using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DaoTheVoice
{
    public class daBaiViet
    {
        public DataTable DanhSachCanRender(SqlConnection conn)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_tblBaiViet_DanhSachCanRender", conn);
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
        
        public DataTable DanhSachTheoNguoiDung(SqlConnection conn,Guid IDNguoiDung,DateTime NgayTao)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_tblBaiViet_DanhSach_TheoNguoiDung", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 72000;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            try
            {
                cmd.Parameters.AddWithValue("@IDNguoiDung", IDNguoiDung);
                cmd.Parameters.AddWithValue("@NgayTao", NgayTao);
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
        public void Them(SqlConnection conn, string NoiDung,Guid IDNguoiDung, string NgonNgu, string GioiTinh)
        {
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("sp_tblBaiViet_Them", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandTimeout = 72000;
            try
            {
                sqlCommand.Parameters.AddWithValue("@NoiDung", NoiDung);
                sqlCommand.Parameters.AddWithValue("@IDNguoiDung", IDNguoiDung);
                sqlCommand.Parameters.AddWithValue("@NgonNgu", NgonNgu);
                sqlCommand.Parameters.AddWithValue("@GioiTinh", GioiTinh);               
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

        public void UpdateDangRender(SqlConnection conn, Guid IDBaiViet)
        {
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("sp_tblBaiViet_UpdateDangRender", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandTimeout = 72000;
            try
            {

                sqlCommand.Parameters.AddWithValue("@ID", IDBaiViet);
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
        public void UpdateDaRender(SqlConnection conn, Guid IDBaiViet, string LinkVoice)
        {
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("sp_tblBaiViet_UpdateDaRender", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandTimeout = 72000;
            try
            {
              
                sqlCommand.Parameters.AddWithValue("@ID", IDBaiViet);
                sqlCommand.Parameters.AddWithValue("@LinkVoice", LinkVoice);         
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
