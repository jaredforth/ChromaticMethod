using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ChromaticMethod
{
    public partial class Home : ContentPage
    {
        void Handle_Activated(object sender, System.EventArgs e)
        {
            DisplayAlert("Login", "Login Sucessful", "OK");
        }

        public Home()
        {
            InitializeComponent();
        }

        async void C_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CHome());
        }

        async void D_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new DHome());
        }

        async void E_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CHome());
        }

        async void F_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CHome());
        }

        async void G_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CHome());
        }

        async void A_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CHome());
        }

        async void B_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CHome());
        }

        async void CsDb_Clicked(object sender, System.EventArgs e)
        {
            var CsDb = await DisplayAlert("Enharmonic Equivalents", "Select either C# or Db", "Db", "C#");
            if (CsDb)
            {
                await Navigation.PushAsync(new ContentPage());
            }
            else
            {
                await Navigation.PushAsync(new ContentPage());
            }
        }

        async void DsEb_Clicked(object sender, System.EventArgs e)
        {
            var DsEb = await DisplayAlert("Enharmonic Equivelants", "Select either D# or Eb", "Eb", "D#");
            if (DsEb)
            {
                await Navigation.PushAsync(new ContentPage());
            }
            else
            {
                await Navigation.PushAsync(new ContentPage());
            }
        }

        async void FsGb_Clicked(object sender, System.EventArgs e)
        {
            var FsGb = await DisplayAlert("Enharmonic Equivelants", "Select either F# or Gb", "Gb", "F#");
            if (FsGb)
            {
                await Navigation.PushAsync(new ContentPage());
            }
            else
            {
                await Navigation.PushAsync(new ContentPage());
            }
        }

        async void GsAb_Clicked(object sender, System.EventArgs e)
        {
            var GsAb = await DisplayAlert("Enharmonic Equivelants", "Select either G# or Ab", "Ab", "G#");
            if (GsAb)
            {
                await Navigation.PushAsync(new ContentPage());
            }
            else
            {
                await Navigation.PushAsync(new ContentPage());
            }
        }

        async void AsBb_Clicked(object sender, System.EventArgs e)
        {
            var AsBb = await DisplayAlert("Enharmonic Equivelants", "Select either A# or Bb", "Bb", "A#");
            if (AsBb)
            {
                await Navigation.PushAsync(new ContentPage());
            }
            else 
            {
                await Navigation.PushAsync(new ContentPage());
            }
        }
    }
}
