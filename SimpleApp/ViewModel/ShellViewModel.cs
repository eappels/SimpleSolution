using SimpleApp.Commands;
using System.Windows.Input;

namespace SimpleApp.ViewModel
{
    public class ShellViewModel
    {

        public ICommand ExitCommand { get; }

        public ShellViewModel()
        {
            ExitCommand = new ExitCommand(this);
        }

        public void ExitCommand_Clicked(object value)
        {
            App.Current.Shutdown();
        }
    }
}