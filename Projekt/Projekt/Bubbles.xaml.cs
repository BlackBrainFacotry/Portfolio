﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projekt
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Bubbles : ContentPage
    {
        public Bubbles()
        {
            InitializeComponent();

        }

        private async void Zawroc_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}