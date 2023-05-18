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

namespace PrakLaba1var7
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
            double radius; if (double.TryParse(txtRadius.Text, out radius))
            {
                if (radius >= 0)
                {
                    double circumference = 2 * Math.PI * radius;
                    double area = Math.PI * radius * radius; txtCircumference.Text = circumference.ToString("F2");
                    txtArea.Text = area.ToString("F2"); lblError.Content = "";
                }
                else
                {
                    lblError.Content = "Радиус не может быть отрицательным";
                }
            }
            else
            {
                lblError.Content = "Ошибка ввода";
            }
        }
    }
}
