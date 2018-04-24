using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ChromaticMethod
{
    public partial class DIonian : ContentPage
    {
        public DIonian()
        {
            InitializeComponent();

            var builder = new Major();
            var scale = Major.Ionian("D");

            var layout = new StackLayout() { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center };
            var text = new Label() { Text = $"The D Ionian scale is: {scale}" };

            layout.Children.Add(text);
            Content = layout;
        }
    }
}
