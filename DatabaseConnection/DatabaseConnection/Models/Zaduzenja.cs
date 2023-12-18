﻿using System;

namespace DatabaseConnection.Models
{
    public class Zaduzenja
    {
        public int KadrovskiBroj { get; set; }
        public int InterniBrojOpreme { get; set; }
        public DateTime DAT_zaduzenja { get; set; }
        public DateTime DAT_razduzenja { get; set; }
        public string FLOK { get; set; }
        public int ZAD_ID { get; set; }
        public int IMT { get; set; }
        public int RIF { get; set; }
    }
}