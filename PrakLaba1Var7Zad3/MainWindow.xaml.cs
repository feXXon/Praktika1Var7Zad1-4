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

namespace PrakLaba1Var7Zad3
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
            double weight; double price;
            if (double.TryParse(txtWeight.Text, out weight) && double.TryParse(txtPrice.Text, out price))
            {
                if (weight >= 0 && price >= 0)
                {
                    double pricePerKg = price / weight; double totalPrice = pricePerKg * double.Parse(txtWeight.Text);
                    txtPricePerKg.Text = pricePerKg.ToString("F2"); txtTotalPrice.Text = totalPrice.ToString("F2");
                    lblError.Content = "";
                }
                else
                {
                    lblError.Content = "Введенные значения не могут быть отрицательными";
                }
            }
            else
            {
                lblError.Content = "Ошибка ввода";
            }
        }
    }
}
