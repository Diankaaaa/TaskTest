using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTest.ViewModel
{
    internal class MainViewModel
    {
        public FactorialTask Factorials { get; set; }
        public MainViewModel()
        {
            Factorials = new FactorialTask();
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
                    }));
            }
        }
    }

        
    }
    
