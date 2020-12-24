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
    public partial class AbsolutePageByCode : ContentPage
    {
        public AbsolutePageByCode()
        {
            InitializeComponent();

            var layout = new AbsoluteLayout();
            Content = layout;

            var aquaBox = new BoxView { Color = Color.Aqua };
            layout.Children.Add(aquaBox,
                        new Rectangle(0, 0, 100, 100),
                        AbsoluteLayoutFlags.All);
            AbsoluteLayout.SetLayoutBounds(aquaBox, new Rectangle(0, 0, 1, 1));
            AbsoluteLayout.SetLayoutFlags(aquaBox, AbsoluteLayoutFlags.All);

            var whiteBox = new BoxView { Color = Color.White };
            layout.Children.Add(whiteBox,
                        new Rectangle(0.5, 0.1, 100, 100),
                        AbsoluteLayoutFlags.PositionProportional);

            var button = new Button { Text = "Get Started" };
            layout.Children.Add(button, new Rectangle(0.5, 1, 1, 50), AbsoluteLayoutFlags.PositionProportional | AbsoluteLayoutFlags.WidthProportional);

        }
    }
}