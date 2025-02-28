using System.Linq;
using SchwimmbadTreueprogramm.Models;

namespace SchwimmbadTreueprogramm.Data
{
    public static class DbInitializer
    {
        public static void Initialize(TreueprogrammContext context)
        {
            if (context.Nutzer.Any())
            {
                // DB wurde bereits initialisiert
                return;
            }

            // Beispieldaten
            var nutzer = new Nutzer[]
            {
                new Nutzer { Name = "Max Mustermann", Email = "max@example.com", Punkte = 5, Besuche = 3 },
                new Nutzer { Name = "Erika Musterfrau", Email = "erika@example.com", Punkte = 8, Besuche = 4 },
                new Nutzer { Name = "Melih", Email = "melih@gmail.com", Punkte = 12, Besuche = 6 }
            };
            foreach (var n in nutzer)
            {
                context.Nutzer.Add(n);
            }
            context.SaveChanges();
        }
    }
}
