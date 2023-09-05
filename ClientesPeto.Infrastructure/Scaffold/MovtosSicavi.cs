using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class MovtosSicavi
    {
        public int CveBod { get; set; }
        public int FolMov { get; set; }
        public int CveMov { get; set; }
        public string SerMov { get; set; }
        public DateTime FecMov { get; set; }
        public decimal ImpMov { get; set; }
        public decimal ImpSub { get; set; }
        public decimal ImpTot { get; set; }
        public string Login { get; set; }
        public string Observ { get; set; }
    }
}
