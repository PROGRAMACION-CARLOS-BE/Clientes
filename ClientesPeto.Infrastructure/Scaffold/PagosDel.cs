using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class PagosDel
    {
        public int FolPag { get; set; }
        public int CveSuc { get; set; }
        public int IdCaja { get; set; }
        public DateTime FecPag { get; set; }
        public decimal Capital { get; set; }
        public decimal Interes { get; set; }
        public decimal Recargos { get; set; }
        public decimal ImpPag { get; set; }
        public string Letras { get; set; }
        public int CveUser { get; set; }
        public DateTime FechaReal { get; set; }
        public int CveTipPag { get; set; }
        public int FolMov { get; set; }
        public string Clave { get; set; }
        public short StsEnvio { get; set; }
        public short RegVersion { get; set; }
        public int IdFilaLocal { get; set; }
        public int IdFilaCentral { get; set; }
        public bool EsRemoto { get; set; }
        public int CveUserCanc { get; set; }
        public DateTime FecCancelada { get; set; }
        public string LoginCanc { get; set; }
    }
}
