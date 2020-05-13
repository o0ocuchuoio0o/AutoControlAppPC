using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TheVoice.KetNoi
{
    public class Cl_KetNoi
    {
        public static SqlConnection hamketnoisql()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringHeThong"].ConnectionString.ToString());
        }
    }
}