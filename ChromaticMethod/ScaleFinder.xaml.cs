﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ChromaticMethod
{
    public partial class ScaleFinder : ContentPage
    {
        public ScaleFinder()
        {
            InitializeComponent();
        }

        void C_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("C Major Scale", "C - D - E ...", "Go Back");
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("D Major Scale", "D - E - F#...", "Go Back");
        }
    }
}
