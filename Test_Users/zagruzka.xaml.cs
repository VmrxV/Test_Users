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
using System.Windows.Threading;
using Test_Users.Forms;
namespace Test_Users
{
    /// <summary>
    /// Логика взаимодействия для zagruzka.xaml
    /// </summary>
    public partial class zagruzka : Window
    {
        public zagruzka()
        {
            InitializeComponent();
        }
        private void Window_Closed(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        DispatcherTimer timer = new DispatcherTimer();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }
        private void Load()
        {
            timer.Interval = TimeSpan.FromMilliseconds(10);
            timer.Tick += dtTicker;
            timer.Start();
        }
        private int incremetn = 0;
        private void dtTicker(object sender, EventArgs e)
        {
            incremetn += 1;
            slider.Value = incremetn;
            if (incremetn == 101)
            {
                Avtoriz menu = new Avtoriz();
                menu.Show();
                this.Hide();
            }
        }
        int h = 1;
        private void Button1_Click(object sender, RoutedEventArgs e)
        {

            if (h / 2 == 0)
            {
                h++;
                Button1.Content = "STOP"; timer.Start();
                Load();
            }
            else
            {
                h--;
                Button1.Content = "START";
                timer.Stop();
            }
        }
        }
}
