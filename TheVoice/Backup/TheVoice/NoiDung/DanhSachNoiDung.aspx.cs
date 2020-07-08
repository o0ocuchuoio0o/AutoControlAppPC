using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using TheVoice.KetNoi;
using Ext.Net;
using DaoTheVoice;
using System.Net;
using System.IO;
namespace TheVoice.NoiDung
{
    public partial class DanhSachNoiDung : System.Web.UI.Page
    {

        private void hienthidulieu()
        {
            daBaiViet ds = new daBaiViet();
            DataTable dt = new DataTable();
            DateTime ngay = Convert.ToDateTime(txtngay.Text);           
            dt = ds.DanhSachTheoNguoiDung(Cl_KetNoi.hamketnoisql(), Guid.Parse(lblflag.Value.ToString()), ngay);
            if (dt.Rows.Count > 0)
            {
                stodanhsachtintuc.DataSource = dt;
                stodanhsachtintuc.DataBind();
            }
        }
        protected void DanhSachTinTucPhanTrang(object sender, StoreReadDataEventArgs e)
        {
            hienthidulieu();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session.Clear();
                lblflag.Value = Request.QueryString["ACCS-_-ADD"];
                txtngay.Text = DateTime.Now.ToString("dd/MM/yyyy");              
                hienthidulieu();
            }
        }
        protected void btnhienthi_Click(object sender, DirectEventArgs e)
        {
            hienthidulieu();
        }       
        
        protected void cmblayfilevoice_Down(object sender, DirectEventArgs e)
        {
            string filePath = e.ExtraParams["LinkVoice"].ToString();
            String FilePath = filePath.Replace("/", "\\");
            String FileName = FilePath.Substring(FilePath.LastIndexOf("\\") + 1);    

            Response.ContentType = "application/zip";
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + FileName);
            Response.TransmitFile(Server.MapPath("~"+filePath));
            Response.End();
        }
    }
}