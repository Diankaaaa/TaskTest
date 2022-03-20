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
using System.IO;
using TaskTest.ViewModel;
using TaskTest.Model;

namespace TaskTest
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int task1, task2;
        private string input2, outPut2, input3, outPut3;
        public MainWindow()
        {
            input2 = "input2.txt";
            outPut2 = "output2.txt";
            InitializeComponent();
            DataContext = new ViewModelTask();
        }


        private async void Task1()
        {
            Factorial();
            TASK1.Text = task1.ToString();
        }

        private async void Task2()
        {

        }


        private async void ConvertTime()
        {
            DateTime.Now.ToString("HH:mm:ss");

            //Чтение из файла
            using (StreamReader reader = new StreamReader(input3))
            {
                string text = await reader.ReadToEndAsync();
                MessageBox.Show(input3);
            }

            //Запись в файл
            using (StreamWriter writer = new StreamWriter(outPut3, true, System.Text.Encoding.Default))
            {
                await writer.WriteLineAsync(task1.ToString());
            }
        }


        private async void Factorial()
        {
            int F = 1;
            for(int i = 1; i<=F; i++)
            {
                F = F * i;
            }

            task1 = F;

            //Чтение из файла
            using (StreamReader reader = new StreamReader(input2))
            {
                string text = await reader.ReadToEndAsync();
                MessageBox.Show(input2);
            }

            //Запись в файл
            using (StreamWriter writer = new StreamWriter(outPut2, true, System.Text.Encoding.Default))
            {
                await writer.WriteLineAsync(task1.ToString());
            }

        }
    }
}
