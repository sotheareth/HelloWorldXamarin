using HelloWorld.DataAccess;
using HelloWorld.Forms;
using HelloWorld.Navigation;
using HelloWorld.Navigation.TabPage;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    public partial class App : Application
    {
        private readonly string NameKey = "Name";
        private readonly string NotificationEnabledKey = "NotificationEnabled";

        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new FormPage());
            MainPage = new ApplicationPropertiesPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        public string Title
        {
            get
            {
                if (Properties.ContainsKey(NameKey))
                    return Properties[NameKey].ToString();

                return "";
            }
            set
            {
                Properties[NameKey] = value;
            }
        }

        public bool NotificationEnabled
        {
            get
            {
                if (Properties.ContainsKey(NotificationEnabledKey))
                    return (bool)Properties[NotificationEnabledKey];

                return false;
            }
            set
            {
                Properties[NotificationEnabledKey] = value;
            }
        }
    }
}
