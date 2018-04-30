using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ChromaticMethod
{
    public partial class GMajor : ContentPage
    {
        public GMajor(string type)
        {
            InitializeComponent();

            var layout = new StackLayout() { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center };

            // Major Scales

            if (type == "Ionian")
            {
                var scale = Major.ModeI("G");
                var text = new Label() { Text = $"The G {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Dorian")
            {
                var scale = Major.ModeII("G");
                var text = new Label() { Text = $"The A {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Phrygian")
            {
                var scale = Major.ModeIII("G");
                var text = new Label() { Text = $"The B {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Lydian")
            {
                var scale = Major.ModeIV("G");
                var text = new Label() { Text = $"The C {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Mixolydian")
            {
                var scale = Major.ModeV("G");
                var text = new Label() { Text = $"The D {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Aolian")
            {
                var scale = Major.ModeVI("G");
                var text = new Label() { Text = $"The E {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Locrian")
            {
                var scale = Major.ModeVII("G");
                var text = new Label() { Text = $"The F# {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }

            // Minor Pentatonic Scales 

            if (type == "Minor Pentatonic I")
            {
                var scale = MinorPentatonic.ModeI("E");
                var text = new Label() { Text = $"The E {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Minor Pentatonic II")
            {
                var scale = MinorPentatonic.ModeII("E");
                var text = new Label() { Text = $"The E {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Minor Pentatonic III")
            {
                var scale = MinorPentatonic.ModeIII("E");
                var text = new Label() { Text = $"The E {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Minor Pentatonic IV")
            {
                var scale = MinorPentatonic.ModeIV("E");
                var text = new Label() { Text = $"The E {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Minor Pentatonic V")
            {
                var scale = MinorPentatonic.ModeV("E");
                var text = new Label() { Text = $"The E {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }

            // Major Pentatonic Scales 

            if (type == "Major Pentatonic I")
            {
                var scale = MajorPentatonic.ModeI("G");
                var text = new Label() { Text = $"The G {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Major Pentatonic II")
            {
                var scale = MajorPentatonic.ModeII("G");
                var text = new Label() { Text = $"The G {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Major Pentatonic III")
            {
                var scale = MajorPentatonic.ModeIII("G");
                var text = new Label() { Text = $"The G {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Major Pentatonic IV")
            {
                var scale = MajorPentatonic.ModeIV("G");
                var text = new Label() { Text = $"The G {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Major Pentatonic V")
            {
                var scale = MajorPentatonic.ModeV("G");
                var text = new Label() { Text = $"The G {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }


            // Melodic Minor Scales 


            if (type == "Melodic Minor I")
            {
                var scale = MelodicMinor.ModeI("G");
                var text = new Label() { Text = $"The G {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Minor II")
            {
                var scale = MelodicMinor.ModeII("G");
                var text = new Label() { Text = $"The G {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Minor III")
            {
                var scale = MelodicMinor.ModeIII("G");
                var text = new Label() { Text = $"The G {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Minor IV")
            {
                var scale = MelodicMinor.ModeIV("G");
                var text = new Label() { Text = $"The G {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Minor V")
            {
                var scale = MelodicMinor.ModeV("G");
                var text = new Label() { Text = $"The G {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Minor VI")
            {
                var scale = MelodicMinor.ModeVI("G");
                var text = new Label() { Text = $"The G {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Minor VII")
            {
                var scale = MelodicMinor.ModeVII("G");
                var text = new Label() { Text = $"The G {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }

            // Melodic Major 

            if (type == "Melodic Major I")
            {
                var scale = MelodicMajor.ModeI("G");
                var text = new Label() { Text = $"The G {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Major II")
            {
                var scale = MelodicMajor.ModeII("G");
                var text = new Label() { Text = $"The G {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Major III")
            {
                var scale = MelodicMajor.ModeIII("G");
                var text = new Label() { Text = $"The G {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Major IV")
            {
                var scale = MelodicMajor.ModeIV("G");
                var text = new Label() { Text = $"The G {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Major V")
            {
                var scale = MelodicMajor.ModeV("G");
                var text = new Label() { Text = $"The G {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Major VI")
            {
                var scale = MelodicMajor.ModeVI("G");
                var text = new Label() { Text = $"The G {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Major VII")
            {
                var scale = MelodicMajor.ModeVII("G");
                var text = new Label() { Text = $"The G {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }

            // Enigmatic Minor Scale 


            if (type == "Enigmatic Minor I")
            {
                var scale = EnigmaticMinor.ModeI("G");
                var text = new Label() { Text = $"The G {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Enigmatic Minor II")
            {
                var scale = EnigmaticMinor.ModeII("G");
                var text = new Label() { Text = $"The G {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Enigmatic Minor III")
            {
                var scale = EnigmaticMinor.ModeIII("G");
                var text = new Label() { Text = $"The G {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Enigmatic Minor IV")
            {
                var scale = EnigmaticMinor.ModeIV("G");
                var text = new Label() { Text = $"The G {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Enigmatic Minor V")
            {
                var scale = EnigmaticMinor.ModeV("G");
                var text = new Label() { Text = $"The G {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Enigmatic Minor VI")
            {
                var scale = EnigmaticMinor.ModeVI("G");
                var text = new Label() { Text = $"The G {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Enigmatic Minor VII")
            {
                var scale = EnigmaticMinor.ModeVII("G");
                var text = new Label() { Text = $"The G {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }

            // Whole Tone Scales 

            if (type == "Whole Tone I")
            {
                var scale = WholeTone.ModeI("G");
                var text = new Label() { Text = $"The G {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Whole Tone II")
            {
                var scale = WholeTone.ModeII("G");
                var text = new Label() { Text = $"The G {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Whole Tone III")
            {
                var scale = WholeTone.ModeIII("G");
                var text = new Label() { Text = $"The G {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Whole Tone IV")
            {
                var scale = WholeTone.ModeIV("G");
                var text = new Label() { Text = $"The G {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Whole Tone V")
            {
                var scale = WholeTone.ModeV("G");
                var text = new Label() { Text = $"The G {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Whole Tone VI")
            {
                var scale = WholeTone.ModeVI("G");
                var text = new Label() { Text = $"The G {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Whole Tone VII")
            {
                var scale = WholeTone.ModeVII("G");
                var text = new Label() { Text = $"The G {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }


            // Major Triads 

            if (type == "Triad I")
            {
                var chord = Triads.TriadI("G");
                var text = new Label() { Text = $"The G {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Triad II")
            {
                var chord = Triads.TriadII("G");
                var text = new Label() { Text = $"The G {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Triad III")
            {
                var chord = Triads.TriadIII("G");
                var text = new Label() { Text = $"The G {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Triad IV")
            {
                var chord = Triads.TriadIV("G");
                var text = new Label() { Text = $"The G {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Triad V")
            {
                var chord = Triads.TriadV("G");
                var text = new Label() { Text = $"The G {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Triad VI")
            {
                var chord = Triads.TriadVI("G");
                var text = new Label() { Text = $"The G {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Triad VII")
            {
                var chord = Triads.TriadVII("G");
                var text = new Label() { Text = $"The G {type} scale is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }


            // Dominant 7ths

            if (type == "Dom 7th I")
            {
                var chord = DomSevenths.SeventhI("G");
                var text = new Label() { Text = $"The G {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Dom 7th II")
            {
                var chord = DomSevenths.SeventhII("G");
                var text = new Label() { Text = $"The G {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Dom 7th III")
            {
                var chord = DomSevenths.SeventhIII("G");
                var text = new Label() { Text = $"The G {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Dom 7th IV")
            {
                var chord = DomSevenths.SeventhIV("G");
                var text = new Label() { Text = $"The G {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Dom 7th V")
            {
                var chord = DomSevenths.SeventhV("G");
                var text = new Label() { Text = $"The G {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Dom 7th VI")
            {
                var chord = DomSevenths.SeventhVI("G");
                var text = new Label() { Text = $"The G {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Dom 7th VII")
            {
                var chord = DomSevenths.SeventhVII("G");
                var text = new Label() { Text = $"The G {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }


            // Major and Minor 7ths

            if (type == "7th I")
            {
                var chord = Sevenths.SeventhI("G");
                var text = new Label() { Text = $"The G {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "7th II")
            {
                var chord = Sevenths.SeventhII("G");
                var text = new Label() { Text = $"The G {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "7th III")
            {
                var chord = Sevenths.SeventhIII("G");
                var text = new Label() { Text = $"The G {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "7th IV")
            {
                var chord = Sevenths.SeventhIV("G");
                var text = new Label() { Text = $"The G {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "7th V")
            {
                var chord = Sevenths.SeventhV("G");
                var text = new Label() { Text = $"The G {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "7th VI")
            {
                var chord = Sevenths.SeventhVI("G");
                var text = new Label() { Text = $"The G {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "7th VII")
            {
                var chord = Sevenths.SeventhVII("G");
                var text = new Label() { Text = $"The G {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }

            // Major and Minor 9ths

            if (type == "9th I")
            {
                var chord = Ninths.NinthI("G");
                var text = new Label() { Text = $"The G {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "9th II")
            {
                var chord = Ninths.NinthII("G");
                var text = new Label() { Text = $"The G {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "9th III")
            {
                var chord = Ninths.NinthIII("G");
                var text = new Label() { Text = $"The G {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "9th IV")
            {
                var chord = Ninths.NinthIV("G");
                var text = new Label() { Text = $"The G {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "9th V")
            {
                var chord = Ninths.NinthV("G");
                var text = new Label() { Text = $"The G {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "9th VI")
            {
                var chord = Ninths.NinthVI("G");
                var text = new Label() { Text = $"The G {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "9th VII")
            {
                var chord = Ninths.NinthVII("G");
                var text = new Label() { Text = $"The G {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }


            // Dominant 9ths

            if (type == "Dom 9th I")
            {
                var chord = DomNinths.NinthI("G");
                var text = new Label() { Text = $"The G {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Dom 9th II")
            {
                var chord = DomNinths.NinthII("G");
                var text = new Label() { Text = $"The G {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Dom 9th III")
            {
                var chord = DomNinths.NinthIII("G");
                var text = new Label() { Text = $"The G {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Dom 9th IV")
            {
                var chord = DomNinths.NinthIV("G");
                var text = new Label() { Text = $"The G {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Dom 9th V")
            {
                var chord = DomNinths.NinthV("G");
                var text = new Label() { Text = $"The G {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Dom 9th VI")
            {
                var chord = DomNinths.NinthVI("G");
                var text = new Label() { Text = $"The G {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Dom 9th VII")
            {
                var chord = DomNinths.NinthVII("G");
                var text = new Label() { Text = $"The G {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
        }
    }
}