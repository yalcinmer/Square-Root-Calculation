using MVVM_ICommand2.Commands;
using MVVM_ICommand2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_ICommand2.ViewModels
{
    public class SqrtViewModels:INotifyPropertyChanged
    {
        SqrtModel sqrtModel;

        public ICommand SqrtCommand { get; private set; }

        public SqrtViewModels()
        {
            this.sqrtModel = new SqrtModel();

            SqrtCommand = new RelayCommand(o =>
            {
                sqrtModel.Sqrt();
                OnPropertyChanged("Result");
            });
        }
        public string Number
        {
            get { return sqrtModel.Number.ToString(); }
            set 
            {
                if (value == Number) return;
                sqrtModel.Number = double.Parse(value);
                OnPropertyChanged("Number");
            }
        }

        public string Result
        {
            get { return sqrtModel.Result.ToString(); }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string arg)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(arg));
        }
    }
}
