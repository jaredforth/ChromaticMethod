using System;

using Xamarin.Forms;

namespace ChromaticMethod
{
    public class Search : ContentPage
    {
        public Search()
        {
			Content = new StackLayout
			{
                Children = {
					new SearchBar { Placeholder = "Search all Keys" }
                }
            };
        }
    }
}

