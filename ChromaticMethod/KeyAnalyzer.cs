﻿using System;
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
            var searchHeader = new Label { Text = "Search", FontSize = 20, HorizontalOptions = LayoutOptions.Center, Margin = 20 };

            layout.Children.Add(header);
            layout.Children.Add(subHeader);

            if (Key == "C")
            {
                var scale = new Label() { Text = $"The notes in the {Key} major scale are {Major.ModeI(Key)}" };
                var chords = new Label() { Text = $"The {Key} diatonic triads are {Triads.TriadI(Key)}" };
                var search = new Button { Text = $"Search Key of {Key}" };
                layout.Children.Add(scale);
                layout.Children.Add(chords);
                layout.Children.Add(searchHeader);
                layout.Children.Add(search);
                page.Content = layout;
            }
            else if (Key == "C#")
            {
                var scale = new Label() { Text = $"The notes in the {Key} major scale are {Major.ModeI(Key)}" };
                var chords = new Label() { Text = $"The {Key} diatonic triads are {Triads.TriadI(Key)}" };
                var search = new Button { Text = $"Search Key of {Key}" };
                layout.Children.Add(scale);
                layout.Children.Add(chords);
                layout.Children.Add(searchHeader);
                layout.Children.Add(search);
                page.Content = layout;
            }
            else if (Key == "Db")
            {
                var scale = new Label() { Text = $"The notes in the {Key} major scale are {Major.ModeI(Key)}" };
                var chords = new Label() { Text = $"The {Key} diatonic triads are {Triads.TriadI(Key)}" };
                var search = new Button { Text = $"Search Key of {Key}" };
                layout.Children.Add(scale);
                layout.Children.Add(chords);
                layout.Children.Add(searchHeader);
                layout.Children.Add(search);
                page.Content = layout;
            }
            else if (Key == "D")
            {
                var scale = new Label() { Text = $"The notes in the {Key} major scale are {Major.ModeI(Key)}" };
                var chords = new Label() { Text = $"The {Key} diatonic triads are {Triads.TriadI(Key)}" };
                var search = new Button { Text = $"Search Key of {Key}" };
                layout.Children.Add(scale);
                layout.Children.Add(chords);
                layout.Children.Add(searchHeader);
                layout.Children.Add(search);
                page.Content = layout;
            }
            else if (Key == "D#")
            {
                var scale = new Label() { Text = $"The notes in the {Key} major scale are {Major.ModeI(Key)}" };
                var chords = new Label() { Text = $"The {Key} diatonic triads are {Triads.TriadI(Key)}" };
                var search = new Button { Text = $"Search Key of {Key}" };
                layout.Children.Add(scale);
                layout.Children.Add(chords);
                layout.Children.Add(searchHeader);
                layout.Children.Add(search);
                page.Content = layout;
            }
            else if (Key == "Eb")
            {
                var scale = new Label() { Text = $"The notes in the {Key} major scale are {Major.ModeI(Key)}" };
                var chords = new Label() { Text = $"The {Key} diatonic triads are {Triads.TriadI(Key)}" };
                var search = new Button { Text = $"Search Key of {Key}" };
                layout.Children.Add(scale);
                layout.Children.Add(chords);
                layout.Children.Add(searchHeader);
                layout.Children.Add(search);
                page.Content = layout;
            }
            else if (Key == "E")
            {
                var scale = new Label() { Text = $"The notes in the {Key} major scale are {Major.ModeI(Key)}" };
                var chords = new Label() { Text = $"The {Key} diatonic triads are {Triads.TriadI(Key)}" };
                var search = new Button { Text = $"Search Key of {Key}" };
                layout.Children.Add(scale);
                layout.Children.Add(chords);
                layout.Children.Add(searchHeader);
                layout.Children.Add(search);
                page.Content = layout;
            }
            else if (Key == "F")
            {
                var scale = new Label() { Text = $"The notes in the {Key} major scale are {Major.ModeI(Key)}" };
                var chords = new Label() { Text = $"The {Key} diatonic triads are {Triads.TriadI(Key)}" };
                var search = new Button { Text = $"Search Key of {Key}" };
                layout.Children.Add(scale);
                layout.Children.Add(chords);
                layout.Children.Add(searchHeader);
                layout.Children.Add(search);
                page.Content = layout;
            }
            else if (Key == "F#")
            {
                var scale = new Label() { Text = $"The notes in the {Key} major scale are {Major.ModeI(Key)}" };
                var chords = new Label() { Text = $"The {Key} diatonic triads are {Triads.TriadI(Key)}" };
                var search = new Button { Text = $"Search Key of {Key}" };
                layout.Children.Add(scale);
                layout.Children.Add(chords);
                layout.Children.Add(searchHeader);
                layout.Children.Add(search);
                page.Content = layout;
            }
            else if (Key == "Gb")
            {
                var scale = new Label() { Text = $"The notes in the {Key} major scale are {Major.ModeI(Key)}" };
                var chords = new Label() { Text = $"The {Key} diatonic triads are {Triads.TriadI(Key)}" };
                var search = new Button { Text = $"Search Key of {Key}" };
                layout.Children.Add(scale);
                layout.Children.Add(chords);
                layout.Children.Add(searchHeader);
                layout.Children.Add(search);
                page.Content = layout;
            }
            else if (Key == "G")
            {
                var scale = new Label() { Text = $"The notes in the {Key} major scale are {Major.ModeI(Key)}" };
                var chords = new Label() { Text = $"The {Key} diatonic triads are {Triads.TriadI(Key)}" };
                var search = new Button { Text = $"Search Key of {Key}" };
                layout.Children.Add(scale);
                layout.Children.Add(chords);
                layout.Children.Add(searchHeader);
                layout.Children.Add(search);
                page.Content = layout;
            }
            else if (Key == "G#")
            {
                var scale = new Label() { Text = $"The notes in the {Key} major scale are {Major.ModeI(Key)}" };
                var chords = new Label() { Text = $"The {Key} diatonic triads are {Triads.TriadI(Key)}" };
                var search = new Button { Text = $"Search Key of {Key}" };
                layout.Children.Add(scale);
                layout.Children.Add(chords);
                layout.Children.Add(searchHeader);
                layout.Children.Add(search);
                page.Content = layout;
            }
            else if (Key == "Ab")
            {
                var scale = new Label() { Text = $"The notes in the {Key} major scale are {Major.ModeI(Key)}" };
                var chords = new Label() { Text = $"The {Key} diatonic triads are {Triads.TriadI(Key)}" };
                var search = new Button { Text = $"Search Key of {Key}" };
                layout.Children.Add(scale);
                layout.Children.Add(chords);
                layout.Children.Add(searchHeader);
                layout.Children.Add(search);
                page.Content = layout;
            }
            else if (Key == "A")
            {
                var scale = new Label() { Text = $"The notes in the {Key} major scale are {Major.ModeI(Key)}" };
                var chords = new Label() { Text = $"The {Key} diatonic triads are {Triads.TriadI(Key)}" };
                var search = new Button { Text = $"Search Key of {Key}" };
                layout.Children.Add(scale);
                layout.Children.Add(chords);
                layout.Children.Add(searchHeader);
                layout.Children.Add(search);
                page.Content = layout;
            }
            else if (Key == "A#")
            {
                var scale = new Label() { Text = $"The notes in the {Key} major scale are {Major.ModeI(Key)}" };
                var chords = new Label() { Text = $"The {Key} diatonic triads are {Triads.TriadI(Key)}" };
                var search = new Button { Text = $"Search Key of {Key}" };
                layout.Children.Add(scale);
                layout.Children.Add(chords);
                layout.Children.Add(searchHeader);
                layout.Children.Add(search);
                page.Content = layout;
            }
            else if (Key == "Bb")
            {
                var scale = new Label() { Text = $"The notes in the {Key} major scale are {Major.ModeI(Key)}" };
                var chords = new Label() { Text = $"The {Key} diatonic triads are {Triads.TriadI(Key)}" };
                var search = new Button { Text = $"Search Key of {Key}" };
                layout.Children.Add(scale);
                layout.Children.Add(chords);
                layout.Children.Add(searchHeader);
                layout.Children.Add(search);
                page.Content = layout;
            }
            else if (Key == "B")
            {
                var scale = new Label() { Text = $"The notes in the {Key} major scale are {Major.ModeI(Key)}" };
                var chords = new Label() { Text = $"The {Key} diatonic triads are {Triads.TriadI(Key)}" };
                var search = new Button { Text = $"Search Key of {Key}" };
                layout.Children.Add(scale);
                layout.Children.Add(chords);
                layout.Children.Add(searchHeader);
                layout.Children.Add(search);
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
