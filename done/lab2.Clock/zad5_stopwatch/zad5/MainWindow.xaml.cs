using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace zad5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        System.Windows.Threading.DispatcherTimer Timer;

        public MainWindow()
        {
            InitializeComponent();
            //инициализация переменной таймер
            Timer = new System.Windows.Threading.DispatcherTimer();

            //назначение обработчика события Тик
            Timer.Tick += new EventHandler(dispatcherTimer_Tick);

            //установка интервала между тиками 
            //TimeSpan – переменная для хранения времени в формате часы/минуты/секунды
            Timer.Interval = new TimeSpan(0, 0, 1);

            CurrentTime.Content = "00:00:00";
        }

        int totSec = 0; //Total seconds
        int CurSec = 0; //Current seconds
        int CurMin = 0; //Current minetus
        int CurHours = 0; //Current hours

        private void IndusCodding()//:)
        {
            /// Я все сделал без datetime))))
            if (CurHours < 10 && CurMin < 10 && CurSec < 10)                            //0 0 0
            {                                                                           //0 0 1
                CurrentTime.Content = "0" + CurHours + ":0" + CurMin + ":0" + CurSec;   //0 1 0
            }                                                                           //1 0 0
                                                                                        //0 1 1
            if (CurHours < 10 && CurMin < 10 && CurSec >= 10)                           //1 0 1
            {                                                                           //1 1 0
                CurrentTime.Content = "0" + CurHours + ":0" + CurMin + ":" + CurSec;    //1 1 1
            }

            if (CurHours < 10 && CurMin >= 10 && CurSec < 10)
            {
                CurrentTime.Content = "0" + CurHours + ":" + CurMin + ":0" + CurSec;
            }

            if (CurHours >= 10 && CurMin < 10 && CurSec < 10)
            {
                CurrentTime.Content = "" + CurHours + ":0" + CurMin + ":0" + CurSec;
            }

            if (CurHours < 10 && CurMin >= 10 && CurSec >= 10)
            {
                CurrentTime.Content = "0" + CurHours + ":" + CurMin + ":" + CurSec;
            }

            if (CurHours >= 10 && CurMin < 10 && CurSec >= 10)
            {
                CurrentTime.Content = "" + CurHours + ":0" + CurMin + ":" + CurSec;
            }

            if (CurHours >= 10 && CurMin >= 10 && CurSec < 10)
            {
                CurrentTime.Content = "" + CurHours + ":" + CurMin + ":0" + CurSec;
            }

            if (CurHours >= 10 && CurMin >= 10 && CurSec >= 10)
            {
                CurrentTime.Content = "" + CurHours + ":" + CurMin + ":" + CurSec;
            }

            CurSec++;
            totSec++;
        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            //seconds
            if (CurSec < 60)
            {
                IndusCodding();
            }

            //minutes
            if (CurSec >= 60)
            {
                CurSec = 0;
                CurMin++;
            }

            //hours
            if (CurMin >= 60)
            {
                CurMin = 0;
                CurHours++;
            }
        }

        private void Sign_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            //запуск таймера
            Timer.Start();

            //Стирает запомненное время при запуске нового таймера
            if ((string)CurrentTime.Content == "00:00:00")
            {
                MemberTimes.Text = "";
            }

            //обнуление переменных времени
            if ((string)CurrentTime.Content == "00:00:00")
            {
                totSec = 0; //Total seconds
                CurSec = 0; //Current seconds
                CurMin = 0; //Current minetus
                CurHours = 0; //Current hours
            }
        }

        int q = 1; // q - это сколько времени зафиксировано
        private void Remember_Click(object sender, RoutedEventArgs e)
        {
            Timer.Tag = CurrentTime.Content;

            if ((string)Timer.Tag != "00:00:00" && Sign.IsChecked == false)
            {
                MemberTimes.Text += "\nВремя " + q + ": " + (string)Timer.Tag;
                q++;
            }

            if((string)Timer.Tag != "00:00:00" && Sign.IsChecked == true)
            {
                MemberTimes.Text += "\nВремя " + q + ": " + totSec + " сек.";
                q++;
            }
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            //остановка таймера
            Timer.Stop();

            CurrentTime.Content = "00:00:00";

            q = 1;
        }
    }
}
