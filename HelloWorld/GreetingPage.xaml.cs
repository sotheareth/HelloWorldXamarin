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
    public partial class GreetingPage : ContentPage
    {
        public GreetingPage()
        {
            InitializeComponent();
            slider.Value = 0.5;

            //Padding = Device.OnPlatform(
            //    iOS: () =>
            //    {
            //        Padding: new Thickness(0, 20, 0, 0)
            //    }    
            //);
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            label.Text = String.Format("Value Slide is: {0:F2}", e.NewValue);
        }
    }
}