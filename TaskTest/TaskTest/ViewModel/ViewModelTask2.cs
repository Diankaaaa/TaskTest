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
using TaskTest.View;

namespace TaskTest.ViewModel
{
    public class ViewModelTask2 : INotifyPropertyChanged
    {

        private RelayCommand openWindowTask3;
        public RelayCommand OpenWindowTask3
        {
            get
            {
                return openWindowTask3 ??
                    (openWindowTask3 = new RelayCommand(obj =>
                    {
                        try
                        {
                            Task3 window = new Task3();
                            window.Show();
                        }
                        catch (Exception ex)
                        {
                            dialogService.ShowMessage(ex.Message);
                        }
                    }));
            }
        }

        public ViewModelTask2(IDialogService dialogService)
        {
            this.dialogService = dialogService;
        }

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
                                var factorals = fileService.OpenFile(dialogService.FilePath);
                                factorals.Clear();
                                foreach (var p in factorals)
                                    factorals.Add(p);
                                dialogService.ShowMessage("Open file!");
                                
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
