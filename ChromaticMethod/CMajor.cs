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
                var scale = Major.ModeI("C");
                var text = new Label() { Text = $"The C {scaleType} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (scaleType == "Dorian")
            {
                var scale = Major.ModeII("C");
                var text = new Label() { Text = $"The D {scaleType} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (scaleType == "Phrygian")
            {
                var scale = Major.ModeIII("C");
                var text = new Label() { Text = $"The E {scaleType} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (scaleType == "Lydian")
            {
                var scale = Major.ModeIV("C");
                var text = new Label() { Text = $"The F {scaleType} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (scaleType == "Mixolydian")
            {
                var scale = Major.ModeV("C");
                var text = new Label() { Text = $"The G {scaleType} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (scaleType == "Aolian")
            {
                var scale = Major.ModeVI("C");
                var text = new Label() { Text = $"The A {scaleType} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (scaleType == "Locrian")
            {
                var scale = Major.ModeVII("C");
                var text = new Label() { Text = $"The B {scaleType} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }

            // Minor Pentatonic Scales 

            if (scaleType == "Minor Pentatonic I")
            {
                var scale = MinorPentatonic.ModeI("A");
                var text = new Label() { Text = $"The A {scaleType} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (scaleType == "Minor Pentatonic II")
            {
                var scale = MinorPentatonic.ModeII("A");
                var text = new Label() { Text = $"The A {scaleType} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (scaleType == "Minor Pentatonic III")
            {
                var scale = MinorPentatonic.ModeIII("A");
                var text = new Label() { Text = $"The A {scaleType} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (scaleType == "Minor Pentatonic IV")
            {
                var scale = MinorPentatonic.ModeIV("A");
                var text = new Label() { Text = $"The A {scaleType} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (scaleType == "Minor Pentatonic V")
            {
                var scale = MinorPentatonic.ModeV("A");
                var text = new Label() { Text = $"The A {scaleType} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }

            // Major Pentatonic Scales 

            if (scaleType == "Major Pentatonic I")
            {
                var scale = MajorPentatonic.ModeI("C");
                var text = new Label() { Text = $"The C {scaleType} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (scaleType == "Major Pentatonic II")
            {
                var scale = MajorPentatonic.ModeII("C");
                var text = new Label() { Text = $"The C {scaleType} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (scaleType == "Major Pentatonic III")
            {
                var scale = MajorPentatonic.ModeIII("C");
                var text = new Label() { Text = $"The C {scaleType} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (scaleType == "Major Pentatonic IV")
            {
                var scale = MajorPentatonic.ModeIV("C");
                var text = new Label() { Text = $"The C {scaleType} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (scaleType == "Major Pentatonic V")
            {
                var scale = MajorPentatonic.ModeV("C");
                var text = new Label() { Text = $"The C {scaleType} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }


            // Melodic Minor Scales 


            if (scaleType == "Melodic Minor I")
            {
                var scale = MelodicMinor.ModeI("C");
                var text = new Label() { Text = $"The C {scaleType} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (scaleType == "Melodic Minor II")
            {
                var scale = MelodicMinor.ModeII("C");
                var text = new Label() { Text = $"The C {scaleType} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (scaleType == "Melodic Minor III")
            {
                var scale = MelodicMinor.ModeIII("C");
                var text = new Label() { Text = $"The C {scaleType} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (scaleType == "Melodic Minor IV")
            {
                var scale = MelodicMinor.ModeIV("C");
                var text = new Label() { Text = $"The C {scaleType} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (scaleType == "Melodic Minor V")
            {
                var scale = MelodicMinor.ModeV("C");
                var text = new Label() { Text = $"The C {scaleType} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (scaleType == "Melodic Minor VI")
            {
                var scale = MelodicMinor.ModeVI("C");
                var text = new Label() { Text = $"The C {scaleType} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (scaleType == "Melodic Minor VII")
            {
                var scale = MelodicMinor.ModeVII("C");
                var text = new Label() { Text = $"The C {scaleType} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }

            // Melodic Major 

            if (scaleType == "Melodic Major I")
            {
                var scale = MelodicMajor.ModeI("C");
                var text = new Label() { Text = $"The C {scaleType} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (scaleType == "Melodic Major II")
            {
                var scale = MelodicMajor.ModeII("C");
                var text = new Label() { Text = $"The C {scaleType} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (scaleType == "Melodic Major III")
            {
                var scale = MelodicMajor.ModeIII("C");
                var text = new Label() { Text = $"The C {scaleType} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (scaleType == "Melodic Major IV")
            {
                var scale = MelodicMajor.ModeIV("C");
                var text = new Label() { Text = $"The C {scaleType} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (scaleType == "Melodic Major V")
            {
                var scale = MelodicMajor.ModeV("C");
                var text = new Label() { Text = $"The C {scaleType} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (scaleType == "Melodic Major VI")
            {
                var scale = MelodicMajor.ModeVI("C");
                var text = new Label() { Text = $"The C {scaleType} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (scaleType == "Melodic Major VII")
            {
                var scale = MelodicMajor.ModeVII("C");
                var text = new Label() { Text = $"The C {scaleType} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }

            // Enigmatic Minor Scale 


            if (scaleType == "Enigmatic Minor I")
            {
                var scale = EnigmaticMinor.ModeI("C");
                var text = new Label() { Text = $"The C {scaleType} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (scaleType == "Enigmatic Minor II")
            {
                var scale = EnigmaticMinor.ModeII("C");
                var text = new Label() { Text = $"The C {scaleType} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (scaleType == "Enigmatic Minor III")
            {
                var scale = EnigmaticMinor.ModeIII("C");
                var text = new Label() { Text = $"The C {scaleType} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (scaleType == "Enigmatic Minor IV")
            {
                var scale = EnigmaticMinor.ModeIV("C");
                var text = new Label() { Text = $"The C {scaleType} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (scaleType == "Enigmatic Minor V")
            {
                var scale = EnigmaticMinor.ModeV("C");
                var text = new Label() { Text = $"The C {scaleType} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (scaleType == "Enigmatic Minor VI")
            {
                var scale = EnigmaticMinor.ModeVI("C");
                var text = new Label() { Text = $"The C {scaleType} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (scaleType == "Enigmatic Minor VII")
            {
                var scale = EnigmaticMinor.ModeVII("C");
                var text = new Label() { Text = $"The C {scaleType} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }

            // Whole Tone Scales 

            if (scaleType == "Whole Tone I")
            {
                var scale = WholeTone.ModeI("C");
                var text = new Label() { Text = $"The C {scaleType} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (scaleType == "Whole Tone II")
            {
                var scale = WholeTone.ModeII("C");
                var text = new Label() { Text = $"The C {scaleType} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (scaleType == "Whole Tone III")
            {
                var scale = WholeTone.ModeIII("C");
                var text = new Label() { Text = $"The C {scaleType} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (scaleType == "Whole Tone IV")
            {
                var scale = WholeTone.ModeIV("C");
                var text = new Label() { Text = $"The C {scaleType} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (scaleType == "Whole Tone V")
            {
                var scale = WholeTone.ModeV("C");
                var text = new Label() { Text = $"The C {scaleType} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (scaleType == "Whole Tone VI")
            {
                var scale = WholeTone.ModeVI("C");
                var text = new Label() { Text = $"The C {scaleType} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (scaleType == "Whole Tone VII")
            {
                var scale = WholeTone.ModeVII("C");
                var text = new Label() { Text = $"The C {scaleType} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
        }
    }
}
