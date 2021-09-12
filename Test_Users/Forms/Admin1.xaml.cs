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
using Test_Users.Pages;
namespace Test_Users.Forms
{
    /// <summary>
    /// Логика взаимодействия для Admin1.xaml
    /// </summary>
    public partial class Admin1 : Window
    {
        public Admin1()
        {
            InitializeComponent();
        }

        private void butom1_Click(object sender, RoutedEventArgs e)
        {
            Paget._pages = 2;
            dateTest dateTest = new dateTest();
            dateTest.Show();
            this.Hide();
        }

        private void butom3_Click(object sender, RoutedEventArgs e)
        {
            new_sotrudnic new_sotrudnic = new new_sotrudnic();
            new_sotrudnic.Show();
            this.Hide();
        }

        private void butom4_Click(object sender, RoutedEventArgs e)
        {
            Avtoriz avtoriz = new Avtoriz();
            avtoriz.Show();
            this.Hide();
        }

        private void butom2_Click(object sender, RoutedEventArgs e)
        {
            Paget._pages = 0;
            Rezultat rezultat = new Rezultat();
            rezultat.Show();
            this.Hide();
        }

        private void butom_Click(object sender, RoutedEventArgs e)
        {
            Paget._pages = 0;
            Test_Setting Test_Setting = new Test_Setting();
            Test_Setting.Show();
            this.Hide();
        }
    }
}
