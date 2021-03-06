﻿using System;
using Xamarin.Forms;

namespace ShellNavExample.Views
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    [QueryProperty(nameof(Input), nameof(Input))] 
    public partial class Page2 : ContentPage
    {
        string input { get; set; }
        public string Input
        {
            get => input;
            set
            {
                input = Uri.UnescapeDataString(value ?? string.Empty);
                OnPropertyChanged();
            }
        }

        public Page2()
        {
            InitializeComponent();
            BindingContext = this;

            destinationLabel.Text = Input ?? "No data was passed";


        }
    }
}