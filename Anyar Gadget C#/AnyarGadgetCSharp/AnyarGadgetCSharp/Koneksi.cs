using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace AnyarGadgetCSharp
{
    class Koneksi
    {
        public System.Data.SqlClient.SqlConnection GetConn()
        {
            System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
            conn.ConnectionString = "Data Source=10.1.0.53; Initial Catalog=DB_EMAIL;user=sa; Password=h0spit4lity#";
            return conn;

        }

    }
}
