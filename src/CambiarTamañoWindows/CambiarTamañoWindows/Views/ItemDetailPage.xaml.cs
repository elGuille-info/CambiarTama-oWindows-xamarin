using System.ComponentModel;

using CambiarTamañoWindows.ViewModels;

using Xamarin.Forms;

namespace CambiarTamañoWindows.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}