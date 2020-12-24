using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Forms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DateTimePickerPage : ContentPage
    {
        public DateTimePickerPage()
        {
            InitializeComponent();
        }

        private void DatePicker_Selected(object sender, DateChangedEventArgs e)
        {

        }
    }
}