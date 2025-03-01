using System.Linq;
using MyProject.Data;
using MyProject.Models;

namespace MyProject.Repositories
{
    public class NutzerRepository
    {
        public void EnsureDatabaseCreated()
        {
            using var context = new AppDbContext();
            context.Database.EnsureCreated();
        }

        public Nutzer GetByEmail(string email)
        {
            using var context = new AppDbContext();
            return context.Nutzer.FirstOrDefault(n => n.Email == email);
        }

        public void AddNutzer(Nutzer nutzer)
        {
            using var context = new AppDbContext();
            context.Nutzer.Add(nutzer);
            context.SaveChanges();
        }

        public void UpdateNutzer(Nutzer nutzer)
        {
            using var context = new AppDbContext();
            context.Nutzer.Update(nutzer);
            context.SaveChanges();
        }
    }
}
