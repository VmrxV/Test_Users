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
using MySql.Data.MySqlClient;
using Test_Users.Classes;
using Test_Users.Connect;
using Test_Users.Pages;
namespace Test_Users.Forms
{
    /// <summary>
    /// Логика взаимодействия для Avtoriz.xaml
    /// </summary>
    public partial class Avtoriz : Window
    {
        public Avtoriz()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(pols.con);
                connection.Open();
                if (textBox1.Text.Length > 0 & textBox2.Password.Length > 0)
                {
                   
                    
                    string login = string.Format("SELECT Id_role from `users` where" +
                        " Login='{0}'and Password='{1}'", textBox1.Text, textBox2.Password);
                    MySqlCommand command1 = new MySqlCommand(login, connection);
                    int name = Convert.ToInt32(command1.ExecuteScalar());
                    //Получаем ео табельный номер
                    string Idnumer = string.Format("SELECT ID from `users` where" +
                        " Login='{0}'and Password='{1}'", textBox1.Text, textBox2.Password);
                    command1 = new MySqlCommand(Idnumer, connection);
                    polzovatel.ID = Convert.ToInt32(command1.ExecuteScalar());

                    switch (name)
                    {
                        case 1:
                            //логин пользователя
                            polzovatel.login = textBox1.Text;
                            Admin1 admin = new Admin1();
                            admin.Show();
                            this.Close();
                            break;

                        case 2:
                            polzovatel.login = textBox1.Text;
                            Test_list sotrudnic = new Test_list();
                            sotrudnic.Show();
                            this.Close();
                            break;
                        default:
                            MessageBox.Show("Неправельный логин или пароль");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Не все поля заполнены", "Внимение",
                        MessageBoxButton.OK, MessageBoxImage.Warning);
                    connection.Close();
                    return;
                }
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Нет соединения с БД!"+
                    "\n\tПроверьте соединения с БД",
                    "Внимание",MessageBoxButton.OKCancel,
                    MessageBoxImage.Warning);
                return;
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void proverka_Click(object sender, RoutedEventArgs e)
        {
            ConnectForm Condition = new ConnectForm();
            Condition.Show();
            this.Close();
        }
    }
}
