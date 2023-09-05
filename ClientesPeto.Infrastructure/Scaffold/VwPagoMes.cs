using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class VwPagoMes
    {
        public int CveSuc { get; set; }
        public int? Anio { get; set; }
        public int? Mes { get; set; }
        public decimal? CapPag { get; set; }
        public decimal? IngPag { get; set; }
        public decimal? RegPag { get; set; }
        public decimal? TotPag { get; set; }
    }
}
