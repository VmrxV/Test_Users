using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Users.Properties;

namespace Test_Users.Classes
{
    class pols
    {
        //Подключение
        /*public static string con = "Server = localhost;" +
                "port=3307; UserID=root;" +
             "Password =root; Database =sql12388390";*/
        public static string con= Settings.Default.ConnectionString;
        public static bool CheckConnection(string connectionString)
        {
            MySqlConnection connection = new MySqlConnection(pols.con);
            try { connection = new MySqlConnection(connectionString); 
                connection.Open();
                con = connectionString;
            }
            catch { return false; }
            finally { connection.Close(); }
            return true;
        }
    }
}
