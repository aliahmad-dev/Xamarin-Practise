using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ImagePractise
{
    public partial class MainPage : ContentPage
    {
        int imId;
        public MainPage()
        {
            InitializeComponent();
            imageView.Source = imageUrl("http://lorempixel.com/1920/1080/city/1");
            imId = 1;
        }

        private void Next_Clicked(object sender, EventArgs e)
        {
            if (imId == 10)
            {
                imageView.Source = imageUrl("http://lorempixel.com/1920/1080/city/1");
                imId = 1;
            }
            else
            {
                imageView.Source = imageUrl(String.Format("http://lorempixel.com/1920/1080/city/{0}", imId + 1));
                imId++;
            }
        }

        private void Previous_Clicked(object sender, EventArgs e)
        {
            if (imId == 1)
            {
                imageView.Source = imageUrl("http://lorempixel.com/1920/1080/city/10");
                imId = 10;
            }
            else
            {
                imageView.Source = imageUrl(String.Format("http://lorempixel.com/1920/1080/city/{0}", imId - 1));
                imId--;
            }
        }

        public UriImageSource imageUrl(String uri)
        {
            return new UriImageSource { Uri = new Uri(uri), CachingEnabled = false };
        }
    }
}
