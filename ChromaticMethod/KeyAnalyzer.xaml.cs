using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ChromaticMethod
{
    public partial class KeyAnalyzer : TabbedPage
    {
        public KeyAnalyzer(string Key)
        {
			

            this.Title = $"{Key} Major";

			var page = new ContentPage() {};
            page.Icon = "clef.png";
            page.Title = "Key Analyzer";

			var layout = new StackLayout() { HorizontalOptions = LayoutOptions.Center};
			var header = new Label() { Text = "Key Analyzer", TextColor = Color.Black, FontSize = 40, HorizontalOptions = LayoutOptions.Center, Margin = 20 };
			var subHeader = new Label { Text = "Overview", FontSize = 30, HorizontalOptions = LayoutOptions.Center, Margin = 15 };

            layout.Children.Add(header);
            layout.Children.Add(subHeader);
            
            if (Key == "C")
            {
				var scale = new Label() { Text = $"The notes in the {Key} major scale are:", HorizontalOptions = LayoutOptions.Center, Margin = 15 };
				var scaleNotes = new Label() { Text = $"{Major.ModeI(Key)}", HorizontalOptions = LayoutOptions.Center  };
				var chords = new Label() { Text = $"The {Key} diatonic triads are:", HorizontalOptions = LayoutOptions.Center, Margin = 15 };

				var triadI = new Label() { Text = $"{Triads.TriadI(Key)}", HorizontalOptions = LayoutOptions.Center };
				var triadII = new Label() { Text = $"{Triads.TriadII(Key)}", HorizontalOptions = LayoutOptions.Center };
				var triadIII = new Label() { Text = $"{Triads.TriadIII(Key)}", HorizontalOptions = LayoutOptions.Center };
				var triadIV = new Label() { Text = $"{Triads.TriadIV(Key)}", HorizontalOptions = LayoutOptions.Center }; 
				var triadV = new Label() { Text = $"{Triads.TriadV(Key)}", HorizontalOptions = LayoutOptions.Center }; 
				var triadVI = new Label() { Text = $"{Triads.TriadVI(Key)}", HorizontalOptions = LayoutOptions.Center };
				var triadVII = new Label() { Text = $"{Triads.TriadVII(Key)}", HorizontalOptions = LayoutOptions.Center };

                layout.Children.Add(scale);
				layout.Children.Add(scaleNotes);
                layout.Children.Add(chords);

				layout.Children.Add(triadI);
				layout.Children.Add(triadII);
				layout.Children.Add(triadIII);
				layout.Children.Add(triadIV);
				layout.Children.Add(triadV);
				layout.Children.Add(triadVI);
				layout.Children.Add(triadVII);
                
                page.Content = layout;
            }
            else if (Key == "C#")
            {
                var scale = new Label() { Text = $"The notes in the {Key} major scale are {Major.ModeI(Key)}" };
                var chords = new Label() { Text = $"The {Key} diatonic triads are {Triads.TriadI(Key)}" };
                
                layout.Children.Add(scale);
                layout.Children.Add(chords);
                
                page.Content = layout;
            }
            else if (Key == "Db")
            {
                var scale = new Label() { Text = $"The notes in the {Key} major scale are {Major.ModeI(Key)}" };
                var chords = new Label() { Text = $"The {Key} diatonic triads are {Triads.TriadI(Key)}" };
                
                layout.Children.Add(scale);
                layout.Children.Add(chords);
                
                page.Content = layout;
            }
            else if (Key == "D")
            {
                var scale = new Label() { Text = $"The notes in the {Key} major scale are {Major.ModeI(Key)}" };
                var chords = new Label() { Text = $"The {Key} diatonic triads are {Triads.TriadI(Key)}" };
                
                layout.Children.Add(scale);
                layout.Children.Add(chords);
                
                page.Content = layout;
            }
            else if (Key == "D#")
            {
                var scale = new Label() { Text = $"The notes in the {Key} major scale are {Major.ModeI(Key)}" };
                var chords = new Label() { Text = $"The {Key} diatonic triads are {Triads.TriadI(Key)}" };
                
                layout.Children.Add(scale);
                layout.Children.Add(chords);
                
                page.Content = layout;
            }
            else if (Key == "Eb")
            {
                var scale = new Label() { Text = $"The notes in the {Key} major scale are {Major.ModeI(Key)}" };
                var chords = new Label() { Text = $"The {Key} diatonic triads are {Triads.TriadI(Key)}" };
                
                layout.Children.Add(scale);
                layout.Children.Add(chords);
                
                page.Content = layout;
            }
            else if (Key == "E")
            {
                var scale = new Label() { Text = $"The notes in the {Key} major scale are {Major.ModeI(Key)}" };
                var chords = new Label() { Text = $"The {Key} diatonic triads are {Triads.TriadI(Key)}" };
                
                layout.Children.Add(scale);
                layout.Children.Add(chords);
                
                page.Content = layout;
            }
            else if (Key == "F")
            {
                var scale = new Label() { Text = $"The notes in the {Key} major scale are {Major.ModeI(Key)}" };
                var chords = new Label() { Text = $"The {Key} diatonic triads are {Triads.TriadI(Key)}" };
                
                layout.Children.Add(scale);
                layout.Children.Add(chords);
                
                page.Content = layout;
            }
            else if (Key == "F#")
            {
                var scale = new Label() { Text = $"The notes in the {Key} major scale are {Major.ModeI(Key)}" };
                var chords = new Label() { Text = $"The {Key} diatonic triads are {Triads.TriadI(Key)}" };
                
                layout.Children.Add(scale);
                layout.Children.Add(chords);
                
                page.Content = layout;
            }
            else if (Key == "Gb")
            {
                var scale = new Label() { Text = $"The notes in the {Key} major scale are {Major.ModeI(Key)}" };
                var chords = new Label() { Text = $"The {Key} diatonic triads are {Triads.TriadI(Key)}" };
                
                layout.Children.Add(scale);
                layout.Children.Add(chords);
                
                page.Content = layout;
            }
            else if (Key == "G")
            {
                var scale = new Label() { Text = $"The notes in the {Key} major scale are {Major.ModeI(Key)}" };
                var chords = new Label() { Text = $"The {Key} diatonic triads are {Triads.TriadI(Key)}" };
                
                layout.Children.Add(scale);
                layout.Children.Add(chords);
                
                page.Content = layout;
            }
            else if (Key == "G#")
            {
                var scale = new Label() { Text = $"The notes in the {Key} major scale are {Major.ModeI(Key)}" };
                var chords = new Label() { Text = $"The {Key} diatonic triads are {Triads.TriadI(Key)}" };
                
                layout.Children.Add(scale);
                layout.Children.Add(chords);
                
                page.Content = layout;
            }
            else if (Key == "Ab")
            {
                var scale = new Label() { Text = $"The notes in the {Key} major scale are {Major.ModeI(Key)}" };
                var chords = new Label() { Text = $"The {Key} diatonic triads are {Triads.TriadI(Key)}" };
                
                layout.Children.Add(scale);
                layout.Children.Add(chords);
                
                page.Content = layout;
            }
            else if (Key == "A")
            {
                var scale = new Label() { Text = $"The notes in the {Key} major scale are {Major.ModeI(Key)}" };
                var chords = new Label() { Text = $"The {Key} diatonic triads are {Triads.TriadI(Key)}" };
                
                layout.Children.Add(scale);
                layout.Children.Add(chords);
                
                page.Content = layout;
            }
            else if (Key == "A#")
            {
                var scale = new Label() { Text = $"The notes in the {Key} major scale are {Major.ModeI(Key)}" };
                var chords = new Label() { Text = $"The {Key} diatonic triads are {Triads.TriadI(Key)}" };
                
                layout.Children.Add(scale);
                layout.Children.Add(chords);
                
                page.Content = layout;
            }
            else if (Key == "Bb")
            {
                var scale = new Label() { Text = $"The notes in the {Key} major scale are {Major.ModeI(Key)}" };
                var chords = new Label() { Text = $"The {Key} diatonic triads are {Triads.TriadI(Key)}" };
                
                layout.Children.Add(scale);
                layout.Children.Add(chords);
                
                page.Content = layout;
            }
            else if (Key == "B")
            {
                var scale = new Label() { Text = $"The notes in the {Key} major scale are {Major.ModeI(Key)}" };
                var chords = new Label() { Text = $"The {Key} diatonic triads are {Triads.TriadI(Key)}" };
                
                layout.Children.Add(scale);
                layout.Children.Add(chords);
                
                page.Content = layout;
            }

            this.Children.Add(page);
            this.Children.Add(new ScaleFinder(Key));
            this.Children.Add(new ChordFinder(Key));
        }

        void Search_Key(object sender, System.EventArgs e)
        {
            DisplayAlert("Search", "Searching key of C", "Go back");
        }
    }
}
