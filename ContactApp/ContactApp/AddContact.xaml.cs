using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace ContactApp
{
    public partial class AddContact : ContentPage
    {
        static public Contact newContact;
        public AddContact()
        {
            InitializeComponent();
        }

        async void Handle_ClickedAsync(object sender, System.EventArgs e)
        {
           newContact =   new Contact { Name =String.Format("{0} {1}",fName.Text,lName.Text), Phone = phoneNo.Text, Email = email.Text, Bloked = block.On ? true : false };

            await Navigation.PopAsync();
        }


    }
}
