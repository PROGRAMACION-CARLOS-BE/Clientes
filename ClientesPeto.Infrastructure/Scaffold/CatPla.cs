using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class CatPla
    {
        public int CvePla { get; set; }
        public short DiasPlazo { get; set; }
        public decimal PorcInt { get; set; }
        public decimal GastosAdm { get; set; }
        public decimal AlmYseg { get; set; }
        public int DiasGracia { get; set; }
        public bool? Promo { get; set; }
        public bool? CuadroCorte1 { get; set; }
        public bool? CuadroCorte2 { get; set; }
        public byte LetraA { get; set; }
        public byte LetraB { get; set; }
        public byte LetraC { get; set; }
        public byte LetraD { get; set; }
        public int RedondeoA { get; set; }
        public byte CampoPrecio { get; set; }
        public short DiasVenc { get; set; }
        public bool? EsJoyeria { get; set; }
        public bool? EsAparatos { get; set; }
        public bool? EsPlata { get; set; }
        public bool? EsAutos { get; set; }
        public decimal PorcRecargo { get; set; }
        public string Descripcion { get; set; }
        public string Leyenda { get; set; }
        public int NumRefGratis { get; set; }
        public decimal DesctoCc { get; set; }
        public bool? Habilitado { get; set; }
        public decimal PorcAumPrecExp { get; set; }
        public decimal PorcDescRefExp { get; set; }
        public bool? Cotizador { get; set; }
        public int NumRefMax { get; set; }
        public int DiasCartVenc { get; set; }
        public short StsEnvio { get; set; }
        public short RegVersion { get; set; }
        public int IdFilaLocal { get; set; }
        public int IdFilaCentral { get; set; }
        public bool EsAutosGps { get; set; }
    }
}
