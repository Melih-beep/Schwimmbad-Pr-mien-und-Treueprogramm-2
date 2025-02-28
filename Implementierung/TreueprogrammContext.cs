using Microsoft.EntityFrameworkCore;
using Schwimmbad_2._3;
using SchwimmbadTreueprogramm.Models;

namespace SchwimmbadTreueprogramm.Data
{
    public class TreueprogrammContext : DbContext
    {
        public DbSet<Nutzer> Nutzer { get; set; }
        public DbSet<Einloesung> Einloesung { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Für SQLite:
            optionsBuilder.UseSqlite("Data Source=treueprogramm.db");
        }
    }
}
