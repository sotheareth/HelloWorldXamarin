using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarousellPage : CarouselPage
    {
        public CarousellPage()
        {
            InitializeComponent();
        }

        private async void Delete_Click(object sender, System.EventArgs e)
        {
            var response = await DisplayAlert("Confirm", "Are you sure to delete this item?", "Yes", "No");
            if(response)
            {
                await DisplayAlert("Done", "Answer is: " + response, "OK");
            }
        }

        private async void Send_Click(object sender, System.EventArgs e)
        {
            var response = await DisplayActionSheet("Confirm", "Cancel", "Delete", "Copy Link", "Message", "Email");
            await DisplayAlert("Done", "Answer is: " + response, "OK");
            
        }
    }
}