using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using HelloWorld.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        private ObservableCollection<Contact> _contact = new ObservableCollection<Contact>
            {
                new Contact { Name = "Moshit", Status="Inactive", ImageUrl="https://picsum.photos/100/100" },
                new Contact { Name = "Nana", Status="Active", ImageUrl="https://picsum.photos/100" }
            };
        public ListViewPage()
        {
            InitializeComponent();

            _contact = GetContact();
            listView.ItemsSource = _contact;
        }

        private ObservableCollection<Contact> GetContact(string textSearch = null)
        {
            if (string.IsNullOrWhiteSpace(textSearch))
                return _contact;

            var result = _contact.Where(c => c.Name.StartsWith(textSearch)).ToList();
            return new ObservableCollection<Contact>(result);
        }

        private void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            //DisplayAlert("List", "" + e.ItemIndex, "OK");
        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //Contact contact = e.SelectedItem as Contact;
            //DisplayAlert("List", "" + contact.Name , "OK");
        }

        private void Delete_Clicked(object sender, System.EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Contact;
            _contact.Remove(contact);
        }

        private void Call_Clicked(object sender, System.EventArgs e)
        {

            var contact = (sender as MenuItem).CommandParameter as Contact;
            DisplayAlert("List", "Call" + contact.Name, "OK");
        }

        private void refresh_listView(object sender, System.EventArgs e)
        {
            listView.ItemsSource = GetContact();
            listView.EndRefresh();
        }

        private void Search_ListView(object sender, TextChangedEventArgs e)
        {
            listView.ItemsSource = GetContact(e.NewTextValue);
        }
    }
}