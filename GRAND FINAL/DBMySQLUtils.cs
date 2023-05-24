using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GRAND_FINAL
{
    class DBMySQLUtils
    {
        public static MySqlConnection GetDBConnection(string host, int port, string database, string user, string password)
        {
            String connString = $"Server={host};port={port};database={database};user={user};password={password}";
            MySqlConnection conn = new MySqlConnection(connString);
            return conn;

        }
    }
}
