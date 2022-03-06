using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using System.Data;
using TaskTest.Model;

namespace TaskTest.ViewModel
{
    public class ViewModelTask2 : INotifyPropertyChanged
    {
        IDialogService dialogService;
        IFileService fileService;
        private RelayCommand openFileDialog;
        public RelayCommand OpenFileDialog
        {
            get
            {
                return openFileDialog ??
                    (openFileDialog = new RelayCommand(obj =>
                    {
                        try
                        {
                            if (dialogService.OpenFileDialog() == true)
                            {
                                fileService.SaveFactorial(dialogService.FilePath);
                            }
                        }
                        catch(Exception ex)
                        {
                            dialogService.ShowMessage(ex.Message);
                        }
                    }));   
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
