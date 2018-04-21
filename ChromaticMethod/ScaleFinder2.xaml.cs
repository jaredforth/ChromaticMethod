using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ChromaticMethod
{
    public partial class ScaleFinder2 : ContentPage
    {
        public ScaleFinder2()
        {
            InitializeComponent();
        }

        void C_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("C Major Scale", "C - D - E ...", "Go Back");
        }
    }
}
