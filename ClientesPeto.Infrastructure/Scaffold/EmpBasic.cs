using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class EmpBasic
    {
        public int FolOri { get; set; }
        public int FolMov { get; set; }
        public int FolMovOrig { get; set; }
        public int CveSuc { get; set; }
        public int CveCli { get; set; }
        public DateTime Fecalt { get; set; }
        public string Nomcli { get; set; }
        public int AnnMov { get; set; }
        public int MesMov { get; set; }
        public int DiaMov { get; set; }
        public DateTime? FecVenc { get; set; }
        public int CvePla { get; set; }
        public string Descripcion { get; set; }
        public bool? Cancelada { get; set; }
        public bool? Afectada { get; set; }
        public bool? Enajenado { get; set; }
        public bool? Desempeñado { get; set; }
        public int FolPag { get; set; }
        public int? AnnPag { get; set; }
        public int? MesPag { get; set; }
        public int? DiaPag { get; set; }
        public decimal? Capital { get; set; }
        public decimal? Saldo { get; set; }
        public decimal? CapPag { get; set; }
        public decimal? Intereses { get; set; }
        public decimal? Recargos { get; set; }
        public decimal? ImpPag { get; set; }
        public int? CveTipPag { get; set; }
        public string DesTipPag { get; set; }
        public int AnnOri { get; set; }
        public int MesOri { get; set; }
        public int DiaOri { get; set; }
        public int SemMov { get; set; }
        public DateTime? FecPag { get; set; }
        public DateTime? FechaRealPag { get; set; }
        public DateTime FecMov { get; set; }
        public DateTime FechaRealMov { get; set; }
        public decimal? ImpBon { get; set; }
        public decimal? ReimCosto { get; set; }
        public DateTime? RegTimeStamp { get; set; }
        public int? RegVersion { get; set; }
        public string Tipo { get; set; }
        public int? CveTipProd { get; set; }
        public string Producto { get; set; }
        public int? CveUser { get; set; }
        public string NomUser { get; set; }
        public string Login { get; set; }
        public int? CveUserM { get; set; }
        public string NomUserM { get; set; }
        public string LoginM { get; set; }
        public int? StsEnvio { get; set; }
        public int? IdFilaLocal { get; set; }
        public int? IdFilaCentral { get; set; }
    }
}
