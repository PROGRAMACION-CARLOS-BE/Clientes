using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class VwIncidencias
    {
        public int Id { get; set; }
        public int CveSucOrig { get; set; }
        public int FolMovOrig { get; set; }
        public int CveInc { get; set; }
        public string DesInc { get; set; }
        public string ObsInc { get; set; }
        public DateTime FechaReal { get; set; }
        public int CveUser { get; set; }
        public string NomUser { get; set; }
        public string Login { get; set; }
        public int Cvecli { get; set; }
        public string Nomcli { get; set; }
        public DateTime FecMov { get; set; }
        public DateTime Fecharealmovto { get; set; }
        public decimal Capital { get; set; }
        public string Prendas { get; set; }
        public int? UltFolio { get; set; }
        public int Cveusermovto { get; set; }
        public string Nomusermovto { get; set; }
        public string Loginmovto { get; set; }
        public bool Enajenado { get; set; }
        public DateTime FecEnajenado { get; set; }
        public string LoteEnaj { get; set; }
        public int CveUserEnaj { get; set; }
        public int? Status { get; set; }
    }
}
