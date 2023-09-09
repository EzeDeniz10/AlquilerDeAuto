using AlquilerDeAutos.Controladora.DTOs.Vehiculo;

namespace AlquilerDeAutos.Controladora
{
    public interface IVehiculoService
    {
        Task<VehiculoDetalleDto> Actualizar(int id, VehiculoCrearDto dto);
        Task<VehiculoDetalleDto> Crear(VehiculoCrearDto dto);
        Task<VehiculoDetalleDto> Eliminar(int id);
        Task<VehiculoDetalleDto> ObtenerPorId(int id);
        Task<List<VehiculoDetalleDto>> ObtenerTodos();
    }
}