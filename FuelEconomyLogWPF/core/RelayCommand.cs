using System;
using System.Windows.Input;

namespace FuelEconomyLogWPF.core
{
    public class RelayCommand : ICommand
    {
        private Action<object>? _execute;
        private Func<object, bool>? _canExecute;

        /// <summary>Occurs when changes occur that affect whether or not the command should execute.</summary>
        public event EventHandler? CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }
        /// <summary>
        /// Relays Commands to execute action and canexecute function
        /// </summary>
        /// <param name="execute"></param>
        /// <param name="canexecute"></param>
        public RelayCommand(Action<object>? execute, Func<object, bool>? canexecute = null)
        {
            _execute = execute;
            _canExecute = canexecute;
        }

        /// <summary>Defines the method that determines whether the command can execute in its current state.</summary>
        /// <param name="parameter">Data used by the command.  If the command does not require data to be passed, this object can be set to <see langword="null" />.</param>
        /// <returns>
        ///   <see langword="true" /> if this command can be executed; otherwise, <see langword="false" />.</returns>
        public bool? CanExecute(object? parameter)
        {
            return _canExecute == null || _canExecute(parameter!);
        }

        /// <summary>Defines the method to be called when the command is invoked.</summary>
        /// <param name="parameter">Data used by the command.  If the command does not require data to be passed, this object can be set to <see langword="null" />.</param>
        public void Execute(object? parameter)
        {
            _execute!(parameter!);
        }

        bool ICommand.CanExecute(object? parameter)
        {
            return _canExecute == null || _canExecute(parameter!);
        }
    }
}
