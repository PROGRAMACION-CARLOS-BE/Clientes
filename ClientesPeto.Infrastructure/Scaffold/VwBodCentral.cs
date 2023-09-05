using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class VwBodCentral
    {
        public int Folmov { get; set; }
        public int Cvesuc { get; set; }
        public int Idcaja { get; set; }
        public DateTime Fecmov { get; set; }
        public DateTime Fecvenc { get; set; }
        public decimal Capital { get; set; }
        public string Ubica { get; set; }
        public string Nomcli { get; set; }
        public string Prenda { get; set; }
        public byte? Tipo { get; set; }
        public int Cvestatus { get; set; }
        public string Desstatus { get; set; }
        public DateTime Fecstatus { get; set; }
        public int Cveuserstatus { get; set; }
        public string Observastatus { get; set; }
        public int Cveuser2status { get; set; }
        public string Observastatus2 { get; set; }
        public int Iddet { get; set; }
        public int? CveTipProd { get; set; }
    }
}
