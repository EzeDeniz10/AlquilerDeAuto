using AlquilerDeAutos.Controladora.TipoCombustibles;

namespace AlquilerDeAutos.Controladora
{
    public interface ITipoCombustibleService
    {
        Task<TipoCombustibleDetalleDto> Actualizar(int id, TipoCombustibleCrearDto dto);
        Task<TipoCombustibleDetalleDto> Crear(TipoCombustibleCrearDto dto);
        Task<TipoCombustibleDetalleDto> Eliminar(int id);
        Task<TipoCombustibleDetalleDto> ObtenerPorId(int id);
        Task<List<TipoCombustibleDetalleDto>> ObtenerTodos();
    }
}