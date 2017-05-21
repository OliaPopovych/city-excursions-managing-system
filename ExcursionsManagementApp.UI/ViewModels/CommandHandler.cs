using System;
using System.Windows.Input;

namespace ExcursionsManagementApp.UI.ViewModels
{
    /// <summary>
    /// This class purpose is to control whether command can be executed
    /// </summary>
    public class CommandHandler : ICommand
    {
        private Action<object> action;
        private bool canExecute;
        public CommandHandler(Action<object> action, bool canExecute)
        {
            this.action = action;
            this.canExecute = canExecute;
        }
        // Below two methods are for cases when ui element can not be executable
        // and other ui elements have to watch when it will be enabled
        public bool CanExecute(object parameter)
        {
            return canExecute;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            action(parameter);
        }
    }
}
