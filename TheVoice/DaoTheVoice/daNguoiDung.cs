//using Google.Authenticator;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DaoTheVoice
{
    public class daNguoiDung
    {
        //public string _GetCodeOTP(string SecertKey)
        //{
        //    string _code = new TwoFactorAuthenticator().GetCurrentPINs(SecertKey).ToString();
        //    return _code;
        //}

        //public string _Login(string txt_SecertKey)
        //{
        //    string kq = "0";
        //    TwoFactorAuthenticator tfA = new TwoFactorAuthenticator();
        //    var result = tfA.ValidateTwoFactorPIN(txt_SecertKey, _GetCodeOTP(txt_SecertKey));
        //    if (result)
        //    { kq = "1"; }
        //    else { kq = "0"; }
        //    return kq;
        //}

        public DataTable DangNhap(SqlConnection conn, string taikhoan, string matkhau)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_tblNguoiDung_ThongTin", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 72000;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            try
            {
                cmd.Parameters.AddWithValue("@TaiKhoan", taikhoan);
                cmd.Parameters.AddWithValue("@MatKhau", matkhau);
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

        public DataTable DanhSach(SqlConnection conn)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_tblNguoiDung_DanhSach", conn);
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

        public DataTable ThongTinTheoIDNguoiDung(SqlConnection conn, Guid IDNguoiDung)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_tblNguoidung_ThongTinTheoID", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 72000;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            try
            {
                cmd.Parameters.AddWithValue("@IDNguoiDung", IDNguoiDung);
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


        public void Xoa(SqlConnection conn, Guid IDNguoiDung)
        {
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("sp_tblNguoiDung_Xoa", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            try
            {
                sqlCommand.Parameters.AddWithValue("@IDNguoiDung", IDNguoiDung);              
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
       
        public void Sua(SqlConnection conn,Guid IDNguoiDung,string MatKhau,DateTime NgayKetThuc,DateTime NgayBatDau,int SoLuongUp )
        {
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("sp_tblNguoiDung_Sua", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            try
            {
                sqlCommand.Parameters.AddWithValue("@IDNguoiDung", IDNguoiDung);
                sqlCommand.Parameters.AddWithValue("@MatKhau", MatKhau);
                sqlCommand.Parameters.AddWithValue("@NgayKetThuc", NgayKetThuc);
                sqlCommand.Parameters.AddWithValue("@NgayBatDau", NgayBatDau);
                sqlCommand.Parameters.AddWithValue("@SoLuongUp", SoLuongUp);               
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
        public void Them(SqlConnection conn, string TaiKhoan, string MatKhau, DateTime NgayBatDau, DateTime NgayKetThuc, int QuyenHan, int SoLuongUp)
        {
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("sp_tblNguoiDung_Them", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            try
            {
                sqlCommand.Parameters.AddWithValue("@TaiKhoan", TaiKhoan);
                sqlCommand.Parameters.AddWithValue("@MatKhau", MatKhau);
                sqlCommand.Parameters.AddWithValue("@NgayBatDau", NgayBatDau);
                sqlCommand.Parameters.AddWithValue("@NgayKetThuc", NgayKetThuc);
                sqlCommand.Parameters.AddWithValue("@QuyenHan", QuyenHan);
                sqlCommand.Parameters.AddWithValue("@SoLuongUp", SoLuongUp);
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
