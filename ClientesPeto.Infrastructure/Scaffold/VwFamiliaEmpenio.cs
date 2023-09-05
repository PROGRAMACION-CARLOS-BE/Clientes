using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class VwFamiliaEmpenio
    {
        public int IdEmpenio { get; set; }
        public int? IdFamilia { get; set; }
        public string NomFamilia { get; set; }
        public int Cvepla { get; set; }
        public int? FolioOriginal { get; set; }
        public int? UltimoFolio { get; set; }
        public DateTime? Inicia { get; set; }
        public DateTime? Termina { get; set; }
        public int? DiasEmpenio { get; set; }
        public int? Refrendos { get; set; }
        public decimal? Capital { get; set; }
    }
}
