using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace KiemSoatCuoiNgay.KetNoi
{
    public class cl_KetNoi
    {
        public static SqlConnection hamketnoisql()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringHeThong"].ConnectionString.ToString());
        }

        public static SqlConnection CheckKetNoiBCCP(string IP_Server, string Data_name, string Account, string Pass)
        {
            return new SqlConnection("server=" + IP_Server + ";database=" + Data_name + ";user id=" + Account + ";password=" + Pass + "");
        }
    }
}