﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class DetGrupoPer
    {
        public int CveGrup { get; set; }
        public int CvePer { get; set; }
        public string Llave { get; set; }
        public int Permiso { get; set; }
        public DateTime FechaRegistro { get; set; }
        public short StsEnvio { get; set; }
        public short RegVersion { get; set; }
        public int IdFilaLocal { get; set; }
        public int IdFilaCentral { get; set; }
    }
}
