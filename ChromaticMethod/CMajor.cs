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

            var layout = new StackLayout() { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center };

            // Major Scales

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

            // Minor Pentatonic Scales 

            if (scaleType == "Minor Pentatonic I")
            {
                var scale = MinorPentatonic.ModeI("A");
                var text = new Label() { Text = $"The A {scaleType} scale is: {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (scaleType == "Minor Pentatonic II")
            {
                var scale = MinorPentatonic.ModeII("A");
                var text = new Label() { Text = $"The A {scaleType} scale is: {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (scaleType == "Minor Pentatonic III")
            {
                var scale = MinorPentatonic.ModeIII("A");
                var text = new Label() { Text = $"The A {scaleType} scale is: {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (scaleType == "Minor Pentatonic IV")
            {
                var scale = MinorPentatonic.ModeIV("A");
                var text = new Label() { Text = $"The A {scaleType} scale is: {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (scaleType == "Minor Pentatonic V")
            {
                var scale = MinorPentatonic.ModeV("A");
                var text = new Label() { Text = $"The A {scaleType} scale is: {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }

            // Major Pentatonic Scales 

            if (scaleType == "Major Pentatonic I")
            {
                var scale = MajorPentatonic.ModeI("C");
                var text = new Label() { Text = $"The C {scaleType} scale is: {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (scaleType == "Major Pentatonic II")
            {
                var scale = MajorPentatonic.ModeII("C");
                var text = new Label() { Text = $"The C {scaleType} scale is: {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (scaleType == "Major Pentatonic III")
            {
                var scale = MajorPentatonic.ModeIII("C");
                var text = new Label() { Text = $"The C {scaleType} scale is: {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (scaleType == "Major Pentatonic IV")
            {
                var scale = MajorPentatonic.ModeIV("C");
                var text = new Label() { Text = $"The C {scaleType} scale is: {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (scaleType == "Major Pentatonic V")
            {
                var scale = MajorPentatonic.ModeV("C");
                var text = new Label() { Text = $"The C {scaleType} scale is: {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }

        }
    }
}
