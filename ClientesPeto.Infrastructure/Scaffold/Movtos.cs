using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class Movtos
    {
        public int FolMov { get; set; }
        public int CveSuc { get; set; }
        public int IdCaja { get; set; }
        public int CveCli { get; set; }
        public DateTime FecMov { get; set; }
        public DateTime FecVenc { get; set; }
        public DateTime FecCom { get; set; }
        public int CvePla { get; set; }
        public decimal Capital { get; set; }
        public decimal ValorCom { get; set; }
        public decimal GastosAdm { get; set; }
        public decimal AlmSeg { get; set; }
        public decimal Iva { get; set; }
        public decimal Refrendo { get; set; }
        public decimal Saldo { get; set; }
        public string Letras { get; set; }
        public int FolMovOrig { get; set; }
        public int CveSucOrig { get; set; }
        public string Observa { get; set; }
        public int CveUser { get; set; }
        public DateTime FechaReal { get; set; }
        public bool? Cancelada { get; set; }
        public bool? Afectada { get; set; }
        public bool? Enajenado { get; set; }
        public bool? Desempeñado { get; set; }
        public DateTime FecDesemp { get; set; }
        public DateTime FecEnajenado { get; set; }
        public string Ubica { get; set; }
        public bool? Robada { get; set; }
        public DateTime FecEnajenadoHasta { get; set; }
        public int CveUserRob { get; set; }
        public int CveUserEnaj { get; set; }
        public int CveUserCanc { get; set; }
        public DateTime FecCancelada { get; set; }
        public DateTime FecRobada { get; set; }
        public string Clave { get; set; }
        public string LoteEnaj { get; set; }
        public string FechasPromo { get; set; }
        public decimal TotalPeso { get; set; }
        public decimal TotalPeso2 { get; set; }
        public int CveUserAut { get; set; }
        public bool? Recuperado { get; set; }
        public string TmpLoteEnaj { get; set; }
        public DateTime TmpFecEnajenado { get; set; }
        public DateTime TmpFecRecuperacion { get; set; }
        public int TmpCveUserRec { get; set; }
        public string CodigoBarras1 { get; set; }
        public string CodigoBarras2 { get; set; }
        public string CodigoBarras3 { get; set; }
        public string CodigoBarras4 { get; set; }
        public int CveBod { get; set; }
        public DateTime FecUbi { get; set; }
        public int CveUserUbi { get; set; }
        public int CveCli2 { get; set; }
        public string NomBen { get; set; }
        public string FolioBolsa { get; set; }
        public int StsEnvio { get; set; }
        public int RegVersion { get; set; }
        public int IdFilaLocal { get; set; }
        public int IdFilaCentral { get; set; }
        public int CveCliRevLocal { get; set; }
        public DateTime? RegTimeStamp { get; set; }
        public int? FolMovPrim { get; set; }
        public bool BloqueoExp { get; set; }
        public int CveUserBloqueoExp { get; set; }
        public DateTime FecBloqueoExp { get; set; }
        public int CveSucOri { get; set; }
        public int CveUserResp { get; set; }
        public int CveUserGte { get; set; }
    }
}
