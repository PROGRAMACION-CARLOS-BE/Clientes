using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class FecUltMovtoCte
    {
        public int CveSuc { get; set; }
        public int CveCli { get; set; }
        public DateTime UltimoMov { get; set; }
        public int StsEnvio { get; set; }
        public int RegVersion { get; set; }
        public int IdFilaLocal { get; set; }
        public int IdFilaCentral { get; set; }
    }
}
