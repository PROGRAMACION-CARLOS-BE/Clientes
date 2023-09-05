using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class VwEmpBasicFamilia
    {
        public int IdEmpenio { get; set; }
        public int FolMov { get; set; }
        public int? FolMovOriginal { get; set; }
        public int CveSuc { get; set; }
        public int CveCli { get; set; }
        public string NomCli { get; set; }
        public DateTime FecMov { get; set; }
        public DateTime FecVenc { get; set; }
        public int CvePla { get; set; }
        public string Descripcion { get; set; }
        public bool Cancelada { get; set; }
        public bool Afectada { get; set; }
        public bool Enajenado { get; set; }
        public bool Desempeñado { get; set; }
        public decimal? Capital { get; set; }
        public int? Id { get; set; }
        public string Prenda { get; set; }
        public int? IdFamilia { get; set; }
        public string NomFamilia { get; set; }
        public int? IdMenor { get; set; }
    }
}
