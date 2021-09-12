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
using Test_Users.Forms;
using Test_Users.Classes;
using System.Data;

namespace Test_Users.Pages
{
    /// <summary>
    /// Логика взаимодействия для dateTest.xaml
    /// </summary>
    public partial class dateTest : Window
    {
        public dateTest()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection(pols.con);
        DataTable table = new DataTable();

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            int select = datagrid.SelectedIndex;
            if (select < 0)
            {
                MessageBox.Show("Выберите строку для удаления", "Ошибка");
                return;
            }
            try
            {
                polzovatel.vopros = table.DefaultView[datagrid.SelectedIndex]
                    ["вопрос"].ToString();//выделяемая строка маркировка
                connection.Open();
                string delete = string.Format("DELETE FROM `vopros` " +
                    "WHERE `vopros`.`question` = '{2}'; " +
                    " delete from `vopros` Where vopros.id={0};" +
                "Update `vopros` set `vopros`.id=id - {1} where vopros.id>{0};" +
                 "SELECT vopros.id as № ,vopros.question as вопрос," +
                " vopros.ansver1 as ответ_1 ,vopros.ansver2 as ответ_2," +
                "vopros.ansver3 as ответ_3, vopros.ansver4 as ответ_4," +
                " vopros.ansvertrue as правильный_ответ " +
                "FROM `vopros` ORDER BY `vopros`.`id` ASC", select + 1, 1, polzovatel.vopros);
                MySqlDataAdapter s = new MySqlDataAdapter(delete, connection);
                //выводим то что если запрос =true 
                DataTable table1 = new DataTable();
                s.Fill(table1);
                datagrid.ItemsSource = table1.DefaultView;//заполняем datagrid 
                connection.Close();
                
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                connection.Close();
                return;
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            polzovatel.h = 0;
            polzovatel.butadd = 1;
            change_test edit_Test = new change_test();
            edit_Test.Show();
            this.Hide();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (datagrid.SelectedIndex >= 0)
            {
                string num = table.DefaultView[datagrid.SelectedIndex]
                ["№"].ToString();//выделяемая строка маркировка
                polzovatel.num = Convert.ToInt32(num);
                polzovatel.vopros = table.DefaultView[datagrid.SelectedIndex]
                ["вопрос"].ToString();//выделяемая строка маркировка
                polzovatel.otvet1 = table.DefaultView[datagrid.SelectedIndex]
                ["ответ_1"].ToString();//выделяемая строка маркировка
                polzovatel.otvet2 = table.DefaultView[datagrid.SelectedIndex]
               ["ответ_2"].ToString();//выделяемая строка маркировка
                polzovatel.otvet3 = table.DefaultView[datagrid.SelectedIndex]
               ["ответ_3"].ToString();//выделяемая строка маркировка
                polzovatel.otvet4 = table.DefaultView[datagrid.SelectedIndex]
              ["ответ_4"].ToString();//выделяемая строка маркировка
                polzovatel.Pravotvet = table.DefaultView[datagrid.SelectedIndex]
               ["правильный_ответ"].ToString();//выделяемая строка маркировка
                polzovatel.h = 1; polzovatel.butadd = 0;
                change_test edit_Test = new change_test();
                edit_Test.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Выберите строку для изменения", "Ошибка",
                    MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            polzovatel.butadd = 0;
            Admin1 admin = new Admin1();
            admin.Show();
            this.Hide();
        }
        public void Data(DataGrid dataGrid)
        {
            string select = "SELECT vopros.id as № ,vopros.question as вопрос," +
                " vopros.ansver1 as ответ_1 ,vopros.ansver2 as ответ_2," +
                "vopros.ansver3 as ответ_3, vopros.ansver4 as ответ_4," +
                " vopros.ansvertrue as правильный_ответ " +
                "FROM `vopros` ORDER BY `vopros`.`id` ASC";
            connection.Open();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(select, connection);
            dataAdapter.Fill(table);
            datagrid.ItemsSource = table.DefaultView;
            connection.Close();
        } 
            private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if(Visibility==Visibility.Visible)
            {
                try
                {
                    string select = "SELECT vopros.id as № ,vopros.question as вопрос," +
                " vopros.ansver1 as ответ_1 ,vopros.ansver2 as ответ_2," +
                "vopros.ansver3 as ответ_3, vopros.ansver4 as ответ_4," +
                " vopros.ansvertrue as правильный_ответ " +
                "FROM `vopros` ORDER BY `vopros`.`id` ASC";
                    connection.Open();
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(select, connection);
                    dataAdapter.Fill(table);
                    datagrid.ItemsSource = table.DefaultView;
                    connection.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return;
                }
            }    
        }
    }
}
