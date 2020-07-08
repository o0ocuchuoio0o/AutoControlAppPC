using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
namespace AutoFB
{
    public class daSqllite
    {
        SQLiteConnection _con = new SQLiteConnection();
        public void createConection()
        {
            string _strConnect = "Data Source=DuLieu.sqlite;Version=3;";
            _con.ConnectionString = _strConnect;
            _con.Open();
        }

        public void closeConnection()
        {
            _con.Close();
        }
        public void createTable()
        {
        //    string sql = "CREATE TABLE IF NOT EXISTS tbl_TaiKhoan ([ID] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, Email nvarchar(250), MatKhau nvarchar(259),MailKhoiPhuc nvarchar(250), Khoa2FA nvarchar(500), GhiChu nvarchar(500))";
        //    SQLiteConnection.CreateFile("DuLieu.sqlite");
        //    createConection();
        //    SQLiteCommand command = new SQLiteCommand(sql, _con);
        //    command.ExecuteNonQuery();
        //    closeConnection();
        }
        public void Insert(string UID,string USERNAME,string PASSWORD,string SECRET,string COOKIES,int DAY,
              int MONTH,int YEAR,string FULLNAME,string GENDER,string AVATAR,string COVER,
              string HOME,string CITY,string BIO,string WORK,string UNIVERSITY,string SCHOOL,string FRIENDS,
              string ISP, string TIME_REGISTER, string GMAIL_USERNAME,
              string GMAIL_PASSWORD,string GMAIL_RECOVERY, string GMAIL_TIME_REGISTER,int IDPhone)
        {
            string strInsert = string.Format("INSERT INTO tbl_TaiKhoan([UID],[USERNAME],[PASSWORD],[SECRET],[COOKIES],[DAY] , "
             + " [MONTH],[YEAR],[FULLNAME],[GENDER],[AVATAR],[COVER], "
             + " [HOME],[CITY],[BIO],[WORK],[UNIVERSITY],[SCHOOL],[FRIENDS], "
             + " [ISP],[TIME_REGISTER],[GMAIL_USERNAME],"
             + " [GMAIL_PASSWORD],[GMAIL_RECOVERY],[GMAIL_TIME_REGISTER],[IDPhone]) "
             + " VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}',"
             + "  '{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}',"
             + "  '{20}', '{21}', '{22}', '{23}', '{24}', '{25}')", UID,  USERNAME,  PASSWORD,  SECRET,  COOKIES,  DAY,
               MONTH,  YEAR,  FULLNAME,  GENDER,  AVATAR,  COVER,
               HOME,  CITY,  BIO,  WORK,  UNIVERSITY,  SCHOOL,  FRIENDS,
               ISP,  TIME_REGISTER,  GMAIL_USERNAME,
               GMAIL_PASSWORD,  GMAIL_RECOVERY,  GMAIL_TIME_REGISTER, IDPhone);
            createConection();
            SQLiteCommand cmd = new SQLiteCommand(strInsert, _con);
            cmd.ExecuteNonQuery();
            closeConnection();
        }

        public void Delete(string id)
        {
            string strdelete = string.Format("DELETE FROM tbl_TaiKhoan where ID='{0}'", id);
            createConection();
            SQLiteCommand cmd = new SQLiteCommand(strdelete, _con);
            cmd.ExecuteNonQuery();
            closeConnection();
        }
        public DataSet KiemTraMail(string USERNAME)
        {
            DataSet ds = new DataSet();
            createConection();
            SQLiteDataAdapter da = new SQLiteDataAdapter("Select *FROM tbl_TaiKhoan where USERNAME='"+ USERNAME + "'", _con);
            da.Fill(ds);
            closeConnection();
            return ds;
        }
        public void UpdatePhone(string USERNAME, int IDPhone)
        {
            string strUpdate = string.Format("UPDATE tbl_TaiKhoan set IDPhone='{0}' where USERNAME='{1}'",
                IDPhone, USERNAME);
            createConection();
            SQLiteCommand cmd = new SQLiteCommand(strUpdate, _con);
            cmd.ExecuteNonQuery();
            closeConnection();


        }


        public DataSet loadData()
        {
            DataSet ds = new DataSet();
            createConection();
            SQLiteDataAdapter da = new SQLiteDataAdapter("select * from tbl_TaiKhoan", _con);
            da.Fill(ds);
            closeConnection();
            return ds;
        }

        public DataSet DataDaGanPhone()
        {
            DataSet ds = new DataSet();
            createConection();
            SQLiteDataAdapter da = new SQLiteDataAdapter("select * from tbl_TaiKhoan where IDPhone!=-1", _con);
            da.Fill(ds);
            closeConnection();
            return ds;
        }
        public DataSet DataChuaGanPhone()
        {
            DataSet ds = new DataSet();
            createConection();
            SQLiteDataAdapter da = new SQLiteDataAdapter("select * from tbl_TaiKhoan where IDPhone=-1", _con);
            da.Fill(ds);
            closeConnection();
            return ds;
        }
        public DataSet DataTheoPhone(int IDPhone)
        {
            DataSet ds = new DataSet();
            createConection();
            SQLiteDataAdapter da = new SQLiteDataAdapter("select * from tbl_TaiKhoan where IDPhone='" + IDPhone + "'", _con);
            da.Fill(ds);
            closeConnection();
            return ds;
        }
    }
}
