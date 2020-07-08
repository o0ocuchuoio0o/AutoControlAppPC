using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using DaoTheVoice;
using TheVoice.KetNoi;
namespace TheVoice
{
    /// <summary>
    /// Summary description for WS_Service
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WS_Service : System.Web.Services.WebService
    {

        [WebMethod]
        public DataTable DanhSachCanRender()
        {
            DataTable dt = new DataTable();
            daBaiViet bv = new daBaiViet();
            dt = bv.DanhSachCanRender(Cl_KetNoi.hamketnoisql());
            return dt;
        }
        [WebMethod]
        public void UpdateDangRender(Guid IDBaiViet)
        {           
            daBaiViet bv = new daBaiViet();
            bv.UpdateDangRender(Cl_KetNoi.hamketnoisql(), IDBaiViet);           
        }
        [WebMethod]
        public void UpdateDaRender(Guid IDBaiViet,string linkvoice)
        {
            daBaiViet bv = new daBaiViet();
            bv.UpdateDaRender(Cl_KetNoi.hamketnoisql(), IDBaiViet,linkvoice);
        }
        [WebMethod]
        public DataTable DanhSachAPI()
        {
            DataTable dt = new DataTable();
            daDanhMucAPI bv = new daDanhMucAPI();
            dt = bv.DanhSach(Cl_KetNoi.hamketnoisql());
            return dt;
        }
    }
}
