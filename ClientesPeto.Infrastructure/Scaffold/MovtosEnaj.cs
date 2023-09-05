using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class MovtosEnaj
    {
        public int Folmov { get; set; }
        public int? Folioorig { get; set; }
        public bool EnajFinal { get; set; }
        public DateTime Fecenajenado { get; set; }
        public int CveUserEnaj { get; set; }
        public DateTime FecEnajenadoHasta { get; set; }
        public bool? EnajOrig { get; set; }
        public short StsEnvio { get; set; }
        public short RegVersion { get; set; }
        public int IdFilaLocal { get; set; }
        public int IdFilaCentral { get; set; }
    }
}
