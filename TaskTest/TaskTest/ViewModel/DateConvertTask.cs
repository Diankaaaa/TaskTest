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
    public class DateConvertTask
    {
        public string DateInput { get;set;}
        public string DateOut { get; set; }
        public string OutFile { get; set; }

        public DateConvertTask()
        {
            DateInput = Read();
            DateOut = Converting(DateInput);
            DateOut = Write();
        }

        private string Converting(string dateTime)
        {
            DateTime date = Convert.ToDateTime(dateTime);
            string result = date.ToString("T");
            return result;
        }
        private string Read()
        {
            Thread.Sleep(2000);
            string text = "";
            using (StreamReader reader = new StreamReader("input3.txt"))
            {
                text = reader.ReadToEnd();
            }
            return text;
        }

        private string Write()
        {
            string text = DateOut;
            using (StreamWriter writer = new StreamWriter("output3.txt"))
            {
                writer.WriteLineAsync(text);
            }
            return text;
        }
    }
}

