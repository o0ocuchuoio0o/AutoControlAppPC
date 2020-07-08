using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace TheVoice
{
    public partial class UpLoadVoice : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            foreach (string f in Request.Files.AllKeys)
            {
                HttpPostedFile file = Request.Files[f];
                string FolderPath = ConfigurationManager.AppSettings["FolderVoice"];
                string FilePath = Server.MapPath(FolderPath + file.FileName);
                file.SaveAs(FilePath);
            }	
        }
    }
}