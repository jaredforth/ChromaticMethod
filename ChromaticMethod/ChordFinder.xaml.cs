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
            await Navigation.PushAsync(new CMajor("Triad I"));
        }
        async void TriadII_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("Triad II"));
        }
        async void TriadIII_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("Triad III"));
        }
        async void TriadIV_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("Triad IV"));
        }
        async void TriadV_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("Triad V"));
        }
        async void TriadVI_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("Triad VI"));
        }
        async void TriadVII_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("Triad VII"));
        }
    }
}
