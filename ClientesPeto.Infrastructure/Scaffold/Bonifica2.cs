using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class Bonifica2
    {
        public int FolBon { get; set; }
        public DateTime FecBon { get; set; }
        public int FolMov { get; set; }
        public int CveSuc { get; set; }
        public int IdCaja { get; set; }
        public decimal ImpBon { get; set; }
        public decimal ImpSis { get; set; }
        public int CveUser { get; set; }
        public DateTime FechaReal { get; set; }
        public string Clave { get; set; }
        public short StsEnvio { get; set; }
        public short RegVersion { get; set; }
        public int IdFilaLocal { get; set; }
        public int IdFilaCentral { get; set; }
    }
}
