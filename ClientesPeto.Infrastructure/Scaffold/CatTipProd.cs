using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class CatTipProd
    {
        public int CveTipProd { get; set; }
        public string DesTipProd { get; set; }
        public byte Tipo { get; set; }
        public bool? CapUbi { get; set; }
        public DateTime FechaReal { get; set; }
        public int CveUser { get; set; }
        public bool? ValidoLetraA { get; set; }
        public bool? ValidoLetraB { get; set; }
        public bool? ValidoLetraC { get; set; }
        public bool? ValidoLetraD { get; set; }
        public decimal PorcLetraA { get; set; }
        public decimal PorcLetraB { get; set; }
        public decimal PorcLetraC { get; set; }
        public decimal PorcLetraD { get; set; }
        public decimal PorcExp { get; set; }
        public decimal PorcDesctoRef { get; set; }
        public bool? SepararCart { get; set; }
        public bool? Activo { get; set; }
        public short StsEnvio { get; set; }
        public short RegVersion { get; set; }
        public int IdFilaLocal { get; set; }
        public int IdFilaCentral { get; set; }
        public int NumRefGratis { get; set; }
    }
}
