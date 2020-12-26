using ShellNavExample.Views;
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ShellNavExample
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(Page2), typeof(Page2));
        }
    }
}
