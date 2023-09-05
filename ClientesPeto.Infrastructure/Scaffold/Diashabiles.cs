using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class Diashabiles
    {
        public int FolioId { get; set; }
        public int Mes { get; set; }
        public int Año { get; set; }
        public DateTime FechaInhabil { get; set; }
        public string Sucursal { get; set; }
        public short StsEnvio { get; set; }
        public short RegVersion { get; set; }
        public int IdFilaLocal { get; set; }
        public int IdFilaCentral { get; set; }
        public DateTime FecRevCentral { get; set; }
        public DateTime FecRevLocal { get; set; }
        public int CveSuc { get; set; }
        public int? Activo { get; set; }
    }
}
