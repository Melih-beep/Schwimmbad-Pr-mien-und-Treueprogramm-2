using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace SchwimmbadTreueprogramm
{
    public partial class RegisterLoginWindow : Window
    {
        public RegisterLoginWindow()
        {
            InitializeComponent();
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb != null && (tb.Text == "Benutzername"))
            {
                tb.Text = "";
                tb.Foreground = Brushes.Black;
            }
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb != null && string.IsNullOrWhiteSpace(tb.Text))
            {
                tb.Text = "Benutzername";
                tb.Foreground = Brushes.Gray;
            }
        }
    }
}
