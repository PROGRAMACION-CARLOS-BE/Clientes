using AutoMapper;
using ClientesPeto.Core.DTOs.CatCliDTOS;
using ClientesPeto.Core.Entities;
using ClientesPeto.Core.Filters;
using ClientesPeto.Core.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ClientesPeto.Api.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class CatCliController : ControllerBase
    {
        private readonly ICatCliRepository _repository;
        private readonly IMapper _mapper;
        public CatCliController(ICatCliRepository repository, IMapper mapper )
        {
            this._repository = repository;
            this._mapper = mapper;
        }
        /// <summary>
        /// Obtiene todos los registros de clientes que no se han enviado a Gema en la Suc. Tizimin
        /// </summary>
        /// <returns>Lista de objetos</returns>
        [HttpGet]
        [Route("ClientesNoEnviados")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(CatCli))]
        public IActionResult GetAll()
        {
            var entity = _repository.GetAll();
            //var entityDTO = _mapper.Map<IEnumerable<CatCli>, IEnumerable<CatCliResponse>>((IEnumerable<CatCli>)entity);

            return Ok(entity);
        }

        /// <summary>
        /// Obtiene todos los registros de clientes en la Suc. Tizimin mostrando solo CVECLI, NOMBRE Y DIRECCION 
        /// </summary>
        /// <returns>Lista de objetos</returns>
        [HttpGet]
        [Route("Previus")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(CatCliFilter))]
        public IActionResult GetByFilter()
        {
            // var productospc = await _repository.GetProductoFilter();
            //var productopcDTO = _mapper.Map<IEnumerable<ProductoPc>, IEnumerable<ProductoPcResponseDTO>>(productospc);
            return Ok(_repository.Previus());
        }

        /// <summary>
        /// Obtiene un registro del cliente mediante su CVECLI en la Suc. Tizimin 
        /// </summary>
        /// <returns>Lista de objetos</returns>
        //[HttpGet("{id:int}")]
        //[ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(CatCli))]
        //public async Task<IActionResult> GetById(int id)
        //{
        //    var entity = await _repository.GetById(id);
        //    if (entity is null)
        //        return Content("NO se encontraron registros");
        //    var entityDTO = _mapper.Map<CatCli, CatCliResponse>(entity);
        //    return Ok(entityDTO);
        //}

        /// <summary>
        /// Obtiene los documentos del cliente mediante su CVECLI en la Suc. Tizimin mostrando solo su CVECLI, DOCUMENTO Y NOMBRE DEL DOCUMENTO
        /// </summary>
        /// <returns>Lista de objetos</returns>
        [HttpGet]
        [Route("Documents/{id:int}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(CatCliDocuments))]
        public IActionResult DocumentsGetByCveCli(int id)
        {
            // var productospc = await _repository.GetProductoFilter();
            //var productopcDTO = _mapper.Map<IEnumerable<ProductoPc>, IEnumerable<ProductoPcResponseDTO>>(productospc);
            var entity = _repository.DocumentosByCatCliID(id);
            if (entity is null)
                return Content("NO se encontraron registros");
            //var entityDTO = _mapper.Map<CatCli, CatCliDocuments>(entity);
            return Ok(entity);
        }

        /// <summary>
        /// Obtiene un registro del cliente mediante su CVECLI en la Suc. Tizimin mostrando la ciudad a la que pertenece el cliente.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Objeto</returns>
        [HttpGet]
        [Route("{id:int}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(CatCliCiu))]
        public IActionResult DocumentsGetByCveCliCiu(int id)
        {
            // var productospc = await _repository.GetProductoFilter();
            //var productopcDTO = _mapper.Map<IEnumerable<ProductoPc>, IEnumerable<ProductoPcResponseDTO>>(productospc);
            var entity = _repository.GetByIdCiu(id);
            if (entity is null)
                return Content("NO se encontraron registros");
            //var entityDTO = _mapper.Map<CatCli, CatCliDocuments>(entity);
            return Ok(entity);
        }
    }
}
