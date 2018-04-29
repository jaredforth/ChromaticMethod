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


        // Dominant 7ths 

        async void DomSeventhI_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("Dom 7th I"));
        }
        async void DomSeventhII_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("Dom 7th II"));
        }
        async void DomSeventhIII_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("Dom 7th III"));
        }
        async void DomSeventhIV_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("Dom 7th IV"));
        }
        async void DomSeventhV_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("Dom 7th V"));
        }
        async void DomSeventhVI_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("Dom 7th VI"));
        }
        async void DomSeventhVII_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("Dom 7th VII"));
        }


        // Major and Minor 7ths 

        async void SeventhI_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("7th I"));
        }
        async void SeventhII_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("7th II"));
        }
        async void SeventhIII_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("7th III"));
        }
        async void SeventhIV_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("7th IV"));
        }
        async void SeventhV_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("7th V"));
        }
        async void SeventhVI_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("7th VI"));
        }
        async void SeventhVII_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("7th VII"));
        }


        // Dominant 9ths 

        async void DomNinthI_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("Dom 9th I"));
        }
        async void DomNinthII_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("Dom 9th II"));
        }
        async void DomNinthIII_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("Dom 9th III"));
        }
        async void DomNinthIV_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("Dom 9th IV"));
        }
        async void DomNinthV_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("Dom 9th V"));
        }
        async void DomNinthVI_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("Dom 9th VI"));
        }
        async void DomNinthVII_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("Dom 9th VII"));
        }


        // Major and Minor 9ths 

        async void NinthI_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("9th I"));
        }
        async void NinthII_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("9th II"));
        }
        async void NinthIII_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("9th III"));
        }
        async void NinthIV_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("9th IV"));
        }
        async void NinthV_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("9th V"));
        }
        async void NinthVI_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("9th VI"));
        }
        async void NinthVII_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("9th VII"));
        }
    }
}
