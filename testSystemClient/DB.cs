using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testSystemClient
{
    class DB
    {
        public static string conString = "Data Source=DESKTOP-3LAVDLQ;Initial Catalog=testingSystemTestDB;Integrated Security=True";
        SqlConnection conection = new SqlConnection(conString);

        public void openConnection()
        {
            if (conection.State == System.Data.ConnectionState.Closed)
                conection.Open();
        }
        public void closeConnection()
        {
            if (conection.State == System.Data.ConnectionState.Open)
                conection.Close();
        }
        public SqlConnection getConnection ()
        {
            return conection;
        }
    }
}
