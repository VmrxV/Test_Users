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
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using Test_Users.Forms;
using Test_Users.Classes;
namespace Test_Users.Pages
{
    /// <summary>
    /// Логика взаимодействия для new_sotrudnic.xaml
    /// </summary>
    public partial class new_sotrudnic : Window
    {
        public new_sotrudnic()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection(pols.con);
        private void Button_Click(object sender, RoutedEventArgs e)
        {

                int err = 0;
                if (textBox1.Text == "")
                {
                    err++;
                }

                if (textBox2.Password == "")
                {
                    err++;
                }
                if (textBox3.Text == "")
                {
                    err++;
                }
                if (err != 0)
                {
                    MessageBox.Show("Не все поля заполнены", "Ошибка",
                        MessageBoxButton.OK, MessageBoxImage.Warning); return;
                }
            try
            {
                if (textBox2.Password == textBox2p.Password)
                {
                    connection.Open();
                    string login = string.Format("SELECT Login FROM `users`" +
                        " WHERE Login='{0}'", textBox3.Text);
                    MySqlCommand command = new MySqlCommand(login, connection);
                    string login1 = Convert.ToString(command.ExecuteScalar());//получаем результат
                    if (login1 != "")
                    {
                        MessageBox.Show("Логин занят");
                        connection.Close();
                        return;
                    }
                    else
                    {
                        //Уникальный номер
                        string count = "select count(*) from `users`";
                        command = new MySqlCommand(count, connection);
                        int r = Convert.ToInt32(command.ExecuteScalar());
                        string password = textBox2.Password;
                        //вставка
                        string sql1 = String.Format("INSERT INTO `users`(`ID`, `Login`, " +
                            "`Password`,`Fill`,`Id_role`) VALUES('{0}','{1}',{2},'{3}','{4}')",
                            r + 1, textBox3.Text, textBox2.Password, textBox1.Text, 2);
                        MySqlCommand command1 = new MySqlCommand(sql1, connection);//создаем запрос
                        command1.ExecuteNonQuery();//выполняем запрос авторизация
                        command.ExecuteNonQuery();//выполняем запрос в таб работникик
                        connection.Close();//закрываем соединение
                        polzovatel.login = textBox3.Text;//заводим в логин для теста
                        MessageBox.Show("Данные сохранены");
                        Admin1 admin = new Admin1();
                        admin.Show();
                        this.Hide();
                        connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Пароль не совпадает", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
                    textBox2.Password = "";
                    textBox2p.Password = "";
                    return;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                connection.Close();
                return;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Admin1 admin = new Admin1();
            admin.Show();
            this.Hide();
        }
    }
}
