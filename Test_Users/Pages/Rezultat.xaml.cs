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
using System.Data;
using System.IO;
using System.Diagnostics;
using Test_Users.Pages;
using Test_Users.Forms;
using Test_Users.Classes;
using System;

namespace Test_Users.Pages
{
    /// <summary>
    /// Логика взаимодействия для Rezultat.xaml
    /// </summary>
    public partial class Rezultat : Window
    {
        public Rezultat()
        {
            InitializeComponent();
            BindComboBox(cblogin);
            BindComboBox1(cbnametest);
        }
        MySqlConnection connection = new MySqlConnection(pols.con);
        DatePicker _dateStart;
        DataTable table = new DataTable();
        public void BindComboBox(ComboBox cblogin)
        {
            string select = "SELECT `Login` FROM `users` ORDER BY `users`.`ID` ASC";
            connection.Open();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(select, connection);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "tblZones");
            cblogin.ItemsSource = ds.Tables[0].DefaultView;
            cblogin.DisplayMemberPath = ds.Tables[0].
                Columns["Login"].ToString();
            connection.Close();
        }
        public void BindComboBox1(ComboBox cbnametest)
        {
            string select = "SELECT `Name` FROM `test_name` ORDER BY `test_name`.`ID` ASC";
            connection.Open();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(select, connection);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "tblZones");
            cbnametest.ItemsSource = ds.Tables[0].DefaultView;
            cbnametest.DisplayMemberPath = ds.Tables[0].
                Columns["Name"].ToString();
            connection.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Admin1 admin = new Admin1();
            admin.Show();
            this.Hide();
        }
        //запись в таблицу
        public void Data(DataGrid dataGrid)
        {
            connection.Open();
            //вывод результата
            string select1 = "SELECT DISTINCT test_name.Name as Тест,users.Login as " +
                "Пользователь,users.Fill as Имя,testing.datatime as Дата_прохождения," +
                " SUM(testing.bal)as кол_во_балов_из_15 " +
                "FROM test_name, testing, users, vopros" +
                " WHERE test_name.ID = testing.Id_test and testing.id_login = " +
                "users.ID and testing.id_vopros = vopros.id " +
                "GROUP BY  test_name.Name,users.Login,testing.datatime, users.Fill";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(select1, connection);
            table = new DataTable();
            dataAdapter.Fill(table);
            datagrid.ItemsSource = table.DefaultView;
            connection.Close();

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                PrintDG print = new PrintDG();
                print.printDG(datagrid, "Результат на " +DateTime.Now.Date);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                try
                {
                    Data(datagrid);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return;
                }
            }
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            //очистка
            _dateStart=null;
            dtPickerStart.SelectedDate = null;
            cblogin.Text = "";
            cbnametest.Text = "";
            connection.Open();
            string select1 = "SELECT DISTINCT test_name.Name as Тест,users.Login as " +
                "Пользователь,users.Fill as Имя,testing.datatime as Дата_прохождения, SUM(testing.bal)as кол_во_балов_из_15 " +
               "FROM test_name, testing, users, vopros" +
               " WHERE test_name.ID = testing.Id_test and testing.id_login = " +
               "users.ID and testing.id_vopros = vopros.id " +
               "GROUP BY  test_name.Name,users.Login,testing.datatime,users.Fill";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(select1, connection);
             table = new DataTable();
            dataAdapter.Fill(table);
            datagrid.ItemsSource = table.DefaultView;
            connection.Close();
        }
        private void cbnametest_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowData();
        }

        private void cblogin_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowData();
        }
        
        private void dtPicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DatePicker item = (DatePicker)sender;
            if (item.Name == "dtPickerStart")
            {
                _dateStart = item;
                
            }
            ShowData();
        }
        private void ShowData()
        {
            try
            {
                int nametest = 0; 
                int namelogin = 0;
                string datetimetest = "";
                if (cbnametest.SelectedValue != null)
                {
                    //запрос на првоерку
                    nametest = cbnametest.SelectedIndex + 1;
                }
                if (cblogin.SelectedValue != null)
                {
                    //запрос на првоерку
                    namelogin = cbnametest.SelectedIndex + 1;
                }
                if (_dateStart != null)
                {
                    //запрос на проверку
                    datetimetest =Convert.ToString(dtPickerStart.Text);
                }
                if (nametest > 0 & namelogin > 0 & datetimetest!="")
                {
                    connection.Open();
                    string select = string.Format("SELECT DISTINCT test_name.Name " +
                        "as Тест,users.Login as Пользователь,users.Fill as Имя, testing.datatime " +
                        "as Дата_прохождения, SUM(testing.bal)as кол_во_балов_из_15" +
                        " FROM test_name, testing, users, vopros " +
                        "WHERE testing.Id_test ='{0}' and users.ID='{1}' and" +
                        " testing.id_vopros = vopros.id and testing.id_login=users.ID " +
                        "and testing.Id_test=test_name.ID and testing.datatime='{2}'" +
                        "GROUP BY test_name.Name,users.Login,testing.datatime,users.Fill", 
                        nametest, namelogin, datetimetest);
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(select, connection);
                    DataTable table = new DataTable();
                    dataAdapter.Fill(table);
                    datagrid.ItemsSource = table.DefaultView;
                    connection.Close();
                    return;
                }
                if (nametest > 0 & namelogin > 0)
                {
                    connection.Open();
                    string select = string.Format("SELECT DISTINCT test_name.Name " +
                        "as Тест,users.Login as Пользователь,users.Fill as Имя, testing.datatime " +
                        "as Дата_прохождения, SUM(testing.bal)as кол_во_балов_из_15" +
                        " FROM test_name, testing, users, vopros " +
                        "WHERE testing.Id_test ='{0}' and users.ID='{1}' and" +
                        " testing.id_vopros = vopros.id and testing.id_login=users.ID " +
                        "and testing.Id_test=test_name.ID" +
                        "GROUP BY test_name.Name,users.Login,testing.datatime,users.Fill",
                        nametest, namelogin);
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(select, connection);
                    DataTable table = new DataTable();
                    dataAdapter.Fill(table);
                    datagrid.ItemsSource = table.DefaultView;
                    connection.Close();
                    return;
                }
                if (namelogin > 0 & datetimetest != "")
                {
                    connection.Open();
                    string select = string.Format("SELECT DISTINCT test_name.Name " +
                         "as Тест,users.Login as Пользователь,users.Fill as Имя, testing.datatime " +
                         "as Дата_прохождения, SUM(testing.bal)as кол_во_балов_из_15" +
                         " FROM test_name, testing, users, vopros " +
                         "WHERE users.ID='{0}' and" +
                         " testing.id_vopros = vopros.id and testing.id_login=users.ID " +
                         "and testing.Id_test=test_name.ID and testing.datatime='{2}'" +
                         "GROUP BY test_name.Name,users.Login,testing.datatime,users.Fill",
                          namelogin, datetimetest);
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(select, connection);
                    DataTable table = new DataTable();
                    dataAdapter.Fill(table);
                    datagrid.ItemsSource = table.DefaultView;
                    connection.Close();
                    return;
                }
                if (nametest > 0)
                {
                    connection.Open();
                    string select = string.Format("SELECT DISTINCT test_name.Name " +
                         "as Тест,users.Login as Пользователь,users.Fill as Имя, testing.datatime " +
                         "as Дата_прохождения, SUM(testing.bal)as кол_во_балов_из_15" +
                         " FROM test_name, testing, users, vopros " +
                         "WHERE testing.Id_test ='{0}' and" +
                         " testing.id_vopros = vopros.id and testing.id_login=users.ID " +
                         "and testing.Id_test=test_name.ID " +
                         "GROUP BY test_name.Name,users.Login,testing.datatime,users.Fill",
                         nametest);
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(select, connection);
                    DataTable table = new DataTable();
                    dataAdapter.Fill(table);
                    datagrid.ItemsSource = table.DefaultView;
                    connection.Close();
                }
                if ( namelogin > 0)
                {
                    connection.Open();
                    string select = string.Format("SELECT DISTINCT test_name.Name " +
                        "as Тест,users.Login as Пользователь,users.Fill as Имя, testing.datatime " +
                        "as Дата_прохождения, SUM(testing.bal)as кол_во_балов_из_15" +
                        " FROM test_name, testing, users, vopros " +
                        "WHERE users.ID='{1}' and" +
                        " testing.id_vopros = vopros.id and testing.id_login=users.ID " +
                        "and testing.Id_test=test_name.ID " +
                        "GROUP BY test_name.Name,users.Login,testing.datatime,users.Fill",
                         namelogin);
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(select, connection);
                    DataTable table = new DataTable();
                    dataAdapter.Fill(table);
                    datagrid.ItemsSource = table.DefaultView;
                    connection.Close();
                }
                
                if ( datetimetest != "")
                {
                    connection.Open();
                    string select = string.Format("SELECT DISTINCT test_name.Name " +
                        "as Тест,users.Login as Пользователь,users.Fill as Имя, testing.datatime " +
                        "as Дата_прохождения, SUM(testing.bal)as кол_во_балов_из_15" +
                        " FROM test_name, testing, users, vopros " +
                        "WHERE testing.id_vopros = vopros.id and testing.id_login=users.ID " +
                        "and testing.Id_test=test_name.ID and testing.datatime='{0}'" +
                        "GROUP BY test_name.Name,users.Login,testing.datatime,users.Fill",
                       datetimetest);
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(select, connection);
                    DataTable table = new DataTable();
                    dataAdapter.Fill(table);
                    datagrid.ItemsSource = table.DefaultView;
                    connection.Close();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }
        //обработка клика
        private void Row_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            //клик
            if (datagrid.SelectedIndex >= 0)
            {
                try
                {
                    polzovatel.testName = table.DefaultView[datagrid.SelectedIndex]
                    ["Тест"].ToString();//выделяемая строка маркировка
                    polzovatel.testLogin = table.DefaultView[datagrid.SelectedIndex]
                    ["Пользователь"].ToString();//выделяемая строка маркировка
                    polzovatel.testdate = table.DefaultView[datagrid.SelectedIndex]
                    ["Дата_прохождения"].ToString();//выделяемая строка маркировка
                    Rezultat_user Rezultat_user = new Rezultat_user();
                    Rezultat_user.Show();
                    this.Hide();
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
