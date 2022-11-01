using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Coffee_Shop_App.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private async void espressoPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EspressoPage());
        }

        private async void hotDrinksPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HotDrinksPage());
        }

        private async void coldDrinksPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ColdDrinksPage());
        }

        private async void quickBitesPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QuickBitesPage());
        }
    }
}