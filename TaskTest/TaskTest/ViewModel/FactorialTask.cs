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
    public class FactorialTask 
    {
        public int Number { get;set;}
        public long Factorial { get; set; }
        public FactorialTask()
        {
            Number = Read();
            Factorial = Fact(Number);
            Factorial = Write();
        }
        private long Fact(int n)
        {
            long F = 1;
            for (int i = 1; i <=n; i++)
            {
                F *= i;
            }
            return F;
        }
        private int Read()
        {
            Thread.Sleep(2000);
            string text = "";
            using (StreamReader reader = new StreamReader("input2.txt"))
            {
                text = reader.ReadToEnd();
            }

            int res = int.Parse(text);
            return res;
        }

        private long Write()
        {
            string text = Factorial.ToString();
            using (StreamWriter writer = new StreamWriter("output2.txt"))
            {
                writer.WriteLineAsync(text);
            }
            return long.Parse(text);
        }
    }
}
