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
using Test_Users.Forms;
using Test_Users.Classes;
using MySql.Data.MySqlClient;
using Microsoft.Win32;
using System.IO;

namespace Test_Users.Pages
{
    /// <summary>
    /// Логика взаимодействия для change_test.xaml
    /// </summary>
    public partial class change_test : Window
    {
        public change_test()
        {
            InitializeComponent();
            if (polzovatel.h > 0)
            {
                label1.Text = "Изменения вопроса №" +
 polzovatel.num.ToString();
                textbox1.Text = polzovatel.vopros;
                textbox2.Text = polzovatel.otvet1;
                textbox3.Text = polzovatel.otvet2;
                textbox4.Text = polzovatel.otvet3;
                textbox5.Text = polzovatel.otvet4;
                if (polzovatel.Pravotvet == polzovatel.otvet1)
                {
                    comboBox.Text = "Ответ 1";
                }
                if (polzovatel.Pravotvet == polzovatel.otvet2)
                {
                    comboBox.Text = "Ответ 2";
                }
                if (polzovatel.Pravotvet == polzovatel.otvet3)
                {
                    comboBox.Text = "Ответ 3";
                }
                if (polzovatel.Pravotvet == polzovatel.otvet4)
                {
                    comboBox.Text = "Ответ 4";
                }
            }
            else
            {
                MySqlConnection conn = new MySqlConnection(pols.con);
                //соединяемся с бд
                // устанавливаем соединение с БД
                conn.Open();
                string count = "select count(*) from `vopros`";
                MySqlCommand command1 = new MySqlCommand(count, conn);
                int id = Convert.ToInt32(command1.ExecuteScalar());
                id = id + 1;
                label1.Text = "Добавление вопроса № " + id;
                conn.Close();
            }
        }


        private void button3_Click(object sender, RoutedEventArgs e)
        {

            {
                int err = 0;
                if (textbox1.Text == "")
                {
                    err++;
                }
                if (textbox2.Text == "")
                {
                    err++;
                }
                if (textbox3.Text == "")
                {
                    err++;
                }
                if (textbox4.Text == "")
                {
                    err++;
                }
                if (textbox5.Text == "")
                {
                    err++;
                }
                if (comboBox.Text == "")
                {
                    err++;
                }
                if (err > 0)
                {
                    MessageBox.Show("Не все поля заполнены", "Внимание");
                    return;
                }
                if (polzovatel.h == 1)
                {
                    MySqlConnection conn = new MySqlConnection(pols.con);
                    // устанавливаем соединение с БД
                    conn.Open();
                    string combo = comboBox.Text;
                    if (combo == "Ответ 1")
                    {
                        combo = textbox2.Text;
                    }
                    if (combo == "Ответ 2")
                    {
                        combo = textbox3.Text;
                    }
                    if (combo == "Ответ 3")
                    {
                        combo = textbox4.Text;
                    }
                    if (combo == "Ответ 4")
                    {
                        combo = textbox5.Text;
                    }
                    try
                    {
                        string Update = string.Format("UPDATE `vopros` SET `question` = '{0}'," +
                            " `ansver1` = '{1}', `ansver2` = '{2}', `ansver3` = '{3}', `ansver4` = '{4}'," +
                            " `ansvertrue` = '{5}' WHERE `vopros`.`id`={6}"
                            , textbox1.Text, textbox2.Text, textbox3.Text, textbox4.Text, textbox5.Text,
                            combo, polzovatel.num);
                        MySqlCommand command = new MySqlCommand(Update, conn);
                        command.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Вопрос изменен");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        return;
                    }
                }
                else
                {
                    try {
                        MySqlConnection conn = new MySqlConnection(pols.con);
                        //соединяемся с бд
                        // устанавливаем соединение с БД
                        conn.Open();

                        string count = "select count(*) from `vopros`";
                        string login = string.Format("SELECT `vopros`.`question` " +
                            "FROM `vopros`" +
                            "WHERE `vopros`.`question` = '{0}'",
                            textbox2.Text);
                        MySqlCommand command1 = new MySqlCommand(count, conn);
                        MySqlCommand command = new MySqlCommand(login, conn);//выполнем команду
                        string quetion = Convert.ToString(command.ExecuteScalar());//получаем результат
                        int id = Convert.ToInt32(command1.ExecuteScalar());
                        if (quetion != "")
                        {
                            MessageBox.Show("Данный вопрос уже существует");
                            return;
                        }
                        string combo = comboBox.Text;
                        if (combo == "Ответ 1")
                        {
                            combo = textbox2.Text;
                        }
                        if (combo == "Ответ 2")
                        {
                            combo = textbox3.Text;
                        }
                        if (combo == "Ответ 3")
                        {
                            combo = textbox4.Text;
                        }
                        if (combo == "Ответ 4")
                        {
                            combo = textbox5.Text;
                        }
                        //вставка нового вопроса
                        string Update = string.Format("INSERT INTO `vopros`" +
                            "(`id`, `question`, `ansver1`, `ansver2`, `ansver3`, `ansver4`, `ansvertrue`)" +
                            " VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", id + 1,
                            textbox1.Text, textbox2.Text, textbox3.Text,
                            textbox4.Text, textbox5.Text, combo);
                        //выполение команды
                        MySqlCommand comman = new MySqlCommand(Update, conn);
                        comman.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Вопрос добавлен");
                        //возврат назад
                        dateTest oborud = new dateTest();
                        oborud.Show();
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            dateTest test = new dateTest();
            test.Show();
            this.Hide();
        }
        string _fileName;
        private void btFiles_Click(object sender, RoutedEventArgs e)
        {
            //ипорт из файла в в базу
            ShowFiles();
            try
            {
                MySqlConnection con = new MySqlConnection(pols.con);
                string Files = _fileName;

                using (StreamReader sr_trans = new StreamReader(_fileName, Encoding.Default))
                {
                    //считываем со 2 строки
                    int i = -1;
                    //Правильный ответ
                    string strAnsvertrue="";
                    // ответ 4
                    string strAnsver4 = "";
                    // ответ 3
                    string strAnsver3 = "";
                    // ответ 2
                    string strAnsver2 = "";
                    // ответ 1
                    string strAnsver1 = "";
                    // вопрос
                    string strQuestion = "";
                    // номер вопроса
                    string strID = "";
                    MySqlCommand comman;
                    while (!sr_trans.EndOfStream)
                    {
                        string[] tokens0 = sr_trans.ReadLine().Split(new char[] { ';' });
                        //пока не дойдем до последней строки
                        int h = 0;
                        foreach (string element in tokens0)
                        {
                            if (h == 6)
                            {
                                strAnsvertrue = element;
                                h++;h = -1;i++;
                            }
                            if (h == 5)
                            {
                                strAnsver4 = element;
                                h++;
                            }
                            if (h == 4)
                            {
                                strAnsver3 = element;
                                h++;
                            }
                            if (h == 3)
                            {
                                strAnsver2 = element;
                                h++;
                            }
                            if (h == 2)
                            {
                                strAnsver1 = element;
                                h++;
                            }
                            if (h == 1)
                            {
                                strQuestion = element;
                                h++;
                            }
                            if (h == 0)
                            {
                                strID = element;
                                h++;
                            }
                            if (h == -1) {
                                h = 0;i++;
                            }
                            if (i > 1)
                            {
                                i = 0;
                                con.Open();
                                //Запрос на вставку
                                string Update = string.Format("INSERT INTO `vopros`" +
                           "(`id`, `question`, `ansver1`, `ansver2`, `ansver3`,`ansver4`, `ansvertrue`)" +
                           " VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", strID, strQuestion,
                           strAnsver1, strAnsver2, strAnsver3,strAnsver4, strAnsvertrue);
                                comman = new MySqlCommand(Update, con);
                                comman.ExecuteNonQuery();
                                con.Close();
                            }
                        }
                        }

                    }
                MessageBox.Show("Данные добавлены");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Данные добавлены");
                /*MessageBox.Show(ex.ToString());
                return;*/
            }
            dateTest test = new dateTest();
            test.Show();
            this.Hide();
        }

        private void ShowFiles()
        {
            //Имя файла
            try
            {
                OpenFileDialog fd = new OpenFileDialog();
                fd.DefaultExt = "*.csv";
                fd.Filter = "CSV files (*.csv)|*.csv";
                fd.ShowDialog();
                _fileName = fd.FileName;
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
                if(polzovatel.butadd==1)
                btFiles.Visibility = Visibility.Visible;
                else
                btFiles.Visibility = Visibility.Hidden;
            }
        }
    }
}
