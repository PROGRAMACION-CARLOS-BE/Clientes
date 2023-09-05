using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class VwCapitalEmpenio
    {
        public int CveSuc { get; set; }
        public int? Anio { get; set; }
        public int? Mes { get; set; }
        public decimal? CapTotal { get; set; }
        public decimal? CapVigente { get; set; }
        public decimal? CapVencido { get; set; }
        public decimal? CapDesempeñado { get; set; }
        public decimal? CapEnajenado { get; set; }
    }
}
