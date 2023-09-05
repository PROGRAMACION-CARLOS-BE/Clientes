using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class MultiSucursales
    {
        public int CveSuc { get; set; }
        public string NomSuc { get; set; }
        public string ServerSql { get; set; }
        public string UserSql { get; set; }
        public string PassSql { get; set; }
        public string Bdsql { get; set; }
        public bool Activo { get; set; }
        public short StsEnvio { get; set; }
        public short RegVersion { get; set; }
        public int IdFilaLocal { get; set; }
        public int IdFilaCentral { get; set; }
    }
}
