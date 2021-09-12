using MySql.Data.MySqlClient;
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
using System.Data;
using Test_Users.Forms;
using Test_Users.Pages;
namespace Test_Users.Pages
{
    /// <summary>
    /// Логика взаимодействия для Test_list.xaml
    /// </summary>
    public partial class Test_list : Window
    {
        DataTable table1 = new DataTable();
        public Test_list()
        {
            InitializeComponent();
            BindComboBox(cbImage);
        }
        MySqlConnection connection = new MySqlConnection(pols.con);
        public void BindComboBox(ComboBox cbImage)
        {
            string select = "SELECT `Name` FROM `test_name` ORDER BY `test_name`.`ID` ASC";
            connection.Open();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(select, connection);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "tblZones");
            cbImage.ItemsSource = ds.Tables[0].DefaultView;
            cbImage.DisplayMemberPath = ds.Tables[0].
                Columns["Name"].ToString();
            connection.Close();
        }

        private void butom1_Click(object sender, RoutedEventArgs e)
        {
            if (cbImage.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите тест", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
           polzovatel.testNum = cbImage.SelectedIndex+1;
            TestV vopros = new TestV();
            vopros.Show();
            this.Hide();
        }

        private void bage_Click(object sender, RoutedEventArgs e)
        {
            polzovatel.butadd = 0;
            Avtoriz Avtoriz = new Avtoriz();
            Avtoriz.Show();
            this.Hide();
        }

        private void cbImage_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
