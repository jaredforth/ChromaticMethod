using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ChromaticMethod
{
    public partial class BMajor : ContentPage
    {
        public BMajor(string type)
        {
            InitializeComponent();

            var layout = new StackLayout() { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center };

            // Major Scales

            if (type == "Ionian")
            {
                var scale = Major.ModeI("B");
                var text = new Label() { Text = $"The B {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Dorian")
            {
                var scale = Major.ModeII("B");
                var text = new Label() { Text = $"The C# {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Phrygian")
            {
                var scale = Major.ModeIII("B");
                var text = new Label() { Text = $"The D# {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Lydian")
            {
                var scale = Major.ModeIV("B");
                var text = new Label() { Text = $"The E {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Mixolydian")
            {
                var scale = Major.ModeV("B");
                var text = new Label() { Text = $"The F# {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Aolian")
            {
                var scale = Major.ModeVI("B");
                var text = new Label() { Text = $"The G# {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Locrian")
            {
                var scale = Major.ModeVII("B");
                var text = new Label() { Text = $"The A# {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }

            // Minor Pentatonic Scales 

            if (type == "Minor Pentatonic I")
            {
                var scale = MinorPentatonic.ModeI("G#");
                var text = new Label() { Text = $"The G# {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Minor Pentatonic II")
            {
                var scale = MinorPentatonic.ModeII("G#");
                var text = new Label() { Text = $"The G# {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Minor Pentatonic III")
            {
                var scale = MinorPentatonic.ModeIII("G#");
                var text = new Label() { Text = $"The G# {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Minor Pentatonic IV")
            {
                var scale = MinorPentatonic.ModeIV("G#");
                var text = new Label() { Text = $"The G# {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Minor Pentatonic V")
            {
                var scale = MinorPentatonic.ModeV("G#");
                var text = new Label() { Text = $"The G# {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }

            // Major Pentatonic Scales 

            if (type == "Major Pentatonic I")
            {
                var scale = MajorPentatonic.ModeI("B");
                var text = new Label() { Text = $"The B {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Major Pentatonic II")
            {
                var scale = MajorPentatonic.ModeII("B");
                var text = new Label() { Text = $"The B {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Major Pentatonic III")
            {
                var scale = MajorPentatonic.ModeIII("B");
                var text = new Label() { Text = $"The B {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Major Pentatonic IV")
            {
                var scale = MajorPentatonic.ModeIV("B");
                var text = new Label() { Text = $"The B {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Major Pentatonic V")
            {
                var scale = MajorPentatonic.ModeV("B");
                var text = new Label() { Text = $"The B {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }


            // Melodic Minor Scales 


            if (type == "Melodic Minor I")
            {
                var scale = MelodicMinor.ModeI("B");
                var text = new Label() { Text = $"The B {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Minor II")
            {
                var scale = MelodicMinor.ModeII("B");
                var text = new Label() { Text = $"The B {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Minor III")
            {
                var scale = MelodicMinor.ModeIII("B");
                var text = new Label() { Text = $"The B {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Minor IV")
            {
                var scale = MelodicMinor.ModeIV("B");
                var text = new Label() { Text = $"The B {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Minor V")
            {
                var scale = MelodicMinor.ModeV("B");
                var text = new Label() { Text = $"The B {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Minor VI")
            {
                var scale = MelodicMinor.ModeVI("B");
                var text = new Label() { Text = $"The B {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Minor VII")
            {
                var scale = MelodicMinor.ModeVII("B");
                var text = new Label() { Text = $"The B {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }

            // Melodic Major 

            if (type == "Melodic Major I")
            {
                var scale = MelodicMajor.ModeI("B");
                var text = new Label() { Text = $"The B {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Major II")
            {
                var scale = MelodicMajor.ModeII("B");
                var text = new Label() { Text = $"The B {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Major III")
            {
                var scale = MelodicMajor.ModeIII("B");
                var text = new Label() { Text = $"The B {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Major IV")
            {
                var scale = MelodicMajor.ModeIV("B");
                var text = new Label() { Text = $"The B {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Major V")
            {
                var scale = MelodicMajor.ModeV("B");
                var text = new Label() { Text = $"The B {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Major VI")
            {
                var scale = MelodicMajor.ModeVI("B");
                var text = new Label() { Text = $"The B {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Major VII")
            {
                var scale = MelodicMajor.ModeVII("B");
                var text = new Label() { Text = $"The B {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }

            // Enigmatic Minor Scale 


            if (type == "Enigmatic Minor I")
            {
                var scale = EnigmaticMinor.ModeI("B");
                var text = new Label() { Text = $"The B {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Enigmatic Minor II")
            {
                var scale = EnigmaticMinor.ModeII("B");
                var text = new Label() { Text = $"The B {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Enigmatic Minor III")
            {
                var scale = EnigmaticMinor.ModeIII("B");
                var text = new Label() { Text = $"The B {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Enigmatic Minor IV")
            {
                var scale = EnigmaticMinor.ModeIV("B");
                var text = new Label() { Text = $"The B {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Enigmatic Minor V")
            {
                var scale = EnigmaticMinor.ModeV("B");
                var text = new Label() { Text = $"The B {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Enigmatic Minor VI")
            {
                var scale = EnigmaticMinor.ModeVI("B");
                var text = new Label() { Text = $"The B {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Enigmatic Minor VII")
            {
                var scale = EnigmaticMinor.ModeVII("B");
                var text = new Label() { Text = $"The B {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }

            // Whole Tone Scales 

            if (type == "Whole Tone I")
            {
                var scale = WholeTone.ModeI("B");
                var text = new Label() { Text = $"The B {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Whole Tone II")
            {
                var scale = WholeTone.ModeII("B");
                var text = new Label() { Text = $"The B {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Whole Tone III")
            {
                var scale = WholeTone.ModeIII("B");
                var text = new Label() { Text = $"The B {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Whole Tone IV")
            {
                var scale = WholeTone.ModeIV("B");
                var text = new Label() { Text = $"The B {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Whole Tone V")
            {
                var scale = WholeTone.ModeV("B");
                var text = new Label() { Text = $"The B {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Whole Tone VI")
            {
                var scale = WholeTone.ModeVI("B");
                var text = new Label() { Text = $"The B {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Whole Tone VII")
            {
                var scale = WholeTone.ModeVII("B");
                var text = new Label() { Text = $"The B {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }


            // Major Triads 

            if (type == "Triad I")
            {
                var chord = Triads.TriadI("B");
                var text = new Label() { Text = $"The B {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Triad II")
            {
                var chord = Triads.TriadII("B");
                var text = new Label() { Text = $"The B {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Triad III")
            {
                var chord = Triads.TriadIII("B");
                var text = new Label() { Text = $"The B {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Triad IV")
            {
                var chord = Triads.TriadIV("B");
                var text = new Label() { Text = $"The B {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Triad V")
            {
                var chord = Triads.TriadV("B");
                var text = new Label() { Text = $"The B {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Triad VI")
            {
                var chord = Triads.TriadVI("B");
                var text = new Label() { Text = $"The B {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Triad VII")
            {
                var chord = Triads.TriadVII("B");
                var text = new Label() { Text = $"The B {type} scale is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }


            // Dominant 7ths

            if (type == "Dom 7th I")
            {
                var chord = DomSevenths.SeventhI("B");
                var text = new Label() { Text = $"The B {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Dom 7th II")
            {
                var chord = DomSevenths.SeventhII("B");
                var text = new Label() { Text = $"The B {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Dom 7th III")
            {
                var chord = DomSevenths.SeventhIII("B");
                var text = new Label() { Text = $"The B {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Dom 7th IV")
            {
                var chord = DomSevenths.SeventhIV("B");
                var text = new Label() { Text = $"The B {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Dom 7th V")
            {
                var chord = DomSevenths.SeventhV("B");
                var text = new Label() { Text = $"The B {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Dom 7th VI")
            {
                var chord = DomSevenths.SeventhVI("B");
                var text = new Label() { Text = $"The B {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Dom 7th VII")
            {
                var chord = DomSevenths.SeventhVII("B");
                var text = new Label() { Text = $"The B {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }


            // Major and Minor 7ths

            if (type == "7th I")
            {
                var chord = Sevenths.SeventhI("B");
                var text = new Label() { Text = $"The B {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "7th II")
            {
                var chord = Sevenths.SeventhII("B");
                var text = new Label() { Text = $"The B {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "7th III")
            {
                var chord = Sevenths.SeventhIII("B");
                var text = new Label() { Text = $"The B {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "7th IV")
            {
                var chord = Sevenths.SeventhIV("B");
                var text = new Label() { Text = $"The B {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "7th V")
            {
                var chord = Sevenths.SeventhV("B");
                var text = new Label() { Text = $"The B {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "7th VI")
            {
                var chord = Sevenths.SeventhVI("B");
                var text = new Label() { Text = $"The B {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "7th VII")
            {
                var chord = Sevenths.SeventhVII("B");
                var text = new Label() { Text = $"The B {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }

            // Major and Minor 9ths

            if (type == "9th I")
            {
                var chord = Ninths.NinthI("B");
                var text = new Label() { Text = $"The B {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "9th II")
            {
                var chord = Ninths.NinthII("B");
                var text = new Label() { Text = $"The B {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "9th III")
            {
                var chord = Ninths.NinthIII("B");
                var text = new Label() { Text = $"The B {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "9th IV")
            {
                var chord = Ninths.NinthIV("B");
                var text = new Label() { Text = $"The B {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "9th V")
            {
                var chord = Ninths.NinthV("B");
                var text = new Label() { Text = $"The B {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "9th VI")
            {
                var chord = Ninths.NinthVI("B");
                var text = new Label() { Text = $"The B {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "9th VII")
            {
                var chord = Ninths.NinthVII("B");
                var text = new Label() { Text = $"The B {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }


            // Dominant 9ths

            if (type == "Dom 9th I")
            {
                var chord = DomNinths.NinthI("B");
                var text = new Label() { Text = $"The B {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Dom 9th II")
            {
                var chord = DomNinths.NinthII("B");
                var text = new Label() { Text = $"The B {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Dom 9th III")
            {
                var chord = DomNinths.NinthIII("B");
                var text = new Label() { Text = $"The B {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Dom 9th IV")
            {
                var chord = DomNinths.NinthIV("B");
                var text = new Label() { Text = $"The B {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Dom 9th V")
            {
                var chord = DomNinths.NinthV("B");
                var text = new Label() { Text = $"The B {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Dom 9th VI")
            {
                var chord = DomNinths.NinthVI("B");
                var text = new Label() { Text = $"The B {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Dom 9th VII")
            {
                var chord = DomNinths.NinthVII("B");
                var text = new Label() { Text = $"The B {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
        }
    }
}