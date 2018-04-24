using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ChromaticMethod
{
    public partial class CIonian : ContentPage
    {
        public CIonian()
        {
            InitializeComponent();

            var builder = new Ionian();
            var scale = builder.IonianBuilder("C");

            var test = "testing 1 2 3";

            this.Resources.Add("Scale", scale);

            this.Resources.Add("Test", test);
        }
    }
}
