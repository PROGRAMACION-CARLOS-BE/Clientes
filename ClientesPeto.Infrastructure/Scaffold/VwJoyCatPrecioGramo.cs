using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class VwJoyCatPrecioGramo
    {
        public decimal Kilataje { get; set; }
        public string SubTipoKilataje { get; set; }
        public decimal PrecioGramo { get; set; }
        public int? AnnMov { get; set; }
        public int? MesMov { get; set; }
        public int? DiaMov { get; set; }
    }
}
