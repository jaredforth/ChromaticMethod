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
                var text = new Label() { Text = $"The C {scaleType} scale is: {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (scaleType == "Dorian")
            {
                var scale = Major.Dorian("C");
                var text = new Label() { Text = $"The D {scaleType} scale is: {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (scaleType == "Phrygian")
            {
                var scale = Major.Phrygian("C");
                var text = new Label() { Text = $"The E {scaleType} scale is: {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (scaleType == "Lydian")
            {
                var scale = Major.Lydian("C");
                var text = new Label() { Text = $"The F {scaleType} scale is: {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (scaleType == "Mixolydian")
            {
                var scale = Major.Mixolydian("C");
                var text = new Label() { Text = $"The G {scaleType} scale is: {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (scaleType == "Aolian")
            {
                var scale = Major.Aolian("C");
                var text = new Label() { Text = $"The A {scaleType} scale is: {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (scaleType == "Locrian")
            {
                var scale = Major.Locrian("C");
                var text = new Label() { Text = $"The B {scaleType} scale is: {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
        }
    }
}
