using System;
using System.Collections.Generic;
using System.ComponentModel;

using CambiarTamañoWindows.Models;
using CambiarTamañoWindows.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CambiarTamañoWindows.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}