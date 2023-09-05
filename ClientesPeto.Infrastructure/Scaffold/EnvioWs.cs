using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class EnvioWs
    {
        public DateTime Fecha { get; set; }
        public int Iderp { get; set; }
        public decimal Valor { get; set; }
        public DateTime FechaHora { get; set; }
        public bool Enviado { get; set; }
        public DateTime FechaHoraEnvio { get; set; }
        public string MsgRespWs { get; set; }
        public decimal? ValorDesemDolar { get; set; }
    }
}
