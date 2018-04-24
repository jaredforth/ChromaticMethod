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

        async void Phrygian_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("Phrygian"));
        }

        async void Lydian_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("Lydian"));
        }

        async void Mixolydian_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("Mixolydian"));
        }

        async void Aolian_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("Aolian"));
        }

        async void Locrian_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("Locrian"));
        }
    }
}
