using AutoMapper;
using ClientesPeto.Core.DTOs.CatCiuDTOS;
using ClientesPeto.Core.Entities;
using ClientesPeto.Core.Filters;
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
    public class CatCiuController : ControllerBase
    {
        private readonly ICatCliRepository _repository;
        private readonly IMapper _mapper;
        public CatCiuController(ICatCliRepository repository, IMapper mapper)
        {
            this._repository = repository;
            this._mapper = mapper;
        }

        /// <summary>
        /// Obtiene todos los registros de clientes en la Suc. Tizimin
        /// </summary>
        /// <returns>Lista de objetos</returns>
        //[HttpGet]
        //[ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(CatCiu))]
        //public async Task<IActionResult> GetAll()
        //{
        //    var entity = await _repository.GetAll();
        //    var entityDTO = _mapper.Map<IEnumerable<CatCiu>, IEnumerable<CatCiuResponse>>(entity);

        //    return Ok(entityDTO);
        //}

        //[HttpGet("{id:int}")]
        //[ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(CatCiu))]
        //public async Task<IActionResult> GetById(int id)
        //{
        //    var entity = await _repository.GetById(id);
        //    if (entity is null)
        //        return Content("NO se encontraron registros");
        //    var entityDTO = _mapper.Map<CatCiu, CatCiuResponse>(entity);
        //    return Ok(entityDTO);
        //}



    }
}
