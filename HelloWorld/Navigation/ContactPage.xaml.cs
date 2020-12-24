using HelloWorld.Model;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactPage : ContentPage
    {
        private ObservableCollection<Contact> _contact = new ObservableCollection<Contact>
        {
            new Contact { Name = "Moshit", Status="Inactive", ImageUrl="https://picsum.photos/100/100" },
            new Contact { Name = "Nana", Status="Active", ImageUrl="https://picsum.photos/100" }
        };

        public ContactPage()
        {
            InitializeComponent();
            listView.ItemsSource = _contact;
        }

        private async void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (listView.SelectedItem == null)
                return;

            var contact = e.SelectedItem as Contact;
            await Navigation.PushAsync(new ContactDetailPage(contact));
            listView.SelectedItem = null;
        }
    }
}