using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ChromaticMethod
{
    public partial class ScaleFinder : ContentPage

    {
        public string Key;

        public ScaleFinder(string key)
        {
            InitializeComponent();

            Key = key;
        }

        async void Ionain_Clicked (object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Ionian"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CMajor("Ionian"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new CMajor("Ionian"));
                    break;
                case "D":
                    await Navigation.PushAsync(new CMajor("Ionian"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new CMajor("Ionian"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new CMajor("Ionian"));
                    break;
                case "E":
                    await Navigation.PushAsync(new CMajor("Ionian"));
                    break;
                case "F":
                    await Navigation.PushAsync(new CMajor("Ionian"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new CMajor("Ionian"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new CMajor("Ionian"));
                    break;
                case "G":
                    await Navigation.PushAsync(new CMajor("Ionian"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new CMajor("Ionian"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new CMajor("Ionian"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new CMajor("Ionian"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Ionian"));
                    break;
                case "B":
                    await Navigation.PushAsync(new CMajor("Ionian"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }

        async void Dorian_Clicked (object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Dorian"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CMajor("Dorian"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new CMajor("Dorian"));
                    break;
                case "D":
                    await Navigation.PushAsync(new CMajor("Dorian"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new CMajor("Dorian"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new CMajor("Dorian"));
                    break;
                case "E":
                    await Navigation.PushAsync(new CMajor("Dorian"));
                    break;
                case "F":
                    await Navigation.PushAsync(new CMajor("Dorian"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new CMajor("Dorian"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new CMajor("Dorian"));
                    break;
                case "G":
                    await Navigation.PushAsync(new CMajor("Dorian"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new CMajor("Dorian"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new CMajor("Dorian"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new CMajor("Dorian"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Dorian"));
                    break;
                case "B":
                    await Navigation.PushAsync(new CMajor("Dorian"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }

        async void Phrygian_Clicked(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Phrygian"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CMajor("Phrygian"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new CMajor("Phrygian"));
                    break;
                case "D":
                    await Navigation.PushAsync(new CMajor("Phrygian"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new CMajor("Phrygian"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new CMajor("Phrygian"));
                    break;
                case "E":
                    await Navigation.PushAsync(new CMajor("Phrygian"));
                    break;
                case "F":
                    await Navigation.PushAsync(new CMajor("Phrygian"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new CMajor("Phrygian"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new CMajor("Phrygian"));
                    break;
                case "G":
                    await Navigation.PushAsync(new CMajor("Phrygian"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new CMajor("Phrygian"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new CMajor("Phrygian"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new CMajor("Phrygian"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Phrygian"));
                    break;
                case "B":
                    await Navigation.PushAsync(new CMajor("Phrygian"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }

        async void Lydian_Clicked(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Lydian"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CMajor("Lydian"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new CMajor("Lydian"));
                    break;
                case "D":
                    await Navigation.PushAsync(new CMajor("Lydian"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new CMajor("Lydian"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new CMajor("Lydian"));
                    break;
                case "E":
                    await Navigation.PushAsync(new CMajor("Lydian"));
                    break;
                case "F":
                    await Navigation.PushAsync(new CMajor("Lydian"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new CMajor("Lydian"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new CMajor("Lydian"));
                    break;
                case "G":
                    await Navigation.PushAsync(new CMajor("Lydian"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new CMajor("Lydian"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new CMajor("Lydian"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new CMajor("Lydian"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Lydian"));
                    break;
                case "B":
                    await Navigation.PushAsync(new CMajor("Lydian"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }

        async void Mixolydian_Clicked(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Mixolydian"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CMajor("Mixolydian"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new CMajor("Mixolydian"));
                    break;
                case "D":
                    await Navigation.PushAsync(new CMajor("Mixolydian"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new CMajor("Mixolydian"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new CMajor("Mixolydian"));
                    break;
                case "E":
                    await Navigation.PushAsync(new CMajor("Mixolydian"));
                    break;
                case "F":
                    await Navigation.PushAsync(new CMajor("Mixolydian"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new CMajor("Mixolydian"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new CMajor("Mixolydian"));
                    break;
                case "G":
                    await Navigation.PushAsync(new CMajor("Mixolydian"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new CMajor("Mixolydian"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new CMajor("Mixolydian"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new CMajor("Mixolydian"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Mixolydian"));
                    break;
                case "B":
                    await Navigation.PushAsync(new CMajor("Mixolydian"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }

        async void Aolian_Clicked(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Aolian"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CMajor("Aolian"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new CMajor("Aolian"));
                    break;
                case "D":
                    await Navigation.PushAsync(new CMajor("Aolian"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new CMajor("Aolian"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new CMajor("Aolian"));
                    break;
                case "E":
                    await Navigation.PushAsync(new CMajor("Aolian"));
                    break;
                case "F":
                    await Navigation.PushAsync(new CMajor("Aolian"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new CMajor("Aolian"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new CMajor("Aolian"));
                    break;
                case "G":
                    await Navigation.PushAsync(new CMajor("Aolian"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new CMajor("Aolian"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new CMajor("Aolian"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new CMajor("Aolian"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Aolian"));
                    break;
                case "B":
                    await Navigation.PushAsync(new CMajor("Aolian"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }

        async void Locrian_Clicked(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Locrian"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CMajor("Locrian"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new CMajor("Locrian"));
                    break;
                case "D":
                    await Navigation.PushAsync(new CMajor("Locrian"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new CMajor("Locrian"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new CMajor("Locrian"));
                    break;
                case "E":
                    await Navigation.PushAsync(new CMajor("Locrian"));
                    break;
                case "F":
                    await Navigation.PushAsync(new CMajor("Locrian"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new CMajor("Locrian"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new CMajor("Locrian"));
                    break;
                case "G":
                    await Navigation.PushAsync(new CMajor("Locrian"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new CMajor("Locrian"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new CMajor("Locrian"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new CMajor("Locrian"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Locrian"));
                    break;
                case "B":
                    await Navigation.PushAsync(new CMajor("Locrian"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
