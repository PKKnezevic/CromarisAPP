using DatabaseConnection.Interfaces;

namespace DatabaseConnection.Models
{
    public class MT : IComboBoxStringRep
    {
        public int SAP_sifra { get; set; }
        public string Naziv_MT { get; set; }

        public string GetStringRepOfClass()
        {
            return "MT";
        }
    }
}