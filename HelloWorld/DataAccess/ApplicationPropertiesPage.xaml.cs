using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.DataAccess
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ApplicationPropertiesPage : ContentPage
    {
        public ApplicationPropertiesPage()
        {
            InitializeComponent();

            BindingContext = Application.Current;
        }
         
    }
}