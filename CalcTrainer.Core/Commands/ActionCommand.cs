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

        private readonly Action<ActionCommand> toExecute;
        private bool _commandIsEnabled;
        public bool CommandIsEnabled 
        {
            get =>  _commandIsEnabled;
            set 
            {
                _commandIsEnabled = value;
                CanExecuteChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Create Action Command
        /// </summary>
        /// <param name="toExecute">callback to execute with this command</param>
        public ActionCommand(Action<ActionCommand> toExecute)
        {
            this.toExecute = toExecute;
            this.CommandIsEnabled = true;
        }

        /// <summary>
        /// Shows whether the Command can be executed or not
        /// </summary>
        /// <param name="parameter">will be ignored in current implementation!</param>
        /// <returns></returns>
        public bool CanExecute(object parameter) => CommandIsEnabled;

        /// <summary>
        /// will Execute the <see cref="Action"/> cb which has been added during construction
        /// </summary>
        /// <param name="parameter">is ignored in current implementation!</param>
        public void Execute(object parameter) => toExecute(this);
    }
}
