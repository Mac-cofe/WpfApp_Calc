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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp_Calc
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public double a, b, rez;
        public int cod = 0;   // 1 +  2 -  3 *   4 / 
        public bool znak = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txtBox.Content = txtBox.Content + "1";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            txtBox.Content = txtBox.Content + "2";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            txtBox.Content = txtBox.Content + "3";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            txtBox.Content = txtBox.Content + "4";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            txtBox.Content = txtBox.Content + "5";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            txtBox.Content = txtBox.Content + "6";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            txtBox.Content = txtBox.Content + "7";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            txtBox.Content = txtBox.Content + "8";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            txtBox.Content = txtBox.Content + "9";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            txtBox.Content = txtBox.Content + "0";
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)   // добавление разделительной точки
        {
            bool f = false;
            foreach (char d in Convert.ToString(txtBox.Content))
            {
                if (d == '.')
                    f = true;
            }
            if (f == false)
                txtBox.Content = txtBox.Content + ",";
        }


        private void Button_Click_Rezult(object sender, RoutedEventArgs e)  // вычисление и вывод результата
        {
            if (znak == true)
            {
                switch (cod)                                            // 1 +, 2 -, 3 *, 4 /
                {
                    case 1:
                        b = Convert.ToDouble(txtBox.Content);
                        rez = a + b;
                        txtBox.Content = Convert.ToString(rez);
                        break;
                    case 2:
                        b = Convert.ToDouble(txtBox.Content);
                        rez = a - b;
                        txtBox.Content = Convert.ToString(rez);
                        break;
                    case 3:
                        b = Convert.ToDouble(txtBox.Content);
                        rez = a * b;
                        txtBox.Content = Convert.ToString(rez);
                        break;
                    case 4:
                        b = Convert.ToDouble(txtBox.Content);
                        if (b != 0)
                        {
                            rez = a / b;
                            txtBox.Content = Convert.ToString(rez);
                        }
                        else
                            txtBox.Content = "Error";                   // ошибка деления на ноль
                        break;

                    default:
                        break;
                }
            }
            else
            { txtBox.Content = "Данные не введены"; }               // если значения не введены и не выбрана операция

        }

        private void Button_Click_Minus(object sender, RoutedEventArgs e)   // кнопка вычитание
        {
            if (Convert.ToString(txtBox.Content) != "")
            {
                a = Convert.ToDouble(txtBox.Content);
                cod = 2;
                txtBox.Content = "";
                znak = true;
            }
        }

        private void Button_Click_Umn(object sender, RoutedEventArgs e)  // кнопка умножение
        {
            if (Convert.ToString(txtBox.Content) != "")
            {
                a = Convert.ToDouble(txtBox.Content);
                cod = 3;
                txtBox.Content = "";
                znak = true;
            }
        }

        private void Button_Click_Div(object sender, RoutedEventArgs e)         // кнопка Деление
        {
            if (Convert.ToString(txtBox.Content) != "")
            {
                a = Convert.ToDouble(txtBox.Content);
                cod = 4;
                txtBox.Content = "";
                znak = true;
            }
        }

        private void Button_Click_Z(object sender, RoutedEventArgs e)           // удаление последнего введенного символа
        {
            string str = Convert.ToString(txtBox.Content);
            txtBox.Content = Convert.ToString(str.Remove(str.Length - 1, 1));

        }

        private void Button_Click_Plus(object sender, RoutedEventArgs e)        // кнопка Сложение
        {
            if (Convert.ToString(txtBox.Content) != "")
            {
                a = Convert.ToDouble(txtBox.Content);
                cod = 1;
                txtBox.Content = "";
                znak = true;
            }
        }

        private void Button_Click_C(object sender, RoutedEventArgs e)   // очистка
        {
            txtBox.Content = "";
        }
    }
}
