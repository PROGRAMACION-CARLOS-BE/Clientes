using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class VwAportacionesPorRecibir
    {
        public int FolMov { get; set; }
        public int CveSuc { get; set; }
        public int IdCaja { get; set; }
        public DateTime FecMov { get; set; }
        public decimal Importe { get; set; }
        public byte TipoMov { get; set; }
        public string Observa { get; set; }
        public int CveUser { get; set; }
        public DateTime FechaReal { get; set; }
        public int Cvemovcaja { get; set; }
        public short StsEnvio { get; set; }
        public short RegVersion { get; set; }
        public int IdFilaLocal { get; set; }
        public int IdFilaCentral { get; set; }
        public int CveEmp { get; set; }
        public int Folio { get; set; }
        public string LlaveFindin { get; set; }
        public int CveUserAdic { get; set; }
        public int LlaveCreditoId { get; set; }
        public int CreditoId { get; set; }
        public string NomCliente { get; set; }
        public bool Aceptado { get; set; }
        public DateTime FecAceptado { get; set; }
        public int CveUserDestino { get; set; }
        public bool Cancelado { get; set; }
        public DateTime FecCancelado { get; set; }
        public int CveUserCancel { get; set; }
        public int CveUser2 { get; set; }
    }
}
