using Microsoft.Extensions.DependencyInjection;
using SimpleApp.View;
using SimpleApp.ViewModel;
using System;
using System.Windows;

namespace SimpleApp
{
    public partial class App : Application
    {

        public new static App Current => (App)Application.Current;
        public IServiceProvider Services { get; }

        public App()
        {
            Services = ConfigureServices();
        }

        private static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddTransient<ShellViewModel>();
            services.AddTransient<ShellView>();
            return services.BuildServiceProvider();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Services.GetService<ShellView>()?.Show();
        }
    }
}