using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class PreciosUsd
    {
        public decimal Compra { get; set; }
        public decimal Venta { get; set; }
        public DateTime FechaHora { get; set; }
        public decimal Param1 { get; set; }
        public DateTime FecDescarga { get; set; }
        public int Id { get; set; }
    }
}
