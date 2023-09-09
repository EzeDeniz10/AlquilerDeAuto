using AlquilerDeAutos.AcessoDatos;
using AlquilerDeAutos.Controladora.DTOs.Vehiculo;
using AlquilerDeAutos.Entidades;
using Microsoft.EntityFrameworkCore;

namespace AlquilerDeAutos.Controladora
{
    public class VehiculoService : IVehiculoService
    {
        private readonly AlquilerAutoContext _context;

        public VehiculoService(AlquilerAutoContext context)
        {
            _context = context;
        }

        public async Task<List<VehiculoDetalleDto>> ObtenerTodos()
        {
            var vehiculo = await _context.Vehiculos.Select(v => new VehiculoDetalleDto
            {
                Marca = v.Marca,
                Modelo = v.Modelo,
                Anio = v.Anio,
                CantidadPasajeros = v.CantidadPasajeros,
                CantidadPuertas = v.CantidadPuertas,
                CapacidadCombustible = v.CapacidadCombustible,
                CapacidadDeBaul = v.CapacidadDeBaul,
                IdTipoCombustible = v.IdTipoCombustible,
                PrecioAlquilerPorDia = v.PrecioAlquilerPorDia,
                IdVehiculo = v.IdVehiculo
            }).ToListAsync();

            return vehiculo;
        }

        public async Task<VehiculoDetalleDto> ObtenerPorId(int id)
        {
            var vehiculo = await _context.Vehiculos.FindAsync(id);

            if (vehiculo == null)
            {
                throw new Exception($"El vehiculo con el id {id} no existe");

            }

            return new VehiculoDetalleDto
            {
                Marca = vehiculo.Marca,
                Modelo = vehiculo.Modelo,
                Anio = vehiculo.Anio,
                CantidadPasajeros = vehiculo.CantidadPasajeros,
                CantidadPuertas = vehiculo.CantidadPuertas,
                CapacidadCombustible = vehiculo.CapacidadCombustible,
                CapacidadDeBaul = vehiculo.CapacidadDeBaul,
                IdTipoCombustible = vehiculo.IdTipoCombustible,
                PrecioAlquilerPorDia = vehiculo.PrecioAlquilerPorDia,
                IdVehiculo = vehiculo.IdVehiculo
            };
        }

        public async Task<VehiculoDetalleDto> Crear(VehiculoCrearDto dto)
        {
            var entidad = new Vehiculo
            {
                Marca = dto.Marca,
                Modelo = dto.Modelo,
                Anio = dto.Anio,
                CantidadPasajeros = dto.CantidadPasajeros,
                CantidadPuertas = dto.CantidadPuertas,
                CapacidadCombustible = dto.CapacidadCombustible,
                CapacidadDeBaul = dto.CapacidadDeBaul,
                IdTipoCombustible = dto.IdTipoCombustible,
                PrecioAlquilerPorDia = dto.PrecioAlquilerPorDia,

            };
            await _context.AddAsync(entidad);
            await _context.SaveChangesAsync();

            return new VehiculoDetalleDto
            {
                IdVehiculo = entidad.IdVehiculo,
                Marca = entidad.Marca,
                Modelo = entidad.Modelo,
                Anio = entidad.Anio,
                CantidadPasajeros = entidad.CantidadPasajeros,
                CantidadPuertas = entidad.CantidadPuertas,
                CapacidadCombustible = entidad.CapacidadCombustible,
                CapacidadDeBaul = entidad.CapacidadDeBaul,
                IdTipoCombustible = entidad.IdTipoCombustible,
                PrecioAlquilerPorDia = entidad.PrecioAlquilerPorDia,


            };

        }

        public async Task<VehiculoDetalleDto> Actualizar(int id, VehiculoCrearDto dto)
        {
            var vehiculo = await _context.Vehiculos.FindAsync(id);
            if (vehiculo == null)
            {
                throw new Exception($"El vehiculo con el id {id} no existe");

            }
            vehiculo.Marca = dto.Marca;
            vehiculo.Modelo = dto.Modelo;
            vehiculo.Anio = dto.Anio;
            vehiculo.CantidadPasajeros = dto.CantidadPasajeros;
            vehiculo.CantidadPuertas = dto.CantidadPuertas;
            vehiculo.CapacidadDeBaul = dto.CapacidadDeBaul;
            vehiculo.CapacidadCombustible = dto.CapacidadCombustible;
            vehiculo.IdTipoCombustible = dto.IdTipoCombustible;
            vehiculo.PrecioAlquilerPorDia = dto.PrecioAlquilerPorDia;

            _context.Update(vehiculo);

            return new VehiculoDetalleDto
            {
                IdVehiculo = vehiculo.IdVehiculo,
                Marca = vehiculo.Marca,
                Modelo = vehiculo.Modelo,
                Anio = vehiculo.Anio,
                CantidadPasajeros = vehiculo.CantidadPasajeros,
                CantidadPuertas = vehiculo.CantidadPuertas,
                CapacidadCombustible = vehiculo.CapacidadCombustible,
                CapacidadDeBaul = vehiculo.CapacidadDeBaul,
                IdTipoCombustible = vehiculo.IdTipoCombustible,
                PrecioAlquilerPorDia = vehiculo.PrecioAlquilerPorDia
            };

        }

        public async Task<VehiculoDetalleDto> Eliminar(int id)
        {
            var vehiculo = await _context.Vehiculos.FindAsync(id);
            if (vehiculo == null)
            {
                throw new Exception($"El vehiculo con el id {id} no existe");

            }

            _context.Remove(vehiculo);
            await _context.SaveChangesAsync();
            return new VehiculoDetalleDto
            {
                IdVehiculo = vehiculo.IdVehiculo,
                Marca = vehiculo.Marca,
                Modelo = vehiculo.Modelo,
                Anio = vehiculo.Anio,
                CantidadPasajeros = vehiculo.CantidadPasajeros,
                CantidadPuertas = vehiculo.CantidadPuertas,
                CapacidadCombustible = vehiculo.CapacidadCombustible,
                CapacidadDeBaul = vehiculo.CapacidadDeBaul,
                IdTipoCombustible = vehiculo.IdTipoCombustible,
                PrecioAlquilerPorDia = vehiculo.PrecioAlquilerPorDia,
            };
        }






    }
}
