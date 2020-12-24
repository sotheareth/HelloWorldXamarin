using HelloWorld.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xunit;

namespace HelloWorld.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactDetailPage : ContentPage
    {
        public ContactDetailPage(Contact contact)
        {
            Assert.False(contact is null, "Null contact passed");
            BindingContext = contact;
            InitializeComponent();
        }
    }
}