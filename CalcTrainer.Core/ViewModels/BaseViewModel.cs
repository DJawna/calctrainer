using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CalcTrainer.Core.ViewModels
{
    internal class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };
    }
}
