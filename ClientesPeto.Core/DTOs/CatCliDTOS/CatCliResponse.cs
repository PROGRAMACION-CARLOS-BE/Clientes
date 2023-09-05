using System;
using System.Collections.Generic;
using System.Text;

namespace ClientesPeto.Core.DTOs.CatCliDTOS
{
   public class CatCliResponse
    {
        public int CVECLI { get; set; }
        public string NOMCLI { get; set; }

        public string DIRCLI { get; set; }
        ////CLAVE DEL CLIENTE
        ////COLONIA DEL CLIENTE
        //public string COLCLI { get; set; }
        ////CODIGO POSTAL DEL CLIENTE
        //public string CPCLI { get; set; }
        ////CIUDAD DEL CLIENTE (ES UN TIPO ID, SE NECESITA VER EL CATALOGO DE CIUDADES PARA SABER QUE CIUDAD ES MEDIANTE ESE ID)
        //public int CIUCLI { get; set; }
        ////REGISTRO FEDERAL DE CONTRIBUYENTE DEL CLIENTE
        //public string RFCCLI { get; set; }
        ////CURP DEL CLIENTE
        //public string CURPCLI { get; set; }
        ////CORREO ELECTRONICO DEL CLIENTE
        //public string EMAILCLI { get; set; }
        ////CELULAR DEL CLIENTE(EQUIVALE A CELPHONE EN GEMMA)
        //public string TEL1CLI { get; set; }
        ////INE DEL CLIENTE
        //public string IDENTCLI { get; set; }
        ////FECHA DE NACIMIENTO DEL CLIENTE
        //public DateTime FecNac { get; set; }
        ////GENERO DEL CLIENTE(F: FEMENINO, M:MASCULINO)
        //public string Sexo { get; set; }

        //public int GRUCLI { get; set; }
        //public int CVEOCU { get; set; }
        //public int CVENAC { get; set; }
        //public int CVEEDUCIV { get; set; }
        //public string TEL2CLI { get; set; }
        //public int CVEMED { get; set; }
        //public DateTime FECALT { get; set; }
        ////public byte[] IMAGEN { get; set; }

        //////public byte[] IMAGEN2 { get; set; }
        //public byte[] ARCHIVO1 { get; set; }
        //public string ARCHIVO1NOM { get; set; }
    }
}
