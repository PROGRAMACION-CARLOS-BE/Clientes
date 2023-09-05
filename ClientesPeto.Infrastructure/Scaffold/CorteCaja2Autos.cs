using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class CorteCaja2Autos
    {
        public DateTime Fecha { get; set; }
        public double CapitalVigente { get; set; }
        public double CapitalVencido { get; set; }
        public DateTime FechaReal { get; set; }
        public double InteresVigente { get; set; }
        public double InteresVencido { get; set; }
        public int EsAparatos { get; set; }
    }
}
