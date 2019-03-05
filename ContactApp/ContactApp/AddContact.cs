using System;

using Xamarin.Forms;

namespace ContactApp
{
    public class AddContact : ContentPage
    {
        public AddContact()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

