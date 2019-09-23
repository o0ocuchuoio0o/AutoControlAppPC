using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace AutoWeb
{
    public class Cl_KetNoi
    {
        public static SqlConnection hamketnoisql()
        {
            CauHinhServerBE server = new CauHinhServerBE();
            CauHinhServerBL serverxuly = new CauHinhServerBL();
            server = serverxuly.docdulieu(Environment.CurrentDirectory + "/lib/CauHinhServer.xml");
            return new SqlConnection("server=" + server.Namer1 + ";database=" + server.Data1 + ";user id=" + server.User1 + ";password=" + server.Pass1 + "");
        }

        public static void sqlDependency()
        {
            CauHinhServerBE server = new CauHinhServerBE();
            CauHinhServerBL serverxuly = new CauHinhServerBL();
            server = serverxuly.docdulieu(Environment.CurrentDirectory + "/lib/CauHinhServer.xml");
            string m_connect = "server=" + server.Namer1 + ";database=" + server.Data1 + ";user id=" + server.User1 + ";password=" + server.Pass1 + "";
            try
            {
                SqlClientPermission ss = new SqlClientPermission(System.Security.Permissions.PermissionState.Unrestricted);
                ss.Demand();
            }
            catch (Exception)
            {

                throw;
            }
            SqlDependency.Stop(m_connect);
            SqlDependency.Start(m_connect);
        }
    }
}
