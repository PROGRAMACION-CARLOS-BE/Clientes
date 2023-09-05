using AutoMapper;
using ClientesPeto.Core.DTOs.CatCiuDTOS;
using ClientesPeto.Core.DTOs.CatCliDTOS;
using ClientesPeto.Core.DTOs.ClientesEnviadosGMDTOS;
using ClientesPeto.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClientesPeto.Infrastructure.Mappings
{
    class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            //USUARIOS
            CreateMap<CatCli, CatCliResponse>();
            CreateMap<CatCliResponse, CatCli>();

            //CIUDADES
            CreateMap<CatCiu, CatCiuResponse>();
            CreateMap<CatCiuResponse, CatCiu>();

            //CLIENTES ENVIADOS GM
            //PRODUCTOS PC
            CreateMap<ClientesEnviadosGM, ClientesEnviadosGMCreateRest>();
            CreateMap<ClientesEnviadosGM, ClientesEnviadosGMResponse>();
            CreateMap<ClientesEnviadosGMCreateRest, ClientesEnviadosGM>().AfterMap(
                    ((source, destination) => { }));
            CreateMap<ClientesEnviadosGMResponse, ClientesEnviadosGM>();
        }
    }
}
