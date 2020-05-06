using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ext.Net;
using DaoKiemSoatCuoiNgay;
using KiemSoatCuoiNgay.KetNoi;
using System.Data;
using System.Data.SqlClient;
namespace KiemSoatCuoiNgay
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                Session.Clear();
                wDangNhap.Show();
                txtMaBuuCuc.Focus();
            }         
        }

        protected void btnfDangNhap_Click(object sender, DirectEventArgs e)
        {
            Response.Redirect("Default.aspx");
            //daIPServer dn = new daIPServer();
            //DataTable dt = new DataTable();
            //try
            //{
            //    if (txtMaBuuCuc.Text == "")
            //    {
            //        X.Msg.Alert("Thông báo lỗi", "Bắt buộc phải nhập vào mã bưu cục!").Show();
            //        return;
            //    }
            //}
            //catch
            //{
            //    X.Msg.Alert("Thông báo lỗi", "Bắt buộc phải nhập vào mã bưu cục!").Show();
            //    return;
            //}
            //dt = dn.ThongTinServer(cl_KetNoi.hamketnoisql(), txtMaBuuCuc.Text);
            //if (dt.Rows.Count > 0)
            //{
            //    DataRow r = dt.Rows[0];
            //    string IP_Server=r["IP_Server"].ToString();
            //    string Data_name=r["Data_name"].ToString();
            //    string Account=r["Account"].ToString();
            //    string Pass = r["Pass"].ToString();
            //    // lblThongBao.Text = "Thông tin kết nối IP_Server=" + IP_Server + ";Data_name=" + Data_name + ";Account=" + Account + ";Pass=" + Pass;
            //    #region // kiểm tra kết nối tới máy chủ sql bccp tại đơn vị
            //    try {
            //        SqlConnection conn = new SqlConnection();
            //        conn= cl_KetNoi.CheckKetNoiBCCP(IP_Server, Data_name, Account, Pass);
            //        bool ketnoi = false;
            //        try {
            //            conn.Open();
            //            ketnoi = true;
            //            conn.Close();
            //        }
            //        catch { }
            //        if (ketnoi == true)
            //        {
            //            Response.Redirect("Default.aspx?mabuucuc=" + txtMaBuuCuc.Text);
            //        }
            //    }
            //    catch (Exception ex) {
            //        X.Msg.Alert("Thông báo lỗi", "Không có kết nối tới máy chủ BCCP:" + IP_Server + ".A/C báo IT đơn vị kiểm tra lại máy chủ BCCP" + ex.ToString()).Show();
            //        return;
            //    }
            //    #endregion
            //}
            //else {
            //    X.Msg.Alert("Thông báo lỗi", "Chưa có thông tin kết nối tới BCCP trên doanh thu 24h!Anh/chị hãy báo tin học trung tâm khai báo trên hệ thống doanhthu24h").Show();
            //    return;
            //}
        }
        
    }
}