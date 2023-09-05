using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class Comentarios
    {
        public int IdComentario { get; set; }
        public DateTime FecComentario { get; set; }
        public string PersonaDestino { get; set; }
        public int CveUser { get; set; }
        public byte Preg1 { get; set; }
        public byte Preg2 { get; set; }
        public byte Preg3 { get; set; }
        public byte Preg4 { get; set; }
        public byte Preg5 { get; set; }
        public byte Preg6 { get; set; }
        public byte Preg7 { get; set; }
        public byte Preg8 { get; set; }
        public byte Preg9 { get; set; }
        public byte Preg10 { get; set; }
        public short StsEnvio { get; set; }
        public short RegVersion { get; set; }
        public int IdFilaLocal { get; set; }
        public int IdFilaCentral { get; set; }
    }
}
