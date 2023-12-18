using DatabaseConnection.Interfaces;

namespace DatabaseConnection.Models
{
    public class RIF : IComboBoxStringRep
    {
        public int ID { get; set; }
        public string Narudzbenica { get; set; }
        public string Racun { get; set; }
        public int DMS_BR_dokumenta { get; set; }
        public string InvesticijskiNalog { get; set; }

        public string GetStringRepOfClass()
        {
            return "RIF";
        }
    }
}