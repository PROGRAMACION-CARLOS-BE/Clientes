using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class VwEmpMovttoPagos
    {
        public int CveSuc { get; set; }
        public int? FolOri { get; set; }
        public int? CveTipProd { get; set; }
        public string Producto { get; set; }
        public byte? Tipo { get; set; }
        public int? AnnPag { get; set; }
        public int? MesPag { get; set; }
        public int? DiaPag { get; set; }
        public decimal? CapitalOri { get; set; }
        public decimal? Capital { get; set; }
        public decimal? Saldo { get; set; }
        public decimal? CapPag { get; set; }
        public decimal? Intereses { get; set; }
        public decimal? Recargos { get; set; }
        public decimal? ImpPag { get; set; }
        public string DesTipPag { get; set; }
        public string Login { get; set; }
        public string NomUser { get; set; }
    }
}
