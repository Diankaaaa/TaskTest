using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTest.Model
{
    public interface IDialogService
    {
        void ShowMessage(string message); //Показ сообщения
        string FilePath { get; set; } //Путь к выбранному файлу
        bool OpenFileDialog(); //Открытие файла
        bool SaveFileDialog(); //Сохранение файла
    }
}
