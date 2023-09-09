using AlquilerDeAutos.Controladora.DTOs.FormaDePago;
using AlquilerDeAutos.Controladora;
using Microsoft.AspNetCore.Mvc;
using AlquilerDeAutos.Controladora.TipoCombustibles;
using AlquilerDeAutos.Entidades;

namespace AlquilerDeAuto.Api.Controllers 

{
    [ApiController]
    [Route("api/[controller]")]
    public class TipoCombustibleController : ControllerBase 
    {
        private readonly ITipoCombustibleService _service;

        public TipoCombustibleController(ITipoCombustibleService service)
        {
            _service = service;
        }

        [HttpGet]

        public async Task<List<TipoCombustibleDetalleDto>> Get()
        {
            var respuesta = await _service.ObtenerTodos();
            return respuesta;
        }

        [HttpGet("{id}")]

        public async Task<TipoCombustibleDetalleDto> GetById([FromRoute] int id)
        {
            var respuesta = await _service.ObtenerPorId(id);

            return respuesta;

        }
        [HttpPost]

        public async Task<TipoCombustibleCrearDto> Post([FromBody] TipoCombustibleCrearDto dto)
        {
            var respuesta = await _service.Crear(dto);
            return respuesta;
        }
        [HttpPut("{id}")]

        public async Task<TipoCombustibleDetalleDto> Put([FromRoute] int id, [FromBody] TipoCombustibleCrearDto dto)
        {
            var respuesta = await _service.Actualizar(id, dto);
            return respuesta;
        }
        [HttpDelete("{id}")]

        public async Task<TipoCombustibleDetalleDto> Delete([FromRoute] int id)
        {
            var respuesta = await _service.Eliminar(id);
            return respuesta;
        }
    }

    
}

