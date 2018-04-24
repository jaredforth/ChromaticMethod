using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ChromaticMethod
{
    public partial class DScaleFinder : ContentPage
    {
        public DScaleFinder()
        {
            InitializeComponent();
        }

        async void Ionain_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new DIonian());
        }
    }
}
