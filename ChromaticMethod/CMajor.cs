using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ChromaticMethod
{
    public partial class CMajor : ContentPage
    {
        public CMajor(string scaleType)
        {
            InitializeComponent();

            var builder = new Major();
            var layout = new StackLayout() { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center };

            if (scaleType == "Ionian") 
            {
                var scale = Major.Ionian("C");
                var text = new Label() { Text = $"The C Ionian scale is: {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (scaleType == "Dorian")
            {
                var scale = Major.Dorian("C");
                var text = new Label() { Text = $"The D Dorian scale is: {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
        }
    }
}
