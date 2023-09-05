using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class Base
    {
        public int BaseId { get; set; }
        public int? IndId { get; set; }
        public string NomIndicador { get; set; }
        public decimal? ValBaseAjus { get; set; }
        public decimal? ValBase { get; set; }
        public string SucursalId { get; set; }
        public string AliadoId { get; set; }
        public int Mes { get; set; }
        public int Anio { get; set; }
        public short StsEnvio { get; set; }
        public short RegVersion { get; set; }
        public int IdFilaLocal { get; set; }
        public int IdFilaCentral { get; set; }
        public DateTime FecRevCentral { get; set; }
        public DateTime FecRevLocal { get; set; }
        public int CveSuc { get; set; }
    }
}
