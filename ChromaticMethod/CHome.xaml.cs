using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ChromaticMethod
{
    public partial class CHome : TabbedPage
    {
        public CHome()
        {
            InitializeComponent();

            this.Children.Add(new ScaleFinder("C"));
            this.Children.Add(new ChordFinder("C"));
        }
    }
}
