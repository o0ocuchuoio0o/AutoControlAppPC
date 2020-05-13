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
namespace TheVoice
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                TabPanelChinh.Height = 590;
                string bienkiemtra = "";
                if (Request.QueryString["ACCS-_-ADD"] != null && Session["CheckLG"].ToString() == Request.QueryString["ACCS-_-ADD"].ToString())
                {
                    bienkiemtra = Request.QueryString["ACCS-_-ADD"].ToString();                   
                    TaoMenuChucNang(bienkiemtra);

                }
                else
                {
                    X.Msg.Alert("Lỗi", "Hãy đăng nhập hệ thống!").Show();
                    return;
                }

            }
        }

        private void TaoMenuChucNang(string bienkiemtra)
        {
            daNguoiDung nd = new daNguoiDung();
            DataTable dt = new DataTable();
            dt = nd.ThongTinTheoIDNguoiDung(Cl_KetNoi.hamketnoisql(),Guid.Parse(bienkiemtra));
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                string quyenhan = dr["QuyenHan"].ToString();
                if (quyenhan == "1")
                {
                    #region // phân hệ quản trị
                    string url1 = cl_ReadURL.LayDiaChiURL("/QuanLy/DanhSachNguoiDung.aspx?ACCS-_-ADD=" + bienkiemtra + "");
                    Ext.Net.Button _btn = new Ext.Net.Button();
                    _btn.Icon = Icon.BookmarkAdd;
                    _btn.Text = "Quản lý người dùng";
                    _btn.OnClientClick = "addTab123('idmnuItemquanlydanhsachnguoidung','" + url1 + "','Quản lý người dùng');";
                    ToolbarMenu.Items.Add(_btn);

                    string url2 = cl_ReadURL.LayDiaChiURL("/QuanLy/DanhSachRender.aspx?ACCS-_-ADD=" + bienkiemtra + "");
                    Ext.Net.Button _btn2 = new Ext.Net.Button();
                    _btn2.Icon = Icon.BookmarkGo;
                    _btn2.Text = "Quản lý danh sách render";
                    _btn2.OnClientClick = "addTab123('idmnuItemquanlydanhsachrender','" + url2 + "','Quản lý danh sách render');";
                    ToolbarMenu.Items.Add(_btn2);   

                    #endregion

                }
                else
                {
                    #region // phân hệ người dùng
                    string url3 = cl_ReadURL.LayDiaChiURL("/NoiDung/LayNoiDung.aspx?ACCS-_-ADD=" + bienkiemtra + "");
                    Ext.Net.Button _btn3 = new Ext.Net.Button();
                    _btn3.Icon = Icon.BookAdd;
                    _btn3.Text = "Thêm nội dung";
                    _btn3.OnClientClick = "addTab123('idmnuItemlaynoidung','" + url3 + "','Thêm nội dung');";
                    ToolbarMenu.Items.Add(_btn3);

                    string url4 = cl_ReadURL.LayDiaChiURL("/NoiDung/DanhSachNoiDung.aspx?ACCS-_-ADD=" + bienkiemtra + "");
                    Ext.Net.Button _btn4 = new Ext.Net.Button();
                    _btn4.Icon = Icon.BookMagnify;
                    _btn4.Text = "Danh sách render";
                    _btn4.OnClientClick = "addTab123('idmnuItemdanhsachrender','" + url4 + "','Danh sách render');";
                    ToolbarMenu.Items.Add(_btn4);
                    #endregion

                }

               
                
                Ext.Net.Button _mnuitem = new Ext.Net.Button();
                _mnuitem.Text = "Đăng xuất";
                _mnuitem.Icon = Icon.ArrowRight;
                _mnuitem.Handler = "DangXuat_Click";
                ToolbarMenu.Items.Add(_mnuitem);
            }
        }
    }
}