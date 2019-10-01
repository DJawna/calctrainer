using System;
using System.Windows.Input;

namespace CalcTrainer.Core.Commands
{
    /// <summary>
    /// <see cref="ICommand"/> Implementation which can be used with <see cref="Action"/> objects.
    /// </summary>
    public class ActionCommand : ICommand
    {
        public event EventHandler CanExecuteChanged = (s,e) => { };

        private readonly Action toExecute;
        private readonly Func<bool> canExecute;

        /// <summary>
        /// Create Action Command
        /// </summary>
        /// <param name="toExecute">callback to execute with this command</param>
        /// <param name="canExecute">callback to decide when the command should be able to execute</param>
        public ActionCommand(Action toExecute, Func<bool> canExecute = null)
        {
            this.toExecute = toExecute;
            this.canExecute = canExecute;
            if (canExecute == null)
            {
                this.canExecute = new Func<bool>(() => true);
            }

        }

        /// <summary>
        /// Shows whether the Command can be executed or not
        /// </summary>
        /// <param name="parameter">will be ignored in current implementation!</param>
        /// <returns></returns>
        public bool CanExecute(object parameter) => canExecute();

        /// <summary>
        /// will Execute the <see cref="Action"/> cb which has been added during construction
        /// </summary>
        /// <param name="parameter">is ignored in current implementation!</param>
        public void Execute(object parameter) => toExecute();
    }
}
