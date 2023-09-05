using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class VwEmpPagos
    {
        public int IdEmpenio { get; set; }
        public int FolMov { get; set; }
        public int? FolMovOriginal { get; set; }
        public int CveSuc { get; set; }
        public int? FolPag { get; set; }
        public DateTime? FecPag { get; set; }
        public decimal CapPag { get; set; }
        public decimal Intereses { get; set; }
        public decimal Recargos { get; set; }
    }
}
