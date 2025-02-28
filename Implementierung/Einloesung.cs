using System;

namespace SchwimmbadTreueprogramm.Models
{
    public class Einloesung
    {
        public int EinloesungID { get; set; }
        public int NutzerID { get; set; }
        public string Typ { get; set; } // "Rabatt" oder "Freikarte"
        public DateTime Datum { get; set; }
    }
}
