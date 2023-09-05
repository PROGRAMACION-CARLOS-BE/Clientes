using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ClientesPeto.Infrastructure.Scaffold
{
    public partial class VwEmpActivo
    {
        public int? FolioMovOriginal { get; set; }
        public int? FolUltimoMov { get; set; }
        public int? Cliente { get; set; }
        public string Descripcion { get; set; }
        public int? CveTipProd { get; set; }
        public string TipoProducto { get; set; }
        public string Marca { get; set; }
        public decimal? Prestamo { get; set; }
        public int? ClaveValuador { get; set; }
        public string Valuador { get; set; }
        public int? ClaveSucursal { get; set; }
        public string NombreSucursal { get; set; }
        public DateTime? FechaPrestamo { get; set; }
        public double? Años { get; set; }
        public double? Meses { get; set; }
        public double? Dias { get; set; }
        public string Ubicacion { get; set; }
        public DateTime? FecUbi { get; set; }
        public int? DiasSucUbi { get; set; }
        public int? CveUbi { get; set; }
        public string NomUbi { get; set; }
    }
}
