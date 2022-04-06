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
using System.IO;
using System.Threading;

namespace TaskTest.ViewModel
{
    internal class MainViewModel
    {
        public FactorialTask Factorials { get; set; }
        public DateConvertTask Dates { get;set;}
        public MainViewModel()
        {
            Factorials = new FactorialTask();
            Dates = new DateConvertTask();
        }
        private RelayCommand click;
        public RelayCommand Click
        {
            get
            {
                return click ??
                    (click = new RelayCommand(obj =>
                    {
                        Factorials = new FactorialTask();
                        Dates = new DateConvertTask();
                    }));
            }
        }
    }

        
    }
    
