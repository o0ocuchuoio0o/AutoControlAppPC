using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace StyleTempleProshow
{
    public class Cl_KetNoi
    {
        public static SqlConnection hamketnoisql()
        {
            CauHinhServerBE server = new CauHinhServerBE();
            CauHinhServerBL serverxuly = new CauHinhServerBL();
            server = serverxuly.docdulieu(Environment.CurrentDirectory + "/CauHinhServer.xml");
            return new SqlConnection("server=" + server.Namer1 + ";database=" + server.Data1 + ";user id=" + server.User1 + ";password=" + server.Pass1 + "");
        }
    }
}
