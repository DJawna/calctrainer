using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CalcTrainer.Core
{
    internal class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };
    }
}
