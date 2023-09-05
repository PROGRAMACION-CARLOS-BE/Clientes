﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class CorteCajaPlazos
    {
        public DateTime Fecha { get; set; }
        public double CapitalVigente { get; set; }
        public double InteresVigente { get; set; }
        public double CapitalVencido { get; set; }
        public double InteresVencido { get; set; }
        public DateTime FechaReal { get; set; }
        public bool? EsAparatos { get; set; }
        public int CvePla { get; set; }
        public bool? SepararCart { get; set; }
        public short StsEnvio { get; set; }
        public short RegVersion { get; set; }
        public int IdFilaLocal { get; set; }
        public int IdFilaCentral { get; set; }
        public double CapEnajxRec { get; set; }
        public double CapEnajxExp { get; set; }
    }
}
