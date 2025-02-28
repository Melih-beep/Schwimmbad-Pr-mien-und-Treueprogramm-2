using System.Windows;
using SchwimmbadTreueprogramm.Data;
using SchwimmbadTreueprogramm.Models;

namespace SchwimmbadTreueprogramm
{
    public partial class MainWindow : Window
    {
        private TreueprogrammContext _context;

        public MainWindow()
        {
            InitializeComponent();
            _context = new TreueprogrammContext();
            _context.Database.EnsureCreated(); // Erstellt die DB falls nicht vorhanden
            DbInitializer.Initialize(_context); // Beispieldaten hinzufügen
            MessageBox.Show(_context.Database.CanConnect() ? "Datenbankverbindung erfolgreich!" : "Fehler: Keine Verbindung zur Datenbank!");

        }

        private void btnRegisterLogin_Click(object sender, RoutedEventArgs e)
        {
            var window = new RegisterLoginWindow();
            window.ShowDialog();
        }

        private void btnShowPoints_Click(object sender, RoutedEventArgs e)
        {
            var window = new ShowPointsWindow();
            window.ShowDialog();
        }

        private void btnRedeemPoints_Click(object sender, RoutedEventArgs e)
        {
            var window = new RedeemPointsWindow();
            window.ShowDialog();
        }

        private void btnAdjustPoints_Click(object sender, RoutedEventArgs e)
        {
            var window = new AdminWindow();
            window.ShowDialog();
        }
    }
}
