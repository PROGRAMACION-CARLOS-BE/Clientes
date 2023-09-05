using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class ControlCentral
    {
        public int Id { get; set; }
        public string NomTablaLocal { get; set; }
        public string FiltroLocal { get; set; }
        public string NomTablaCentral { get; set; }
        public string FiltroCentral { get; set; }
        public string ServerCentral { get; set; }
        public string UserCentral { get; set; }
        public string PassCentral { get; set; }
        public string Bdcentral { get; set; }
        public bool Activo { get; set; }
        public int RegVersion { get; set; }
    }
}
