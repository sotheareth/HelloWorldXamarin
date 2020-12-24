using HelloWorld.Extensions;
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
    public partial class FormPage : ContentPage
    {
        public FormPage()
        {
            InitializeComponent();
        }

        private void ViewCell_Tapped(object sender, EventArgs e)
        {
            var page = new ContactMethodsPage();
            page.ContactMethods.ItemSelected += ContactMethods_ItemSelected;
            Navigation.PushAsync(page);
        }

        private void ContactMethods_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            contactMethod.Text = e.SelectedItem.ToString();
            Navigation.PopAsync();
        }
    }
}