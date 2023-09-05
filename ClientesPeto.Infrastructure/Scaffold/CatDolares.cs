using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class CatDolares
    {
        public int Id { get; set; }
        public int Denom { get; set; }
        public decimal PorcCompra { get; set; }
        public bool MalEstado { get; set; }
        public bool Activo { get; set; }
    }
}
