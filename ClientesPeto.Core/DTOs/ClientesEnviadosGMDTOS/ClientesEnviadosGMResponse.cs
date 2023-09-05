using System;
using System.Collections.Generic;
using System.Text;

namespace ClientesPeto.Core.DTOs.ClientesEnviadosGMDTOS
{
   public class ClientesEnviadosGMResponse
    {
        public int CveCliente { get; set; }
        public int IDClienteEnviado { get; set; }

        public string NombreCliente { get; set; }

        public DateTime FechaEnviado { get; set; }
    }
}
