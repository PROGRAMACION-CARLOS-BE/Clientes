using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class Users
    {
        public int CveUser { get; set; }
        public string NomUser { get; set; }
        public string Login { get; set; }
        public string Contrasena { get; set; }
        public decimal MontoMax { get; set; }
        public bool? CambiarPass { get; set; }
        public decimal PorcMaxBonif { get; set; }
        public int NivelUser { get; set; }
        public int NivelAutoriza { get; set; }
        public decimal MontoMaxDiaCte { get; set; }
        public decimal PorcMinExp { get; set; }
        public decimal PorcMaxExp { get; set; }
        public bool? EsValidoJoyeria { get; set; }
        public bool? EsValidoAparatos { get; set; }
        public bool? EsValidoPlateria { get; set; }
        public bool? EsValidoAutos { get; set; }
        public short StsEnvio { get; set; }
        public short RegVersion { get; set; }
        public int IdFilaLocal { get; set; }
        public int IdFilaCentral { get; set; }
        public decimal EfecMax { get; set; }
        public DateTime UltFecActPass { get; set; }
        public bool EsUserBoveda { get; set; }
        public DateTime FechaReal { get; set; }
    }
}
