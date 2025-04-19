using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RestaurantPOS.Views
{
    public partial class DineInView : UserControl
    {
        public DineInView()
        {
            InitializeComponent();
        }
        private void Item1_Click(object sender, RoutedEventArgs e)
        {
            SubItemsPanel.Children.Clear();

            SubItemsPanel.Children.Add(new TextBlock
            {
                Text = "Burgers",
                FontSize = 16,
                FontWeight = FontWeights.Bold,
                Margin = new Thickness(0, 0, 0, 10)
            });

            SubItemsPanel.Children.Add(new Button { Content = "Grilled Burger", Margin = new Thickness(5), Height = 30 });
            SubItemsPanel.Children.Add(new Button { Content = "Zinger Burger", Margin = new Thickness(5), Height = 30 });
            SubItemsPanel.Children.Add(new Button { Content = "Cheese Burger", Margin = new Thickness(5), Height = 30 });
        }
    }
}


