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

namespace pogi2
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
        public string a;
        public string b;

        private void A_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void B_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Result_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            a = A.Text;
            b = B.Text;
            bool canConvertA = double.TryParse(a, out double Num);
            bool canConvertB = double.TryParse(b, out _);
            if (canConvertA == true && canConvertB)
            {
                double result = Convert.ToDouble(a) + Convert.ToDouble(b);
                Result.Text = Convert.ToString(result);
            }
            else
            {
                A.Text = a;
                B.Text = b;
                Result.Text = "";
            }
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            a = A.Text;
            b = B.Text;
            bool canConvertA = double.TryParse(a, out double Num);
            bool canConvertB = double.TryParse(b, out _);
            if (canConvertA == true && canConvertB)
            {
                double result = Convert.ToDouble(a) - Convert.ToDouble(b);
                Result.Text = Convert.ToString(result);
            }
            else
            {
                A.Text = a;
                B.Text = b;
                Result.Text = "";
            }
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            a = A.Text;
            b = B.Text;
            bool canConvertA = double.TryParse(a, out double Num);
            bool canConvertB = double.TryParse(b, out _);
            if (canConvertA == true && canConvertB)
            {
                double result = Convert.ToDouble(a) * Convert.ToDouble(b);
                Result.Text = Convert.ToString(result);
            }
            else
            {
                A.Text = a;
                B.Text = b;
                Result.Text = "";
            }
        }

        private void Division_Click(object sender, RoutedEventArgs e)
        {
            a = A.Text;
            b = B.Text;
            bool canConvertA = double.TryParse(a, out double Num);
            bool canConvertB = double.TryParse(b, out _);
            if (canConvertA == true && canConvertB)
            {
                double result = Convert.ToDouble(a) / Convert.ToDouble(b);
                Result.Text = Convert.ToString(result);
            }
            else
            {
                A.Text = a;
                B.Text = b;
                Result.Text = "";
            }
        }
    }
}
