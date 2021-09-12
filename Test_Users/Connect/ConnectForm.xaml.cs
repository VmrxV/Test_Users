using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Test_Users.Forms;
using Test_Users.Classes;
using Test_Users.Properties;
using MySql.Data.MySqlClient;

namespace Test_Users.Connect
{
    /// <summary>
    /// Логика взаимодействия для ConnectForm.xaml
    /// </summary>
    public partial class ConnectForm : Window
    {
        public ConnectForm()
        {
            InitializeComponent();
        }

        private void bage_Click(object sender, RoutedEventArgs e)
        {
            Avtoriz Avtoriz = new Avtoriz();
            Avtoriz.Show();
            this.Hide();
        }
        pols _Pols = new pols();
        private void Proverka_Click(object sender, RoutedEventArgs e)
        {
            // проверка подключеня
            string Connectio = @"server=" + tbServer.Text  + "; UserID="
                + tbUserID.Text + "; Database=" + tbDatebase.Text + ";" + "port="+tbPort.Text
            + "; password=" + tbPassword.Text + ";charset=utf8;";
            MySqlConnection sqlConn = new MySqlConnection(Connectio);
            MySqlCommand command = sqlConn.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = "SELECT 1";
            try
            {
                

                sqlConn.Open();
                Reader = command.ExecuteReader();
                pols.con = Connectio;
                MessageBox.Show("Все прошло успешно", "Подключение");
                Settings.Default.ConnectionString= Connectio;
                Settings.Default.Save();
                this.Close();
                Avtoriz Avtoriz = new Avtoriz();
                Avtoriz.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Нет связи с БД!", "Ошибка подключения");
                return;
            }
        }
    }
}
