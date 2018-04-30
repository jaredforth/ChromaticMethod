using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ChromaticMethod
{
    public partial class EMajor : ContentPage
    {
        public EMajor(string type)
        {
            InitializeComponent();

            var layout = new StackLayout() { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center };

            // Major Scales

            if (type == "Ionian")
            {
                var scale = Major.ModeI("E");
                var text = new Label() { Text = $"The E {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Dorian")
            {
                var scale = Major.ModeII("E");
                var text = new Label() { Text = $"The F# {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Phrygian")
            {
                var scale = Major.ModeIII("E");
                var text = new Label() { Text = $"The G# {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Lydian")
            {
                var scale = Major.ModeIV("E");
                var text = new Label() { Text = $"The A {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Mixolydian")
            {
                var scale = Major.ModeV("E");
                var text = new Label() { Text = $"The B {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Aolian")
            {
                var scale = Major.ModeVI("E");
                var text = new Label() { Text = $"The C# {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Locrian")
            {
                var scale = Major.ModeVII("E");
                var text = new Label() { Text = $"The D# {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }

            // Minor Pentatonic Scales 

            if (type == "Minor Pentatonic I")
            {
                var scale = MinorPentatonic.ModeI("C#");
                var text = new Label() { Text = $"The C# {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Minor Pentatonic II")
            {
                var scale = MinorPentatonic.ModeII("C#");
                var text = new Label() { Text = $"The C# {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Minor Pentatonic III")
            {
                var scale = MinorPentatonic.ModeIII("C#");
                var text = new Label() { Text = $"The C# {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Minor Pentatonic IV")
            {
                var scale = MinorPentatonic.ModeIV("C#");
                var text = new Label() { Text = $"The C# {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Minor Pentatonic V")
            {
                var scale = MinorPentatonic.ModeV("C#");
                var text = new Label() { Text = $"The C# {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }

            // Major Pentatonic Scales 

            if (type == "Major Pentatonic I")
            {
                var scale = MajorPentatonic.ModeI("E");
                var text = new Label() { Text = $"The E {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Major Pentatonic II")
            {
                var scale = MajorPentatonic.ModeII("E");
                var text = new Label() { Text = $"The E {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Major Pentatonic III")
            {
                var scale = MajorPentatonic.ModeIII("E");
                var text = new Label() { Text = $"The E {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Major Pentatonic IV")
            {
                var scale = MajorPentatonic.ModeIV("E");
                var text = new Label() { Text = $"The E {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Major Pentatonic V")
            {
                var scale = MajorPentatonic.ModeV("E");
                var text = new Label() { Text = $"The E {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }


            // Melodic Minor Scales 


            if (type == "Melodic Minor I")
            {
                var scale = MelodicMinor.ModeI("E");
                var text = new Label() { Text = $"The E {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Minor II")
            {
                var scale = MelodicMinor.ModeII("E");
                var text = new Label() { Text = $"The E {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Minor III")
            {
                var scale = MelodicMinor.ModeIII("E");
                var text = new Label() { Text = $"The E {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Minor IV")
            {
                var scale = MelodicMinor.ModeIV("E");
                var text = new Label() { Text = $"The E {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Minor V")
            {
                var scale = MelodicMinor.ModeV("E");
                var text = new Label() { Text = $"The E {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Minor VI")
            {
                var scale = MelodicMinor.ModeVI("E");
                var text = new Label() { Text = $"The E {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Minor VII")
            {
                var scale = MelodicMinor.ModeVII("E");
                var text = new Label() { Text = $"The E {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }

            // Melodic Major 

            if (type == "Melodic Major I")
            {
                var scale = MelodicMajor.ModeI("E");
                var text = new Label() { Text = $"The E {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Major II")
            {
                var scale = MelodicMajor.ModeII("E");
                var text = new Label() { Text = $"The E {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Major III")
            {
                var scale = MelodicMajor.ModeIII("E");
                var text = new Label() { Text = $"The E {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Major IV")
            {
                var scale = MelodicMajor.ModeIV("E");
                var text = new Label() { Text = $"The E {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Major V")
            {
                var scale = MelodicMajor.ModeV("E");
                var text = new Label() { Text = $"The E {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Major VI")
            {
                var scale = MelodicMajor.ModeVI("E");
                var text = new Label() { Text = $"The E {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Major VII")
            {
                var scale = MelodicMajor.ModeVII("E");
                var text = new Label() { Text = $"The E {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }

            // Enigmatic Minor Scale 


            if (type == "Enigmatic Minor I")
            {
                var scale = EnigmaticMinor.ModeI("E");
                var text = new Label() { Text = $"The E {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Enigmatic Minor II")
            {
                var scale = EnigmaticMinor.ModeII("E");
                var text = new Label() { Text = $"The E {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Enigmatic Minor III")
            {
                var scale = EnigmaticMinor.ModeIII("E");
                var text = new Label() { Text = $"The E {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Enigmatic Minor IV")
            {
                var scale = EnigmaticMinor.ModeIV("E");
                var text = new Label() { Text = $"The E {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Enigmatic Minor V")
            {
                var scale = EnigmaticMinor.ModeV("E");
                var text = new Label() { Text = $"The E {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Enigmatic Minor VI")
            {
                var scale = EnigmaticMinor.ModeVI("E");
                var text = new Label() { Text = $"The E {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Enigmatic Minor VII")
            {
                var scale = EnigmaticMinor.ModeVII("E");
                var text = new Label() { Text = $"The E {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }

            // Whole Tone Scales 

            if (type == "Whole Tone I")
            {
                var scale = WholeTone.ModeI("E");
                var text = new Label() { Text = $"The E {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Whole Tone II")
            {
                var scale = WholeTone.ModeII("E");
                var text = new Label() { Text = $"The E {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Whole Tone III")
            {
                var scale = WholeTone.ModeIII("E");
                var text = new Label() { Text = $"The E {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Whole Tone IV")
            {
                var scale = WholeTone.ModeIV("E");
                var text = new Label() { Text = $"The E {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Whole Tone V")
            {
                var scale = WholeTone.ModeV("E");
                var text = new Label() { Text = $"The E {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Whole Tone VI")
            {
                var scale = WholeTone.ModeVI("E");
                var text = new Label() { Text = $"The E {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Whole Tone VII")
            {
                var scale = WholeTone.ModeVII("E");
                var text = new Label() { Text = $"The E {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }


            // Major Triads 

            if (type == "Triad I")
            {
                var chord = Triads.TriadI("E");
                var text = new Label() { Text = $"The E {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Triad II")
            {
                var chord = Triads.TriadII("E");
                var text = new Label() { Text = $"The E {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Triad III")
            {
                var chord = Triads.TriadIII("E");
                var text = new Label() { Text = $"The E {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Triad IV")
            {
                var chord = Triads.TriadIV("E");
                var text = new Label() { Text = $"The E {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Triad V")
            {
                var chord = Triads.TriadV("E");
                var text = new Label() { Text = $"The E {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Triad VI")
            {
                var chord = Triads.TriadVI("E");
                var text = new Label() { Text = $"The E {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Triad VII")
            {
                var chord = Triads.TriadVII("E");
                var text = new Label() { Text = $"The E {type} scale is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }


            // Dominant 7ths

            if (type == "Dom 7th I")
            {
                var chord = DomSevenths.SeventhI("E");
                var text = new Label() { Text = $"The E {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Dom 7th II")
            {
                var chord = DomSevenths.SeventhII("E");
                var text = new Label() { Text = $"The E {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Dom 7th III")
            {
                var chord = DomSevenths.SeventhIII("E");
                var text = new Label() { Text = $"The E {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Dom 7th IV")
            {
                var chord = DomSevenths.SeventhIV("E");
                var text = new Label() { Text = $"The E {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Dom 7th V")
            {
                var chord = DomSevenths.SeventhV("E");
                var text = new Label() { Text = $"The E {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Dom 7th VI")
            {
                var chord = DomSevenths.SeventhVI("E");
                var text = new Label() { Text = $"The E {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Dom 7th VII")
            {
                var chord = DomSevenths.SeventhVII("E");
                var text = new Label() { Text = $"The E {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }


            // Major and Minor 7ths

            if (type == "7th I")
            {
                var chord = Sevenths.SeventhI("E");
                var text = new Label() { Text = $"The E {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "7th II")
            {
                var chord = Sevenths.SeventhII("E");
                var text = new Label() { Text = $"The E {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "7th III")
            {
                var chord = Sevenths.SeventhIII("E");
                var text = new Label() { Text = $"The E {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "7th IV")
            {
                var chord = Sevenths.SeventhIV("E");
                var text = new Label() { Text = $"The E {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "7th V")
            {
                var chord = Sevenths.SeventhV("E");
                var text = new Label() { Text = $"The E {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "7th VI")
            {
                var chord = Sevenths.SeventhVI("E");
                var text = new Label() { Text = $"The E {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "7th VII")
            {
                var chord = Sevenths.SeventhVII("E");
                var text = new Label() { Text = $"The E {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }

            // Major and Minor 9ths

            if (type == "9th I")
            {
                var chord = Ninths.NinthI("E");
                var text = new Label() { Text = $"The E {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "9th II")
            {
                var chord = Ninths.NinthII("E");
                var text = new Label() { Text = $"The E {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "9th III")
            {
                var chord = Ninths.NinthIII("E");
                var text = new Label() { Text = $"The E {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "9th IV")
            {
                var chord = Ninths.NinthIV("E");
                var text = new Label() { Text = $"The E {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "9th V")
            {
                var chord = Ninths.NinthV("E");
                var text = new Label() { Text = $"The E {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "9th VI")
            {
                var chord = Ninths.NinthVI("E");
                var text = new Label() { Text = $"The E {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "9th VII")
            {
                var chord = Ninths.NinthVII("E");
                var text = new Label() { Text = $"The E {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }


            // Dominant 9ths

            if (type == "Dom 9th I")
            {
                var chord = DomNinths.NinthI("E");
                var text = new Label() { Text = $"The E {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Dom 9th II")
            {
                var chord = DomNinths.NinthII("E");
                var text = new Label() { Text = $"The E {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Dom 9th III")
            {
                var chord = DomNinths.NinthIII("E");
                var text = new Label() { Text = $"The E {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Dom 9th IV")
            {
                var chord = DomNinths.NinthIV("E");
                var text = new Label() { Text = $"The E {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Dom 9th V")
            {
                var chord = DomNinths.NinthV("E");
                var text = new Label() { Text = $"The E {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Dom 9th VI")
            {
                var chord = DomNinths.NinthVI("E");
                var text = new Label() { Text = $"The E {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Dom 9th VII")
            {
                var chord = DomNinths.NinthVII("E");
                var text = new Label() { Text = $"The E {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
        }
    }
}