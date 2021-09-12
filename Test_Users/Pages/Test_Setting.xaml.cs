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
using Test_Users.Classes;
using MySql.Data.MySqlClient;
using System.Data;
using Test_Users.Forms;

namespace Test_Users.Pages
{
    /// <summary>
    /// Логика взаимодействия для Test_Setting.xaml
    /// </summary>
    public partial class Test_Setting : Window
    {
        public Test_Setting()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection(pols.con);
        DataTable table = new DataTable();
        DataTable table2 = new DataTable();
        private void button3_Click(object sender, RoutedEventArgs e)
        {
                dtVorpos();
                MessageBox.Show("Тест создан");
        }
        int [] vopros = new int[16];
        private void dtVorpos()
        {
            int h = 0;
            try 
            {
                string count = "select count(*) from `test_name`";
                MySqlCommand command12 = new MySqlCommand(count, con);
                con.Open();
                int r = Convert.ToInt32(command12.ExecuteScalar());
                //Вставка в бд Test_name 

                string testname = String.Format("INSERT INTO `test_name`" +
                    " (`ID`, `Name`, `Time`)" +
                    " VALUES('{0}','{1}','{2}')", 
                    r + 1, textbox1.Text, textbox2.Text);
                //вставка
                MySqlCommand command1 = new MySqlCommand(testname, con);
                command1.ExecuteNonQuery();

                //смотрим есть ли вопрос выбран
                for (int i =0; i < DgVopros.Items.Count-1; i++)
            {
                CheckBox mycheckbox = DgVopros.Columns[0].GetCellContent
                        (DgVopros.Items[i]) as CheckBox;
                    //если выбран
                    if (mycheckbox == null)
                    {
                        h++;
                        //заносим в масив до 15 вопросв
                        if (h < 17)
                        {
                            vopros[h] = i;
                        }
                    }
                     else if (mycheckbox.IsChecked == true)
                    {
                        h++;
                        //заносим в масив до 15 вопросв
                        if (h < 16)
                        {
                            vopros[h] = i;
                        }
                    }
            }
                if (h < 15)
                {
                    MessageBox.Show("Выберите 15 вопрсов","Внимание");
                    return;
                }
            //проверяем если выбран логин
                for (int i = 1; i < DgUsers.Items.Count-1; i++)
                {
                    CheckBox mycheckbox = DgUsers.Columns[0].GetCellContent(DgUsers.Items[i]) as CheckBox;
                   
                    if (mycheckbox == null)
                    {

                    }
                    else if (mycheckbox.IsChecked == true)
                    {
                        for (int j = 0; j < vopros.Length-1; j++)
                        {
                            //вставляем в БД
                            int vopros2 = vopros[j + 1];
                            string addTessting = String.Format("INSERT INTO `testing_setting`(`Id_test`," +
                                " `Id_Users`, `Id_Vopros`) VALUES('{0}','{1}','{2}')", r+1, i, vopros2+1);
                             command1 = new MySqlCommand(addTessting, con);//создаем запрос
                            command1.ExecuteNonQuery();//выполняем запрос авторизация
                        }
                        con.Close();
                    }
                    
                }

            }
            catch(Exception ex)
            {
                con.Close();
                return;
            }
        }
        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                
                try
                {
                    string select = "SELECT question FROM `vopros` ORDER BY `vopros`.`id` ASC";
                    con.Open();
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(select, con);
                    dataAdapter.Fill(table);
                    DgVopros.ItemsSource = table.DefaultView;

                    string select2 = "SELECT Login FROM `users` ORDER BY `users`.`ID` ASC";
                    MySqlDataAdapter dataAdapter2 = new MySqlDataAdapter(select2, con);
                    dataAdapter2.Fill(table2);
                    DgUsers.ItemsSource = table2.DefaultView;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    con.Close();
                    return;
                }
            }
        }

        private void Bage_Click(object sender, RoutedEventArgs e)
        {
            Admin1 admin = new Admin1();
            admin.Show();
            this.Hide();
        }
    }
}
