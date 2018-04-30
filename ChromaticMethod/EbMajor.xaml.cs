using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ChromaticMethod
{
    public partial class EbMajor : ContentPage
    {
        public EbMajor(string type)
        {
            InitializeComponent();

            var layout = new StackLayout() { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center };

            // Major Scales

            if (type == "Ionian")
            {
                var scale = Major.ModeI("Eb");
                var text = new Label() { Text = $"The Eb {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Dorian")
            {
                var scale = Major.ModeII("Eb");
                var text = new Label() { Text = $"The F {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Phrygian")
            {
                var scale = Major.ModeIII("Eb");
                var text = new Label() { Text = $"The G {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Lydian")
            {
                var scale = Major.ModeIV("Eb");
                var text = new Label() { Text = $"The Ab {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Mixolydian")
            {
                var scale = Major.ModeV("Eb");
                var text = new Label() { Text = $"The Bb {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Aolian")
            {
                var scale = Major.ModeVI("Eb");
                var text = new Label() { Text = $"The C {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Locrian")
            {
                var scale = Major.ModeVII("Eb");
                var text = new Label() { Text = $"The D {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }

            // Minor Pentatonic Scales 

            if (type == "Minor Pentatonic I")
            {
                var scale = MinorPentatonic.ModeI("C");
                var text = new Label() { Text = $"The C {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Minor Pentatonic II")
            {
                var scale = MinorPentatonic.ModeII("C");
                var text = new Label() { Text = $"The C {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Minor Pentatonic III")
            {
                var scale = MinorPentatonic.ModeIII("C");
                var text = new Label() { Text = $"The C {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Minor Pentatonic IV")
            {
                var scale = MinorPentatonic.ModeIV("C");
                var text = new Label() { Text = $"The C {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Minor Pentatonic V")
            {
                var scale = MinorPentatonic.ModeV("C");
                var text = new Label() { Text = $"The C {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }

            // Major Pentatonic Scales 

            if (type == "Major Pentatonic I")
            {
                var scale = MajorPentatonic.ModeI("Eb");
                var text = new Label() { Text = $"The Eb {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Major Pentatonic II")
            {
                var scale = MajorPentatonic.ModeII("Eb");
                var text = new Label() { Text = $"The Eb {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Major Pentatonic III")
            {
                var scale = MajorPentatonic.ModeIII("Eb");
                var text = new Label() { Text = $"The Eb {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Major Pentatonic IV")
            {
                var scale = MajorPentatonic.ModeIV("Eb");
                var text = new Label() { Text = $"The Eb {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Major Pentatonic V")
            {
                var scale = MajorPentatonic.ModeV("Eb");
                var text = new Label() { Text = $"The Eb {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }


            // Melodic Minor Scales 


            if (type == "Melodic Minor I")
            {
                var scale = MelodicMinor.ModeI("Eb");
                var text = new Label() { Text = $"The Eb {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Minor II")
            {
                var scale = MelodicMinor.ModeII("Eb");
                var text = new Label() { Text = $"The Eb {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Minor III")
            {
                var scale = MelodicMinor.ModeIII("Eb");
                var text = new Label() { Text = $"The Eb {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Minor IV")
            {
                var scale = MelodicMinor.ModeIV("Eb");
                var text = new Label() { Text = $"The Eb {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Minor V")
            {
                var scale = MelodicMinor.ModeV("Eb");
                var text = new Label() { Text = $"The Eb {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Minor VI")
            {
                var scale = MelodicMinor.ModeVI("Eb");
                var text = new Label() { Text = $"The Eb {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Minor VII")
            {
                var scale = MelodicMinor.ModeVII("Eb");
                var text = new Label() { Text = $"The Eb {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }

            // Melodic Major 

            if (type == "Melodic Major I")
            {
                var scale = MelodicMajor.ModeI("Eb");
                var text = new Label() { Text = $"The Eb {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Major II")
            {
                var scale = MelodicMajor.ModeII("Eb");
                var text = new Label() { Text = $"The Eb {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Major III")
            {
                var scale = MelodicMajor.ModeIII("Eb");
                var text = new Label() { Text = $"The Eb {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Major IV")
            {
                var scale = MelodicMajor.ModeIV("Eb");
                var text = new Label() { Text = $"The Eb {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Major V")
            {
                var scale = MelodicMajor.ModeV("Eb");
                var text = new Label() { Text = $"The Eb {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Major VI")
            {
                var scale = MelodicMajor.ModeVI("Eb");
                var text = new Label() { Text = $"The Eb {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Melodic Major VII")
            {
                var scale = MelodicMajor.ModeVII("Eb");
                var text = new Label() { Text = $"The Eb {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }

            // Enigmatic Minor Scale 


            if (type == "Enigmatic Minor I")
            {
                var scale = EnigmaticMinor.ModeI("Eb");
                var text = new Label() { Text = $"The Eb {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Enigmatic Minor II")
            {
                var scale = EnigmaticMinor.ModeII("Eb");
                var text = new Label() { Text = $"The Eb {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Enigmatic Minor III")
            {
                var scale = EnigmaticMinor.ModeIII("Eb");
                var text = new Label() { Text = $"The Eb {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Enigmatic Minor IV")
            {
                var scale = EnigmaticMinor.ModeIV("Eb");
                var text = new Label() { Text = $"The Eb {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Enigmatic Minor V")
            {
                var scale = EnigmaticMinor.ModeV("Eb");
                var text = new Label() { Text = $"The Eb {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Enigmatic Minor VI")
            {
                var scale = EnigmaticMinor.ModeVI("Eb");
                var text = new Label() { Text = $"The Eb {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Enigmatic Minor VII")
            {
                var scale = EnigmaticMinor.ModeVII("Eb");
                var text = new Label() { Text = $"The Eb {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }

            // Whole Tone Scales 

            if (type == "Whole Tone I")
            {
                var scale = WholeTone.ModeI("Eb");
                var text = new Label() { Text = $"The Eb {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Whole Tone II")
            {
                var scale = WholeTone.ModeII("Eb");
                var text = new Label() { Text = $"The Eb {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Whole Tone III")
            {
                var scale = WholeTone.ModeIII("Eb");
                var text = new Label() { Text = $"The Eb {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Whole Tone IV")
            {
                var scale = WholeTone.ModeIV("Eb");
                var text = new Label() { Text = $"The Eb {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Whole Tone V")
            {
                var scale = WholeTone.ModeV("Eb");
                var text = new Label() { Text = $"The Eb {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Whole Tone VI")
            {
                var scale = WholeTone.ModeVI("Eb");
                var text = new Label() { Text = $"The Eb {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }
            else if (type == "Whole Tone VII")
            {
                var scale = WholeTone.ModeVII("Eb");
                var text = new Label() { Text = $"The Eb {type} scale is: \n {scale}" };
                layout.Children.Add(text);
                Content = layout;
            }


            // Major Triads 

            if (type == "Triad I")
            {
                var chord = Triads.TriadI("Eb");
                var text = new Label() { Text = $"The Eb {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Triad II")
            {
                var chord = Triads.TriadII("Eb");
                var text = new Label() { Text = $"The Eb {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Triad III")
            {
                var chord = Triads.TriadIII("Eb");
                var text = new Label() { Text = $"The Eb {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Triad IV")
            {
                var chord = Triads.TriadIV("Eb");
                var text = new Label() { Text = $"The Eb {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Triad V")
            {
                var chord = Triads.TriadV("Eb");
                var text = new Label() { Text = $"The Eb {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Triad VI")
            {
                var chord = Triads.TriadVI("Eb");
                var text = new Label() { Text = $"The Eb {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Triad VII")
            {
                var chord = Triads.TriadVII("Eb");
                var text = new Label() { Text = $"The Eb {type} scale is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }


            // Dominant 7ths

            if (type == "Dom 7th I")
            {
                var chord = DomSevenths.SeventhI("Eb");
                var text = new Label() { Text = $"The Eb {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Dom 7th II")
            {
                var chord = DomSevenths.SeventhII("Eb");
                var text = new Label() { Text = $"The Eb {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Dom 7th III")
            {
                var chord = DomSevenths.SeventhIII("Eb");
                var text = new Label() { Text = $"The Eb {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Dom 7th IV")
            {
                var chord = DomSevenths.SeventhIV("Eb");
                var text = new Label() { Text = $"The Eb {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Dom 7th V")
            {
                var chord = DomSevenths.SeventhV("Eb");
                var text = new Label() { Text = $"The Eb {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Dom 7th VI")
            {
                var chord = DomSevenths.SeventhVI("Eb");
                var text = new Label() { Text = $"The Eb {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Dom 7th VII")
            {
                var chord = DomSevenths.SeventhVII("Eb");
                var text = new Label() { Text = $"The Eb {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }


            // Major and Minor 7ths

            if (type == "7th I")
            {
                var chord = Sevenths.SeventhI("Eb");
                var text = new Label() { Text = $"The Eb {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "7th II")
            {
                var chord = Sevenths.SeventhII("Eb");
                var text = new Label() { Text = $"The Eb {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "7th III")
            {
                var chord = Sevenths.SeventhIII("Eb");
                var text = new Label() { Text = $"The Eb {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "7th IV")
            {
                var chord = Sevenths.SeventhIV("Eb");
                var text = new Label() { Text = $"The Eb {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "7th V")
            {
                var chord = Sevenths.SeventhV("Eb");
                var text = new Label() { Text = $"The Eb {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "7th VI")
            {
                var chord = Sevenths.SeventhVI("Eb");
                var text = new Label() { Text = $"The Eb {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "7th VII")
            {
                var chord = Sevenths.SeventhVII("Eb");
                var text = new Label() { Text = $"The Eb {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }

            // Major and Minor 9ths

            if (type == "9th I")
            {
                var chord = Ninths.NinthI("Eb");
                var text = new Label() { Text = $"The Eb {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "9th II")
            {
                var chord = Ninths.NinthII("Eb");
                var text = new Label() { Text = $"The Eb {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "9th III")
            {
                var chord = Ninths.NinthIII("Eb");
                var text = new Label() { Text = $"The Eb {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "9th IV")
            {
                var chord = Ninths.NinthIV("Eb");
                var text = new Label() { Text = $"The Eb {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "9th V")
            {
                var chord = Ninths.NinthV("Eb");
                var text = new Label() { Text = $"The Eb {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "9th VI")
            {
                var chord = Ninths.NinthVI("Eb");
                var text = new Label() { Text = $"The Eb {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "9th VII")
            {
                var chord = Ninths.NinthVII("Eb");
                var text = new Label() { Text = $"The Eb {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }


            // Dominant 9ths

            if (type == "Dom 9th I")
            {
                var chord = DomNinths.NinthI("Eb");
                var text = new Label() { Text = $"The Eb {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Dom 9th II")
            {
                var chord = DomNinths.NinthII("Eb");
                var text = new Label() { Text = $"The Eb {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Dom 9th III")
            {
                var chord = DomNinths.NinthIII("Eb");
                var text = new Label() { Text = $"The Eb {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Dom 9th IV")
            {
                var chord = DomNinths.NinthIV("Eb");
                var text = new Label() { Text = $"The Eb {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Dom 9th V")
            {
                var chord = DomNinths.NinthV("Eb");
                var text = new Label() { Text = $"The Eb {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Dom 9th VI")
            {
                var chord = DomNinths.NinthVI("Eb");
                var text = new Label() { Text = $"The Eb {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
            if (type == "Dom 9th VII")
            {
                var chord = DomNinths.NinthVII("Eb");
                var text = new Label() { Text = $"The Eb {type} chord is: \n {chord}" };
                layout.Children.Add(text);
                Content = layout;
            }
        }
    }
}
