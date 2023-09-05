using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class MovtosRemotos
    {
        public int IdMovto { get; set; }
        public int CveSucOrigen { get; set; }
        public int FolMov { get; set; }
        public int CveSuc { get; set; }
        public int FolMovOrig { get; set; }
        public int CveSucOrig { get; set; }
        public bool EsRefrendo { get; set; }
        public bool EsDesEmpeño { get; set; }
        public int CveUser { get; set; }
        public decimal Capital { get; set; }
        public decimal Interes { get; set; }
        public decimal Recargos { get; set; }
        public decimal Total { get; set; }
        public bool EsRemoto { get; set; }
        public DateTime FechaReal { get; set; }
        public string Login { get; set; }
        public bool Cancelado { get; set; }
        public DateTime Feccancel { get; set; }
        public int Cveusercancel { get; set; }
        public string Logincancel { get; set; }
    }
}
