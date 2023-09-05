using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class DetCliNotas
    {
        public int CveCli { get; set; }
        public int IdNota { get; set; }
        public DateTime FecNota { get; set; }
        public string Nota { get; set; }
        public bool? Ocultar { get; set; }
        public int CveUser { get; set; }
        public int CveUserOculta { get; set; }
        public DateTime FecOcultar { get; set; }
        public short StsEnvio { get; set; }
        public short RegVersion { get; set; }
        public int IdFilaLocal { get; set; }
        public int IdFilaCentral { get; set; }
    }
}
