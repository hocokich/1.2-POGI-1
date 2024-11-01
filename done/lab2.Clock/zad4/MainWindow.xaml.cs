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

namespace zad4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            yearsList();
        }

        private void yearsList()
        {
            for (int i = 2022; i >= 1904; i--)
            {
                Year.Items.Add(i);
            }
        }

        private string monthsArr(int i)
        {
            string[] monthsArr = { "january", "february", "marth", "april", "may", "june", "july", "aughust", "september", "october", "november", "december" };
            return monthsArr[i];
        }

        private void ifEsleForMonths()
        {
            //Здесь условие для месяцев с 31 днем
            if (Month.SelectedIndex + 1 == 1 || Month.SelectedIndex + 1 == 3 || Month.SelectedIndex + 1 == 5 || Month.SelectedIndex + 1 == 7 || Month.SelectedIndex + 1 == 8 || Month.SelectedIndex + 1 == 10 || Month.SelectedIndex + 1 == 12)
            {
                for (int i = 1; i <= 31; i++)
                {
                    Day.Items.Add(i);
                }
            }

            //Здесь условие для месяцев с 30 днем
            if (Month.SelectedIndex + 1 == 4 || Month.SelectedIndex + 1 == 6 || Month.SelectedIndex + 1 == 9 || Month.SelectedIndex + 1 == 11)
            {
                for (int i = 1; i <= 30; i++)
                {
                    Day.Items.Add(i);
                }
            }

            //Здесь условие для февраля
            if (Month.SelectedIndex + 1 == 2 && ((int)Year.SelectionBoxItem % 4) != 0)
            {
                for (int i = 1; i <= 28; i++)
                {
                    Day.Items.Add(i);
                }
            }

            //Здесь условие для февраля в весокосный год
            if (Month.SelectedIndex + 1 == 2 && ((int)Year.SelectionBoxItem % 4) == 0)
            {
                for (int i = 1; i <= 29; i++)
                {
                    Day.Items.Add(i);
                }
            }
        }
        private void Year_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Month.Items.Clear();
            for (int i = 0; i < 12; i++)
            {
                Month.Items.Add(monthsArr(i));
            }
        }

        private void Month_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Day.Items.Clear();
            ifEsleForMonths();
        }

        private void Day_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int year = (int)Year.SelectionBoxItem;
            int month = Month.SelectedIndex + 1;
            int day = Day.SelectedIndex + 1;

            DateTime todayDate = DateTime.Now;

            year = todayDate.Year - year;
            month = todayDate.Month - month;
            day = todayDate.Day - day;
            if (day < 0) day *= -1;

            Result.Text = "С выбранной даты прошло: " + year + " лет, " + month + " месяцев и " + day + " дней.";
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            string st = "Это моя лаба по ПиОГИ. Тут короче прога считает сколько дней, месяцев и лет прошло с момента выбранной даты. вот :>";
            MessageBox.Show(st, "Info by Sanyok", MessageBoxButton.OK);
        }

    }
}
