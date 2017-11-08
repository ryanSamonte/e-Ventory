using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace projectTemp
{
    class DBConnection
    {
        public DBConnection()
        {

        }
        public static String connect()
        {
            //String connectionString = ConfigurationManager.AppSettings["Connection"];

            //String connectionString = "Data Source=RYANRS;Initial Catalog=e-VentoryDB;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            String connectionString = "Data Source=SQL5030.SmarterASP.NET;Initial Catalog=DB_A2B60D_eVentoryDB;User Id=DB_A2B60D_eVentoryDB_admin;Password=09336373145ryan;";

            return connectionString;
        }

    }
}
