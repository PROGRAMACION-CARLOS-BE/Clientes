using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class Resguardos
    {
        public int FolRes { get; set; }
        public int CveSucRes { get; set; }
        public int IdCaja { get; set; }
        public int FolMovOrig { get; set; }
        public int CveSucOrig { get; set; }
        public int CveBod { get; set; }
        public DateTime FecRes { get; set; }
        public int CveUser { get; set; }
        public DateTime FechaReal { get; set; }
        public short StsEnvio { get; set; }
        public short RegVersion { get; set; }
        public int IdFilaLocal { get; set; }
        public int IdFilaCentral { get; set; }
    }
}
