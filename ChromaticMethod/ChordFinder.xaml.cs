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
                    await Navigation.PushAsync(new CsMajor("Triad I"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DbMajor("Triad I"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Triad I"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DsMajor("Triad I"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new EbMajor("Triad I"));
                    break;
                case "E":
                    await Navigation.PushAsync(new EMajor("Triad I"));
                    break;
                case "F":
                    await Navigation.PushAsync(new FMajor("Triad I"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new FsMajor("Triad I"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new GbMajor("Triad I"));
                    break;
                case "G":
                    await Navigation.PushAsync(new GMajor("Triad I"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new GsMajor("Triad I"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new AbMajor("Triad I"));
                    break;
                case "A":
                    await Navigation.PushAsync(new AMajor("Triad I"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new AsMajor("Triad I"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Triad I"));
                    break;
                case "B":
                    await Navigation.PushAsync(new BMajor("Triad I"));
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
                    await Navigation.PushAsync(new CsMajor("Triad II"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DbMajor("Triad II"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Triad II"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DsMajor("Triad II"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new EbMajor("Triad II"));
                    break;
                case "E":
                    await Navigation.PushAsync(new EMajor("Triad II"));
                    break;
                case "F":
                    await Navigation.PushAsync(new FMajor("Triad II"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new FsMajor("Triad II"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new GbMajor("Triad II"));
                    break;
                case "G":
                    await Navigation.PushAsync(new GMajor("Triad II"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new GsMajor("Triad II"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new AbMajor("Triad II"));
                    break;
                case "A":
                    await Navigation.PushAsync(new AMajor("Triad I"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new AsMajor("Triad II"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Triad II"));
                    break;
                case "B":
                    await Navigation.PushAsync(new BMajor("Triad II"));
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
                    await Navigation.PushAsync(new CsMajor("Triad III"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DbMajor("Triad III"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Triad III"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DsMajor("Triad III"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new EbMajor("Triad III"));
                    break;
                case "E":
                    await Navigation.PushAsync(new EMajor("Triad III"));
                    break;
                case "F":
                    await Navigation.PushAsync(new FMajor("Triad III"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new FsMajor("Triad III"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new GbMajor("Triad III"));
                    break;
                case "G":
                    await Navigation.PushAsync(new GMajor("Triad III"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new GsMajor("Triad III"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new AbMajor("Triad III"));
                    break;
                case "A":
                    await Navigation.PushAsync(new AMajor("Triad I"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new AsMajor("Triad III"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Triad III"));
                    break;
                case "B":
                    await Navigation.PushAsync(new BMajor("Triad III"));
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
                    await Navigation.PushAsync(new CsMajor("Triad IV"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DbMajor("Triad IV"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Triad IV"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DsMajor("Triad IV"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new EbMajor("Triad IV"));
                    break;
                case "E":
                    await Navigation.PushAsync(new EMajor("Triad IV"));
                    break;
                case "F":
                    await Navigation.PushAsync(new FMajor("Triad IV"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new FsMajor("Triad IV"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new GbMajor("Triad IV"));
                    break;
                case "G":
                    await Navigation.PushAsync(new GMajor("Triad IV"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new GsMajor("Triad IV"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new AbMajor("Triad IV"));
                    break;
                case "A":
                    await Navigation.PushAsync(new AMajor("Triad I"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new AsMajor("Triad IV"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Triad IV"));
                    break;
                case "B":
                    await Navigation.PushAsync(new BMajor("Triad IV"));
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
                    await Navigation.PushAsync(new CsMajor("Triad V"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DbMajor("Triad V"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Triad V"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DsMajor("Triad V"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new EbMajor("Triad V"));
                    break;
                case "E":
                    await Navigation.PushAsync(new EMajor("Triad V"));
                    break;
                case "F":
                    await Navigation.PushAsync(new FMajor("Triad V"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new FsMajor("Triad V"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new GbMajor("Triad V"));
                    break;
                case "G":
                    await Navigation.PushAsync(new GMajor("Triad V"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new GsMajor("Triad V"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new AbMajor("Triad V"));
                    break;
                case "A":
                    await Navigation.PushAsync(new AMajor("Triad I"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new AsMajor("Triad V"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Triad V"));
                    break;
                case "B":
                    await Navigation.PushAsync(new BMajor("Triad V"));
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
                    await Navigation.PushAsync(new CsMajor("Triad VI"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DbMajor("Triad VI"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Triad VI"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DsMajor("Triad VI"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new EbMajor("Triad VI"));
                    break;
                case "E":
                    await Navigation.PushAsync(new EMajor("Triad VI"));
                    break;
                case "F":
                    await Navigation.PushAsync(new FMajor("Triad VI"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new FsMajor("Triad VI"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new GbMajor("Triad VI"));
                    break;
                case "G":
                    await Navigation.PushAsync(new GMajor("Triad VI"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new GsMajor("Triad VI"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new AbMajor("Triad VI"));
                    break;
                case "A":
                    await Navigation.PushAsync(new AMajor("Triad I"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new AsMajor("Triad VI"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Triad VI"));
                    break;
                case "B":
                    await Navigation.PushAsync(new BMajor("Triad VI"));
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
                    await Navigation.PushAsync(new CsMajor("Triad VII"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DbMajor("Triad VII"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Triad VII"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DsMajor("Triad VII"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new EbMajor("Triad VII"));
                    break;
                case "E":
                    await Navigation.PushAsync(new EMajor("Triad VII"));
                    break;
                case "F":
                    await Navigation.PushAsync(new FMajor("Triad VII"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new FsMajor("Triad VII"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new GbMajor("Triad VII"));
                    break;
                case "G":
                    await Navigation.PushAsync(new GMajor("Triad VII"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new GsMajor("Triad VII"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new AbMajor("Triad VII"));
                    break;
                case "A":
                    await Navigation.PushAsync(new AMajor("Triad I"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new AsMajor("Triad VII"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Triad VII"));
                    break;
                case "B":
                    await Navigation.PushAsync(new BMajor("Triad VII"));
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
                    await Navigation.PushAsync(new CsMajor("Dom 7th I"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DbMajor("Dom 7th I"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Dom 7th I"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DsMajor("Dom 7th I"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new EbMajor("Dom 7th I"));
                    break;
                case "E":
                    await Navigation.PushAsync(new EMajor("Dom 7th I"));
                    break;
                case "F":
                    await Navigation.PushAsync(new FMajor("Dom 7th I"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new FsMajor("Dom 7th I"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new GbMajor("Dom 7th I"));
                    break;
                case "G":
                    await Navigation.PushAsync(new GMajor("Dom 7th I"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new GsMajor("Dom 7th I"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new AbMajor("Dom 7th I"));
                    break;
                case "A":
                    await Navigation.PushAsync(new AMajor("Triad I"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new AsMajor("Dom 7th I"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Dom 7th I"));
                    break;
                case "B":
                    await Navigation.PushAsync(new BMajor("Dom 7th I"));
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
                    await Navigation.PushAsync(new CsMajor("Dom 7th II"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DbMajor("Dom 7th II"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Dom 7th II"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DsMajor("Dom 7th II"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new EbMajor("Dom 7th II"));
                    break;
                case "E":
                    await Navigation.PushAsync(new EMajor("Dom 7th II"));
                    break;
                case "F":
                    await Navigation.PushAsync(new FMajor("Dom 7th II"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new FsMajor("Dom 7th II"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new GbMajor("Dom 7th II"));
                    break;
                case "G":
                    await Navigation.PushAsync(new GMajor("Dom 7th II"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new GsMajor("Dom 7th II"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new AbMajor("Dom 7th II"));
                    break;
                case "A":
                    await Navigation.PushAsync(new AMajor("Triad I"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new AsMajor("Dom 7th II"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Dom 7th II"));
                    break;
                case "B":
                    await Navigation.PushAsync(new BMajor("Dom 7th II"));
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
                    await Navigation.PushAsync(new CsMajor("Dom 7th III"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DbMajor("Dom 7th III"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Dom 7th III"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DsMajor("Dom 7th III"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new EbMajor("Dom 7th III"));
                    break;
                case "E":
                    await Navigation.PushAsync(new EMajor("Dom 7th III"));
                    break;
                case "F":
                    await Navigation.PushAsync(new FMajor("Dom 7th III"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new FsMajor("Dom 7th III"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new GbMajor("Dom 7th III"));
                    break;
                case "G":
                    await Navigation.PushAsync(new GMajor("Dom 7th III"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new GsMajor("Dom 7th III"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new AbMajor("Dom 7th III"));
                    break;
                case "A":
                    await Navigation.PushAsync(new AMajor("Triad I"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new AsMajor("Dom 7th III"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Dom 7th III"));
                    break;
                case "B":
                    await Navigation.PushAsync(new BMajor("Dom 7th III"));
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
                    await Navigation.PushAsync(new CsMajor("Dom 7th IV"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DbMajor("Dom 7th IV"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Dom 7th IV"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DsMajor("Dom 7th IV"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new EbMajor("Dom 7th IV"));
                    break;
                case "E":
                    await Navigation.PushAsync(new EMajor("Dom 7th IV"));
                    break;
                case "F":
                    await Navigation.PushAsync(new FMajor("Dom 7th IV"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new FsMajor("Dom 7th IV"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new GbMajor("Dom 7th IV"));
                    break;
                case "G":
                    await Navigation.PushAsync(new GMajor("Dom 7th IV"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new GsMajor("Dom 7th IV"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new AbMajor("Dom 7th IV"));
                    break;
                case "A":
                    await Navigation.PushAsync(new AMajor("Triad I"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new AsMajor("Dom 7th IV"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Dom 7th IV"));
                    break;
                case "B":
                    await Navigation.PushAsync(new BMajor("Dom 7th IV"));
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
                    await Navigation.PushAsync(new CsMajor("Dom 7th V"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DbMajor("Dom 7th V"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Dom 7th V"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DsMajor("Dom 7th V"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new EbMajor("Dom 7th V"));
                    break;
                case "E":
                    await Navigation.PushAsync(new EMajor("Dom 7th V"));
                    break;
                case "F":
                    await Navigation.PushAsync(new FMajor("Dom 7th V"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new FsMajor("Dom 7th V"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new GbMajor("Dom 7th V"));
                    break;
                case "G":
                    await Navigation.PushAsync(new GMajor("Dom 7th V"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new GsMajor("Dom 7th V"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new AbMajor("Dom 7th V"));
                    break;
                case "A":
                    await Navigation.PushAsync(new AMajor("Triad I"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new AsMajor("Dom 7th V"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Dom 7th V"));
                    break;
                case "B":
                    await Navigation.PushAsync(new BMajor("Dom 7th V"));
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
                    await Navigation.PushAsync(new CsMajor("Dom 7th VI"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DbMajor("Dom 7th VI"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Dom 7th VI"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DsMajor("Dom 7th VI"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new EbMajor("Dom 7th VI"));
                    break;
                case "E":
                    await Navigation.PushAsync(new EMajor("Dom 7th VI"));
                    break;
                case "F":
                    await Navigation.PushAsync(new FMajor("Dom 7th VI"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new FsMajor("Dom 7th VI"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new GbMajor("Dom 7th VI"));
                    break;
                case "G":
                    await Navigation.PushAsync(new GMajor("Dom 7th VI"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new GsMajor("Dom 7th VI"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new AbMajor("Dom 7th VI"));
                    break;
                case "A":
                    await Navigation.PushAsync(new AMajor("Triad I"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new AsMajor("Dom 7th VI"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Dom 7th VI"));
                    break;
                case "B":
                    await Navigation.PushAsync(new BMajor("Dom 7th VI"));
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
                    await Navigation.PushAsync(new CsMajor("Dom 7th VII"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DbMajor("Dom 7th VII"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Dom 7th VII"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DsMajor("Dom 7th VII"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new EbMajor("Dom 7th VII"));
                    break;
                case "E":
                    await Navigation.PushAsync(new EMajor("Dom 7th VII"));
                    break;
                case "F":
                    await Navigation.PushAsync(new FMajor("Dom 7th VII"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new FsMajor("Dom 7th VII"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new GbMajor("Dom 7th VII"));
                    break;
                case "G":
                    await Navigation.PushAsync(new GMajor("Dom 7th VII"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new GsMajor("Dom 7th VII"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new AbMajor("Dom 7th VII"));
                    break;
                case "A":
                    await Navigation.PushAsync(new AMajor("Dom 7th VII"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new AsMajor("Dom 7th VII"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Dom 7th VII"));
                    break;
                case "B":
                    await Navigation.PushAsync(new BMajor("Dom 7th VII"));
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
                    await Navigation.PushAsync(new CsMajor("7th I"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DbMajor("7th I"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("7th I"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DsMajor("7th I"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new EbMajor("7th I"));
                    break;
                case "E":
                    await Navigation.PushAsync(new EMajor("7th I"));
                    break;
                case "F":
                    await Navigation.PushAsync(new FMajor("7th I"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new FsMajor("7th I"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new GbMajor("7th I"));
                    break;
                case "G":
                    await Navigation.PushAsync(new GMajor("7th I"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new GsMajor("7th I"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new AbMajor("7th I"));
                    break;
                case "A":
                    await Navigation.PushAsync(new AMajor("Dom 7th VII"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new AsMajor("7th I"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("7th I"));
                    break;
                case "B":
                    await Navigation.PushAsync(new BMajor("7th I"));
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
                    await Navigation.PushAsync(new CsMajor("7th II"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DbMajor("7th II"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("7th II"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DsMajor("7th II"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new EbMajor("7th II"));
                    break;
                case "E":
                    await Navigation.PushAsync(new EMajor("7th II"));
                    break;
                case "F":
                    await Navigation.PushAsync(new FMajor("7th II"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new FsMajor("7th II"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new GbMajor("7th II"));
                    break;
                case "G":
                    await Navigation.PushAsync(new GMajor("7th II"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new GsMajor("7th II"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new AbMajor("7th II"));
                    break;
                case "A":
                    await Navigation.PushAsync(new AMajor("Dom 7th VII"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new AsMajor("7th II"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("7th II"));
                    break;
                case "B":
                    await Navigation.PushAsync(new BMajor("7th II"));
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
                    await Navigation.PushAsync(new CsMajor("7th III"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DbMajor("7th III"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("7th III"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DsMajor("7th III"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new EbMajor("7th III"));
                    break;
                case "E":
                    await Navigation.PushAsync(new EMajor("7th III"));
                    break;
                case "F":
                    await Navigation.PushAsync(new FMajor("7th III"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new FsMajor("7th III"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new GbMajor("7th III"));
                    break;
                case "G":
                    await Navigation.PushAsync(new GMajor("7th III"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new GsMajor("7th III"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new AbMajor("7th III"));
                    break;
                case "A":
                    await Navigation.PushAsync(new AMajor("Dom 7th VII"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new AsMajor("7th III"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("7th III"));
                    break;
                case "B":
                    await Navigation.PushAsync(new BMajor("7th III"));
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
                    await Navigation.PushAsync(new CsMajor("7th IV"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DbMajor("7th IV"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("7th IV"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DsMajor("7th IV"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new EbMajor("7th IV"));
                    break;
                case "E":
                    await Navigation.PushAsync(new EMajor("7th IV"));
                    break;
                case "F":
                    await Navigation.PushAsync(new FMajor("7th IV"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new FsMajor("7th IV"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new GbMajor("7th IV"));
                    break;
                case "G":
                    await Navigation.PushAsync(new GMajor("7th IV"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new GsMajor("7th IV"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new AbMajor("7th IV"));
                    break;
                case "A":
                    await Navigation.PushAsync(new AMajor("Dom 7th VII"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new AsMajor("7th IV"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("7th IV"));
                    break;
                case "B":
                    await Navigation.PushAsync(new BMajor("7th IV"));
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
                    await Navigation.PushAsync(new CsMajor("7th V"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DbMajor("7th V"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("7th V"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DsMajor("7th V"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new EbMajor("7th V"));
                    break;
                case "E":
                    await Navigation.PushAsync(new EMajor("7th V"));
                    break;
                case "F":
                    await Navigation.PushAsync(new FMajor("7th V"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new FsMajor("7th V"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new GbMajor("7th V"));
                    break;
                case "G":
                    await Navigation.PushAsync(new GMajor("7th V"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new GsMajor("7th V"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new AbMajor("7th V"));
                    break;
                case "A":
                    await Navigation.PushAsync(new AMajor("Dom 7th VII"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new AsMajor("7th V"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("7th V"));
                    break;
                case "B":
                    await Navigation.PushAsync(new BMajor("7th V"));
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
                    await Navigation.PushAsync(new CsMajor("7th VI"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DbMajor("7th VI"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("7th VI"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DsMajor("7th VI"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new EbMajor("7th VI"));
                    break;
                case "E":
                    await Navigation.PushAsync(new EMajor("7th VI"));
                    break;
                case "F":
                    await Navigation.PushAsync(new FMajor("7th VI"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new FsMajor("7th VI"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new GbMajor("7th VI"));
                    break;
                case "G":
                    await Navigation.PushAsync(new GMajor("7th VI"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new GsMajor("7th VI"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new AbMajor("7th VI"));
                    break;
                case "A":
                    await Navigation.PushAsync(new AMajor("Dom 7th VII"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new AsMajor("7th VI"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("7th VI"));
                    break;
                case "B":
                    await Navigation.PushAsync(new BMajor("7th VI"));
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
                    await Navigation.PushAsync(new CsMajor("7th VII"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DbMajor("7th VII"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("7th VII"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DsMajor("7th VII"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new EbMajor("7th VII"));
                    break;
                case "E":
                    await Navigation.PushAsync(new EMajor("7th VII"));
                    break;
                case "F":
                    await Navigation.PushAsync(new FMajor("7th VII"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new FsMajor("7th VII"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new GbMajor("7th VII"));
                    break;
                case "G":
                    await Navigation.PushAsync(new GMajor("7th VII"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new GsMajor("7th VII"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new AbMajor("7th VII"));
                    break;
                case "A":
                    await Navigation.PushAsync(new AMajor("Dom 7th VII"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new AsMajor("7th VII"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("7th VII"));
                    break;
                case "B":
                    await Navigation.PushAsync(new BMajor("7th VII"));
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
                    await Navigation.PushAsync(new CsMajor("Dom 9th I"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DbMajor("Dom 9th I"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Dom 9th I"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DsMajor("Dom 9th I"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new EbMajor("Dom 9th I"));
                    break;
                case "E":
                    await Navigation.PushAsync(new EMajor("Dom 9th I"));
                    break;
                case "F":
                    await Navigation.PushAsync(new FMajor("Dom 9th I"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new FsMajor("Dom 9th I"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new GbMajor("Dom 9th I"));
                    break;
                case "G":
                    await Navigation.PushAsync(new GMajor("Dom 9th I"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new GsMajor("Dom 9th I"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new AbMajor("Dom 9th I"));
                    break;
                case "A":
                    await Navigation.PushAsync(new AMajor("Dom 7th VII"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new AsMajor("Dom 9th I"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Dom 9th I"));
                    break;
                case "B":
                    await Navigation.PushAsync(new BMajor("Dom 9th I"));
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
                    await Navigation.PushAsync(new CsMajor("Dom 9th II"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DbMajor("Dom 9th II"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Dom 9th II"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DsMajor("Dom 9th II"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new EbMajor("Dom 9th II"));
                    break;
                case "E":
                    await Navigation.PushAsync(new EMajor("Dom 9th II"));
                    break;
                case "F":
                    await Navigation.PushAsync(new FMajor("Dom 9th II"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new FsMajor("Dom 9th II"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new GbMajor("Dom 9th II"));
                    break;
                case "G":
                    await Navigation.PushAsync(new GMajor("Dom 9th II"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new GsMajor("Dom 9th II"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new AbMajor("Dom 9th II"));
                    break;
                case "A":
                    await Navigation.PushAsync(new AMajor("Dom 7th VII"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new AsMajor("Dom 9th II"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Dom 9th II"));
                    break;
                case "B":
                    await Navigation.PushAsync(new BMajor("Dom 9th II"));
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
                    await Navigation.PushAsync(new CsMajor("Dom 9th III"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DbMajor("Dom 9th III"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Dom 9th III"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DsMajor("Dom 9th III"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new EbMajor("Dom 9th III"));
                    break;
                case "E":
                    await Navigation.PushAsync(new EMajor("Dom 9th III"));
                    break;
                case "F":
                    await Navigation.PushAsync(new FMajor("Dom 9th III"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new FsMajor("Dom 9th III"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new GbMajor("Dom 9th III"));
                    break;
                case "G":
                    await Navigation.PushAsync(new GMajor("Dom 9th III"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new GsMajor("Dom 9th III"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new AbMajor("Dom 9th III"));
                    break;
                case "A":
                    await Navigation.PushAsync(new AMajor("Dom 7th VII"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new AsMajor("Dom 9th III"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Dom 9th III"));
                    break;
                case "B":
                    await Navigation.PushAsync(new BMajor("Dom 9th III"));
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
                    await Navigation.PushAsync(new CsMajor("Dom 9th IV"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DbMajor("Dom 9th IV"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Dom 9th IV"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DsMajor("Dom 9th IV"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new EbMajor("Dom 9th IV"));
                    break;
                case "E":
                    await Navigation.PushAsync(new EMajor("Dom 9th IV"));
                    break;
                case "F":
                    await Navigation.PushAsync(new FMajor("Dom 9th IV"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new FsMajor("Dom 9th IV"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new GbMajor("Dom 9th IV"));
                    break;
                case "G":
                    await Navigation.PushAsync(new GMajor("Dom 9th IV"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new GsMajor("Dom 9th IV"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new AbMajor("Dom 9th IV"));
                    break;
                case "A":
                    await Navigation.PushAsync(new AMajor("Dom 7th VII"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new AsMajor("Dom 9th IV"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Dom 9th IV"));
                    break;
                case "B":
                    await Navigation.PushAsync(new BMajor("Dom 9th IV"));
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
                    await Navigation.PushAsync(new CsMajor("Dom 9th V"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DbMajor("Dom 9th V"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Dom 9th V"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DsMajor("Dom 9th V"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new EbMajor("Dom 9th V"));
                    break;
                case "E":
                    await Navigation.PushAsync(new EMajor("Dom 9th V"));
                    break;
                case "F":
                    await Navigation.PushAsync(new FMajor("Dom 9th V"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new FsMajor("Dom 9th V"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new GbMajor("Dom 9th V"));
                    break;
                case "G":
                    await Navigation.PushAsync(new GMajor("Dom 9th V"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new GsMajor("Dom 9th V"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new AbMajor("Dom 9th V"));
                    break;
                case "A":
                    await Navigation.PushAsync(new AMajor("Dom 7th VII"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new AsMajor("Dom 9th V"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Dom 9th V"));
                    break;
                case "B":
                    await Navigation.PushAsync(new BMajor("Dom 9th V"));
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
                    await Navigation.PushAsync(new CsMajor("Dom 9th VI"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DbMajor("Dom 9th VI"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Dom 9th VI"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DsMajor("Dom 9th VI"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new EbMajor("Dom 9th VI"));
                    break;
                case "E":
                    await Navigation.PushAsync(new EMajor("Dom 9th VI"));
                    break;
                case "F":
                    await Navigation.PushAsync(new FMajor("Dom 9th VI"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new FsMajor("Dom 9th VI"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new GbMajor("Dom 9th VI"));
                    break;
                case "G":
                    await Navigation.PushAsync(new GMajor("Dom 9th VI"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new GsMajor("Dom 9th VI"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new AbMajor("Dom 9th VI"));
                    break;
                case "A":
                    await Navigation.PushAsync(new AMajor("Dom 7th VII"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new AsMajor("Dom 9th VI"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Dom 9th VI"));
                    break;
                case "B":
                    await Navigation.PushAsync(new BMajor("Dom 9th VI"));
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
                    await Navigation.PushAsync(new CsMajor("Dom 9th VII"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DbMajor("Dom 9th VII"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("Dom 9th VII"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DsMajor("Dom 9th VII"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new EbMajor("Dom 9th VII"));
                    break;
                case "E":
                    await Navigation.PushAsync(new EMajor("Dom 9th VII"));
                    break;
                case "F":
                    await Navigation.PushAsync(new FMajor("Dom 9th VII"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new FsMajor("Dom 9th VII"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new GbMajor("Dom 9th VII"));
                    break;
                case "G":
                    await Navigation.PushAsync(new GMajor("Dom 9th VII"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new GsMajor("Dom 9th VII"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new AbMajor("Dom 9th VII"));
                    break;
                case "A":
                    await Navigation.PushAsync(new AMajor("Dom 7th VII"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new AsMajor("Dom 9th VII"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("Dom 9th VII"));
                    break;
                case "B":
                    await Navigation.PushAsync(new BMajor("Dom 9th VII"));
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
                    await Navigation.PushAsync(new CsMajor("9th I"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DbMajor("9th I"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("9th I"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DsMajor("9th I"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new EbMajor("9th I"));
                    break;
                case "E":
                    await Navigation.PushAsync(new EMajor("9th I"));
                    break;
                case "F":
                    await Navigation.PushAsync(new FMajor("9th I"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new FsMajor("9th I"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new GbMajor("9th I"));
                    break;
                case "G":
                    await Navigation.PushAsync(new GMajor("9th I"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new GsMajor("9th I"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new AbMajor("9th I"));
                    break;
                case "A":
                    await Navigation.PushAsync(new AMajor("Dom 7th VII"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new AsMajor("9th I"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("9th I"));
                    break;
                case "B":
                    await Navigation.PushAsync(new BMajor("9th I"));
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
                    await Navigation.PushAsync(new CsMajor("9th II"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DbMajor("9th II"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("9th II"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DsMajor("9th II"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new EbMajor("9th II"));
                    break;
                case "E":
                    await Navigation.PushAsync(new EMajor("9th II"));
                    break;
                case "F":
                    await Navigation.PushAsync(new FMajor("9th II"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new FsMajor("9th II"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new GbMajor("9th II"));
                    break;
                case "G":
                    await Navigation.PushAsync(new GMajor("9th II"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new GsMajor("9th II"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new AbMajor("9th II"));
                    break;
                case "A":
                    await Navigation.PushAsync(new AMajor("Dom 7th VII"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new AsMajor("9th II"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("9th II"));
                    break;
                case "B":
                    await Navigation.PushAsync(new BMajor("9th II"));
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
                    await Navigation.PushAsync(new CsMajor("9th III"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DbMajor("9th III"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("9th III"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DsMajor("9th III"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new EbMajor("9th III"));
                    break;
                case "E":
                    await Navigation.PushAsync(new EMajor("9th III"));
                    break;
                case "F":
                    await Navigation.PushAsync(new FMajor("9th III"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new FsMajor("9th III"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new GbMajor("9th III"));
                    break;
                case "G":
                    await Navigation.PushAsync(new GMajor("9th III"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new GsMajor("9th III"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new AbMajor("9th III"));
                    break;
                case "A":
                    await Navigation.PushAsync(new AMajor("Dom 7th VII"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new AsMajor("9th III"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("9th III"));
                    break;
                case "B":
                    await Navigation.PushAsync(new BMajor("9th III"));
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
                    await Navigation.PushAsync(new CsMajor("9th IV"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DbMajor("9th IV"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("9th IV"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DsMajor("9th IV"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new EbMajor("9th IV"));
                    break;
                case "E":
                    await Navigation.PushAsync(new EMajor("9th IV"));
                    break;
                case "F":
                    await Navigation.PushAsync(new FMajor("9th IV"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new FsMajor("9th IV"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new GbMajor("9th IV"));
                    break;
                case "G":
                    await Navigation.PushAsync(new GMajor("9th IV"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new GsMajor("9th IV"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new AbMajor("9th IV"));
                    break;
                case "A":
                    await Navigation.PushAsync(new AMajor("Dom 7th VII"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new AsMajor("9th IV"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("9th IV"));
                    break;
                case "B":
                    await Navigation.PushAsync(new BMajor("9th IV"));
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
                    await Navigation.PushAsync(new CsMajor("9th V"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DbMajor("9th V"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("9th V"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DsMajor("9th V"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new EbMajor("9th V"));
                    break;
                case "E":
                    await Navigation.PushAsync(new EMajor("9th V"));
                    break;
                case "F":
                    await Navigation.PushAsync(new FMajor("9th V"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new FsMajor("9th V"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new GbMajor("9th V"));
                    break;
                case "G":
                    await Navigation.PushAsync(new GMajor("9th V"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new GsMajor("9th V"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new AbMajor("9th V"));
                    break;
                case "A":
                    await Navigation.PushAsync(new AMajor("Dom 7th VII"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new AsMajor("9th V"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("9th V"));
                    break;
                case "B":
                    await Navigation.PushAsync(new BMajor("9th V"));
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
                    await Navigation.PushAsync(new CsMajor("9th VI"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DbMajor("9th VI"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("9th VI"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DsMajor("9th VI"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new EbMajor("9th VI"));
                    break;
                case "E":
                    await Navigation.PushAsync(new EMajor("9th VI"));
                    break;
                case "F":
                    await Navigation.PushAsync(new FMajor("9th VI"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new FsMajor("9th VI"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new GbMajor("9th VI"));
                    break;
                case "G":
                    await Navigation.PushAsync(new GMajor("9th VI"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new GsMajor("9th VI"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new AbMajor("9th VI"));
                    break;
                case "A":
                    await Navigation.PushAsync(new AMajor("Dom 7th VII"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new AsMajor("9th VI"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("9th VI"));
                    break;
                case "B":
                    await Navigation.PushAsync(new BMajor("9th VI"));
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
                    await Navigation.PushAsync(new CsMajor("9th VII"));
                    break;
                case "Db":
                    await Navigation.PushAsync(new DbMajor("9th VII"));
                    break;
                case "D":
                    await Navigation.PushAsync(new DMajor("9th VII"));
                    break;
                case "D#":
                    await Navigation.PushAsync(new DsMajor("9th VII"));
                    break;
                case "Eb":
                    await Navigation.PushAsync(new EbMajor("9th VII"));
                    break;
                case "E":
                    await Navigation.PushAsync(new EMajor("9th VII"));
                    break;
                case "F":
                    await Navigation.PushAsync(new FMajor("9th VII"));
                    break;
                case "F#":
                    await Navigation.PushAsync(new FsMajor("9th VII"));
                    break;
                case "Gb":
                    await Navigation.PushAsync(new GbMajor("9th VII"));
                    break;
                case "G":
                    await Navigation.PushAsync(new GMajor("9th VII"));
                    break;
                case "G#":
                    await Navigation.PushAsync(new GsMajor("9th VII"));
                    break;
                case "Ab":
                    await Navigation.PushAsync(new AbMajor("9th VII"));
                    break;
                case "A":
                    await Navigation.PushAsync(new AMajor("Dom 7th VII"));
                    break;
                case "A#":
                    await Navigation.PushAsync(new AsMajor("9th VII"));
                    break;
                case "Bb":
                    await Navigation.PushAsync(new CMajor("9th VII"));
                    break;
                case "B":
                    await Navigation.PushAsync(new BMajor("9th VII"));
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
