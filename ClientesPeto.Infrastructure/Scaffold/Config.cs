using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class Config
    {
        public int MinsChequeoEfecMax { get; set; }
        public int DiasActPass { get; set; }
        public int NumPassAnt { get; set; }
        public int MinsCancRemoto { get; set; }
        public bool ControlCentral { get; set; }
        public bool ControlCentralInicio { get; set; }
        public int ControlCentralMins { get; set; }
        public decimal? PorcMaxAdicPrecGra { get; set; }
        public decimal MaxMontoRetiro { get; set; }
        public int MaxVecesUserRetiro { get; set; }
        public int MaxVecesCancRetiro { get; set; }
    }
}
