using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_ICommand2.Commands
{
    internal class RelayCommand : ICommand
    {
        Action<object> executeAction;
        Func<object, bool> canExecuted;
        bool canExecuteChanged;

        public RelayCommand(Action<object> execute) : this(execute, null, false) { }

        public RelayCommand(Action<object> executeAction, Func<object, bool> canExecuted, bool canExecuteChanged)
        {
            this.executeAction = executeAction;
            this.canExecuted = canExecuted;
            this.canExecuteChanged = canExecuteChanged;
        }   

        public bool CanExecute(object parameter)
        {
            if (canExecuted == null)
                return true;
            return canExecuted(parameter);
        }

        public void Execute(object parameter)
        {
            executeAction(parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
