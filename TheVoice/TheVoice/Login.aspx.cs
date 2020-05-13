using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ext.Net;
using System.Data;
using TheVoice.KetNoi;
using DaoTheVoice;
using Newtonsoft.Json;
namespace TheVoice
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                Session.Clear();
                wDangNhap.Show();
                txtTaiKhoan.Focus();
            }
        }
        private DateTime _NgayHeThong = DateTime.Now;

        protected void btnfDangNhap_Click(object sender, DirectEventArgs e)
        {
            daNguoiDung dn = new daNguoiDung();
            DataTable dt = new DataTable();
            try
            {
                if (txtTaiKhoan.Text == "")
                {
                    X.Msg.Alert("Thông báo lỗi", "Bắt buộc phải nhập vào tài khoản!").Show();
                    return;
                }
            }
            catch
            {
                X.Msg.Alert("Thông báo lỗi", "Bắt buộc phải nhập vào tài khoản!").Show();
                return;
            }
            try
            {
                if (txtMatKhau.Text == "")
                {
                    X.Msg.Alert("Thông báo lỗi", "Bắt buộc phải nhập vào mật khẩu!").Show();
                    return;
                }
            }
            catch
            {
                X.Msg.Alert("Thông báo lỗi", "Bắt buộc phải nhập vào mật khẩu!").Show();
                return;
            }
            dt = dn.DangNhap(Cl_KetNoi.hamketnoisql(), txtTaiKhoan.Text, txtMatKhau.Text);
            if (dt.Rows.Count > 0)
            {
                DataRow r = dt.Rows[0];
                string _nguoidung = r["IDNguoiDung"].ToString();
                Session["CheckLG"] = _nguoidung;
              
                DateTime _HanSuDung = DateTime.Parse(r["NgayKetThuc"].ToString());            
                if (_HanSuDung <_NgayHeThong)
                {
                    X.Msg.Alert( "Lỗi","Thông báo lỗi không đăng nhập được! Do hết hạn sử dụng.").Show();
                    return;
                }
                else
                {
                    Response.Redirect("Default.aspx?ACCS-_-ADD=" + _nguoidung);
                }
            }
            else {
                X.Msg.Alert("Lỗi","Không tồn tại tài khoản này").Show();
                return;
            }
        }
        protected void btnDangKy_Click(object sender, DirectEventArgs e)
        {

        }
    }
}