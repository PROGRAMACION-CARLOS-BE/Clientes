using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class VwEmpMovttoEfectivoDetalle
    {
        public int CveSuc { get; set; }
        public int CveSucEmp { get; set; }
        public int? AnnMov { get; set; }
        public int? MesMov { get; set; }
        public int? DiaMov { get; set; }
        public int FolPag { get; set; }
        public DateTime? FechaRealPag { get; set; }
        public int? AnnPag { get; set; }
        public int? MesPag { get; set; }
        public int? DiaPag { get; set; }
        public int? CveTipPag { get; set; }
        public string DesTipPag { get; set; }
        public string DesTipPag2 { get; set; }
        public int? FolOri { get; set; }
        public int FolMov { get; set; }
        public bool? Cancelada { get; set; }
        public int FolMovOrig { get; set; }
        public decimal? Capital { get; set; }
        public decimal CapPag { get; set; }
        public decimal Intereses { get; set; }
        public decimal Recargos { get; set; }
        public decimal? ImpPag { get; set; }
        public decimal ImpBon { get; set; }
        public decimal ReimCosto { get; set; }
        public byte? Tipo { get; set; }
        public int? CveTipProd { get; set; }
        public string Producto { get; set; }
        public int? CveUser { get; set; }
        public string NomUser { get; set; }
        public string Login { get; set; }
        public int? CveCli { get; set; }
        public string Nomcli { get; set; }
        public string NomSuc { get; set; }
    }
}
