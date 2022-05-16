using Microsoft.Extensions.DependencyInjection;
using SimpleApp.ViewModel;
using System.Windows;

namespace SimpleApp.View
{
    public partial class ShellView : Window
    {
        public ShellView()
        {
            InitializeComponent();
            DataContext = App.Current.Services.GetService<ShellViewModel>();
        }
    }
}