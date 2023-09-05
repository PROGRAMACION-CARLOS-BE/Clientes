using System;
using System.Collections.Generic;
using System.Text;

namespace ClientesPeto.Core.DTOs.AliadoDTOs
{
   public class AliadoCreateRest
    {
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public string Nss { get; set; }
        public string ClaveEmpleado { get; set; }
        public string ApPaterno { get; set; }
        public string ApMaterno { get; set; }
        public string Departamento { get; set; }
    }
}
