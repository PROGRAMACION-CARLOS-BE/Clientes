using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class MovtosTmpCorte2Autos
    {
        public int FolMov { get; set; }
        public int CveSuc { get; set; }
        public DateTime FecMov { get; set; }
        public DateTime FecVenc { get; set; }
        public int CvePla { get; set; }
        public decimal Capital { get; set; }
        public DateTime FecDesemp { get; set; }
        public DateTime FecEnajenado { get; set; }
        public int DiasComer { get; set; }
        public bool? Promo { get; set; }
        public decimal Pagado { get; set; }
    }
}
