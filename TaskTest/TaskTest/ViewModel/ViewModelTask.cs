using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using TaskTest.Model;
using System.Data;

namespace TaskTest.ViewModel
{
    class ViewModelTask : INotifyPropertyChanged
    {
        public ViewModelTask()
        {
            Task2();
            Task3();
        }

        

        Task task2 = new Task(() => {
            Factorial num = new Factorial(5);
            string s = "";
            for (int i = 1; i <= int.Parse(num.ToString()); i++)
            {
                i = i * int.Parse(num.ToString());
                s = i.ToString();
            }
            
        });


        private Task Task2()
        {
            return task2;
        }





        Task task3 = new Task(() => {
            TimeTask time = new TimeTask();
            DateTime dt = Convert.ToDateTime(time);
            String militaryDate = dt.ToString("HH:mm:sstt");
        });


        private Task Task3()
        {
            return task3;            
        }

        private RelayCommand factorialTask;
        public RelayCommand FactorialTask
        {
            get
            {
                return factorialTask ??
                    (factorialTask = new RelayCommand(obj =>
                    {
                        Task2();
                    }));
            }
        }

        private RelayCommand dateConvert;
        public RelayCommand DateConvert
        {
            get
            {
                return dateConvert ??
                    (dateConvert = new RelayCommand(obj =>
                   {
                       Task3();
                   }));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
