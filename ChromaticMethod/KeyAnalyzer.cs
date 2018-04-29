using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ChromaticMethod
{
    public partial class KeyAnalyzer : TabbedPage
    {
        public KeyAnalyzer(string Key)
        {
            InitializeComponent();

            this.Title = $"{Key} Major";

            var page = new ContentPage();
            page.Icon = "clef.png";
            page.Title = "Key Analyzer";

            var layout = new StackLayout();
            var header = new Label() { Text = "Key Analyzer", TextColor = Color.Black, FontSize = 30, HorizontalOptions = LayoutOptions.Center };
            var subHeader = new Label { Text = "Overview", FontSize = 20, HorizontalOptions = LayoutOptions.Center, Margin = 20 };
            var searchheader = new Label { Text = $"Search key of {Key}", FontSize = 20, HorizontalOptions = LayoutOptions.Center, Margin = 20 };

            layout.Children.Add(header);
            layout.Children.Add(subHeader);

            if (Key == "C")
            {
                var scale = new Label() {Text = $"The notes in the {Key} major scale are {Major.ModeI(Key)}"};
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
