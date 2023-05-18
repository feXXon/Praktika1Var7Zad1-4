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

namespace PrakLaba1var7Zad4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double x; if (double.TryParse(txtX.Text, out x))
            {
                if (x > 0 && x < 15)
                {
                    double b = Math.Pow(10, x) + Math.Log10(x);
                    double a = 1 / Math.Cos(x) + Math.Log(Math.Abs(Math.Tan(x / 2))) + b * b; txtResult.Text = a.ToString("F2");
                    lblError.Content = "";
                }
                else
                {
                    lblError.Content = "Введенное значение не принадлежит допустимой области значений функции";
                }
            }
            else
            {
                lblError.Content = "Ошибка ввода";
            }
        }
    }
}
