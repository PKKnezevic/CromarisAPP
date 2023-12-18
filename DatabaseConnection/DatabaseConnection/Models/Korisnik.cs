using DatabaseConnection.Interfaces;

namespace DatabaseConnection.Models
{
    public class Korisnik : IComboBoxStringRep
    {
        public int KadrovskiBroj { get; set; }
        public string ImePrezime { get; set; }

        public string GetStringRepOfClass()
        {
            return "Korisnik";
        }
    }
    
}