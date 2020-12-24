using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Extensions
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DateCellView : ViewCell
    {
        public static readonly BindableProperty LabelProperty =
            BindableProperty.Create("Label", typeof(string), typeof(DateCellView));

        public string Label
        {
            get {
                return (string)GetValue(LabelProperty);
            }
            set {
                SetValue(LabelProperty, value);
            }
        }

        public DateCellView()
        {
            InitializeComponent();
            BindingContext = this;
        }


    }
}