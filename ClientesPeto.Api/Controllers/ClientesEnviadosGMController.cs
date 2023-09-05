using AutoMapper;
using ClientesPeto.Core.DTOs.ClientesEnviadosGMDTOS;
using ClientesPeto.Core.Entities;
using ClientesPeto.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ClientesPeto.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesEnviadosGMController : ControllerBase
    {
        private readonly IClientesEnviadosGMRepository _repository;
        private readonly IMapper _mapper;
        public ClientesEnviadosGMController(IClientesEnviadosGMRepository repository, IMapper mapper)
        {
            this._repository = repository;
            this._mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ClientesEnviadosGM))]
        public async Task<IActionResult> GetAll()
        {
            var entity = await _repository.GetAll();
            var entityDTO = _mapper.Map<IEnumerable<ClientesEnviadosGM>, IEnumerable<ClientesEnviadosGMResponse>>(entity);

            return Ok(entityDTO);
        }

        [HttpPost]
        [Route("ProductoPC")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ClientesEnviadosGMCreateRest))]
        public async Task<IActionResult> PostPc(ClientesEnviadosGMCreateRest entitydto)
        {
            var entity = _mapper.Map<ClientesEnviadosGMCreateRest, ClientesEnviadosGM>(entitydto);
            await _repository.Add(entity);
            var entityresponseDTO = _mapper.Map<ClientesEnviadosGM, ClientesEnviadosGMCreateRest>(entity);
            return Ok(entityresponseDTO);
        }
    }
}
