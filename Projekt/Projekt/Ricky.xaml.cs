using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projekt
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ricky : ContentPage
    {


        public Ricky()
        {
            InitializeComponent();

        }

        private async void Zawroc_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}