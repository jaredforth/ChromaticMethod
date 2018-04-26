using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ChromaticMethod
{
    public partial class ChordFinder : ContentPage
    {
        public ChordFinder(string Key)
        {
            InitializeComponent();
        }

        // Triads 

        async void TriadI_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("Whole Tone I"));
        }
        async void TriadII_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("Whole Tone II"));
        }
        async void TriadIII_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("Whole Tone III"));
        }
        async void TriadIV_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("Whole Tone IV"));
        }
        async void TriadV_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("Whole Tone V"));
        }
        async void TriadVI_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("Whole Tone VI"));
        }
        async void TriadVII_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("Whole Tone VII"));
        }
    }
}
