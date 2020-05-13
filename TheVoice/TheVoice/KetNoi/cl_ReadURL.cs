using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheVoice.KetNoi
{
    public class cl_ReadURL
    {
        public static string LayDiaChiURL(string DuongDan)
        {
            HttpRequest r = HttpContext.Current.Request;
            if (r.ApplicationPath == "/")
                return r.Url.Scheme + "://" + r.Url.Authority + DuongDan;
            else
                return r.Url.Scheme + "://" + r.Url.Authority + r.ApplicationPath + DuongDan;
        }
    }
}