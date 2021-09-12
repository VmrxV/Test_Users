using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Test_Users.Classes
{
    public class Database
    {//server
        MySqlConnection connection = new MySqlConnection(
            "Server = sql2.freemysqlhosting.net;" +
               "port=3306; UserID=sql2386755; Password =nS6%aN5*; " +
            "Database =sql2386755");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }


        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
