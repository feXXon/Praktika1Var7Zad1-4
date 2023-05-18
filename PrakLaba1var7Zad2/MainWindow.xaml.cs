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

namespace PrakLaba1var7Zad2
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
            double x1, y1, x2, y2; if (double.TryParse(txtX1.Text, out x1) && double.TryParse(txtY1.Text, out y1) &&
     double.TryParse(txtX2.Text, out x2) && double.TryParse(txtY2.Text, out y2))
            {
                double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)); txtDistance.Text = distance.ToString("F2");
                lblError.Content = "";
            }
            else
            {
                lblError.Content = "Ошибка ввода";
            }
        }
    }
}