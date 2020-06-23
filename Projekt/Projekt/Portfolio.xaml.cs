using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Essentials;
using Xamarin.Forms.Xaml;

namespace Projekt
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Portfolio : ContentPage
    {
        public ICommand Strona { get; }

        public Portfolio()
        {
            InitializeComponent();

            Strona = new Command(async () => await Browser.OpenAsync("https://www.wykop.pl/cdn/c3201142/comment_puZv9IPJhQZ6fHhFEfvVh4RZuBscQJHh.gif"));

            BindingContext = this;

        }

        private async void goBack_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void meme_Clicked(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("( ͡°( ͡° ͜ʖ( ͡° ͜ʖ ͡°)ʖ ͡°) ͡°)", "Gapisz mi sie na bebech?", "tak", "co?");

            if(result)
            {
                await Navigation.PushAsync(new Ricky());
            } else
            {
                await Navigation.PushAsync(new Bubbles());
            }

        }
    }
}