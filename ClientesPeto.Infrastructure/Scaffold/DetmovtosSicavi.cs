using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class DetmovtosSicavi
    {
        public int CveBod { get; set; }
        public int FolMov { get; set; }
        public int CveMov { get; set; }
        public string SerMov { get; set; }
        public int Id { get; set; }
        public string CveProd { get; set; }
        public decimal Cant { get; set; }
        public decimal PreUni { get; set; }
        public decimal ImpSub { get; set; }
        public string DesProd { get; set; }
    }
}
