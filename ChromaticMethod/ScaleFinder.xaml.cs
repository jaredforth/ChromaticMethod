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

        // Major Scales 

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

        // Minor Pentatonic Scales 

        async void MiPentI (object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic I"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic I"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic I"));
                    break;
                case "D":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic I"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic I"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic I"));
                    break;
                case "F":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic I"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic I"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic I"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic I"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic I"));
                    break;
                case "A":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic I"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic I"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic I"));
                    break;
                case "B":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic I"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void MiPentII(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic II"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic II"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic II"));
                    break;
                case "D":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic II"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic II"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic II"));
                    break;
                case "F":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic II"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic II"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic II"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic II"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic II"));
                    break;
                case "A":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic II"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic II"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic II"));
                    break;
                case "B":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic II"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void MiPentIII(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic III"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic III"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic III"));
                    break;
                case "D":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic III"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic III"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic III"));
                    break;
                case "F":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic III"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic III"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic III"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic III"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic III"));
                    break;
                case "A":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic III"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic III"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic III"));
                    break;
                case "B":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic III"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void MiPentIV(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic IV"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic IV"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic IV"));
                    break;
                case "D":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic IV"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic IV"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic IV"));
                    break;
                case "F":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic IV"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic IV"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic IV"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic IV"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic IV"));
                    break;
                case "A":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic IV"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic IV"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic IV"));
                    break;
                case "B":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic IV"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void MiPentV(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic V"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic V"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic V"));
                    break;
                case "D":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic V"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic V"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic V"));
                    break;
                case "F":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic V"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic V"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic V"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic V"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic V"));
                    break;
                case "A":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic V"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic V"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic V"));
                    break;
                case "B":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic V"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }

        // Major Pentatonic Scales 

        async void MPentI(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic I"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic I"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic I"));
                    break;
                case "D":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic I"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic I"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic I"));
                    break;
                case "F":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic I"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic I"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic I"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic I"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic I"));
                    break;
                case "A":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic I"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic I"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic I"));
                    break;
                case "B":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic I"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void MPentII(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic II"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic II"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic II"));
                    break;
                case "D":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic II"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic II"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic II"));
                    break;
                case "F":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic II"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic II"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic II"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic II"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic II"));
                    break;
                case "A":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic II"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic II"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic II"));
                    break;
                case "B":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic II"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void MPentIII(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic III"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic III"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic III"));
                    break;
                case "D":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic III"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic III"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic III"));
                    break;
                case "F":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic III"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic III"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic III"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic III"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic III"));
                    break;
                case "A":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic III"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic III"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic III"));
                    break;
                case "B":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic III"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void MPentIV(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic IV"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic IV"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic IV"));
                    break;
                case "D":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic IV"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic IV"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic IV"));
                    break;
                case "F":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic IV"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic IV"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic IV"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic IV"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic IV"));
                    break;
                case "A":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic IV"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic IV"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic IV"));
                    break;
                case "B":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic IV"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void MPentV(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic V"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic V"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic V"));
                    break;
                case "D":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic V"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic V"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic V"));
                    break;
                case "F":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic V"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic V"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic V"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic V"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic V"));
                    break;
                case "A":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic V"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic V"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic V"));
                    break;
                case "B":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic V"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }

        // Melodic Minor Scales 

        async void Melodic_MinorI(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("Melodic Minor I"));
        }
        async void Melodic_MinorII(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("Melodic Minor II"));
        }
        async void Melodic_MinorIII(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("Melodic Minor III"));
        }
        async void Melodic_MinorIV(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("Melodic Minor IV"));
        }
        async void Melodic_MinorV(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("Melodic Minor V"));
        }
        async void Melodic_MinorVI(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("Melodic Minor VI"));
        }
        async void Melodic_MinorVII(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("Melodic Minor VII"));
        }

        // Melodic Major Scales 

        async void Melodic_MajorI(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("Melodic Major I"));
        }
        async void Melodic_MajorII(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("Melodic Major II"));
        }
        async void Melodic_MajorIII(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("Melodic Major III"));
        }
        async void Melodic_MajorIV(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("Melodic Major IV"));
        }
        async void Melodic_MajorV(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("Melodic Major V"));
        }
        async void Melodic_MajorVI(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("Melodic Major VI"));
        }
        async void Melodic_MajorVII(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CMajor("Melodic Major VII"));
        }
    }
}