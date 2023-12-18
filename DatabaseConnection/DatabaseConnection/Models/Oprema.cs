using System;

namespace DatabaseConnection.Models
{
    public class Oprema
    {
        public int InterniBroj { get; set; }
        public int SerijskiBroj { get; set; }
        public string Dobavljac { get; set; }
        public int RIF_ID { get; set; }
        public string NazivSAP { get; set; }
        public int SAP_sifra { get; set; }
        public DateTime DAT_aktivacije { get; set; }
        public bool EU_fond { get; set; }
        public DateTime DAT_primke { get; set; }
        public string IP_adresa { get; set; }
        public DateTime DAT_zaprimanja { get; set; }
    }
}