using DatabaseConnection.Interfaces;

namespace DatabaseConnection.Models
{
    public class Lokacija : IComboBoxStringRep
    {
        public string ID { get; set; }
        public string Naziv { get; set; }

        public string GetStringRepOfClass()
        {
            return "Lokacija";
        }
    }
}