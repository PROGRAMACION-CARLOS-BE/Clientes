using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class VwIndCartera
    {
        public DateTime Fecha { get; set; }
        public int? AnnCar { get; set; }
        public int? MesCar { get; set; }
        public int? DiaCar { get; set; }
        public double? CapitalVigente { get; set; }
        public double? CapitalVencido { get; set; }
        public double? CapEnajxRec { get; set; }
        public double? CapEnajxExp { get; set; }
        public string Tipo { get; set; }
    }
}
