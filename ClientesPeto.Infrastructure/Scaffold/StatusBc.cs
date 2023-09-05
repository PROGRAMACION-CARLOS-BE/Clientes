using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class StatusBc
    {
        public int CveStatus { get; set; }
        public string DesStatus { get; set; }
        public bool SoloBc { get; set; }
        public bool ReqUser2 { get; set; }
        public bool ImprimeDocto { get; set; }
        public bool Habilitado { get; set; }
        public DateTime FechaReal { get; set; }
        public int CveUser { get; set; }
        public short StsEnvio { get; set; }
        public short RegVersion { get; set; }
        public int IdFilaLocal { get; set; }
        public int IdFilaCentral { get; set; }
    }
}
