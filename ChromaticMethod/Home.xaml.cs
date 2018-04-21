using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ChromaticMethod
{
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
        }

        async void C_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CHome());
        }
    }
}
