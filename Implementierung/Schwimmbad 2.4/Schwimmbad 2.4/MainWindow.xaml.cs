using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using MyProject.Models;
using MyProject.Repositories;

namespace MyProject.Views
{
    public partial class MainWindow : Window
    {
        private readonly NutzerRepository repository = new NutzerRepository();

        public MainWindow()
        {
            InitializeComponent();
            repository.EnsureDatabaseCreated();
        }

        // Fade-In Animation beim Tabwechsel
        private void MainTabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MainTabControl.SelectedContent is UIElement tabContent && tabContent is FrameworkElement fe)
            {
                fe.Opacity = 0;
                var storyboard = (Storyboard)Resources["FadeInStoryboard"];
                storyboard.Begin(fe);
            }
        }

        // Registrierung / Login
        private void LoginRegister_Click(object sender, RoutedEventArgs e)
        {
            string email = txtEmailLogin.Text.Trim();
            string name = txtNameLogin.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                txtResultLogin.Text = "Bitte E-Mail eingeben.";
                return;
            }

            var user = repository.GetByEmail(email);
            if (user != null)
            {
                user.Punkte += 1;
                user.Besuche += 1;
                repository.UpdateNutzer(user);
                txtResultLogin.Text = $"Erfolgreich eingeloggt! Punkte: {user.Punkte}, Besuche: {user.Besuche}";
            }
            else
            {
                if (string.IsNullOrEmpty(name))
                {
                    txtResultLogin.Text = "Name muss für die Registrierung eingegeben werden.";
                    return;
                }
                Nutzer newUser = new Nutzer
                {
                    Email = email,
                    Name = name,
                    Punkte = 1,
                    Besuche = 1
                };
                repository.AddNutzer(newUser);
                txtResultLogin.Text = "Registrierung erfolgreich! Du hast 1 Punkt für den ersten Besuch erhalten.";
            }
        }

        // Punkte anzeigen
        private void ShowPoints_Click(object sender, RoutedEventArgs e)
        {
            string email = txtEmailShow.Text.Trim();
            var user = repository.GetByEmail(email);
            txtResultShow.Text = user != null
                ? $"Name: {user.Name}, Punkte: {user.Punkte}, Besuche: {user.Besuche}"
                : "Nutzer nicht gefunden!";
        }

        // Punkte einlösen
        private void RedeemPoints_Click(object sender, RoutedEventArgs e)
        {
            string email = txtEmailRedeem.Text.Trim();
            var user = repository.GetByEmail(email);
            if (user == null)
            {
                txtResultRedeem.Text = "Nutzer nicht gefunden!";
                return;
            }

            string choice = txtChoiceRedeem.Text.Trim();
            if (choice == "1")
            {
                if (user.Punkte >= 5)
                {
                    user.Punkte -= 5;
                    repository.UpdateNutzer(user);
                    txtResultRedeem.Text = "Rabatt erfolgreich eingelöst!";
                }
                else
                {
                    txtResultRedeem.Text = "Nicht genügend Punkte für Rabatt!";
                }
            }
            else if (choice == "2")
            {
                if (user.Punkte >= 10)
                {
                    user.Punkte -= 10;
                    repository.UpdateNutzer(user);
                    txtResultRedeem.Text = "Freikarte erfolgreich eingelöst!";
                }
                else
                {
                    txtResultRedeem.Text = "Nicht genügend Punkte für Freikarte!";
                }
            }
            else
            {
                txtResultRedeem.Text = "Ungültige Auswahl!";
            }
        }

        // Admin: Punkte anpassen
        private void AdjustPoints_Click(object sender, RoutedEventArgs e)
        {
            string adminEmail = txtAdminEmail.Text.Trim();
            string adminPass = txtAdminPassword.Password.Trim();

            if (adminEmail != "melih@gmail.com" || adminPass != "melih")
            {
                txtResultAdmin.Text = "Unberechtigter Zugriff oder falsches Passwort.";
                return;
            }

            string targetEmail = txtTargetEmail.Text.Trim();
            var user = repository.GetByEmail(targetEmail);
            if (user == null)
            {
                txtResultAdmin.Text = "Zielnutzer nicht gefunden!";
                return;
            }

            if (int.TryParse(txtNewPoints.Text.Trim(), out int newPoints))
            {
                user.Punkte = newPoints;
                repository.UpdateNutzer(user);
                txtResultAdmin.Text = "Punktestand erfolgreich angepasst!";
            }
            else
            {
                txtResultAdmin.Text = "Ungültige Zahl.";
            }
        }
    }
}
