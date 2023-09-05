using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class VwClienteEmpenio
    {
        public int IdEmpenio { get; set; }
        public int CveSuc { get; set; }
        public int CveCli { get; set; }
        public string NomCli { get; set; }
        public int CvePla { get; set; }
        public int? FolioOriginal { get; set; }
        public int? Refrendos { get; set; }
        public int? UltimoFolio { get; set; }
        public DateTime? Inicia { get; set; }
        public DateTime? Termina { get; set; }
        public decimal? Capital { get; set; }
        public decimal? CapitalPagado { get; set; }
        public decimal? InteresesPagados { get; set; }
        public decimal? RecargosPagados { get; set; }
        public decimal? Vencido { get; set; }
        public decimal FactorDescto { get; set; }
        public decimal? ValorCte { get; set; }
    }
}
