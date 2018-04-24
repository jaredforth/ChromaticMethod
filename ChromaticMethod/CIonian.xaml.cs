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
            var scale = Ionian.IonianBuilder("C");

            var layout = new StackLayout() {HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center};
            var text = new Label() { Text = $"The C Ionian scale is: {scale}"};

            layout.Children.Add(text);
            Content = layout;
        }
    }
}
