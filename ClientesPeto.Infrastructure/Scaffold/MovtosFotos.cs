using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class MovtosFotos
    {
        public int Cvesuc { get; set; }
        public int Folmovorig { get; set; }
        public byte[] Imagen1 { get; set; }
        public string Imagennom1 { get; set; }
        public byte[] Imagen2 { get; set; }
        public string Imagennom2 { get; set; }
        public byte[] Imagen3 { get; set; }
        public string Imagennom3 { get; set; }
        public byte[] Imagen4 { get; set; }
        public string Imagennom4 { get; set; }
        public DateTime Fechareal { get; set; }
        public int Cveuser { get; set; }
        public short StsEnvio { get; set; }
        public short RegVersion { get; set; }
        public int IdFilaLocal { get; set; }
        public int IdFilaCentral { get; set; }
    }
}
