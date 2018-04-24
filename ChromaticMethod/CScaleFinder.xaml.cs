using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ChromaticMethod
{
    public partial class CScaleFinder : ContentPage
    {
        public CScaleFinder()
        {
            InitializeComponent();
        }

        async void Ionain_Clicked (object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("Ionian"));
        }

        async void Dorian_Clicked (object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("Dorian"));
        }
    }
}
