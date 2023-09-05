using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class CatParametroRemoto
    {
        public int ParRemotoId { get; set; }
        public string ParamDescripcion { get; set; }
        public DateTime Fecha { get; set; }
        public bool Enviado { get; set; }
    }
}
