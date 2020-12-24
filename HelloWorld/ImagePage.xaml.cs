using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImagePage : ContentPage
    {
        public ImagePage()
        {
            InitializeComponent();

            //image.Source = ImageSource.FromUri(new Uri("https://www.researchgate.net/profile/An_Le39/publication/316945804/figure/fig1/AS:550885887406080@1508352838404/Sample-100x100-maze-environment.png"));

            //string imageUrl = "https://cdn-nativespeaker.pressidium.com/wp-content/uploads/2020/01/interesting.jpg";
            //var imageSource = new UriImageSource { Uri = new Uri(imageUrl) };
            //imageSource.CachingEnabled = false;
            //imageSource.CacheValidity = TimeSpan.FromHours(1);

            image.Source = ImageSource.FromResource("HelloWorld.Images.interesting.jpg");
            
        }
    }
}