using System.Windows;

namespace SchwimmbadTreueprogramm
{
    public partial class ShowPointsWindow : Window
    {
        public ShowPointsWindow()
        {
            InitializeComponent();
            txtPoints.Text = "150"; // Platzhalter-Wert
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
