using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace RestaurantPOS.Views
{
    public partial class DeliveryView : UserControl
    {
        public DeliveryView()
        {
            InitializeComponent();
            this.Loaded += UserControl_Loaded; // Attach event properly
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            // Show popup on load
            CustomerPopup.Visibility = Visibility.Visible;
        }

        private void ConfirmCustomer_Click(object sender, RoutedEventArgs e)
        {
            // Validate inputs (basic validation)
            if (!string.IsNullOrWhiteSpace(CustomerNameBox.Text) &&
                !string.IsNullOrWhiteSpace(CustomerPhoneBox.Text) &&
                CustomerNameBox.Foreground != Brushes.Gray &&
                CustomerPhoneBox.Foreground != Brushes.Gray)
            {
                CustomerPopup.Visibility = Visibility.Collapsed;
                // Future: Save or load customer details from DB
            }
            else
            {
                MessageBox.Show("Please enter valid customer details.");
            }
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string query = SearchBox.Text.Trim();
            if (!string.IsNullOrEmpty(query) && SearchBox.Foreground != Brushes.Gray)
            {
                MessageBox.Show($"Searched for: {query} (implement actual DB lookup here)");
            }
            else
            {
                MessageBox.Show("Enter a valid search term.");
            }
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

        // Simulate PlaceholderText
        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb.Foreground == Brushes.Gray)
            {
                tb.Text = "";
                tb.Foreground = Brushes.Black;
            }
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                if (tb == SearchBox) tb.Text = "Search by name or phone...";
                else if (tb == CustomerNameBox) tb.Text = "Customer Name";
                else if (tb == CustomerPhoneBox) tb.Text = "Phone Number";
                else if (tb == CustomerAddressBox) tb.Text = "Address";

                tb.Foreground = Brushes.Gray;
            }
        }
    }
}
