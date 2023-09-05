using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class PreciosInternet
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public DateTime FecActualizacion { get; set; }
        public DateTime FecDescarga { get; set; }
        public string ClaveInterna { get; set; }
        public string UsuarioInternet { get; set; }
        public decimal Precio2 { get; set; }
        public decimal? Precio3 { get; set; }
        public short StsEnvio { get; set; }
        public short RegVersion { get; set; }
        public int IdFilaLocal { get; set; }
        public int IdFilaCentral { get; set; }
    }
}
