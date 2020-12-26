using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShellNavExample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            BindingContext = this;

        }

        public string UserInputText { get; set; }

        async void TakeInput_ClickedAsync(object sender, EventArgs e)
        {
            if (UserInput.Text != "User Input Text")
            {
                await Shell.Current.GoToAsync($"{nameof(Page2)}?Input={UserInputText}");
            }
            else
            {
                await Shell.Current.GoToAsync($"{nameof(Page2)}");
            }

        }

        async void SkipInput_ClickedAsync(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"{nameof(Page2)}");
        }




    }
}