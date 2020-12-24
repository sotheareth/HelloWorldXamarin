using System.Collections.Generic;
using System.Collections.ObjectModel;
using HelloWorld.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewGroupPage : ContentPage
    {
        private ObservableCollection<ContactGroup> _contactGroup;
        public ListViewGroupPage()
        {
            InitializeComponent();

            _contactGroup = new ObservableCollection<ContactGroup>
            {
                new ContactGroup("M", "M") { 
                    new Contact { Name = "Moshit", Status="Inactive", ImageUrl="https://picsum.photos/100/100" },
                },
                new ContactGroup("N", "N") {
                    new Contact { Name = "Nana", Status="Active", ImageUrl="https://picsum.photos/100" }
                }
            };
            listView.ItemsSource = _contactGroup;
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
            var contactGroup = (sender as ContactGroup);
            DisplayAlert("List", "Call" + contactGroup[0].Name, "OK");
        }

        private void Call_Clicked(object sender, System.EventArgs e)
        {
            var contactGroup = (sender as ContactGroup);
            _contactGroup.Remove(contactGroup);
        }
    }
}