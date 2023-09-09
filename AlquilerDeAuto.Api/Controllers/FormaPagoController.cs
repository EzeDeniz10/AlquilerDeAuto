using AlquilerDeAutos.Controladora;
using AlquilerDeAutos.Controladora.DTOs.FormaDePago;
using Microsoft.AspNetCore.Mvc;

namespace AlquilerDeAuto.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FormaPagoController : ControllerBase
    {
        private readonly IFormaDePagoService _service;

        public FormaPagoController(IFormaDePagoService service)
        {
            _service = service;
        }

        [HttpGet]

        public async Task<List<FormaDePagoDetalleDto>> Get()
       {
            var respuesta = await _service.ObtenerTodos();
            return respuesta;
        }

        [HttpGet("{id}")]

        public async Task <FormaDePagoDetalleDto> GetById([FromRoute] int id)
        {
            var respuesta = await _service.ObtenerPorId(id);

                return respuesta;

        }
        [HttpPost]

        public async Task<FormaDePagoCrearDto> Post([FromBody]  FormaDePagoCrearDto dto)
        {
            var respuesta = await _service.Crear(dto);
            return respuesta;
        }
       [HttpPut("{id}")]

       public async Task <FormaDePagoDetalleDto> Put([FromRoute] int id, [FromBody] FormaDePagoCrearDto dto)
        {
            var respuesta = await _service.Actualizar(id, dto);
            return respuesta;
        }
        [HttpDelete("{id}")]

        public async Task <FormaDePagoDetalleDto> Delete([FromRoute] int id)
        {
            var respuesta = await _service.Eliminar(id);
            return respuesta;
        }
    }
}
