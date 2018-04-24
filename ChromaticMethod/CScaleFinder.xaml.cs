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
            await Navigation.PushAsync(new CIonian());
        }

        //void Ionain_Clicked(object sender, System.EventArgs e)
        //{
            
        //    var builder = new Ionian();
        //    var scale = builder.IonianBuilder("C");

        //    DisplayAlert("Ionain Scale:", scale, "Cancel");
        //}
    }
}
