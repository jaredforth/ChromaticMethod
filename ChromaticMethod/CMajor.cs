using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ChromaticMethod
{
    public partial class CMajor : ContentPage
    {
        public CMajor(string type)
        {
            InitializeComponent();

            var layout = new StackLayout() { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center };

            // Major Scales

            if (type == "Ionian") 
            {
                var scale = Major.ModeI("C");
                var text = new Label() { Text = $"The C {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Dorian")
            {
                var scale = Major.ModeII("C");
                var text = new Label() { Text = $"The D {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Phrygian")
            {
                var scale = Major.ModeIII("C");
                var text = new Label() { Text = $"The E {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Lydian")
            {
                var scale = Major.ModeIV("C");
                var text = new Label() { Text = $"The F {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Mixolydian")
            {
                var scale = Major.ModeV("C");
                var text = new Label() { Text = $"The G {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Aolian")
            {
                var scale = Major.ModeVI("C");
                var text = new Label() { Text = $"The A {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Locrian")
            {
                var scale = Major.ModeVII("C");
                var text = new Label() { Text = $"The B {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }

            // Minor Pentatonic Scales 

            if (type == "Minor Pentatonic I")
            {
                var scale = MinorPentatonic.ModeI("A");
                var text = new Label() { Text = $"The A {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Minor Pentatonic II")
            {
                var scale = MinorPentatonic.ModeII("A");
                var text = new Label() { Text = $"The A {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Minor Pentatonic III")
            {
                var scale = MinorPentatonic.ModeIII("A");
                var text = new Label() { Text = $"The A {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Minor Pentatonic IV")
            {
                var scale = MinorPentatonic.ModeIV("A");
                var text = new Label() { Text = $"The A {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Minor Pentatonic V")
            {
                var scale = MinorPentatonic.ModeV("A");
                var text = new Label() { Text = $"The A {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }

            // Major Pentatonic Scales 

            if (type == "Major Pentatonic I")
            {
                var scale = MajorPentatonic.ModeI("C");
                var text = new Label() { Text = $"The C {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Major Pentatonic II")
            {
                var scale = MajorPentatonic.ModeII("C");
                var text = new Label() { Text = $"The C {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Major Pentatonic III")
            {
                var scale = MajorPentatonic.ModeIII("C");
                var text = new Label() { Text = $"The C {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Major Pentatonic IV")
            {
                var scale = MajorPentatonic.ModeIV("C");
                var text = new Label() { Text = $"The C {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Major Pentatonic V")
            {
                var scale = MajorPentatonic.ModeV("C");
                var text = new Label() { Text = $"The C {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }


            // Melodic Minor Scales 


            if (type == "Melodic Minor I")
            {
                var scale = MelodicMinor.ModeI("C");
                var text = new Label() { Text = $"The C {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Minor II")
            {
                var scale = MelodicMinor.ModeII("C");
                var text = new Label() { Text = $"The C {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Minor III")
            {
                var scale = MelodicMinor.ModeIII("C");
                var text = new Label() { Text = $"The C {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Minor IV")
            {
                var scale = MelodicMinor.ModeIV("C");
                var text = new Label() { Text = $"The C {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Minor V")
            {
                var scale = MelodicMinor.ModeV("C");
                var text = new Label() { Text = $"The C {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Minor VI")
            {
                var scale = MelodicMinor.ModeVI("C");
                var text = new Label() { Text = $"The C {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Minor VII")
            {
                var scale = MelodicMinor.ModeVII("C");
                var text = new Label() { Text = $"The C {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }

            // Melodic Major 

            if (type == "Melodic Major I")
            {
                var scale = MelodicMajor.ModeI("C");
                var text = new Label() { Text = $"The C {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Major II")
            {
                var scale = MelodicMajor.ModeII("C");
                var text = new Label() { Text = $"The C {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Major III")
            {
                var scale = MelodicMajor.ModeIII("C");
                var text = new Label() { Text = $"The C {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Major IV")
            {
                var scale = MelodicMajor.ModeIV("C");
                var text = new Label() { Text = $"The C {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Major V")
            {
                var scale = MelodicMajor.ModeV("C");
                var text = new Label() { Text = $"The C {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Major VI")
            {
                var scale = MelodicMajor.ModeVI("C");
                var text = new Label() { Text = $"The C {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Major VII")
            {
                var scale = MelodicMajor.ModeVII("C");
                var text = new Label() { Text = $"The C {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }

            // Enigmatic Minor Scale 


            if (type == "Enigmatic Minor I")
            {
                var scale = EnigmaticMinor.ModeI("C");
                var text = new Label() { Text = $"The C {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Enigmatic Minor II")
            {
                var scale = EnigmaticMinor.ModeII("C");
                var text = new Label() { Text = $"The C {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Enigmatic Minor III")
            {
                var scale = EnigmaticMinor.ModeIII("C");
                var text = new Label() { Text = $"The C {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Enigmatic Minor IV")
            {
                var scale = EnigmaticMinor.ModeIV("C");
                var text = new Label() { Text = $"The C {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Enigmatic Minor V")
            {
                var scale = EnigmaticMinor.ModeV("C");
                var text = new Label() { Text = $"The C {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Enigmatic Minor VI")
            {
                var scale = EnigmaticMinor.ModeVI("C");
                var text = new Label() { Text = $"The C {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Enigmatic Minor VII")
            {
                var scale = EnigmaticMinor.ModeVII("C");
                var text = new Label() { Text = $"The C {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }

            // Whole Tone Scales 

            if (type == "Whole Tone I")
            {
                var scale = WholeTone.ModeI("C");
                var text = new Label() { Text = $"The C {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Whole Tone II")
            {
                var scale = WholeTone.ModeII("C");
                var text = new Label() { Text = $"The C {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Whole Tone III")
            {
                var scale = WholeTone.ModeIII("C");
                var text = new Label() { Text = $"The C {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Whole Tone IV")
            {
                var scale = WholeTone.ModeIV("C");
                var text = new Label() { Text = $"The C {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Whole Tone V")
            {
                var scale = WholeTone.ModeV("C");
                var text = new Label() { Text = $"The C {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Whole Tone VI")
            {
                var scale = WholeTone.ModeVI("C");
                var text = new Label() { Text = $"The C {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Whole Tone VII")
            {
                var scale = WholeTone.ModeVII("C");
                var text = new Label() { Text = $"The C {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }


            // Major Triads 

            if (type == "Triad I")
            {
                var chord = Triads.TriadI("C");
                var text = new Label() { Text = $"The C {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Triad II")
            {
                var chord = Triads.TriadII("C");
                var text = new Label() { Text = $"The C {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Triad III")
            {
                var chord = Triads.TriadIII("C");
                var text = new Label() { Text = $"The C {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Triad IV")
            {
                var chord = Triads.TriadIV("C");
                var text = new Label() { Text = $"The C {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Triad V")
            {
                var chord = Triads.TriadV("C");
                var text = new Label() { Text = $"The C {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Triad VI")
            {
                var chord = Triads.TriadVI("C");
                var text = new Label() { Text = $"The C {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Triad VII")
            {
                var chord = Triads.TriadVII("C");
                var text = new Label() { Text = $"The C {type} scale is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }


            // Dominant 7ths

            if (type == "Dom 7th I")
            {
                var chord = DomSevenths.SeventhI("C");
                var text = new Label() { Text = $"The C {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Dom 7th II")
            {
                var chord = DomSevenths.SeventhII("C");
                var text = new Label() { Text = $"The C {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Dom 7th III")
            {
                var chord = DomSevenths.SeventhIII("C");
                var text = new Label() { Text = $"The C {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Dom 7th IV")
            {
                var chord = DomSevenths.SeventhIV("C");
                var text = new Label() { Text = $"The C {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Dom 7th V")
            {
                var chord = DomSevenths.SeventhV("C");
                var text = new Label() { Text = $"The C {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Dom 7th VI")
            {
                var chord = DomSevenths.SeventhVI("C");
                var text = new Label() { Text = $"The C {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Dom 7th VII")
            {
                var chord = DomSevenths.SeventhVII("C");
                var text = new Label() { Text = $"The C {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }


            // Major and Minor 7ths

            if (type == "7th I")
            {
                var chord = Sevenths.SeventhI("C");
                var text = new Label() { Text = $"The C {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "7th II")
            {
                var chord = Sevenths.SeventhII("C");
                var text = new Label() { Text = $"The C {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "7th III")
            {
                var chord = Sevenths.SeventhIII("C");
                var text = new Label() { Text = $"The C {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "7th IV")
            {
                var chord = Sevenths.SeventhIV("C");
                var text = new Label() { Text = $"The C {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "7th V")
            {
                var chord = Sevenths.SeventhV("C");
                var text = new Label() { Text = $"The C {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "7th VI")
            {
                var chord = Sevenths.SeventhVI("C");
                var text = new Label() { Text = $"The C {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "7th VII")
            {
                var chord = Sevenths.SeventhVII("C");
                var text = new Label() { Text = $"The C {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }


            // Major and Minor 9ths

            if (type == "9th I")
            {
                var chord = Ninths.NinthI("C");
                var text = new Label() { Text = $"The C {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "9th II")
            {
                var chord = Ninths.NinthII("C");
                var text = new Label() { Text = $"The C {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "9th III")
            {
                var chord = Ninths.NinthIII("C");
                var text = new Label() { Text = $"The C {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "9th IV")
            {
                var chord = Ninths.NinthIV("C");
                var text = new Label() { Text = $"The C {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "9th V")
            {
                var chord = Ninths.NinthV("C");
                var text = new Label() { Text = $"The C {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "9th VI")
            {
                var chord = Ninths.NinthVI("C");
                var text = new Label() { Text = $"The C {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "9th VII")
            {
                var chord = Ninths.NinthVII("C");
                var text = new Label() { Text = $"The C {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
        }
    }
}