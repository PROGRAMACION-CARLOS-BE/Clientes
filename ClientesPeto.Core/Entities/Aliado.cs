using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Core
{
    public partial class Aliado
    {
        public int IdAliado { get; set; }
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public string Nss { get; set; }
        public string ClaveEmpleado { get; set; }
        public string ApPaterno { get; set; }
        public string ApMaterno { get; set; }
        public string Estado { get; set; }
        public string Departamento { get; set; }
    }
}
