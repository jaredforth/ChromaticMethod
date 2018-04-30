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

        async void Ionain_Clicked(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Ionian"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CsMajor("Ionian"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DbMajor("Ionian"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Ionian"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DsMajor("Ionian"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new EbMajor("Ionian"));
                    break;
                case "E":
                    await Navigation.PushAsync(new EMajor("Ionian"));
                    break;
                case "F":
                    await Navigation.PushAsync(new FMajor("Ionian"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new FsMajor("Ionian"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new GbMajor("Ionian"));
                    break;
                case "G":
                    await Navigation.PushAsync(new GMajor("Ionian"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new GsMajor("Ionian"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new AbMajor("Ionian"));
                    break;
                case "A":
                    await Navigation.PushAsync(new AMajor("Dom 7th VII"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new AsMajor("Ionian"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new BbMajor("Ionian"));
                    break;
                case "B":
                    await Navigation.PushAsync(new BMajor("Ionian"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }

        async void Dorian_Clicked(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Dorian"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CsMajor("Dorian"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DbMajor("Dorian"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Dorian"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DsMajor("Dorian"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new EbMajor("Dorian"));
                    break;
                case "E":
                    await Navigation.PushAsync(new EMajor("Dorian"));
                    break;
                case "F":
                    await Navigation.PushAsync(new FMajor("Dorian"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new FsMajor("Dorian"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new GbMajor("Dorian"));
                    break;
                case "G":
                    await Navigation.PushAsync(new GMajor("Dorian"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new GsMajor("Dorian"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new AbMajor("Dorian"));
                    break;
                case "A":
                    await Navigation.PushAsync(new AMajor("Dom 7th VII"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new AsMajor("Dorian"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new BbMajor("Dorian"));
                    break;
                case "B":
                    await Navigation.PushAsync(new BMajor("Dorian"));
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
                    await Navigation.PushAsync(new CsMajor("Phrygian"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DbMajor("Phrygian"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Phrygian"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DsMajor("Phrygian"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new EbMajor("Phrygian"));
                    break;
                case "E":
                    await Navigation.PushAsync(new EMajor("Phrygian"));
                    break;
                case "F":
                    await Navigation.PushAsync(new FMajor("Phrygian"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new FsMajor("Phrygian"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new GbMajor("Phrygian"));
                    break;
                case "G":
                    await Navigation.PushAsync(new GMajor("Phrygian"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new GsMajor("Phrygian"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new AbMajor("Phrygian"));
                    break;
                case "A":
                    await Navigation.PushAsync(new AMajor("Dom 7th VII"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new AsMajor("Phrygian"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new BbMajor("Phrygian"));
                    break;
                case "B":
                    await Navigation.PushAsync(new BMajor("Phrygian"));
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
                    await Navigation.PushAsync(new CsMajor("Lydian"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DbMajor("Lydian"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Lydian"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DsMajor("Lydian"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new EbMajor("Lydian"));
                    break;
                case "E":
                    await Navigation.PushAsync(new EMajor("Lydian"));
                    break;
                case "F":
                    await Navigation.PushAsync(new FMajor("Lydian"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new FsMajor("Lydian"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new GbMajor("Lydian"));
                    break;
                case "G":
                    await Navigation.PushAsync(new GMajor("Lydian"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new GsMajor("Lydian"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new AbMajor("Lydian"));
                    break;
                case "A":
                    await Navigation.PushAsync(new AMajor("Dom 7th VII"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new AsMajor("Lydian"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new BbMajor("Lydian"));
                    break;
                case "B":
                    await Navigation.PushAsync(new BMajor("Lydian"));
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
                    await Navigation.PushAsync(new CsMajor("Mixolydian"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DbMajor("Mixolydian"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Mixolydian"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DsMajor("Mixolydian"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new EbMajor("Mixolydian"));
                    break;
                case "E":
                    await Navigation.PushAsync(new EMajor("Mixolydian"));
                    break;
                case "F":
                    await Navigation.PushAsync(new FMajor("Mixolydian"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new FsMajor("Mixolydian"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new GbMajor("Mixolydian"));
                    break;
                case "G":
                    await Navigation.PushAsync(new GMajor("Mixolydian"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new GsMajor("Mixolydian"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new AbMajor("Mixolydian"));
                    break;
                case "A":
                    await Navigation.PushAsync(new AMajor("Dom 7th VII"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new AsMajor("Mixolydian"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new BbMajor("Mixolydian"));
                    break;
                case "B":
                    await Navigation.PushAsync(new BMajor("Mixolydian"));
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
                    await Navigation.PushAsync(new CsMajor("Aolian"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DbMajor("Aolian"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Aolian"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DsMajor("Aolian"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new EbMajor("Aolian"));
                    break;
                case "E":
                    await Navigation.PushAsync(new EMajor("Aolian"));
                    break;
                case "F":
                    await Navigation.PushAsync(new FMajor("Aolian"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new FsMajor("Aolian"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new GbMajor("Aolian"));
                    break;
                case "G":
                    await Navigation.PushAsync(new GMajor("Aolian"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new GsMajor("Aolian"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new AbMajor("Aolian"));
                    break;
                case "A":
                    await Navigation.PushAsync(new AMajor("Dom 7th VII"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new AsMajor("Aolian"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new BbMajor("Aolian"));
                    break;
                case "B":
                    await Navigation.PushAsync(new BMajor("Aolian"));
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
                    await Navigation.PushAsync(new CsMajor("Locrian"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DbMajor("Locrian"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Locrian"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DsMajor("Locrian"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new EbMajor("Locrian"));
                    break;
                case "E":
                    await Navigation.PushAsync(new EMajor("Locrian"));
                    break;
                case "F":
                    await Navigation.PushAsync(new FMajor("Locrian"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new FsMajor("Locrian"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new GbMajor("Locrian"));
                    break;
                case "G":
                    await Navigation.PushAsync(new GMajor("Locrian"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new GsMajor("Locrian"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new AbMajor("Locrian"));
                    break;
                case "A":
                    await Navigation.PushAsync(new AMajor("Dom 7th VII"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new AsMajor("Locrian"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new BbMajor("Locrian"));
                    break;
                case "B":
                    await Navigation.PushAsync(new BMajor("Locrian"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }

        // Minor Pentatonic Scales 

        async void MiPentI(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic I"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CsMajor("Minor Pentatonic I"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DbMajor("Minor Pentatonic I"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Minor Pentatonic I"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DsMajor("Minor Pentatonic I"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new EbMajor("Minor Pentatonic I"));
                    break;
                case "F":
                    await Navigation.PushAsync(new FMajor("Minor Pentatonic I"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new FsMajor("Minor Pentatonic I"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new GbMajor("Minor Pentatonic I"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new GsMajor("Minor Pentatonic I"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new AbMajor("Minor Pentatonic I"));
                    break;
                case "A":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic I"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new AsMajor("Minor Pentatonic I"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new BbMajor("Minor Pentatonic I"));
                    break;
                case "B":
                    await Navigation.PushAsync(new BMajor("Minor Pentatonic I"));
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
                    await Navigation.PushAsync(new CsMajor("Minor Pentatonic II"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DbMajor("Minor Pentatonic II"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Minor Pentatonic II"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DsMajor("Minor Pentatonic II"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new EbMajor("Minor Pentatonic II"));
                    break;
                case "F":
                    await Navigation.PushAsync(new FMajor("Minor Pentatonic II"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new FsMajor("Minor Pentatonic II"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new GbMajor("Minor Pentatonic II"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new GsMajor("Minor Pentatonic II"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new AbMajor("Minor Pentatonic II"));
                    break;
                case "A":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic II"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new AsMajor("Minor Pentatonic II"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new BbMajor("Minor Pentatonic II"));
                    break;
                case "B":
                    await Navigation.PushAsync(new BMajor("Minor Pentatonic II"));
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
                    await Navigation.PushAsync(new CsMajor("Minor Pentatonic III"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DbMajor("Minor Pentatonic III"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Minor Pentatonic III"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DsMajor("Minor Pentatonic III"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new EbMajor("Minor Pentatonic III"));
                    break;
                case "F":
                    await Navigation.PushAsync(new FMajor("Minor Pentatonic III"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new FsMajor("Minor Pentatonic III"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new GbMajor("Minor Pentatonic III"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new GsMajor("Minor Pentatonic III"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new AbMajor("Minor Pentatonic III"));
                    break;
                case "A":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic III"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new AsMajor("Minor Pentatonic III"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new BbMajor("Minor Pentatonic III"));
                    break;
                case "B":
                    await Navigation.PushAsync(new BMajor("Minor Pentatonic III"));
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
                    await Navigation.PushAsync(new CsMajor("Minor Pentatonic IV"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DbMajor("Minor Pentatonic IV"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Minor Pentatonic IV"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DsMajor("Minor Pentatonic IV"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new EbMajor("Minor Pentatonic IV"));
                    break;
                case "F":
                    await Navigation.PushAsync(new FMajor("Minor Pentatonic IV"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new FsMajor("Minor Pentatonic IV"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new GbMajor("Minor Pentatonic IV"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new GsMajor("Minor Pentatonic IV"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new AbMajor("Minor Pentatonic IV"));
                    break;
                case "A":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic IV"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new AsMajor("Minor Pentatonic IV"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new BbMajor("Minor Pentatonic IV"));
                    break;
                case "B":
                    await Navigation.PushAsync(new BMajor("Minor Pentatonic IV"));
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
                    await Navigation.PushAsync(new CsMajor("Minor Pentatonic V"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DbMajor("Minor Pentatonic V"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Minor Pentatonic V"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DsMajor("Minor Pentatonic V"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new EbMajor("Minor Pentatonic V"));
                    break;
                case "F":
                    await Navigation.PushAsync(new FMajor("Minor Pentatonic V"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new FsMajor("Minor Pentatonic V"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new GbMajor("Minor Pentatonic V"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new GsMajor("Minor Pentatonic V"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new AbMajor("Minor Pentatonic V"));
                    break;
                case "A":
                    await Navigation.PushAsync(new CMajor("Minor Pentatonic V"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new AsMajor("Minor Pentatonic V"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new BbMajor("Minor Pentatonic V"));
                    break;
                case "B":
                    await Navigation.PushAsync(new BMajor("Minor Pentatonic V"));
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
                    await Navigation.PushAsync(new CsMajor("Major Pentatonic I"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DbMajor("Major Pentatonic I"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Major Pentatonic I"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DsMajor("Major Pentatonic I"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new EbMajor("Major Pentatonic I"));
                    break;
                case "F":
                    await Navigation.PushAsync(new FMajor("Major Pentatonic I"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new FsMajor("Major Pentatonic I"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new GbMajor("Major Pentatonic I"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new GsMajor("Major Pentatonic I"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new AbMajor("Major Pentatonic I"));
                    break;
                case "A":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic I"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new AsMajor("Major Pentatonic I"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new BbMajor("Major Pentatonic I"));
                    break;
                case "B":
                    await Navigation.PushAsync(new BMajor("Major Pentatonic I"));
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
                    await Navigation.PushAsync(new CsMajor("Major Pentatonic II"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DbMajor("Major Pentatonic II"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Major Pentatonic II"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DsMajor("Major Pentatonic II"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new EbMajor("Major Pentatonic II"));
                    break;
                case "F":
                    await Navigation.PushAsync(new FMajor("Major Pentatonic II"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new FsMajor("Major Pentatonic II"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new GbMajor("Major Pentatonic II"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new GsMajor("Major Pentatonic II"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new AbMajor("Major Pentatonic II"));
                    break;
                case "A":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic II"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new AsMajor("Major Pentatonic II"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new BbMajor("Major Pentatonic II"));
                    break;
                case "B":
                    await Navigation.PushAsync(new BMajor("Major Pentatonic II"));
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
                    await Navigation.PushAsync(new CsMajor("Major Pentatonic III"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DbMajor("Major Pentatonic III"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Major Pentatonic III"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DsMajor("Major Pentatonic III"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new EbMajor("Major Pentatonic III"));
                    break;
                case "F":
                    await Navigation.PushAsync(new FMajor("Major Pentatonic III"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new FsMajor("Major Pentatonic III"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new GbMajor("Major Pentatonic III"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new GsMajor("Major Pentatonic III"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new AbMajor("Major Pentatonic III"));
                    break;
                case "A":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic III"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new AsMajor("Major Pentatonic III"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new BbMajor("Major Pentatonic III"));
                    break;
                case "B":
                    await Navigation.PushAsync(new BMajor("Major Pentatonic III"));
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
                    await Navigation.PushAsync(new CsMajor("Major Pentatonic IV"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DbMajor("Major Pentatonic IV"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Major Pentatonic IV"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DsMajor("Major Pentatonic IV"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new EbMajor("Major Pentatonic IV"));
                    break;
                case "F":
                    await Navigation.PushAsync(new FMajor("Major Pentatonic IV"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new FsMajor("Major Pentatonic IV"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new GbMajor("Major Pentatonic IV"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new GsMajor("Major Pentatonic IV"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new AbMajor("Major Pentatonic IV"));
                    break;
                case "A":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic IV"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new AsMajor("Major Pentatonic IV"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new BbMajor("Major Pentatonic IV"));
                    break;
                case "B":
                    await Navigation.PushAsync(new BMajor("Major Pentatonic IV"));
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
                    await Navigation.PushAsync(new CsMajor("Major Pentatonic V"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DbMajor("Major Pentatonic V"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Major Pentatonic V"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DsMajor("Major Pentatonic V"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new EbMajor("Major Pentatonic V"));
                    break;
                case "F":
                    await Navigation.PushAsync(new FMajor("Major Pentatonic V"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new FsMajor("Major Pentatonic V"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new GbMajor("Major Pentatonic V"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new GsMajor("Major Pentatonic V"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new AbMajor("Major Pentatonic V"));
                    break;
                case "A":
                    await Navigation.PushAsync(new CMajor("Major Pentatonic V"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new AsMajor("Major Pentatonic V"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new BbMajor("Major Pentatonic V"));
                    break;
                case "B":
                    await Navigation.PushAsync(new BMajor("Major Pentatonic V"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }

        // Melodic Minor Scales 

        async void Melodic_MinorI(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Melodic Minor I"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CsMajor("Melodic Minor I"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DMajor("Melodic Minor I"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Melodic Minor I"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DMajor("Melodic Minor I"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new DMajor("Melodic Minor I"));
                    break;
                case "E":
                    await Navigation.PushAsync(new DMajor("Melodic Minor I"));
                    break;
                case "F":
                    await Navigation.PushAsync(new DMajor("Melodic Minor I"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new DMajor("Melodic Minor I"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new DMajor("Melodic Minor I"));
                    break;
                case "G":
                    await Navigation.PushAsync(new DMajor("Melodic Minor I"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new DMajor("Melodic Minor I"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new DMajor("Melodic Minor I"));
                    break;
                case "A":
                    await Navigation.PushAsync(new DMajor("Melodic Minor I"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new DMajor("Melodic Minor I"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new DMajor("Melodic Minor I"));
                    break;
                case "B":
                    await Navigation.PushAsync(new DMajor("Melodic Minor I"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void Melodic_MinorII(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Melodic Minor II"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CsMajor("Melodic Minor II"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DMajor("Melodic Minor II"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Melodic Minor II"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DMajor("Melodic Minor II"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new DMajor("Melodic Minor II"));
                    break;
                case "E":
                    await Navigation.PushAsync(new DMajor("Melodic Minor II"));
                    break;
                case "F":
                    await Navigation.PushAsync(new DMajor("Melodic Minor II"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new DMajor("Melodic Minor II"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new DMajor("Melodic Minor II"));
                    break;
                case "G":
                    await Navigation.PushAsync(new DMajor("Melodic Minor II"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new DMajor("Melodic Minor II"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new DMajor("Melodic Minor II"));
                    break;
                case "A":
                    await Navigation.PushAsync(new DMajor("Melodic Minor II"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new DMajor("Melodic Minor II"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new DMajor("Melodic Minor II"));
                    break;
                case "B":
                    await Navigation.PushAsync(new DMajor("Melodic Minor II"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void Melodic_MinorIII(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Melodic Minor III"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CsMajor("Melodic Minor III"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DMajor("Melodic Minor III"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Melodic Minor III"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DMajor("Melodic Minor III"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new DMajor("Melodic Minor III"));
                    break;
                case "E":
                    await Navigation.PushAsync(new DMajor("Melodic Minor III"));
                    break;
                case "F":
                    await Navigation.PushAsync(new DMajor("Melodic Minor III"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new DMajor("Melodic Minor III"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new DMajor("Melodic Minor III"));
                    break;
                case "G":
                    await Navigation.PushAsync(new DMajor("Melodic Minor III"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new DMajor("Melodic Minor III"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new DMajor("Melodic Minor III"));
                    break;
                case "A":
                    await Navigation.PushAsync(new DMajor("Melodic Minor III"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new DMajor("Melodic Minor III"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new DMajor("Melodic Minor III"));
                    break;
                case "B":
                    await Navigation.PushAsync(new DMajor("Melodic Minor III"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void Melodic_MinorIV(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Melodic Minor IV"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CsMajor("Melodic Minor IV"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DMajor("Melodic Minor IV"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Melodic Minor IV"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DMajor("Melodic Minor IV"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new DMajor("Melodic Minor IV"));
                    break;
                case "E":
                    await Navigation.PushAsync(new DMajor("Melodic Minor IV"));
                    break;
                case "F":
                    await Navigation.PushAsync(new DMajor("Melodic Minor IV"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new DMajor("Melodic Minor IV"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new DMajor("Melodic Minor IV"));
                    break;
                case "G":
                    await Navigation.PushAsync(new DMajor("Melodic Minor IV"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new DMajor("Melodic Minor IV"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new DMajor("Melodic Minor IV"));
                    break;
                case "A":
                    await Navigation.PushAsync(new DMajor("Melodic Minor IV"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new DMajor("Melodic Minor IV"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new DMajor("Melodic Minor IV"));
                    break;
                case "B":
                    await Navigation.PushAsync(new DMajor("Melodic Minor IV"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void Melodic_MinorV(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Melodic Minor V"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CsMajor("Melodic Minor V"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DMajor("Melodic Minor V"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Melodic Minor V"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DMajor("Melodic Minor V"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new DMajor("Melodic Minor V"));
                    break;
                case "E":
                    await Navigation.PushAsync(new DMajor("Melodic Minor V"));
                    break;
                case "F":
                    await Navigation.PushAsync(new DMajor("Melodic Minor V"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new DMajor("Melodic Minor V"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new DMajor("Melodic Minor V"));
                    break;
                case "G":
                    await Navigation.PushAsync(new DMajor("Melodic Minor V"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new DMajor("Melodic Minor V"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new DMajor("Melodic Minor V"));
                    break;
                case "A":
                    await Navigation.PushAsync(new DMajor("Melodic Minor V"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new DMajor("Melodic Minor V"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new DMajor("Melodic Minor V"));
                    break;
                case "B":
                    await Navigation.PushAsync(new DMajor("Melodic Minor V"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void Melodic_MinorVI(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Melodic Minor VI"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CsMajor("Melodic Minor VI"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DMajor("Melodic Minor VI"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Melodic Minor VI"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DMajor("Melodic Minor VI"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new DMajor("Melodic Minor VI"));
                    break;
                case "E":
                    await Navigation.PushAsync(new DMajor("Melodic Minor VI"));
                    break;
                case "F":
                    await Navigation.PushAsync(new DMajor("Melodic Minor VI"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new DMajor("Melodic Minor VI"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new DMajor("Melodic Minor VI"));
                    break;
                case "G":
                    await Navigation.PushAsync(new DMajor("Melodic Minor VI"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new DMajor("Melodic Minor VI"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new DMajor("Melodic Minor VI"));
                    break;
                case "A":
                    await Navigation.PushAsync(new DMajor("Melodic Minor VI"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new DMajor("Melodic Minor VI"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new DMajor("Melodic Minor VI"));
                    break;
                case "B":
                    await Navigation.PushAsync(new DMajor("Melodic Minor VI"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void Melodic_MinorVII(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Melodic Minor VII"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CsMajor("Melodic Minor VII"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DMajor("Melodic Minor VII"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Melodic Minor VII"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DMajor("Melodic Minor VII"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new DMajor("Melodic Minor VII"));
                    break;
                case "E":
                    await Navigation.PushAsync(new DMajor("Melodic Minor VII"));
                    break;
                case "F":
                    await Navigation.PushAsync(new DMajor("Melodic Minor VII"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new DMajor("Melodic Minor VII"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new DMajor("Melodic Minor VII"));
                    break;
                case "G":
                    await Navigation.PushAsync(new DMajor("Melodic Minor VII"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new DMajor("Melodic Minor VII"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new DMajor("Melodic Minor VII"));
                    break;
                case "A":
                    await Navigation.PushAsync(new DMajor("Melodic Minor VII"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new DMajor("Melodic Minor VII"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new DMajor("Melodic Minor VII"));
                    break;
                case "B":
                    await Navigation.PushAsync(new DMajor("Melodic Minor VII"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }

        // Melodic Major Scales 

        async void Melodic_MajorI(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Melodic Major I"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CsMajor("Melodic Major I"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DMajor("Melodic Major I"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Melodic Major I"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DMajor("Melodic Major I"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new DMajor("Melodic Major I"));
                    break;
                case "E":
                    await Navigation.PushAsync(new DMajor("Melodic Major I"));
                    break;
                case "F":
                    await Navigation.PushAsync(new DMajor("Melodic Major I"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new DMajor("Melodic Major I"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new DMajor("Melodic Major I"));
                    break;
                case "G":
                    await Navigation.PushAsync(new DMajor("Melodic Major I"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new DMajor("Melodic Major I"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new DMajor("Melodic Major I"));
                    break;
                case "A":
                    await Navigation.PushAsync(new DMajor("Melodic Major I"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new DMajor("Melodic Major I"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new DMajor("Melodic Major I"));
                    break;
                case "B":
                    await Navigation.PushAsync(new DMajor("Melodic Major I"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void Melodic_MajorII(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Melodic Major II"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CsMajor("Melodic Major II"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DMajor("Melodic Major II"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Melodic Major II"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DMajor("Melodic Major II"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new DMajor("Melodic Major II"));
                    break;
                case "E":
                    await Navigation.PushAsync(new DMajor("Melodic Major II"));
                    break;
                case "F":
                    await Navigation.PushAsync(new DMajor("Melodic Major II"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new DMajor("Melodic Major II"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new DMajor("Melodic Major II"));
                    break;
                case "G":
                    await Navigation.PushAsync(new DMajor("Melodic Major II"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new DMajor("Melodic Major II"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new DMajor("Melodic Major II"));
                    break;
                case "A":
                    await Navigation.PushAsync(new DMajor("Melodic Major II"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new DMajor("Melodic Major II"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new DMajor("Melodic Major II"));
                    break;
                case "B":
                    await Navigation.PushAsync(new DMajor("Melodic Major II"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void Melodic_MajorIII(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Melodic Major III"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CsMajor("Melodic Major III"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DMajor("Melodic Major III"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Melodic Major III"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DMajor("Melodic Major III"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new DMajor("Melodic Major III"));
                    break;
                case "E":
                    await Navigation.PushAsync(new DMajor("Melodic Major III"));
                    break;
                case "F":
                    await Navigation.PushAsync(new DMajor("Melodic Major III"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new DMajor("Melodic Major III"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new DMajor("Melodic Major III"));
                    break;
                case "G":
                    await Navigation.PushAsync(new DMajor("Melodic Major III"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new DMajor("Melodic Major III"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new DMajor("Melodic Major III"));
                    break;
                case "A":
                    await Navigation.PushAsync(new DMajor("Melodic Major III"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new DMajor("Melodic Major III"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new DMajor("Melodic Major III"));
                    break;
                case "B":
                    await Navigation.PushAsync(new DMajor("Melodic Major III"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void Melodic_MajorIV(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Melodic Major IV"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CsMajor("Melodic Major IV"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DMajor("Melodic Major IV"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Melodic Major IV"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DMajor("Melodic Major IV"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new DMajor("Melodic Major IV"));
                    break;
                case "E":
                    await Navigation.PushAsync(new DMajor("Melodic Major IV"));
                    break;
                case "F":
                    await Navigation.PushAsync(new DMajor("Melodic Major IV"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new DMajor("Melodic Major IV"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new DMajor("Melodic Major IV"));
                    break;
                case "G":
                    await Navigation.PushAsync(new DMajor("Melodic Major IV"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new DMajor("Melodic Major IV"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new DMajor("Melodic Major IV"));
                    break;
                case "A":
                    await Navigation.PushAsync(new DMajor("Melodic Major IV"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new DMajor("Melodic Major IV"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new DMajor("Melodic Major IV"));
                    break;
                case "B":
                    await Navigation.PushAsync(new DMajor("Melodic Major IV"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void Melodic_MajorV(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Melodic Major V"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CsMajor("Melodic Major V"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DMajor("Melodic Major V"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Melodic Major V"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DMajor("Melodic Major V"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new DMajor("Melodic Major V"));
                    break;
                case "E":
                    await Navigation.PushAsync(new DMajor("Melodic Major V"));
                    break;
                case "F":
                    await Navigation.PushAsync(new DMajor("Melodic Major V"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new DMajor("Melodic Major V"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new DMajor("Melodic Major V"));
                    break;
                case "G":
                    await Navigation.PushAsync(new DMajor("Melodic Major V"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new DMajor("Melodic Major V"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new DMajor("Melodic Major V"));
                    break;
                case "A":
                    await Navigation.PushAsync(new DMajor("Melodic Major V"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new DMajor("Melodic Major V"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new DMajor("Melodic Major V"));
                    break;
                case "B":
                    await Navigation.PushAsync(new DMajor("Melodic Major V"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void Melodic_MajorVI(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Melodic Major VI"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CsMajor("Melodic Major VI"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DMajor("Melodic Major VI"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Melodic Major VI"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DMajor("Melodic Major VI"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new DMajor("Melodic Major VI"));
                    break;
                case "E":
                    await Navigation.PushAsync(new DMajor("Melodic Major VI"));
                    break;
                case "F":
                    await Navigation.PushAsync(new DMajor("Melodic Major VI"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new DMajor("Melodic Major VI"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new DMajor("Melodic Major VI"));
                    break;
                case "G":
                    await Navigation.PushAsync(new DMajor("Melodic Major VI"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new DMajor("Melodic Major VI"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new DMajor("Melodic Major VI"));
                    break;
                case "A":
                    await Navigation.PushAsync(new DMajor("Melodic Major VI"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new DMajor("Melodic Major VI"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new DMajor("Melodic Major VI"));
                    break;
                case "B":
                    await Navigation.PushAsync(new DMajor("Melodic Major VI"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void Melodic_MajorVII(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Melodic Major VII"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CsMajor("Melodic Major VII"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DMajor("Melodic Major VII"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Melodic Major VII"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DMajor("Melodic Major VII"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new DMajor("Melodic Major VII"));
                    break;
                case "E":
                    await Navigation.PushAsync(new DMajor("Melodic Major VII"));
                    break;
                case "F":
                    await Navigation.PushAsync(new DMajor("Melodic Major VII"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new DMajor("Melodic Major VII"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new DMajor("Melodic Major VII"));
                    break;
                case "G":
                    await Navigation.PushAsync(new DMajor("Melodic Major VII"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new DMajor("Melodic Major VII"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new DMajor("Melodic Major VII"));
                    break;
                case "A":
                    await Navigation.PushAsync(new DMajor("Melodic Major VII"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new DMajor("Melodic Major VII"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new DMajor("Melodic Major VII"));
                    break;
                case "B":
                    await Navigation.PushAsync(new DMajor("Melodic Major VII"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }

        // Enigmatic Minor Scales 

        async void Enigmatic_MinorI(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Enigmatic Minor I"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CsMajor("Enigmatic Minor I"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor I"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor I"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor I"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor I"));
                    break;
                case "E":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor I"));
                    break;
                case "F":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor I"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor I"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor I"));
                    break;
                case "G":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor I"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor I"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor I"));
                    break;
                case "A":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor I"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor I"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor I"));
                    break;
                case "B":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor I"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void Enigmatic_MinorII(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Enigmatic Minor II"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CsMajor("Enigmatic Minor II"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor II"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor II"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor II"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor II"));
                    break;
                case "E":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor II"));
                    break;
                case "F":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor II"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor II"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor II"));
                    break;
                case "G":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor II"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor II"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor II"));
                    break;
                case "A":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor II"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor II"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor II"));
                    break;
                case "B":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor II"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void Enigmatic_MinorIII(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Enigmatic Minor III"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CsMajor("Enigmatic Minor III"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor III"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor III"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor III"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor III"));
                    break;
                case "E":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor III"));
                    break;
                case "F":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor III"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor III"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor III"));
                    break;
                case "G":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor III"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor III"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor III"));
                    break;
                case "A":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor III"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor III"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor III"));
                    break;
                case "B":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor III"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void Enigmatic_MinorIV(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Enigmatic Minor IV"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CsMajor("Enigmatic Minor IV"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor IV"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor IV"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor IV"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor IV"));
                    break;
                case "E":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor IV"));
                    break;
                case "F":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor IV"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor IV"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor IV"));
                    break;
                case "G":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor IV"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor IV"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor IV"));
                    break;
                case "A":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor IV"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor IV"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor IV"));
                    break;
                case "B":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor IV"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void Enigmatic_MinorV(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Enigmatic Minor V"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CsMajor("Enigmatic Minor V"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor V"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor V"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor V"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor V"));
                    break;
                case "E":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor V"));
                    break;
                case "F":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor V"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor V"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor V"));
                    break;
                case "G":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor V"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor V"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor V"));
                    break;
                case "A":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor V"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor V"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor V"));
                    break;
                case "B":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor V"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void Enigmatic_MinorVI(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Enigmatic Minor VI"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CsMajor("Enigmatic Minor VI"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor VI"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor VI"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor VI"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor VI"));
                    break;
                case "E":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor VI"));
                    break;
                case "F":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor VI"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor VI"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor VI"));
                    break;
                case "G":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor VI"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor VI"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor VI"));
                    break;
                case "A":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor VI"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor VI"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor VI"));
                    break;
                case "B":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor VI"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void Enigmatic_MinorVII(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Enigmatic Minor VII"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CsMajor("Enigmatic Minor VII"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor VII"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor VII"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor VII"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor VII"));
                    break;
                case "E":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor VII"));
                    break;
                case "F":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor VII"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor VII"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor VII"));
                    break;
                case "G":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor VII"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor VII"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor VII"));
                    break;
                case "A":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor VII"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor VII"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor VII"));
                    break;
                case "B":
                    await Navigation.PushAsync(new DMajor("Enigmatic Minor VII"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }

        // Whole Tone Scales


        async void Whole_ToneI(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Whole Tone I"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CsMajor("Whole Tone I"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DMajor("Whole Tone I"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Whole Tone I"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DMajor("Whole Tone I"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new DMajor("Whole Tone I"));
                    break;
                case "E":
                    await Navigation.PushAsync(new DMajor("Whole Tone I"));
                    break;
                case "F":
                    await Navigation.PushAsync(new DMajor("Whole Tone I"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new DMajor("Whole Tone I"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new DMajor("Whole Tone I"));
                    break;
                case "G":
                    await Navigation.PushAsync(new DMajor("Whole Tone I"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new DMajor("Whole Tone I"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new DMajor("Whole Tone I"));
                    break;
                case "A":
                    await Navigation.PushAsync(new DMajor("Whole Tone I"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new DMajor("Whole Tone I"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new DMajor("Whole Tone I"));
                    break;
                case "B":
                    await Navigation.PushAsync(new DMajor("Whole Tone I"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void Whole_ToneII(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Whole Tone II"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CsMajor("Whole Tone II"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DMajor("Whole Tone II"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Whole Tone II"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DMajor("Whole Tone II"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new DMajor("Whole Tone II"));
                    break;
                case "E":
                    await Navigation.PushAsync(new DMajor("Whole Tone II"));
                    break;
                case "F":
                    await Navigation.PushAsync(new DMajor("Whole Tone II"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new DMajor("Whole Tone II"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new DMajor("Whole Tone II"));
                    break;
                case "G":
                    await Navigation.PushAsync(new DMajor("Whole Tone II"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new DMajor("Whole Tone II"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new DMajor("Whole Tone II"));
                    break;
                case "A":
                    await Navigation.PushAsync(new DMajor("Whole Tone II"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new DMajor("Whole Tone II"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new DMajor("Whole Tone II"));
                    break;
                case "B":
                    await Navigation.PushAsync(new DMajor("Whole Tone II"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void Whole_ToneIII(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Whole Tone III"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CsMajor("Whole Tone III"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DMajor("Whole Tone III"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Whole Tone III"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DMajor("Whole Tone III"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new DMajor("Whole Tone III"));
                    break;
                case "E":
                    await Navigation.PushAsync(new DMajor("Whole Tone III"));
                    break;
                case "F":
                    await Navigation.PushAsync(new DMajor("Whole Tone III"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new DMajor("Whole Tone III"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new DMajor("Whole Tone III"));
                    break;
                case "G":
                    await Navigation.PushAsync(new DMajor("Whole Tone III"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new DMajor("Whole Tone III"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new DMajor("Whole Tone III"));
                    break;
                case "A":
                    await Navigation.PushAsync(new DMajor("Whole Tone III"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new DMajor("Whole Tone III"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new DMajor("Whole Tone III"));
                    break;
                case "B":
                    await Navigation.PushAsync(new DMajor("Whole Tone III"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void Whole_ToneIV(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Whole Tone IV"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CsMajor("Whole Tone IV"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DMajor("Whole Tone IV"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Whole Tone IV"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DMajor("Whole Tone IV"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new DMajor("Whole Tone IV"));
                    break;
                case "E":
                    await Navigation.PushAsync(new DMajor("Whole Tone IV"));
                    break;
                case "F":
                    await Navigation.PushAsync(new DMajor("Whole Tone IV"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new DMajor("Whole Tone IV"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new DMajor("Whole Tone IV"));
                    break;
                case "G":
                    await Navigation.PushAsync(new DMajor("Whole Tone IV"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new DMajor("Whole Tone IV"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new DMajor("Whole Tone IV"));
                    break;
                case "A":
                    await Navigation.PushAsync(new DMajor("Whole Tone IV"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new DMajor("Whole Tone IV"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new DMajor("Whole Tone IV"));
                    break;
                case "B":
                    await Navigation.PushAsync(new DMajor("Whole Tone IV"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void Whole_ToneV(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Whole Tone V"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CsMajor("Whole Tone V"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DMajor("Whole Tone V"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Whole Tone V"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DMajor("Whole Tone V"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new DMajor("Whole Tone V"));
                    break;
                case "E":
                    await Navigation.PushAsync(new DMajor("Whole Tone V"));
                    break;
                case "F":
                    await Navigation.PushAsync(new DMajor("Whole Tone V"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new DMajor("Whole Tone V"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new DMajor("Whole Tone V"));
                    break;
                case "G":
                    await Navigation.PushAsync(new DMajor("Whole Tone V"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new DMajor("Whole Tone V"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new DMajor("Whole Tone V"));
                    break;
                case "A":
                    await Navigation.PushAsync(new DMajor("Whole Tone V"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new DMajor("Whole Tone V"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new DMajor("Whole Tone V"));
                    break;
                case "B":
                    await Navigation.PushAsync(new DMajor("Whole Tone V"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void Whole_ToneVI(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Whole Tone VI"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CsMajor("Whole Tone VI"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DMajor("Whole Tone VI"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Whole Tone VI"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DMajor("Whole Tone VI"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new DMajor("Whole Tone VI"));
                    break;
                case "E":
                    await Navigation.PushAsync(new DMajor("Whole Tone VI"));
                    break;
                case "F":
                    await Navigation.PushAsync(new DMajor("Whole Tone VI"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new DMajor("Whole Tone VI"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new DMajor("Whole Tone VI"));
                    break;
                case "G":
                    await Navigation.PushAsync(new DMajor("Whole Tone VI"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new DMajor("Whole Tone VI"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new DMajor("Whole Tone VI"));
                    break;
                case "A":
                    await Navigation.PushAsync(new DMajor("Whole Tone VI"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new DMajor("Whole Tone VI"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new DMajor("Whole Tone VI"));
                    break;
                case "B":
                    await Navigation.PushAsync(new DMajor("Whole Tone VI"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        async void Whole_ToneVII(object sender, System.EventArgs e)
        {
            switch (Key)
            {
                case "C":
                    await Navigation.PushAsync(new CMajor("Whole Tone VII"));
                    break;
                case "C#":
                    await Navigation.PushAsync(new CsMajor("Whole Tone VII"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DMajor("Whole Tone VII"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Whole Tone VII"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DMajor("Whole Tone VII"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new DMajor("Whole Tone VII"));
                    break;
                case "E":
                    await Navigation.PushAsync(new DMajor("Whole Tone VII"));
                    break;
                case "F":
                    await Navigation.PushAsync(new DMajor("Whole Tone VII"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new DMajor("Whole Tone VII"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new DMajor("Whole Tone VII"));
                    break;
                case "G":
                    await Navigation.PushAsync(new DMajor("Whole Tone VII"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new DMajor("Whole Tone VII"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new DMajor("Whole Tone VII"));
                    break;
                case "A":
                    await Navigation.PushAsync(new DMajor("Whole Tone VII"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new DMajor("Whole Tone VII"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new DMajor("Whole Tone VII"));
                    break;
                case "B":
                    await Navigation.PushAsync(new DMajor("Whole Tone VII"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
    }
}