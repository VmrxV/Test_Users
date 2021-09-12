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
using Test_Users.Forms;
using System.Windows.Threading;

namespace Test_Users.Pages
{
    /// <summary>
    /// Логика взаимодействия для TestV.xaml
    /// </summary>
    public partial class TestV : Window
    {
        public TestV()
        {
            InitializeComponent();
            datetimestest();
            random_mas();
            vopros();
            one_otvet();
            tho_otvet();
            the_otvet();
            for_otvet();
        }
        int voprosnum = 1;
        //тест кнопки 
        private void v1_Click(object sender, RoutedEventArgs e)
        {
            //проверка вопроса который активный
            label1.Content = "Вопрос 1 из 15";
            voprosnum = 1;
            visibli(); Colors();
            list1.Visibility = Visibility.Visible;
            button2.Content = "Далее";
        }

        private void v2_Click(object sender, RoutedEventArgs e)
        {
            label1.Content = "Вопрос 2 из 15";
            voprosnum = 2;
            visibli(); Colors();
            list2.Visibility = Visibility.Visible;
            button2.Content = "Далее";
        }
        private void v3_Click(object sender, RoutedEventArgs e)
        {
            label1.Content = "Вопрос 3 из 15";
            voprosnum = 3;
            visibli(); Colors();
            list3.Visibility = Visibility.Visible;
            button2.Content = "Далее";
        }
        private void v4_Click(object sender, RoutedEventArgs e)
        {
            label1.Content = "Вопрос 4 из 15";
            voprosnum = 4;
            visibli(); Colors();
            list4.Visibility = Visibility.Visible;
            button2.Content = "Далее";
        }
        private void v5_Click(object sender, RoutedEventArgs e)
        {
            label1.Content = "Вопрос 5 из 15";
            voprosnum = 5;
            visibli(); Colors();
            list5.Visibility = Visibility.Visible;
            button2.Content = "Далее";
        }
        private void v6_Click(object sender, RoutedEventArgs e)
        {
            label1.Content = "Вопрос 6 из 15";
            voprosnum = 6;
            visibli(); Colors();
            list6.Visibility = Visibility.Visible;
            button2.Content = "Далее";
        }
        private void v7_Click(object sender, RoutedEventArgs e)
        {
            label1.Content = "Вопрос 7 из 15";
            voprosnum = 7;
            visibli(); Colors();
            list7.Visibility = Visibility.Visible;
            button2.Content = "Далее";
        }
        private void v8_Click(object sender, RoutedEventArgs e)
        {
            label1.Content = "Вопрос 8 из 15";
            voprosnum = 8;
            visibli(); Colors();
            list8.Visibility = Visibility.Visible;
            button2.Content = "Далее";
        }
        private void v9_Click(object sender, RoutedEventArgs e)
        {
            label1.Content = "Вопрос 9 из 15";
            voprosnum = 9;
            visibli(); Colors();
            list9.Visibility = Visibility.Visible;
            button2.Content = "Далее";
        }
        private void v10_Click(object sender, RoutedEventArgs e)
        {
            label1.Content = "Вопрос 10 из 15";
            voprosnum = 10;
            visibli(); Colors();
            list10.Visibility = Visibility.Visible;
            button2.Content = "Далее";
        }
        private void v11_Click(object sender, RoutedEventArgs e)
        {
            label1.Content = "Вопрос 11 из 15";
            voprosnum = 11;
            visibli(); Colors();
            list11.Visibility = Visibility.Visible;
            button2.Content = "Далее";
        }
        private void v12_Click(object sender, RoutedEventArgs e)
        {
            label1.Content = "Вопрос 12 из 15";
            voprosnum = 12;
            visibli(); Colors();
            list12.Visibility = Visibility.Visible;
            button2.Content = "Далее";
        }
        private void v13_Click(object sender, RoutedEventArgs e)
        {
            label1.Content = "Вопрос 13 из 15";
            voprosnum = 13;
            visibli(); Colors();
            list13.Visibility = Visibility.Visible;
            button2.Content = "Далее";
        }
        private void v14_Click(object sender, RoutedEventArgs e)
        {
            label1.Content = "Вопрос 14 из 15";
            voprosnum = 14;
            visibli(); Colors();
            list14.Visibility = Visibility.Visible;
            button2.Content = "Далее";
        }
        private void v15_Click(object sender, RoutedEventArgs e)
        {
            label1.Content = "Вопрос 15 из 15";
            voprosnum = 15;
            visibli(); Colors();
            list15.Visibility = Visibility.Visible;
            button2.Content = "Завершить тест";
        }
        //методы изчезновения
        private void visibli()
        {
            if (list1.Visibility == Visibility.Visible)
                list1.Visibility = Visibility.Hidden;
            if (list2.Visibility == Visibility.Visible)
                list2.Visibility = Visibility.Hidden;
            if (list3.Visibility == Visibility.Visible)
                list3.Visibility = Visibility.Hidden;
            if (list4.Visibility == Visibility.Visible)
                list4.Visibility = Visibility.Hidden;
            if (list5.Visibility == Visibility.Visible)
                list5.Visibility = Visibility.Hidden;
            if (list6.Visibility == Visibility.Visible)
                list6.Visibility = Visibility.Hidden;
            if (list7.Visibility == Visibility.Visible)
                list7.Visibility = Visibility.Hidden;
            if (list8.Visibility == Visibility.Visible)
                list8.Visibility = Visibility.Hidden;
            if (list9.Visibility == Visibility.Visible)
                list9.Visibility = Visibility.Hidden;
            if (list10.Visibility == Visibility.Visible)
                list10.Visibility = Visibility.Hidden;
            if (list11.Visibility == Visibility.Visible)
                list11.Visibility = Visibility.Hidden;
            if (list12.Visibility == Visibility.Visible)
                list12.Visibility = Visibility.Hidden;
            if (list13.Visibility == Visibility.Visible)
                list13.Visibility = Visibility.Hidden;
            if (list14.Visibility == Visibility.Visible)
                list14.Visibility = Visibility.Hidden;
            if (list15.Visibility == Visibility.Visible)
                list15.Visibility = Visibility.Hidden;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (button2.Content == "Завершить тест")
            {
                if (MessageBox.Show("Вы точно хотите завершить тест", "Внимание",
                    MessageBoxButton.OKCancel, MessageBoxImage.Information)
                    == MessageBoxResult.OK)
                {
                    rezultat();
                }

            }
            else
            {
                //если вопрос до 15
                voprosnum++;
                label1.Content = "Вопрос " + voprosnum + " из 15";
                visibli(); Colors();
                perehot();
            }
        }
        //покрашивание
        private void Colors()
        {
            if (rad11.IsChecked == true)
            {
                v1.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50));
                v1.BorderBrush = v1.Background;
            }
            if (rad21.IsChecked == true) { v1.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v1.BorderBrush = v1.Background; }
            if (rad31.IsChecked == true) { v1.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v1.BorderBrush = v1.Background; }
            if (rad41.IsChecked == true) { v1.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v1.BorderBrush = v1.Background; }

            if (rad12.IsChecked == true) { v2.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v2.BorderBrush = v2.Background; v2.BorderBrush = v2.Background; v2.BorderBrush = v2.Background; }
            if (rad22.IsChecked == true) { v2.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v2.BorderBrush = v2.Background; v2.BorderBrush = v2.Background; v2.BorderBrush = v2.Background; }
            if (rad32.IsChecked == true) { v2.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v2.BorderBrush = v2.Background; v2.BorderBrush = v2.Background; v2.BorderBrush = v2.Background; }
            if (rad42.IsChecked == true) { v2.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v2.BorderBrush = v2.Background; v2.BorderBrush = v2.Background; v2.BorderBrush = v2.Background; }

            if (rad13.IsChecked == true) { v3.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v3.BorderBrush = v3.Background; }
            if (rad23.IsChecked == true) { v3.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v3.BorderBrush = v3.Background; }
            if (rad33.IsChecked == true) { v3.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v3.BorderBrush = v3.Background; }
            if (rad43.IsChecked == true) { v3.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v3.BorderBrush = v3.Background; }

            if (rad14.IsChecked == true) { v4.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v4.BorderBrush = v4.Background; }
            if (rad24.IsChecked == true) { v4.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v4.BorderBrush = v4.Background; }
            if (rad34.IsChecked == true) { v4.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v4.BorderBrush = v4.Background; }
            if (rad44.IsChecked == true) { v4.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v4.BorderBrush = v4.Background; }

            if (rad15.IsChecked == true) { v5.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v5.BorderBrush = v5.Background; v5.BorderBrush = v5.Background; v5.BorderBrush = v5.Background; }
            if (rad25.IsChecked == true) { v5.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v5.BorderBrush = v5.Background; v5.BorderBrush = v5.Background; v5.BorderBrush = v5.Background; }
            if (rad35.IsChecked == true) { v5.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v5.BorderBrush = v5.Background; v5.BorderBrush = v5.Background; v5.BorderBrush = v5.Background; }
            if (rad45.IsChecked == true) { v5.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v5.BorderBrush = v5.Background; v5.BorderBrush = v5.Background; v5.BorderBrush = v5.Background; }

            if (rad16.IsChecked == true) { v6.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v6.BorderBrush = v6.Background; }
            if (rad26.IsChecked == true) { v6.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v6.BorderBrush = v6.Background; }
            if (rad36.IsChecked == true) { v6.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v6.BorderBrush = v6.Background; }
            if (rad46.IsChecked == true) { v6.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v6.BorderBrush = v6.Background; }

            if (rad17.IsChecked == true) { v7.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v7.BorderBrush = v7.Background; }
            if (rad27.IsChecked == true) { v7.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v7.BorderBrush = v7.Background; }
            if (rad37.IsChecked == true) { v7.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v7.BorderBrush = v7.Background; }
            if (rad47.IsChecked == true) { v7.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v7.BorderBrush = v7.Background; }

            if (rad18.IsChecked == true) { v8.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v8.BorderBrush = v8.Background; }
            if (rad28.IsChecked == true) { v8.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v8.BorderBrush = v8.Background; }
            if (rad38.IsChecked == true) { v8.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v8.BorderBrush = v8.Background; }
            if (rad48.IsChecked == true) { v8.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v8.BorderBrush = v8.Background; }

            if (rad19.IsChecked == true) { v9.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v9.BorderBrush = v9.Background; }
            if (rad29.IsChecked == true) { v9.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v9.BorderBrush = v9.Background; }
            if (rad39.IsChecked == true) { v9.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v9.BorderBrush = v9.Background; }
            if (rad49.IsChecked == true) { v9.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v9.BorderBrush = v9.Background; }

            if (rad110.IsChecked == true) { v10.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50));  v10.BorderBrush = v10.Background; }
            if (rad210.IsChecked == true) { v10.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50));  v10.BorderBrush = v10.Background; }
            if (rad310.IsChecked == true) { v10.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50));  v10.BorderBrush = v10.Background; }
            if (rad410.IsChecked == true) { v10.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v10.BorderBrush = v10.Background; }

            if (rad111.IsChecked == true) { v11.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v11.BorderBrush = v11.Background; }
            if (rad211.IsChecked == true) { v11.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v11.BorderBrush = v11.Background; }
            if (rad311.IsChecked == true) { v11.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v11.BorderBrush = v11.Background; }
            if (rad411.IsChecked == true) { v11.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v11.BorderBrush = v11.Background; }

            if (rad112.IsChecked == true) { v12.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v12.BorderBrush = v12.Background; }
            if (rad212.IsChecked == true) { v12.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v12.BorderBrush = v12.Background; }
            if (rad312.IsChecked == true) { v12.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v12.BorderBrush = v12.Background; }
            if (rad412.IsChecked == true) { v12.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v12.BorderBrush = v12.Background; }

            if (rad113.IsChecked == true) { v13.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v13.BorderBrush = v13.Background; }
            if (rad213.IsChecked == true) { v13.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v13.BorderBrush = v13.Background; }
            if (rad313.IsChecked == true) { v13.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v13.BorderBrush = v13.Background; }
            if (rad413.IsChecked == true) { v13.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v13.BorderBrush = v13.Background; }

            if (rad114.IsChecked == true) { v14.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v14.BorderBrush = v14.Background; }
            if (rad214.IsChecked == true) { v14.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v14.BorderBrush = v14.Background; }
            if (rad314.IsChecked == true) { v14.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v14.BorderBrush = v14.Background; }
            if (rad414.IsChecked == true) { v14.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v14.BorderBrush = v14.Background; }

            if (rad115.IsChecked == true) { v15.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v15.BorderBrush = v15.Background; }
            if (rad215.IsChecked == true) { v15.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v15.BorderBrush = v15.Background; }
            if (rad315.IsChecked == true) { v15.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v15.BorderBrush = v15.Background; }
            if (rad415.IsChecked == true) { v15.Background = new SolidColorBrush(Color.FromRgb(66, 230, 50)); v15.BorderBrush = v15.Background; }

        }
        private void rezultat()
        {
            DateTime thisDay = DateTime.Now;
            thisDay.ToString("yyyy:mm:dd");
            string date = thisDay.ToShortDateString();
            string otvet = "";
            string ansvertrue = "";
            MySqlCommand command1 = new MySqlCommand();
            MySqlCommand command = new MySqlCommand();
            string f = "";
            int bal = 0;
            //вставляем 1 вопрос
            otvet = ""; num = vopros_test[0];
            if (rad11.IsChecked == true) { otvet = rad11.Content.ToString(); }
            if (rad21.IsChecked == true) { otvet = rad21.Content.ToString(); }
            if (rad31.IsChecked == true) { otvet = rad31.Content.ToString(); }
            if (rad41.IsChecked == true) { otvet = rad41.Content.ToString(); }
            //запрос совопдает ли отвте с правельный овтетом
            ansvertrue = string.Format("SELECT vopros.id FROM `vopros` " +
                "where vopros.id = '{0}' and vopros.ansvertrue = '{1}'",
                num, otvet);
            connection.Open();
            command1 = new MySqlCommand(ansvertrue, connection);
            bal = Convert.ToInt32(command1.ExecuteScalar());
            if (bal > 0) bal = 1; else bal = 0;
            //вставляем результат
            f = string.Format("INSERT INTO `testing` ( `id_login`, " +
                "`id_vopros`, `otvet`,`bal`, `datatime`, `Id_test`)" +
                " VALUES ('{0}', '{1}', '{2}','{3}','{4}', '{5}');",
                polzovatel.ID, num, otvet, bal, date, polzovatel.testNum);
            command = new MySqlCommand(f, connection);
            command.ExecuteNonQuery();
            connection.Close();
            //вставляем 2 вопрос
            otvet = ""; num = vopros_test[1];
            if (rad12.IsChecked == true) { otvet = rad12.Content.ToString(); }
            if (rad22.IsChecked == true) { otvet = rad22.Content.ToString(); }
            if (rad32.IsChecked == true) { otvet = rad32.Content.ToString(); }
            if (rad42.IsChecked == true) { otvet = rad42.Content.ToString(); }
            //запрос совопдает ли отвте с правельный овтетом
            ansvertrue = string.Format("SELECT vopros.id FROM `vopros` " +
               "where vopros.id = '{0}' and vopros.ansvertrue = '{1}'",
               num, otvet);
            connection.Open();
            command1 = new MySqlCommand(ansvertrue, connection);
            bal = Convert.ToInt32(command1.ExecuteScalar());
            if (bal > 0) bal = 1; else bal = 0;
            //вставляем результат
            f = string.Format("INSERT INTO `testing` ( `id_login`, " +
                "`id_vopros`, `otvet`,`bal`, `datatime`, `Id_test`)" +
                " VALUES ('{0}', '{1}', '{2}','{3}','{4}', '{5}');",
                polzovatel.ID, num, otvet, bal, date, polzovatel.testNum);
            command = new MySqlCommand(f, connection);
            command.ExecuteNonQuery();
            connection.Close();
            //вставляем 3 вопрос
            otvet = ""; num = vopros_test[2];
            if (rad13.IsChecked == true) { otvet = rad13.Content.ToString(); }
            if (rad23.IsChecked == true) { otvet = rad23.Content.ToString(); }
            if (rad33.IsChecked == true) { otvet = rad33.Content.ToString(); }
            if (rad43.IsChecked == true) { otvet = rad43.Content.ToString(); }
            //запрос совопдает ли отвте с правельный овтетом
            ansvertrue = string.Format("SELECT vopros.id FROM `vopros` " +
               "where vopros.id = '{0}' and vopros.ansvertrue = '{1}'",
               num, otvet);
            connection.Open();
            command1 = new MySqlCommand(ansvertrue, connection);
            bal = Convert.ToInt32(command1.ExecuteScalar());
            if (bal > 0) bal = 1; else bal = 0;
            //вставляем результат
            f = string.Format("INSERT INTO `testing` ( `id_login`, " +
                "`id_vopros`, `otvet`,`bal`, `datatime`, `Id_test`)" +
                " VALUES ('{0}', '{1}', '{2}','{3}','{4}', '{5}');",
                polzovatel.ID, num, otvet, bal, date, polzovatel.testNum);
            command = new MySqlCommand(f, connection);
            command.ExecuteNonQuery();
            connection.Close();
            //вставляем 4 вопрос
            otvet = ""; num = vopros_test[3];
            if (rad14.IsChecked == true) { otvet = rad14.Content.ToString(); }
            if (rad24.IsChecked == true) { otvet = rad24.Content.ToString(); }
            if (rad34.IsChecked == true) { otvet = rad34.Content.ToString(); }
            if (rad44.IsChecked == true) { otvet = rad44.Content.ToString(); }
            //запрос совопдает ли отвте с правельный овтетом
            ansvertrue = string.Format("SELECT vopros.id FROM `vopros` " +
               "where vopros.id = '{0}' and vopros.ansvertrue = '{1}'",
               num, otvet);
            connection.Open();
            command1 = new MySqlCommand(ansvertrue, connection);
            bal = Convert.ToInt32(command1.ExecuteScalar());
            if (bal > 0) bal = 1; else bal = 0;
            //вставляем результат
            f = string.Format("INSERT INTO `testing` ( `id_login`, " +
                "`id_vopros`, `otvet`,`bal`, `datatime`, `Id_test`)" +
                " VALUES ('{0}', '{1}', '{2}','{3}','{4}', '{5}');",
                polzovatel.ID, num, otvet, bal, date, polzovatel.testNum);
            command = new MySqlCommand(f, connection);
            command.ExecuteNonQuery();
            connection.Close();
            //вставляем 5 вопрос
            otvet = ""; num = vopros_test[4];
            if (rad15.IsChecked == true) { otvet = rad15.Content.ToString(); }
            if (rad25.IsChecked == true) { otvet = rad25.Content.ToString(); }
            if (rad35.IsChecked == true) { otvet = rad35.Content.ToString(); }
            if (rad45.IsChecked == true) { otvet = rad45.Content.ToString(); }
            //запрос совопдает ли отвте с правельный овтетом
            ansvertrue = string.Format("SELECT vopros.id FROM `vopros` " +
               "where vopros.id = '{0}' and vopros.ansvertrue = '{1}'",
               num, otvet);
            connection.Open();
            command1 = new MySqlCommand(ansvertrue, connection);
            bal = Convert.ToInt32(command1.ExecuteScalar());
            if (bal > 0) bal = 1; else bal = 0;
            //вставляем результат
            f = string.Format("INSERT INTO `testing` ( `id_login`, " +
                "`id_vopros`, `otvet`,`bal`, `datatime`, `Id_test`)" +
                " VALUES ('{0}', '{1}', '{2}','{3}','{4}', '{5}');",
                polzovatel.ID, num, otvet, bal, date, polzovatel.testNum);
            command = new MySqlCommand(f, connection);
            command.ExecuteNonQuery();
            connection.Close();
            //вставляем 6 вопрос
            otvet = ""; num = vopros_test[5];
            if (rad16.IsChecked == true) { otvet = rad16.Content.ToString(); }
            if (rad26.IsChecked == true) { otvet = rad26.Content.ToString(); }
            if (rad36.IsChecked == true) { otvet = rad36.Content.ToString(); }
            if (rad46.IsChecked == true) { otvet = rad46.Content.ToString(); }
            //запрос совопдает ли отвте с правельный овтетом
            ansvertrue = string.Format("SELECT vopros.id FROM `vopros` " +
               "where vopros.id = '{0}' and vopros.ansvertrue = '{1}'",
               num, otvet);
            connection.Open();
            command1 = new MySqlCommand(ansvertrue, connection);
            bal = Convert.ToInt32(command1.ExecuteScalar());
            if (bal > 0) bal = 1; else bal = 0;
            //вставляем результат
            f = string.Format("INSERT INTO `testing` ( `id_login`, " +
                "`id_vopros`, `otvet`,`bal`, `datatime`, `Id_test`)" +
                " VALUES ('{0}', '{1}', '{2}','{3}','{4}', '{5}');",
                polzovatel.ID, num, otvet, bal, date, polzovatel.testNum);
            command = new MySqlCommand(f, connection);
            command.ExecuteNonQuery();
            connection.Close();
            //вставляем 7 вопрос
            otvet = ""; num = vopros_test[6];
            if (rad17.IsChecked == true) { otvet = rad17.Content.ToString(); }
            if (rad27.IsChecked == true) { otvet = rad27.Content.ToString(); }
            if (rad37.IsChecked == true) { otvet = rad37.Content.ToString(); }
            if (rad47.IsChecked == true) { otvet = rad47.Content.ToString(); }
            //запрос совопдает ли отвте с правельный овтетом
            ansvertrue = string.Format("SELECT vopros.id FROM `vopros` " +
               "where vopros.id = '{0}' and vopros.ansvertrue = '{1}'",
               num, otvet);
            connection.Open();
            command1 = new MySqlCommand(ansvertrue, connection);
            bal = Convert.ToInt32(command1.ExecuteScalar());
            if (bal > 0) bal = 1; else bal = 0;
            //вставляем результат
            f = string.Format("INSERT INTO `testing` ( `id_login`, " +
                "`id_vopros`, `otvet`,`bal`, `datatime`, `Id_test`)" +
                " VALUES ('{0}', '{1}', '{2}','{3}','{4}', '{5}');",
                polzovatel.ID, num, otvet, bal, date, polzovatel.testNum);
            command = new MySqlCommand(f, connection);
            command.ExecuteNonQuery();
            connection.Close();
            //вставляем 8 вопрос
            otvet = ""; num = vopros_test[7];
            if (rad18.IsChecked == true) { otvet = rad18.Content.ToString(); }
            if (rad28.IsChecked == true) { otvet = rad28.Content.ToString(); }
            if (rad38.IsChecked == true) { otvet = rad38.Content.ToString(); }
            if (rad48.IsChecked == true) { otvet = rad48.Content.ToString(); }
            //запрос совопдает ли отвте с правельный овтетом
            ansvertrue = string.Format("SELECT vopros.id FROM `vopros` " +
               "where vopros.id = '{0}' and vopros.ansvertrue = '{1}'",
               num, otvet);
            connection.Open();
            command1 = new MySqlCommand(ansvertrue, connection);
            bal = Convert.ToInt32(command1.ExecuteScalar());
            if (bal > 0) bal = 1; else bal = 0;
            //вставляем результат
            f = string.Format("INSERT INTO `testing` ( `id_login`, " +
                "`id_vopros`, `otvet`,`bal`, `datatime`, `Id_test`)" +
                " VALUES ('{0}', '{1}', '{2}','{3}','{4}', '{5}');",
                polzovatel.ID, num, otvet, bal, date, polzovatel.testNum);
            command = new MySqlCommand(f, connection);
            command.ExecuteNonQuery();
            connection.Close();
            //вставляем 9 вопрос
            otvet = ""; num = vopros_test[8];
            if (rad19.IsChecked == true) { otvet = rad19.Content.ToString(); }
            if (rad29.IsChecked == true) { otvet = rad29.Content.ToString(); }
            if (rad39.IsChecked == true) { otvet = rad39.Content.ToString(); }
            if (rad49.IsChecked == true) { otvet = rad49.Content.ToString(); }
            //запрос совопдает ли отвте с правельный овтетом
            ansvertrue = string.Format("SELECT vopros.id FROM `vopros` " +
               "where vopros.id = '{0}' and vopros.ansvertrue = '{1}'",
               num, otvet);
            connection.Open();
            command1 = new MySqlCommand(ansvertrue, connection);
            bal = Convert.ToInt32(command1.ExecuteScalar());
            if (bal > 0) bal = 1; else bal = 0;
            //вставляем результат
            f = string.Format("INSERT INTO `testing` ( `id_login`, " +
                "`id_vopros`, `otvet`,`bal`, `datatime`, `Id_test`)" +
                " VALUES ('{0}', '{1}', '{2}','{3}','{4}', '{5}');",
                polzovatel.ID, num, otvet, bal, date, polzovatel.testNum);
            command = new MySqlCommand(f, connection);
            command.ExecuteNonQuery();
            connection.Close();
            //вставляем 10 вопрос
            otvet = ""; num = vopros_test[9];
            if (rad110.IsChecked == true) { otvet = rad110.Content.ToString(); }
            if (rad210.IsChecked == true) { otvet = rad210.Content.ToString(); }
            if (rad310.IsChecked == true) { otvet = rad310.Content.ToString(); }
            if (rad410.IsChecked == true) { otvet = rad410.Content.ToString(); }
            //запрос совопдает ли отвте с правельный овтетом
            ansvertrue = string.Format("SELECT vopros.id FROM `vopros` " +
               "where vopros.id = '{0}' and vopros.ansvertrue = '{1}'",
               num, otvet);
            connection.Open();
            command1 = new MySqlCommand(ansvertrue, connection);
            bal = Convert.ToInt32(command1.ExecuteScalar());
            if (bal > 0) bal = 1; else bal = 0;
            //вставляем результат
            f = string.Format("INSERT INTO `testing` ( `id_login`, " +
                "`id_vopros`, `otvet`,`bal`, `datatime`, `Id_test`)" +
                " VALUES ('{0}', '{1}', '{2}','{3}','{4}', '{5}');",
                polzovatel.ID, num, otvet, bal, date, polzovatel.testNum);
            command = new MySqlCommand(f, connection);
            command.ExecuteNonQuery();
            connection.Close();
            //вставляем 11 вопрос
            otvet = ""; num = vopros_test[10];
            if (rad111.IsChecked == true) { otvet = rad111.Content.ToString(); }
            if (rad211.IsChecked == true) { otvet = rad211.Content.ToString(); }
            if (rad311.IsChecked == true) { otvet = rad311.Content.ToString(); }
            if (rad411.IsChecked == true) { otvet = rad411.Content.ToString(); }
            //запрос совопдает ли отвте с правельный овтетом
            ansvertrue = string.Format("SELECT vopros.id FROM `vopros` " +
               "where vopros.id = '{0}' and vopros.ansvertrue = '{1}'",
               num, otvet);
            connection.Open();
            command1 = new MySqlCommand(ansvertrue, connection);
            bal = Convert.ToInt32(command1.ExecuteScalar());
            if (bal > 0) bal = 1; else bal = 0;
            //вставляем результат
            f = string.Format("INSERT INTO `testing` ( `id_login`, " +
                "`id_vopros`, `otvet`,`bal`, `datatime`, `Id_test`)" +
                " VALUES ('{0}', '{1}', '{2}','{3}','{4}', '{5}');",
                polzovatel.ID, num, otvet, bal, date, polzovatel.testNum);
            command = new MySqlCommand(f, connection);
            command.ExecuteNonQuery();
            connection.Close();
            //вставляем 12 вопрос
            otvet = ""; num = vopros_test[11];
            if (rad112.IsChecked == true) { otvet = rad112.Content.ToString(); }
            if (rad212.IsChecked == true) { otvet = rad212.Content.ToString(); }
            if (rad312.IsChecked == true) { otvet = rad312.Content.ToString(); }
            if (rad412.IsChecked == true) { otvet = rad412.Content.ToString(); }
            //запрос совопдает ли отвте с правельный овтетом
            ansvertrue = string.Format("SELECT vopros.id FROM `vopros` " +
               "where vopros.id = '{0}' and vopros.ansvertrue = '{1}'",
               num, otvet);
            connection.Open();
            command1 = new MySqlCommand(ansvertrue, connection);
            bal = Convert.ToInt32(command1.ExecuteScalar());
            if (bal > 0) bal = 1; else bal = 0;
            //вставляем результат
            f = string.Format("INSERT INTO `testing` ( `id_login`, " +
                "`id_vopros`, `otvet`,`bal`, `datatime`, `Id_test`)" +
                " VALUES ('{0}', '{1}', '{2}','{3}','{4}', '{5}');",
                polzovatel.ID, num, otvet, bal, date, polzovatel.testNum);
            command = new MySqlCommand(f, connection);
            command.ExecuteNonQuery();
            connection.Close();
            //вставляем 13 вопрос
            otvet = ""; num = vopros_test[12];
            if (rad113.IsChecked == true) { otvet = rad113.Content.ToString(); }
            if (rad213.IsChecked == true) { otvet = rad213.Content.ToString(); }
            if (rad313.IsChecked == true) { otvet = rad313.Content.ToString(); }
            if (rad413.IsChecked == true) { otvet = rad413.Content.ToString(); }
            //запрос совопдает ли отвте с правельный овтетом
            ansvertrue = string.Format("SELECT vopros.id FROM `vopros` " +
               "where vopros.id = '{0}' and vopros.ansvertrue = '{1}'",
               num, otvet);
            connection.Open();
            command1 = new MySqlCommand(ansvertrue, connection);
            bal = Convert.ToInt32(command1.ExecuteScalar());
            if (bal > 0) bal = 1; else bal = 0;
            //вставляем результат
            f = string.Format("INSERT INTO `testing` ( `id_login`, " +
                "`id_vopros`, `otvet`,`bal`, `datatime`, `Id_test`)" +
                " VALUES ('{0}', '{1}', '{2}','{3}','{4}', '{5}');",
                polzovatel.ID, num, otvet, bal, date, polzovatel.testNum);
            command = new MySqlCommand(f, connection);
            command.ExecuteNonQuery();
            connection.Close();
            //вставляем 14 вопрос
            otvet = ""; num = vopros_test[13];
            if (rad114.IsChecked == true) { otvet = rad114.Content.ToString(); }
            if (rad214.IsChecked == true) { otvet = rad214.Content.ToString(); }
            if (rad314.IsChecked == true) { otvet = rad314.Content.ToString(); }
            if (rad414.IsChecked == true) { otvet = rad414.Content.ToString(); }
            //запрос совопдает ли отвте с правельный овтетом
            ansvertrue = string.Format("SELECT vopros.id FROM `vopros` " +
               "where vopros.id = '{0}' and vopros.ansvertrue = '{1}'",
               num, otvet);
            connection.Open();
            command1 = new MySqlCommand(ansvertrue, connection);
            bal = Convert.ToInt32(command1.ExecuteScalar());
            if (bal > 0) bal = 1; else bal = 0;
            //вставляем результат
            f = string.Format("INSERT INTO `testing` ( `id_login`, " +
                "`id_vopros`, `otvet`,`bal`, `datatime`, `Id_test`)" +
                " VALUES ('{0}', '{1}', '{2}','{3}','{4}', '{5}');",
                polzovatel.ID, num, otvet, bal, date, polzovatel.testNum);
            command = new MySqlCommand(f, connection);
            command.ExecuteNonQuery();
            connection.Close();
            //вставляем 15 вопрос
            otvet = ""; num = vopros_test[14];
            if (rad115.IsChecked == true) { otvet = rad115.Content.ToString(); }
            if (rad215.IsChecked == true) { otvet = rad215.Content.ToString(); }
            if (rad315.IsChecked == true) { otvet = rad315.Content.ToString(); }
            if (rad415.IsChecked == true) { otvet = rad415.Content.ToString(); }
            //запрос совопдает ли отвте с правельный овтетом
            ansvertrue = string.Format("SELECT vopros.id FROM `vopros` " +
               "where vopros.id = '{0}' and vopros.ansvertrue = '{1}'",
               num, otvet);
            connection.Open();
            command1 = new MySqlCommand(ansvertrue, connection);
            bal = Convert.ToInt32(command1.ExecuteScalar());
            if (bal > 0) bal = 1; else bal = 0;
            //вставляем результат
            f = string.Format("INSERT INTO `testing` ( `id_login`, " +
                "`id_vopros`, `otvet`,`bal`, `datatime`, `Id_test`)" +
                " VALUES ('{0}', '{1}', '{2}','{3}','{4}', '{5}');",
                polzovatel.ID, num, otvet, bal, date, polzovatel.testNum);
            command = new MySqlCommand(f, connection);
            command.ExecuteNonQuery();
            connection.Close();
            timer.Stop();
            timer2.Stop();
            Test_list sotrudnic = new Test_list();
            sotrudnic.Show();
            this.Hide();
        }

        private void dtTicker2(object sender, EventArgs e)
        {
            //пробежка если не успел ответить
            if (i < 15)
            {
                try
                {
                    rezultat();
                    i = 16;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return;
                }
            }
            else
            {
                timer.Stop();
                timer2.Stop();
                Test_list sotrudnic = new Test_list();
                sotrudnic.Show();
                this.Hide();
            }
        }

        private void perehot()
        {
            if (voprosnum == 2)
                list2.Visibility = Visibility.Visible;
            if (voprosnum == 3)
                list3.Visibility = Visibility.Visible;
            if (voprosnum == 4)
                list4.Visibility = Visibility.Visible;
            if (voprosnum == 5)
                list5.Visibility = Visibility.Visible;
            if (voprosnum == 6)
                list6.Visibility = Visibility.Visible;
            if (voprosnum == 7)
                list7.Visibility = Visibility.Visible;
            if (voprosnum == 8)
                list8.Visibility = Visibility.Visible;
            if (voprosnum == 9)
                list9.Visibility = Visibility.Visible;
            if (voprosnum == 10)
                list10.Visibility = Visibility.Visible;
            if (voprosnum == 11)
                list11.Visibility = Visibility.Visible;
            if (voprosnum == 12)
                list12.Visibility = Visibility.Visible;
            if (voprosnum == 13)
                list13.Visibility = Visibility.Visible;
            if (voprosnum == 14)
                list14.Visibility = Visibility.Visible;
            if (voprosnum == 15)
            {
                list15.Visibility = Visibility.Visible;
                button2.Content = "Завершить тест";
            }
            else
            {
                button2.Content = "Далее";
            }
        }
        public int[] vopros_test = new int[15];
        public int[] color = new int[15];
        //вопросы
        private void random_mas()
        {
            try
            {

                connection.Open();
                string count = "select count(*) from `vopros`";
                MySqlCommand command = new MySqlCommand(count, connection);
                int r = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();
                for (int i = 0; i < 15; i++)
                {
                    color[i] = i + 1;
                    vopros_test[i] = 0;
                }
                int rad = 0;
                for (int i = 0; i < 15; i++)
                {
                    for (; ; )
                    {
                        bool good = true;
                        rad = 1 + random.Next(0, r);
                        for (int j = 0; j < 15; j++)
                        {
                            if (rad == vopros_test[j]) { good = false; break; }
                        }
                        if (good) break;
                    }
                    vopros_test[i] = rad; // присваивание рандомного числа элементу массива
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }
        Random random = new Random();
        MySqlConnection connection = new MySqlConnection(pols.con);
        int i = 1;

        int num = 0;

        DispatcherTimer timer = new DispatcherTimer();
        DispatcherTimer timer2 = new DispatcherTimer();
        int secong = 0, minutes = 0;
        //Массив вопросв (его номера)
        string min, sec;
        //время
        private void dtTicker(object sender, EventArgs e)
        {
            //время выполнения теста
            if (secong == 0 & minutes == 0)
            {
                timer.Stop();
                //если не успел ответить то осталные вопросы ответ пустота
                timer2.Interval = TimeSpan.FromMilliseconds(10);
                timer2.Tick += dtTicker2;
                timer2.Start();
            }
            if (secong == 0)
            {
                secong = 60;
                minutes -= 1;
            }
            if (minutes == -1)
            {
                minutes = 0;
                secong = 0;
                min = "0"; sec = "0";
            }
            secong -= 1;

            if (secong < 10)
            {
                sec = "0" + Convert.ToString(secong);

            }
            else
            {
                sec = Convert.ToString(secong);

            }
            if (minutes < 10)
            {
                min = "0" + Convert.ToString(minutes);

            }
            else
            {
                min = Convert.ToString(minutes);

            }
            Time_test.Content = min + ":" + sec;
        }
        //спавн вопросов
        private void vopros()
        {
            //навигация вопрсов
            try
            {//пробежка 15 раз 1 проход все вопросы
                for (int i = 1; i < 16; i++)
                {
                    num = vopros_test[i - 1];
                    connection.Open();
                    string vopros = string.Format("select `vopros`.question from  `vopros`" +
                        "where id={0}", num);
                    MySqlCommand command1 = new MySqlCommand(vopros, connection);
                    //выводим из бд 15 вопросов
                    if (i == 1)
                    {
                        label2v1.Text = Convert.ToString(command1.ExecuteScalar());
                    }
                    if (i == 2)
                    {
                        label2v2.Text = Convert.ToString(command1.ExecuteScalar());
                    }
                    if (i == 3)
                    {
                        label2v3.Text = Convert.ToString(command1.ExecuteScalar());
                    }
                    if (i == 4)
                    {
                        label2v4.Text = Convert.ToString(command1.ExecuteScalar());
                    }
                    if (i == 5)
                    {
                        label2v5.Text = Convert.ToString(command1.ExecuteScalar());
                    }
                    if (i == 6)
                    {
                        label2v6.Text = Convert.ToString(command1.ExecuteScalar());
                    }
                    if (i == 7)
                    {
                        label2v7.Text = Convert.ToString(command1.ExecuteScalar());
                    }
                    if (i == 8)
                    {
                        label2v8.Text = Convert.ToString(command1.ExecuteScalar());
                    }
                    if (i == 9)
                    {
                        label2v9.Text = Convert.ToString(command1.ExecuteScalar());
                    }
                    if (i == 10)
                    {
                        label2v10.Text = Convert.ToString(command1.ExecuteScalar());
                    }
                    if (i == 11)
                    {
                        label2v11.Text = Convert.ToString(command1.ExecuteScalar());
                    }
                    if (i == 12)
                    {
                        label2v12.Text = Convert.ToString(command1.ExecuteScalar());
                    }
                    if (i == 13)
                    {
                        label2v13.Text = Convert.ToString(command1.ExecuteScalar());
                    }
                    if (i == 14)
                    {
                        label2v14.Text = Convert.ToString(command1.ExecuteScalar());
                    }
                    if (i == 15)
                    {
                        label2v15.Text = Convert.ToString(command1.ExecuteScalar());
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        private void one_otvet()
        {
            //навигация ответа
            try
            {
                for (int i = 1; i < 16; i++)
                {
                    num = vopros_test[i - 1];
                    connection.Open();
                    string otvet1 = string.Format("SELECT `vopros`.ansver1 FROM `vopros`" +
                        " WHERE id={0}", num);
                    MySqlCommand my = new MySqlCommand(otvet1, connection);
                    //вывод из бд 15 ответов (ответ1)
                    if (i == 1)
                        rad11.Content = my.ExecuteScalar().ToString();
                    if (i == 2)
                        rad12.Content = my.ExecuteScalar().ToString();
                    if (i == 3)
                        rad13.Content = my.ExecuteScalar().ToString();
                    if (i == 4)
                        rad14.Content = my.ExecuteScalar().ToString();
                    if (i == 5)
                        rad15.Content = my.ExecuteScalar().ToString();
                    if (i == 6)
                        rad16.Content = my.ExecuteScalar().ToString();
                    if (i == 7)
                        rad17.Content = my.ExecuteScalar().ToString();
                    if (i == 8)
                        rad18.Content = my.ExecuteScalar().ToString();
                    if (i == 9)
                        rad19.Content = my.ExecuteScalar().ToString();
                    if (i == 10)
                        rad110.Content = my.ExecuteScalar().ToString();
                    if (i == 11)
                        rad111.Content = my.ExecuteScalar().ToString();
                    if (i == 12)
                        rad112.Content = my.ExecuteScalar().ToString();
                    if (i == 13)
                        rad113.Content = my.ExecuteScalar().ToString();
                    if (i == 14)
                        rad114.Content = my.ExecuteScalar().ToString();
                    if (i == 15)
                        rad115.Content = my.ExecuteScalar().ToString();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }
        private void tho_otvet()
        { //навигация ответа
            try
            {
                for (int i = 1; i < 16; i++)
                {
                    num = vopros_test[i - 1];
                    connection.Open();
                    string otvet1 = string.Format("SELECT `vopros`.ansver2 FROM `vopros`" +
                        " WHERE id={0}", num);
                    MySqlCommand my = new MySqlCommand(otvet1, connection);
                    //вывод из бд 15 ответов (ответ3)
                    if (i == 1)
                        rad21.Content = my.ExecuteScalar().ToString();
                    if (i == 2)
                        rad22.Content = my.ExecuteScalar().ToString();
                    if (i == 3)
                        rad23.Content = my.ExecuteScalar().ToString();
                    if (i == 4)
                        rad24.Content = my.ExecuteScalar().ToString();
                    if (i == 5)
                        rad25.Content = my.ExecuteScalar().ToString();
                    if (i == 6)
                        rad26.Content = my.ExecuteScalar().ToString();
                    if (i == 7)
                        rad27.Content = my.ExecuteScalar().ToString();
                    if (i == 8)
                        rad28.Content = my.ExecuteScalar().ToString();
                    if (i == 9)
                        rad29.Content = my.ExecuteScalar().ToString();
                    if (i == 10)
                        rad210.Content = my.ExecuteScalar().ToString();
                    if (i == 11)
                        rad211.Content = my.ExecuteScalar().ToString();
                    if (i == 12)
                        rad212.Content = my.ExecuteScalar().ToString();
                    if (i == 13)
                        rad213.Content = my.ExecuteScalar().ToString();
                    if (i == 14)
                        rad214.Content = my.ExecuteScalar().ToString();
                    if (i == 15)
                        rad215.Content = my.ExecuteScalar().ToString();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }
        private void the_otvet()
        { //навигация ответа
            try
            {
                for (int i = 1; i < 16; i++)
                {
                    num = vopros_test[i - 1];
                    connection.Open();
                    string otvet1 = string.Format("SELECT `vopros`.ansver3 FROM `vopros`" +
                        " WHERE id={0}", num);
                    MySqlCommand my = new MySqlCommand(otvet1, connection);
                    //вывод из бд 15 ответов (ответ1)
                    if (i == 1)
                        rad31.Content = my.ExecuteScalar().ToString();
                    if (i == 2)
                        rad32.Content = my.ExecuteScalar().ToString();
                    if (i == 3)
                        rad33.Content = my.ExecuteScalar().ToString();
                    if (i == 4)
                        rad34.Content = my.ExecuteScalar().ToString();
                    if (i == 5)
                        rad35.Content = my.ExecuteScalar().ToString();
                    if (i == 6)
                        rad36.Content = my.ExecuteScalar().ToString();
                    if (i == 7)
                        rad37.Content = my.ExecuteScalar().ToString();
                    if (i == 8)
                        rad38.Content = my.ExecuteScalar().ToString();
                    if (i == 9)
                        rad39.Content = my.ExecuteScalar().ToString();
                    if (i == 10)
                        rad310.Content = my.ExecuteScalar().ToString();
                    if (i == 11)
                        rad311.Content = my.ExecuteScalar().ToString();
                    if (i == 12)
                        rad312.Content = my.ExecuteScalar().ToString();
                    if (i == 13)
                        rad313.Content = my.ExecuteScalar().ToString();
                    if (i == 14)
                        rad314.Content = my.ExecuteScalar().ToString();
                    if (i == 15)
                        rad315.Content = my.ExecuteScalar().ToString();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }
        private void for_otvet()
        { //навигация ответа
            try
            {
                for (int i = 1; i < 16; i++)
                {
                    num = vopros_test[i - 1];
                    connection.Open();
                    string otvet1 = string.Format("SELECT `vopros`.ansver4 FROM `vopros`" +
                        " WHERE id={0}", num);
                    MySqlCommand my = new MySqlCommand(otvet1, connection);
                    //вывод из бд 15 ответов (ответ1)
                    if (i == 1)
                        rad41.Content = my.ExecuteScalar().ToString();
                    if (i == 2)
                        rad42.Content = my.ExecuteScalar().ToString();
                    if (i == 3)
                        rad43.Content = my.ExecuteScalar().ToString();
                    if (i == 4)
                        rad44.Content = my.ExecuteScalar().ToString();
                    if (i == 5)
                        rad45.Content = my.ExecuteScalar().ToString();
                    if (i == 6)
                        rad46.Content = my.ExecuteScalar().ToString();
                    if (i == 7)
                        rad47.Content = my.ExecuteScalar().ToString();
                    if (i == 8)
                        rad48.Content = my.ExecuteScalar().ToString();
                    if (i == 9)
                        rad49.Content = my.ExecuteScalar().ToString();
                    if (i == 10)
                        rad410.Content = my.ExecuteScalar().ToString();
                    if (i == 11)
                        rad411.Content = my.ExecuteScalar().ToString();
                    if (i == 12)
                        rad412.Content = my.ExecuteScalar().ToString();
                    if (i == 13)
                        rad413.Content = my.ExecuteScalar().ToString();
                    if (i == 14)
                        rad414.Content = my.ExecuteScalar().ToString();
                    if (i == 15)
                        rad415.Content = my.ExecuteScalar().ToString();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        private void list1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void datetimestest()
        {
            //время выполнения теста бирем из datename test)
            try
            {
                connection.Open();
                string times = string.Format("SELECT test_name.Time" +
                    " FROM test_name where test_name.ID='{0}'", polzovatel.testNum);
                MySqlCommand command = new MySqlCommand(times, connection);
                minutes = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();
                timer.Interval = TimeSpan.FromMilliseconds(1000);
                timer.Tick += dtTicker;
                timer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

    }
}
