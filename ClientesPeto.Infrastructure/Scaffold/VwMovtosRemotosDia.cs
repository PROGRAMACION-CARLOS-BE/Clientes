using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class VwMovtosRemotosDia
    {
        public int Idmovto { get; set; }
        public int Cvesucorigen { get; set; }
        public int Folmov { get; set; }
        public int Cvesuc { get; set; }
        public string NomSuc { get; set; }
        public int Folmovorig { get; set; }
        public int Cvesucorig { get; set; }
        public string Nomsucorig { get; set; }
        public bool Esrefrendo { get; set; }
        public bool Esdesempeño { get; set; }
        public int Cveuser { get; set; }
        public decimal Capital { get; set; }
        public decimal Interes { get; set; }
        public decimal Recargos { get; set; }
        public decimal Total { get; set; }
        public bool Esremoto { get; set; }
        public string Login { get; set; }
        public DateTime FechaReal { get; set; }
        public string TipoMovto { get; set; }
        public bool Cancelado { get; set; }
        public DateTime Feccancel { get; set; }
        public string Logincancel { get; set; }
    }
}
