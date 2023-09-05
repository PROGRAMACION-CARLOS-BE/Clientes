using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class CatMovCaja
    {
        public int CveMovCaja { get; set; }
        public string DesMovCaja { get; set; }
        public int TipoMovCaja { get; set; }
        public DateTime FechaReal { get; set; }
        public int CveUser { get; set; }
        public bool? ReqLlave { get; set; }
        public short StsEnvio { get; set; }
        public short RegVersion { get; set; }
        public int IdFilaLocal { get; set; }
        public int IdFilaCentral { get; set; }
        public int CveEmp { get; set; }
        public int IdExportar { get; set; }
        public bool DesctaEfec { get; set; }
        public bool EsCredFinDin { get; set; }
        public bool ReqFirmaAdic { get; set; }
        public bool Habilitado { get; set; }
        public bool Interno { get; set; }
    }
}
