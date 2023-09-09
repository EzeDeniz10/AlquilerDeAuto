using AlquilerDeAutos.AcessoDatos;
using AlquilerDeAutos.Controladora.DTOs.FormaDePago;
using AlquilerDeAutos.Controladora.DTOs.Pago;
using AlquilerDeAutos.Entidades;
using Microsoft.EntityFrameworkCore;

/*
 namespace AlquilerDeAutos.Controladora
{
    public class PagoService
    {
        private readonly AlquilerAutoContext _context;

        public PagoService(AlquilerAutoContext context)
        {
            _context = context;

        }
        public async Task<List<PagoDetalleDto>> ObtenerTodos()
        {
            var pago = await _context.Pagos.Select(p => new PagoDetalleDto
            {
              IdPago = p.IdPago,
              IdFormaDePago = p.IdFormaDePago,
              IdReservas = p.IdReservas,
              Monto = p.Monto


    }).ToListAsync();

            return pago;

        }
        public async Task<PagoDetalleDto> ObtenerPorId(int id)
        {
            var pago = await _context.Pagos.FindAsync(id);

            if (pago == null)
            {
                throw new Exception($"El pago con el id {id} no existe");
            }

            return new PagoDetalleDto
            {
                IdPago = pago.IdPago,
                IdFormaDePago = pago.IdFormaDePago,
                IdReservas = pago.IdReservas,
                Monto = pago.Monto


            };


        }

        public async Task<PagoDetalleDto> Crear(PagoCrearDto dto)

        {
            var existeNombre = await _context.Pagos
                                             .AnyAsync(x => x.IdFormaDePago.ToLower() == dto.IdFormaDePago.ToLower);
                                             
        }
       


    }
} 
*/
 
