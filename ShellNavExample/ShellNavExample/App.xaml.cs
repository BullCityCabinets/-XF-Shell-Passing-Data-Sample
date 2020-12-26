using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShellNavExample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

    }
}
