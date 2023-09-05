using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class CajaUsd
    {
        public int FolMov { get; set; }
        public int CveSuc { get; set; }
        public int IdCaja { get; set; }
        public DateTime FecMov { get; set; }
        public decimal MontoUsd { get; set; }
        public decimal MontoPesos { get; set; }
        public decimal TipoCambio { get; set; }
        public int CveUser { get; set; }
        public DateTime FechaReal { get; set; }
        public short StsEnvio { get; set; }
        public short RegVersion { get; set; }
        public int IdFilaLocal { get; set; }
        public int IdFilaCentral { get; set; }
    }
}
