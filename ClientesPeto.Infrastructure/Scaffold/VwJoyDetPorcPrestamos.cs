using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class VwJoyDetPorcPrestamos
    {
        public int FolMov { get; set; }
        public int CveSuc { get; set; }
        public int Id { get; set; }
        public string Prenda { get; set; }
        public decimal Kilataje { get; set; }
        public string SubTipoKilataje { get; set; }
        public decimal PesReal { get; set; }
        public decimal PesConPie { get; set; }
        public decimal Monto { get; set; }
        public bool Exportado { get; set; }
        public decimal PrecioGramo { get; set; }
        public decimal Valuado { get; set; }
        public string DesTipProd { get; set; }
        public int? AnnMov { get; set; }
        public int? MesMov { get; set; }
        public int? DiaMov { get; set; }
        public int CveSucOri { get; set; }
        public decimal CalPrecioGramo { get; set; }
        public decimal? PreSugerido { get; set; }
        public decimal? DifPrestamo { get; set; }
        public decimal? PorcDif { get; set; }
    }
}
