using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class IndOperaciones
    {
        public int IndicadorId { get; set; }
        public int? IndId { get; set; }
        public string Nombre { get; set; }
        public decimal? Meta { get; set; }
        public decimal Real { get; set; }
        public decimal? Avance { get; set; }
        public decimal? Tendencia { get; set; }
        public decimal? Cumplimiento { get; set; }
        public DateTime Fecha { get; set; }
        public string SucursalId { get; set; }
        public short StsEnvio { get; set; }
        public short RegVersion { get; set; }
        public int IdFilaLocal { get; set; }
        public int IdFilaCentral { get; set; }
        public DateTime FecRevCentral { get; set; }
        public DateTime FecRevLocal { get; set; }
        public int CveSuc { get; set; }
    }
}
