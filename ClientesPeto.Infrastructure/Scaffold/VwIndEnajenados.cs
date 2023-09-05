using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class VwIndEnajenados
    {
        public int FolMov { get; set; }
        public int CveSuc { get; set; }
        public int IdCaja { get; set; }
        public DateTime FecMov { get; set; }
        public int CveCli { get; set; }
        public string Nomcli { get; set; }
        public DateTime FecVenc { get; set; }
        public DateTime FecCom { get; set; }
        public int CvePla { get; set; }
        public string Despla { get; set; }
        public decimal Capital { get; set; }
        public decimal ValorCom { get; set; }
        public decimal GastosAdm { get; set; }
        public decimal AlmSeg { get; set; }
        public decimal Iva { get; set; }
        public decimal Refrendo { get; set; }
        public decimal Saldo { get; set; }
        public int FolMovOrig { get; set; }
        public bool Cancelada { get; set; }
        public bool Robada { get; set; }
        public bool Enajenado { get; set; }
        public bool Desempeñado { get; set; }
        public int CveTipProd { get; set; }
        public string DesTipProd { get; set; }
        public decimal Monto { get; set; }
        public DateTime FecEnajenado { get; set; }
        public int? Foliooriginal { get; set; }
        public string Ubica { get; set; }
        public int Ubicadet { get; set; }
        public string Prenda { get; set; }
        public decimal Pagado { get; set; }
        public DateTime FecEnajenadoHasta { get; set; }
        public decimal Kilataje { get; set; }
        public string LoteEnaj { get; set; }
        public double? SaldoCapital { get; set; }
        public decimal MontoNuevo { get; set; }
        public string LetraProd { get; set; }
        public decimal PrecioProd { get; set; }
        public bool Recuperado { get; set; }
        public string TmpLoteEnaj { get; set; }
        public DateTime TmpFecEnajenado { get; set; }
        public DateTime TmpFecRecuperacion { get; set; }
        public int TmpCveUserRec { get; set; }
        public string NomUserRec { get; set; }
        public int FolOrigUser { get; set; }
        public string FolOrigLogin { get; set; }
        public string FolOrigNomUser { get; set; }
        public int? NumRefrendos { get; set; }
        public string DesPlazo { get; set; }
        public short DiasPlazo { get; set; }
        public string CveProdExp { get; set; }
        public int? CveSucOrig { get; set; }
        public DateTime FecExporta { get; set; }
        public bool Exportado { get; set; }
    }
}
