using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ChromaticMethod
{
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
        }

        void C_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("C Major Scale", "C - D - E ...", "Go Back");
        }
    }
}
