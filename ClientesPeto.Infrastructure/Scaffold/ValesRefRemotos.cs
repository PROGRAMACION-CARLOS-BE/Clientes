using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class ValesRefRemotos
    {
        public int Cvesuc { get; set; }
        public int Folmovorig { get; set; }
        public int Folmov { get; set; }
        public int Folmovnvo { get; set; }
        public int Numref { get; set; }
        public int Cveuser { get; set; }
        public DateTime Fechareal { get; set; }
        public decimal Importe { get; set; }
        public decimal Importevale { get; set; }
        public short StsEnvio { get; set; }
        public short RegVersion { get; set; }
        public int IdFilaLocal { get; set; }
        public int IdFilaCentral { get; set; }
        public bool EsRemoto { get; set; }
        public string Login { get; set; }
        public bool Cancelado { get; set; }
        public DateTime FecCancel { get; set; }
        public int CveUserCancel { get; set; }
        public string LoginCancel { get; set; }
    }
}
