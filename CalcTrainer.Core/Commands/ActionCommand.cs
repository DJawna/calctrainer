using System;
using System.Windows.Input;

namespace CalcTrainer.Core.Commands
{
    public class ActionCommand : ICommand
    {
        public event EventHandler CanExecuteChanged = (s,e) => { };

        private readonly Action toExecute;

        public ActionCommand(Action toExecute)
        {
            this.toExecute = toExecute;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            this.toExecute();
        }
    }
}
