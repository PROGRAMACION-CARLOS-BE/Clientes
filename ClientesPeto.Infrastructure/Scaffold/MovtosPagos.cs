using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class MovtosPagos
    {
        public int FolMov { get; set; }
        public int CveSuc { get; set; }
        public decimal Capital { get; set; }
        public decimal Interes { get; set; }
        public decimal Recargos { get; set; }
        public int NumReImp { get; set; }
        public decimal ImpReImp { get; set; }
        public int NumValesRef { get; set; }
        public decimal ImpValesRef { get; set; }
        public string HistFolios { get; set; }
    }
}
