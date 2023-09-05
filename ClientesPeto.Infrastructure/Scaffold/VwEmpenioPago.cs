using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class VwEmpenioPago
    {
        public int Cvesuc { get; set; }
        public int? Anio { get; set; }
        public int? Mes { get; set; }
        public decimal? CapitalColocado { get; set; }
        public decimal? CapitalRecuperado { get; set; }
        public decimal? CapitalEnajenado { get; set; }
        public decimal? InteresesCobrados { get; set; }
        public decimal? RecargosCobrados { get; set; }
    }
}
