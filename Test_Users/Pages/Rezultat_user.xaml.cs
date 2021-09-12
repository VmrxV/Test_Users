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
    /// Логика взаимодействия для Rezultat_user.xaml
    /// </summary>
    public partial class Rezultat_user : Window
    {
        public Rezultat_user()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection(pols.con);
        DataTable table = new DataTable();
        public void Data(DataGrid dataGrid)
        {
            try
            {
                connection.Open();
                string select = string.Format("SELECT test_name.Name,users.Login,users.Fill, vopros.question," +
                "testing.otvet,vopros.ansvertrue,testing.datatime FROM users," +
                "test_name,testing,vopros WHERE test_name.Name='{0}'" +
                " and users.Login='{1}' and vopros.id=testing.id_vopros and " +
                "testing.datatime='{2}' and testing.Id_test=test_name.ID and testing.id_login=users.ID" +
                "", polzovatel.testName, polzovatel.testLogin, polzovatel.testdate);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(select, connection);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                datagrid.ItemsSource = table.DefaultView;
                connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                return;
            }
        }
        private void othot_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                PrintDG print = new PrintDG();
                print.printDG(datagrid, "Результат на " + DateTime.Now.Date);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        private void bage_Click(object sender, RoutedEventArgs e)
        {
            Rezultat Rezultat = new Rezultat();
            Rezultat.Show();
            this.Hide();
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
    }
}
