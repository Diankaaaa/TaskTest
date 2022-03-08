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

        public ViewModelTask2(IDialogService dialogService)
        {
            this.dialogService = dialogService;
            this.fileService = fileService;
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
                                foreach (var d in factorals)
                                    factorals.Add(d);
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
