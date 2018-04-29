using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ChromaticMethod
{
    public partial class ChordFinder : ContentPage
    {
        public string Key;

        public ChordFinder(string key)
        {
            InitializeComponent();

            Key = key;
        }

        // Triads 

        async void TriadI_Clicked(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Triad I"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CMajor("Triad I"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new CMajor("Triad I"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Triad I"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new CMajor("Triad I"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new CMajor("Triad I"));
                    break;
                case "E":
                    await Navigation.PushAsync(new CMajor("Triad I"));
                    break;
                case "F":
                    await Navigation.PushAsync(new CMajor("Triad I"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new CMajor("Triad I"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new CMajor("Triad I"));
                    break;
                case "G":
                    await Navigation.PushAsync(new CMajor("Triad I"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new CMajor("Triad I"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new CMajor("Triad I"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new CMajor("Triad I"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Triad I"));
                    break;
                case "B":
                    await Navigation.PushAsync(new CMajor("Triad I"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void TriadII_Clicked(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Triad II"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CMajor("Triad II"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new CMajor("Triad II"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Triad II"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new CMajor("Triad II"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new CMajor("Triad II"));
                    break;
                case "E":
                    await Navigation.PushAsync(new CMajor("Triad II"));
                    break;
                case "F":
                    await Navigation.PushAsync(new CMajor("Triad II"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new CMajor("Triad II"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new CMajor("Triad II"));
                    break;
                case "G":
                    await Navigation.PushAsync(new CMajor("Triad II"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new CMajor("Triad II"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new CMajor("Triad II"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new CMajor("Triad II"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Triad II"));
                    break;
                case "B":
                    await Navigation.PushAsync(new CMajor("Triad II"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void TriadIII_Clicked(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Triad III"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CMajor("Triad III"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new CMajor("Triad III"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Triad III"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new CMajor("Triad III"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new CMajor("Triad III"));
                    break;
                case "E":
                    await Navigation.PushAsync(new CMajor("Triad III"));
                    break;
                case "F":
                    await Navigation.PushAsync(new CMajor("Triad III"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new CMajor("Triad III"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new CMajor("Triad III"));
                    break;
                case "G":
                    await Navigation.PushAsync(new CMajor("Triad III"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new CMajor("Triad III"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new CMajor("Triad III"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new CMajor("Triad III"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Triad III"));
                    break;
                case "B":
                    await Navigation.PushAsync(new CMajor("Triad III"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void TriadIV_Clicked(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Triad IV"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CMajor("Triad IV"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new CMajor("Triad IV"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Triad IV"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new CMajor("Triad IV"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new CMajor("Triad IV"));
                    break;
                case "E":
                    await Navigation.PushAsync(new CMajor("Triad IV"));
                    break;
                case "F":
                    await Navigation.PushAsync(new CMajor("Triad IV"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new CMajor("Triad IV"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new CMajor("Triad IV"));
                    break;
                case "G":
                    await Navigation.PushAsync(new CMajor("Triad IV"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new CMajor("Triad IV"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new CMajor("Triad IV"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new CMajor("Triad IV"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Triad IV"));
                    break;
                case "B":
                    await Navigation.PushAsync(new CMajor("Triad IV"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void TriadV_Clicked(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Triad V"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CMajor("Triad V"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new CMajor("Triad V"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Triad V"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new CMajor("Triad V"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new CMajor("Triad V"));
                    break;
                case "E":
                    await Navigation.PushAsync(new CMajor("Triad V"));
                    break;
                case "F":
                    await Navigation.PushAsync(new CMajor("Triad V"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new CMajor("Triad V"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new CMajor("Triad V"));
                    break;
                case "G":
                    await Navigation.PushAsync(new CMajor("Triad V"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new CMajor("Triad V"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new CMajor("Triad V"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new CMajor("Triad V"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Triad V"));
                    break;
                case "B":
                    await Navigation.PushAsync(new CMajor("Triad V"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void TriadVI_Clicked(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Triad VI"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CMajor("Triad VI"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new CMajor("Triad VI"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Triad VI"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new CMajor("Triad VI"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new CMajor("Triad VI"));
                    break;
                case "E":
                    await Navigation.PushAsync(new CMajor("Triad VI"));
                    break;
                case "F":
                    await Navigation.PushAsync(new CMajor("Triad VI"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new CMajor("Triad VI"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new CMajor("Triad VI"));
                    break;
                case "G":
                    await Navigation.PushAsync(new CMajor("Triad VI"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new CMajor("Triad VI"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new CMajor("Triad VI"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new CMajor("Triad VI"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Triad VI"));
                    break;
                case "B":
                    await Navigation.PushAsync(new CMajor("Triad VI"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void TriadVII_Clicked(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Triad VII"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CMajor("Triad VII"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new CMajor("Triad VII"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Triad VII"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new CMajor("Triad VII"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new CMajor("Triad VII"));
                    break;
                case "E":
                    await Navigation.PushAsync(new CMajor("Triad VII"));
                    break;
                case "F":
                    await Navigation.PushAsync(new CMajor("Triad VII"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new CMajor("Triad VII"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new CMajor("Triad VII"));
                    break;
                case "G":
                    await Navigation.PushAsync(new CMajor("Triad VII"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new CMajor("Triad VII"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new CMajor("Triad VII"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new CMajor("Triad VII"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Triad VII"));
                    break;
                case "B":
                    await Navigation.PushAsync(new CMajor("Triad VII"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }


        // Dominant 7ths 

        async void DomSeventhI_Clicked(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Dom 7th I"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CMajor("Dom 7th I"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new CMajor("Dom 7th I"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Dom 7th I"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new CMajor("Dom 7th I"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new CMajor("Dom 7th I"));
                    break;
                case "E":
                    await Navigation.PushAsync(new CMajor("Dom 7th I"));
                    break;
                case "F":
                    await Navigation.PushAsync(new CMajor("Dom 7th I"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new CMajor("Dom 7th I"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new CMajor("Dom 7th I"));
                    break;
                case "G":
                    await Navigation.PushAsync(new CMajor("Dom 7th I"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new CMajor("Dom 7th I"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new CMajor("Dom 7th I"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new CMajor("Dom 7th I"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Dom 7th I"));
                    break;
                case "B":
                    await Navigation.PushAsync(new CMajor("Dom 7th I"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void DomSeventhII_Clicked(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Dom 7th II"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CMajor("Dom 7th II"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new CMajor("Dom 7th II"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Dom 7th II"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new CMajor("Dom 7th II"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new CMajor("Dom 7th II"));
                    break;
                case "E":
                    await Navigation.PushAsync(new CMajor("Dom 7th II"));
                    break;
                case "F":
                    await Navigation.PushAsync(new CMajor("Dom 7th II"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new CMajor("Dom 7th II"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new CMajor("Dom 7th II"));
                    break;
                case "G":
                    await Navigation.PushAsync(new CMajor("Dom 7th II"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new CMajor("Dom 7th II"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new CMajor("Dom 7th II"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new CMajor("Dom 7th II"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Dom 7th II"));
                    break;
                case "B":
                    await Navigation.PushAsync(new CMajor("Dom 7th II"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void DomSeventhIII_Clicked(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Dom 7th III"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CMajor("Dom 7th III"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new CMajor("Dom 7th III"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Dom 7th III"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new CMajor("Dom 7th III"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new CMajor("Dom 7th III"));
                    break;
                case "E":
                    await Navigation.PushAsync(new CMajor("Dom 7th III"));
                    break;
                case "F":
                    await Navigation.PushAsync(new CMajor("Dom 7th III"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new CMajor("Dom 7th III"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new CMajor("Dom 7th III"));
                    break;
                case "G":
                    await Navigation.PushAsync(new CMajor("Dom 7th III"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new CMajor("Dom 7th III"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new CMajor("Dom 7th III"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new CMajor("Dom 7th III"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Dom 7th III"));
                    break;
                case "B":
                    await Navigation.PushAsync(new CMajor("Dom 7th III"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void DomSeventhIV_Clicked(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Dom 7th IV"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CMajor("Dom 7th IV"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new CMajor("Dom 7th IV"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Dom 7th IV"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new CMajor("Dom 7th IV"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new CMajor("Dom 7th IV"));
                    break;
                case "E":
                    await Navigation.PushAsync(new CMajor("Dom 7th IV"));
                    break;
                case "F":
                    await Navigation.PushAsync(new CMajor("Dom 7th IV"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new CMajor("Dom 7th IV"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new CMajor("Dom 7th IV"));
                    break;
                case "G":
                    await Navigation.PushAsync(new CMajor("Dom 7th IV"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new CMajor("Dom 7th IV"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new CMajor("Dom 7th IV"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new CMajor("Dom 7th IV"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Dom 7th IV"));
                    break;
                case "B":
                    await Navigation.PushAsync(new CMajor("Dom 7th IV"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void DomSeventhV_Clicked(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Dom 7th V"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CMajor("Dom 7th V"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new CMajor("Dom 7th V"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Dom 7th V"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new CMajor("Dom 7th V"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new CMajor("Dom 7th V"));
                    break;
                case "E":
                    await Navigation.PushAsync(new CMajor("Dom 7th V"));
                    break;
                case "F":
                    await Navigation.PushAsync(new CMajor("Dom 7th V"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new CMajor("Dom 7th V"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new CMajor("Dom 7th V"));
                    break;
                case "G":
                    await Navigation.PushAsync(new CMajor("Dom 7th V"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new CMajor("Dom 7th V"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new CMajor("Dom 7th V"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new CMajor("Dom 7th V"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Dom 7th V"));
                    break;
                case "B":
                    await Navigation.PushAsync(new CMajor("Dom 7th V"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void DomSeventhVI_Clicked(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Dom 7th VI"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CMajor("Dom 7th VI"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new CMajor("Dom 7th VI"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Dom 7th VI"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new CMajor("Dom 7th VI"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new CMajor("Dom 7th VI"));
                    break;
                case "E":
                    await Navigation.PushAsync(new CMajor("Dom 7th VI"));
                    break;
                case "F":
                    await Navigation.PushAsync(new CMajor("Dom 7th VI"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new CMajor("Dom 7th VI"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new CMajor("Dom 7th VI"));
                    break;
                case "G":
                    await Navigation.PushAsync(new CMajor("Dom 7th VI"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new CMajor("Dom 7th VI"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new CMajor("Dom 7th VI"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new CMajor("Dom 7th VI"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Dom 7th VI"));
                    break;
                case "B":
                    await Navigation.PushAsync(new CMajor("Dom 7th VI"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void DomSeventhVII_Clicked(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Dom 7th VII"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CMajor("Dom 7th VII"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new CMajor("Dom 7th VII"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Dom 7th VII"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new CMajor("Dom 7th VII"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new CMajor("Dom 7th VII"));
                    break;
                case "E":
                    await Navigation.PushAsync(new CMajor("Dom 7th VII"));
                    break;
                case "F":
                    await Navigation.PushAsync(new CMajor("Dom 7th VII"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new CMajor("Dom 7th VII"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new CMajor("Dom 7th VII"));
                    break;
                case "G":
                    await Navigation.PushAsync(new CMajor("Dom 7th VII"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new CMajor("Dom 7th VII"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new CMajor("Dom 7th VII"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new CMajor("Dom 7th VII"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Dom 7th VII"));
                    break;
                case "B":
                    await Navigation.PushAsync(new CMajor("Dom 7th VII"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }

        // Major and Minor 7ths 

        async void SeventhI_Clicked(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("7th I"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CMajor("7th I"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new CMajor("7th I"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("7th I"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new CMajor("7th I"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new CMajor("7th I"));
                    break;
                case "E":
                    await Navigation.PushAsync(new CMajor("7th I"));
                    break;
                case "F":
                    await Navigation.PushAsync(new CMajor("7th I"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new CMajor("7th I"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new CMajor("7th I"));
                    break;
                case "G":
                    await Navigation.PushAsync(new CMajor("7th I"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new CMajor("7th I"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new CMajor("7th I"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new CMajor("7th I"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("7th I"));
                    break;
                case "B":
                    await Navigation.PushAsync(new CMajor("7th I"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void SeventhII_Clicked(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("7th II"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CMajor("7th II"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new CMajor("7th II"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("7th II"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new CMajor("7th II"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new CMajor("7th II"));
                    break;
                case "E":
                    await Navigation.PushAsync(new CMajor("7th II"));
                    break;
                case "F":
                    await Navigation.PushAsync(new CMajor("7th II"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new CMajor("7th II"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new CMajor("7th II"));
                    break;
                case "G":
                    await Navigation.PushAsync(new CMajor("7th II"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new CMajor("7th II"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new CMajor("7th II"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new CMajor("7th II"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("7th II"));
                    break;
                case "B":
                    await Navigation.PushAsync(new CMajor("7th II"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void SeventhIII_Clicked(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("7th III"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CMajor("7th III"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new CMajor("7th III"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("7th III"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new CMajor("7th III"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new CMajor("7th III"));
                    break;
                case "E":
                    await Navigation.PushAsync(new CMajor("7th III"));
                    break;
                case "F":
                    await Navigation.PushAsync(new CMajor("7th III"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new CMajor("7th III"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new CMajor("7th III"));
                    break;
                case "G":
                    await Navigation.PushAsync(new CMajor("7th III"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new CMajor("7th III"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new CMajor("7th III"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new CMajor("7th III"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("7th III"));
                    break;
                case "B":
                    await Navigation.PushAsync(new CMajor("7th III"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void SeventhIV_Clicked(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("7th IV"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CMajor("7th IV"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new CMajor("7th IV"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("7th IV"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new CMajor("7th IV"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new CMajor("7th IV"));
                    break;
                case "E":
                    await Navigation.PushAsync(new CMajor("7th IV"));
                    break;
                case "F":
                    await Navigation.PushAsync(new CMajor("7th IV"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new CMajor("7th IV"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new CMajor("7th IV"));
                    break;
                case "G":
                    await Navigation.PushAsync(new CMajor("7th IV"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new CMajor("7th IV"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new CMajor("7th IV"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new CMajor("7th IV"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("7th IV"));
                    break;
                case "B":
                    await Navigation.PushAsync(new CMajor("7th IV"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void SeventhV_Clicked(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("7th V"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CMajor("7th V"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new CMajor("7th V"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("7th V"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new CMajor("7th V"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new CMajor("7th V"));
                    break;
                case "E":
                    await Navigation.PushAsync(new CMajor("7th V"));
                    break;
                case "F":
                    await Navigation.PushAsync(new CMajor("7th V"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new CMajor("7th V"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new CMajor("7th V"));
                    break;
                case "G":
                    await Navigation.PushAsync(new CMajor("7th V"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new CMajor("7th V"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new CMajor("7th V"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new CMajor("7th V"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("7th V"));
                    break;
                case "B":
                    await Navigation.PushAsync(new CMajor("7th V"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void SeventhVI_Clicked(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("7th VI"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CMajor("7th VI"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new CMajor("7th VI"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("7th VI"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new CMajor("7th VI"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new CMajor("7th VI"));
                    break;
                case "E":
                    await Navigation.PushAsync(new CMajor("7th VI"));
                    break;
                case "F":
                    await Navigation.PushAsync(new CMajor("7th VI"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new CMajor("7th VI"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new CMajor("7th VI"));
                    break;
                case "G":
                    await Navigation.PushAsync(new CMajor("7th VI"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new CMajor("7th VI"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new CMajor("7th VI"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new CMajor("7th VI"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("7th VI"));
                    break;
                case "B":
                    await Navigation.PushAsync(new CMajor("7th VI"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void SeventhVII_Clicked(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("7th VII"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CMajor("7th VII"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new CMajor("7th VII"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("7th VII"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new CMajor("7th VII"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new CMajor("7th VII"));
                    break;
                case "E":
                    await Navigation.PushAsync(new CMajor("7th VII"));
                    break;
                case "F":
                    await Navigation.PushAsync(new CMajor("7th VII"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new CMajor("7th VII"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new CMajor("7th VII"));
                    break;
                case "G":
                    await Navigation.PushAsync(new CMajor("7th VII"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new CMajor("7th VII"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new CMajor("7th VII"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new CMajor("7th VII"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("7th VII"));
                    break;
                case "B":
                    await Navigation.PushAsync(new CMajor("7th VII"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }


        // Dominant 9ths 

        async void DomNinthI_Clicked(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Dom 9th I"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CMajor("Dom 9th I"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new CMajor("Dom 9th I"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Dom 9th I"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new CMajor("Dom 9th I"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new CMajor("Dom 9th I"));
                    break;
                case "E":
                    await Navigation.PushAsync(new CMajor("Dom 9th I"));
                    break;
                case "F":
                    await Navigation.PushAsync(new CMajor("Dom 9th I"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new CMajor("Dom 9th I"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new CMajor("Dom 9th I"));
                    break;
                case "G":
                    await Navigation.PushAsync(new CMajor("Dom 9th I"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new CMajor("Dom 9th I"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new CMajor("Dom 9th I"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new CMajor("Dom 9th I"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Dom 9th I"));
                    break;
                case "B":
                    await Navigation.PushAsync(new CMajor("Dom 9th I"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void DomNinthII_Clicked(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Dom 9th II"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CMajor("Dom 9th II"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new CMajor("Dom 9th II"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Dom 9th II"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new CMajor("Dom 9th II"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new CMajor("Dom 9th II"));
                    break;
                case "E":
                    await Navigation.PushAsync(new CMajor("Dom 9th II"));
                    break;
                case "F":
                    await Navigation.PushAsync(new CMajor("Dom 9th II"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new CMajor("Dom 9th II"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new CMajor("Dom 9th II"));
                    break;
                case "G":
                    await Navigation.PushAsync(new CMajor("Dom 9th II"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new CMajor("Dom 9th II"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new CMajor("Dom 9th II"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new CMajor("Dom 9th II"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Dom 9th II"));
                    break;
                case "B":
                    await Navigation.PushAsync(new CMajor("Dom 9th II"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void DomNinthIII_Clicked(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Dom 9th III"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CMajor("Dom 9th III"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new CMajor("Dom 9th III"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Dom 9th III"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new CMajor("Dom 9th III"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new CMajor("Dom 9th III"));
                    break;
                case "E":
                    await Navigation.PushAsync(new CMajor("Dom 9th III"));
                    break;
                case "F":
                    await Navigation.PushAsync(new CMajor("Dom 9th III"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new CMajor("Dom 9th III"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new CMajor("Dom 9th III"));
                    break;
                case "G":
                    await Navigation.PushAsync(new CMajor("Dom 9th III"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new CMajor("Dom 9th III"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new CMajor("Dom 9th III"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new CMajor("Dom 9th III"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Dom 9th III"));
                    break;
                case "B":
                    await Navigation.PushAsync(new CMajor("Dom 9th III"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void DomNinthIV_Clicked(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Dom 9th IV"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CMajor("Dom 9th IV"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new CMajor("Dom 9th IV"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Dom 9th IV"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new CMajor("Dom 9th IV"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new CMajor("Dom 9th IV"));
                    break;
                case "E":
                    await Navigation.PushAsync(new CMajor("Dom 9th IV"));
                    break;
                case "F":
                    await Navigation.PushAsync(new CMajor("Dom 9th IV"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new CMajor("Dom 9th IV"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new CMajor("Dom 9th IV"));
                    break;
                case "G":
                    await Navigation.PushAsync(new CMajor("Dom 9th IV"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new CMajor("Dom 9th IV"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new CMajor("Dom 9th IV"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new CMajor("Dom 9th IV"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Dom 9th IV"));
                    break;
                case "B":
                    await Navigation.PushAsync(new CMajor("Dom 9th IV"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void DomNinthV_Clicked(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Dom 9th V"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CMajor("Dom 9th V"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new CMajor("Dom 9th V"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Dom 9th V"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new CMajor("Dom 9th V"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new CMajor("Dom 9th V"));
                    break;
                case "E":
                    await Navigation.PushAsync(new CMajor("Dom 9th V"));
                    break;
                case "F":
                    await Navigation.PushAsync(new CMajor("Dom 9th V"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new CMajor("Dom 9th V"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new CMajor("Dom 9th V"));
                    break;
                case "G":
                    await Navigation.PushAsync(new CMajor("Dom 9th V"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new CMajor("Dom 9th V"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new CMajor("Dom 9th V"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new CMajor("Dom 9th V"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Dom 9th V"));
                    break;
                case "B":
                    await Navigation.PushAsync(new CMajor("Dom 9th V"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void DomNinthVI_Clicked(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Dom 9th VI"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CMajor("Dom 9th VI"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new CMajor("Dom 9th VI"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Dom 9th VI"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new CMajor("Dom 9th VI"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new CMajor("Dom 9th VI"));
                    break;
                case "E":
                    await Navigation.PushAsync(new CMajor("Dom 9th VI"));
                    break;
                case "F":
                    await Navigation.PushAsync(new CMajor("Dom 9th VI"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new CMajor("Dom 9th VI"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new CMajor("Dom 9th VI"));
                    break;
                case "G":
                    await Navigation.PushAsync(new CMajor("Dom 9th VI"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new CMajor("Dom 9th VI"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new CMajor("Dom 9th VI"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new CMajor("Dom 9th VI"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Dom 9th VI"));
                    break;
                case "B":
                    await Navigation.PushAsync(new CMajor("Dom 9th VI"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void DomNinthVII_Clicked(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Dom 9th VII"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CMajor("Dom 9th VII"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new CMajor("Dom 9th VII"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Dom 9th VII"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new CMajor("Dom 9th VII"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new CMajor("Dom 9th VII"));
                    break;
                case "E":
                    await Navigation.PushAsync(new CMajor("Dom 9th VII"));
                    break;
                case "F":
                    await Navigation.PushAsync(new CMajor("Dom 9th VII"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new CMajor("Dom 9th VII"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new CMajor("Dom 9th VII"));
                    break;
                case "G":
                    await Navigation.PushAsync(new CMajor("Dom 9th VII"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new CMajor("Dom 9th VII"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new CMajor("Dom 9th VII"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new CMajor("Dom 9th VII"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Dom 9th VII"));
                    break;
                case "B":
                    await Navigation.PushAsync(new CMajor("Dom 9th VII"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }


        // Major and Minor 9ths 

        async void NinthI_Clicked(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("9th I"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CMajor("9th I"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new CMajor("9th I"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("9th I"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new CMajor("9th I"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new CMajor("9th I"));
                    break;
                case "E":
                    await Navigation.PushAsync(new CMajor("9th I"));
                    break;
                case "F":
                    await Navigation.PushAsync(new CMajor("9th I"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new CMajor("9th I"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new CMajor("9th I"));
                    break;
                case "G":
                    await Navigation.PushAsync(new CMajor("9th I"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new CMajor("9th I"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new CMajor("9th I"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new CMajor("9th I"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("9th I"));
                    break;
                case "B":
                    await Navigation.PushAsync(new CMajor("9th I"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void NinthII_Clicked(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("9th II"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CMajor("9th II"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new CMajor("9th II"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("9th II"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new CMajor("9th II"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new CMajor("9th II"));
                    break;
                case "E":
                    await Navigation.PushAsync(new CMajor("9th II"));
                    break;
                case "F":
                    await Navigation.PushAsync(new CMajor("9th II"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new CMajor("9th II"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new CMajor("9th II"));
                    break;
                case "G":
                    await Navigation.PushAsync(new CMajor("9th II"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new CMajor("9th II"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new CMajor("9th II"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new CMajor("9th II"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("9th II"));
                    break;
                case "B":
                    await Navigation.PushAsync(new CMajor("9th II"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void NinthIII_Clicked(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("9th III"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CMajor("9th III"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new CMajor("9th III"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("9th III"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new CMajor("9th III"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new CMajor("9th III"));
                    break;
                case "E":
                    await Navigation.PushAsync(new CMajor("9th III"));
                    break;
                case "F":
                    await Navigation.PushAsync(new CMajor("9th III"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new CMajor("9th III"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new CMajor("9th III"));
                    break;
                case "G":
                    await Navigation.PushAsync(new CMajor("9th III"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new CMajor("9th III"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new CMajor("9th III"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new CMajor("9th III"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("9th III"));
                    break;
                case "B":
                    await Navigation.PushAsync(new CMajor("9th III"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void NinthIV_Clicked(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("9th IV"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CMajor("9th IV"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new CMajor("9th IV"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("9th IV"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new CMajor("9th IV"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new CMajor("9th IV"));
                    break;
                case "E":
                    await Navigation.PushAsync(new CMajor("9th IV"));
                    break;
                case "F":
                    await Navigation.PushAsync(new CMajor("9th IV"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new CMajor("9th IV"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new CMajor("9th IV"));
                    break;
                case "G":
                    await Navigation.PushAsync(new CMajor("9th IV"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new CMajor("9th IV"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new CMajor("9th IV"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new CMajor("9th IV"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("9th IV"));
                    break;
                case "B":
                    await Navigation.PushAsync(new CMajor("9th IV"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void NinthV_Clicked(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("9th V"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CMajor("9th V"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new CMajor("9th V"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("9th V"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new CMajor("9th V"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new CMajor("9th V"));
                    break;
                case "E":
                    await Navigation.PushAsync(new CMajor("9th V"));
                    break;
                case "F":
                    await Navigation.PushAsync(new CMajor("9th V"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new CMajor("9th V"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new CMajor("9th V"));
                    break;
                case "G":
                    await Navigation.PushAsync(new CMajor("9th V"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new CMajor("9th V"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new CMajor("9th V"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new CMajor("9th V"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("9th V"));
                    break;
                case "B":
                    await Navigation.PushAsync(new CMajor("9th V"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void NinthVI_Clicked(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("9th VI"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CMajor("9th VI"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new CMajor("9th VI"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("9th VI"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new CMajor("9th VI"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new CMajor("9th VI"));
                    break;
                case "E":
                    await Navigation.PushAsync(new CMajor("9th VI"));
                    break;
                case "F":
                    await Navigation.PushAsync(new CMajor("9th VI"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new CMajor("9th VI"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new CMajor("9th VI"));
                    break;
                case "G":
                    await Navigation.PushAsync(new CMajor("9th VI"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new CMajor("9th VI"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new CMajor("9th VI"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new CMajor("9th VI"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("9th VI"));
                    break;
                case "B":
                    await Navigation.PushAsync(new CMajor("9th VI"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void NinthVII_Clicked(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("9th VII"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CMajor("9th VII"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new CMajor("9th VII"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("9th VII"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new CMajor("9th VII"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new CMajor("9th VII"));
                    break;
                case "E":
                    await Navigation.PushAsync(new CMajor("9th VII"));
                    break;
                case "F":
                    await Navigation.PushAsync(new CMajor("9th VII"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new CMajor("9th VII"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new CMajor("9th VII"));
                    break;
                case "G":
                    await Navigation.PushAsync(new CMajor("9th VII"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new CMajor("9th VII"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new CMajor("9th VII"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new CMajor("9th VII"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("9th VII"));
                    break;
                case "B":
                    await Navigation.PushAsync(new CMajor("9th VII"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
