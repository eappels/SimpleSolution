using SimpleApp.ViewModel;
using System;
using System.Windows.Input;

namespace SimpleApp.Commands
{
    public class ExitCommand : ICommand
    {

        private ShellViewModel _viewModel { get; }

        public ExitCommand(ShellViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            _viewModel.ExitCommand_Clicked(parameter);
        }
    }
}