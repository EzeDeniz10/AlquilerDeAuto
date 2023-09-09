using AlquilerDeAutos.Controladora;
using AlquilerDeAutos.Controladora.DTOs.Vehiculo;
using Microsoft.AspNetCore.Mvc;

namespace AlquilerDeAuto.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehiculoController : ControllerBase
    {
      private readonly IVehiculoService _service;

        public VehiculoController(IVehiculoService service)
        {
            _service = service;
        }
        [HttpGet]

        public async Task<List<VehiculoDetalleDto>>Get()
        {
            var respuesta = await _service.ObtenerTodos();
            return respuesta;
        }
        [HttpGet("{id}")]

        public async Task<VehiculoDetalleDto> GetById([FromRoute] int id)
        {
            var respuesta = await _service.ObtenerPorId(id);
            return respuesta;
        }
        [HttpPost]

        public async Task<VehiculoDetalleDto> Post([FromBody] VehiculoCrearDto dto)
        {
            var respuesta = await _service.Crear(dto);
            return respuesta;
        }
        [HttpPut("{id}")]

        public async Task<VehiculoDetalleDto> Put([FromRoute] int id, [FromBody] VehiculoCrearDto dto)
        {
            var respuesta = await _service.Actualizar(id, dto);
            return respuesta;
        }
        [HttpDelete("{id}")]

        public async Task<VehiculoDetalleDto> Delete([FromRoute] int id)
        {
            var respuesta = await _service.Eliminar(id);
            return respuesta;
        }
    }
}
