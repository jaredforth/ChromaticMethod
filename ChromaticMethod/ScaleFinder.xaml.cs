using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ChromaticMethod
{
    public partial class ScaleFinder : ContentPage
    {
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("D Major Scale", "D - E - F#...", "Go Back");
        }

        public ScaleFinder()
        {
            InitializeComponent();
        }

        void C_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("C Major Scale", "C - D - E ...", "Go Back");
        }
    }
}
