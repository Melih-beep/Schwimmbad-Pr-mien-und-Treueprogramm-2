namespace SchwimmbadTreueprogramm.Models
{
    public class Nutzer
    {
        public int NutzerID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Punkte { get; set; }
        public int Besuche { get; set; }
    }
}
