using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class DetCajaUsd
    {
        public int FolMov { get; set; }
        public int CveSuc { get; set; }
        public int IdDet { get; set; }
        public int Cant { get; set; }
        public int Denom { get; set; }
        public bool MalEstado { get; set; }
        public decimal ImpCompra { get; set; }
        public decimal TotalCompra { get; set; }
        public string MalEstadoDes { get; set; }
    }
}
