using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class IndCorteOperaciones
    {
        public int CorteOperacionesId { get; set; }
        public int IndCorteId { get; set; }
        public decimal Importe { get; set; }
        public int NumSemana { get; set; }
        public DateTime FecAlta { get; set; }
        public short StsEnvio { get; set; }
        public short RegVersion { get; set; }
        public int IdFilaLocal { get; set; }
        public int IdFilaCentral { get; set; }
        public DateTime FecRevCentral { get; set; }
        public DateTime FecRevLocal { get; set; }
        public int CveSuc { get; set; }
    }
}
