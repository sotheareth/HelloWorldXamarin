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
    public partial class GridPageByCode : ContentPage
    {
        public GridPageByCode()
        {
            InitializeComponent();
            var grid = new Grid
            {
                RowSpacing = 20,
                ColumnSpacing = 40
            };

            var label = new Label { Text="Label 1" };
            grid.Children.Add(label, 0, 0);
            var label2 = new Label { Text = "Label 2" };
            var label3 = new Label { Text = "Label 3" };
            var label4 = new Label { Text = "Label 4" };
            grid.Children.Add(label2, 0, 1);
            grid.Children.Add(label3, 0, 1);
            grid.Children.Add(label4, 0, 1);
            //Grid.SetRowSpan(label, 2);
            //Grid.SetColumnSpan(label, 2);
            Grid.SetRow(label, 0);
            Grid.SetColumn(label, 0);
            Grid.SetRow(label2, 0);
            Grid.SetColumn(label2, 1);
            Grid.SetRow(label3, 1);
            Grid.SetColumn(label3, 0);
            Grid.SetRow(label4, 1);
            Grid.SetColumn(label4, 1);
            grid.BackgroundColor = Color.Yellow;
            grid.ColumnSpacing = 20;
            grid.RowSpacing = 20;

            Content = grid;
        }
    }
}