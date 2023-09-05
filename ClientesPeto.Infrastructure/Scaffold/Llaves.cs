using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class Llaves
    {
        public int Id { get; set; }
        public string Llave { get; set; }
        public bool? Usado { get; set; }
        public int CveUser { get; set; }
        public DateTime FechaReal { get; set; }
        public DateTime FechaUsado { get; set; }
        public int CveEmp { get; set; }
        public short StsEnvio { get; set; }
        public short RegVersion { get; set; }
        public int IdFilaLocal { get; set; }
        public int IdFilaCentral { get; set; }
    }
}
