using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ext.Net;
using KiemSoatCuoiNgay.KetNoi;
namespace KiemSoatCuoiNgay
{
    public partial class Default : System.Web.UI.Page
    {

        private void TaoMenuChucNang()
        {

            string url1 = cl_ReadURL.LayDiaChiURL("/KiemSoatCod/KiemSoatCod.aspx");
            Ext.Net.Button _btn = new Ext.Net.Button();
            _btn.Icon = Icon.LightningAdd;
            _btn.Text = "Kiểm soát cod lỗi";
            _btn.OnClientClick = "addTab123('idmnuItemquanlykenh','" + url1 + "','Kiểm soát cod lỗi');";
            ToolbarMenu.Items.Add(_btn);

            string url3 = cl_ReadURL.LayDiaChiURL("/KiemSoatDongTui/KiemSoatDongTui.aspx");
            Ext.Net.Button _btn3 = new Ext.Net.Button();
            _btn3.Icon = Icon.Help;
            _btn3.Text = "Kiểm soát chưa đóng túi";
            _btn3.OnClientClick = "addTab123('idmnuItemlaythucong','" + url3 + "','Kiểm soát chưa đóng túi');";
            ToolbarMenu.Items.Add(_btn3);


           
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TabPanelChinh.Height = 590;              
                TaoMenuChucNang();             

            }
        }
    }
}