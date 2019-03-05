using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ContactApp
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Contact> _Contacts = new ObservableCollection<Contact>
        {
            new Contact{Name = "Ali Ahmad" , Phone="+923332301314" , Email="aliahmad71452@gmail.com" , Bloked=false}

        };
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            ReFreshList();

        }

        void Handle_Refreshing(object sender, System.EventArgs e)
        {
            ReFreshList();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new AddContact());

        }

        public void ReFreshList()
        {

            contacts.ItemsSource = _Contacts;
        }

        protected override void OnAppearing()
        {
            if (AddContact.newContact != null)
            {
                _Contacts.Add(AddContact.newContact);
            }
        }
    }
}
