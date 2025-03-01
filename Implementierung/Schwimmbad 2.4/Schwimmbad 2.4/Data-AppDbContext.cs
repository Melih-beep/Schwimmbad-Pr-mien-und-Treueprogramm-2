using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using MyProject.Models;

namespace MyProject.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Nutzer> Nutzer { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Verwendung von SQLite als Datenbank
            optionsBuilder.UseSqlite("Data Source=app.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed-Daten: Beispieldatensätze (mindestens drei Einträge)
            modelBuilder.Entity<Nutzer>().HasData(
                new Nutzer { Id = 1, Email = "Max@gmail.com", Name = "Max Mustermann", Punkte = 10, Besuche = 1 },
                new Nutzer { Id = 2, Email = "Erika@gmail.com", Name = "Erika Mustermann", Punkte = 8, Besuche = 1 },
                new Nutzer { Id = 3, Email = "John@gmail.com", Name = "John Doe", Punkte = 5, Besuche = 1 }
            );
        }
    }
}
