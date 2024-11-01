using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace zad6
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


        private string linkToFile()
        {
            //создание диалога
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            //настройка параметров диалога
            dlg.FileName = "Document"; // Default file name
            dlg.DefaultExt = ".txt"; // Default file extension
            dlg.Filter = "Text documents (.txt)|*.txt"; // Filter files by extension
            
            //вызов диалога
            dlg.ShowDialog();

            return dlg.FileName;
        }


        private void Open(object sender, RoutedEventArgs e)
        {
            //очищаем поле вывода
            TextFromFile.Text = "";

            //открытие файла для чтения
            System.IO.StreamReader file = new System.IO.StreamReader(@linkToFile());

            string line;

            //построчное чтение файла 
            while ((line = file.ReadLine()) != null)
            {
                //операции над полученной строкой
                TextFromFile.Text += line + "\n";
            }

            //закрытие файла
            file.Close();
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            //открытие файла в который запишем строки
            using (StreamWriter outputFile = new StreamWriter(@linkToFile()))
            {
                    outputFile.WriteLine(TextFromFile.Text);
            }
        }
    }
}
