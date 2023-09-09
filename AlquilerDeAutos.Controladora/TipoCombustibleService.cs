using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlquilerDeAutos.AcessoDatos;
using AlquilerDeAutos.Controladora.DTOs.FormaDePago;
using AlquilerDeAutos.Controladora.TipoCombustibles;
using AlquilerDeAutos.Entidades;
using Microsoft.EntityFrameworkCore;

namespace AlquilerDeAutos.Controladora
{
    public class TipoCombustibleService : ITipoCombustibleService
    {
        private readonly AlquilerAutoContext _context;

        public TipoCombustibleService(AlquilerAutoContext context)
        {
            _context = context;
        }
        public async Task<List<TipoCombustibleDetalleDto>> ObtenerTodos()
        {
            var tipoCombustibles = await _context.TipoCombustibles.Select(tc => new TipoCombustibleDetalleDto
            {
                Descripcion = tc.Descripcion,
                IdCombustible = tc.IdCombustible

            }).ToListAsync();

            return tipoCombustibles;

        }

        public async Task<TipoCombustibleDetalleDto> ObtenerPorId(int id)
        {
            var tipoCombustible = await _context.TipoCombustibles.FindAsync(id);

            if (tipoCombustible == null)
            {
                throw new Exception($"El tipo de combustible con el id {id} no existe");
            }

            return new TipoCombustibleDetalleDto
            {
                IdCombustible = tipoCombustible.IdCombustible,
                Descripcion = tipoCombustible.Descripcion

            };


        }

        public async Task<TipoCombustibleDetalleDto> Crear(TipoCombustibleCrearDto dto)
        //Validacion
        {
            var existeNombre = await _context.TipoCombustibles
                                             .AnyAsync(x => x.Descripcion.ToLower() == dto.Descripcion.ToLower());
            if (existeNombre)
                throw new Exception($"El nombre {dto.Descripcion} ya existe usa otra descripcion");
            //Mapeo

            var entidad = new TipoCombustible
            {
                Descripcion = dto.Descripcion,
            };
            //hace la query y la guarda

            await _context.AddAsync(entidad);
            await _context.SaveChangesAsync();

            return new TipoCombustibleDetalleDto
            {
                IdCombustible = entidad.IdCombustible,
                Descripcion = entidad.Descripcion,
            };


        }
        public async Task<TipoCombustibleDetalleDto> Actualizar(int id, TipoCombustibleCrearDto dto)
        {
            var tipoCombustibles = await _context.TipoCombustibles.FindAsync(id);

            if (tipoCombustibles == null)
            {
                throw new Exception($"El tipo de combustible con el id {id} no existe");
            }

            tipoCombustibles.Descripcion = dto.Descripcion;

            _context.Update(tipoCombustibles);
            await _context.SaveChangesAsync();

            return new TipoCombustibleDetalleDto
            {
                IdCombustible = tipoCombustibles.IdCombustible,
                Descripcion = tipoCombustibles.Descripcion
            };

        }
        public async Task<TipoCombustibleDetalleDto> Eliminar(int id)
        {
            var tipoCombustibles = await _context.TipoCombustibles.FindAsync(id);

            if (tipoCombustibles == null)
            {
                throw new Exception($"El tipo de combustible con el id {id} no existe");
            }

            _context.Remove(tipoCombustibles);
            await _context.SaveChangesAsync();

            return new TipoCombustibleDetalleDto
            {
                IdCombustible = tipoCombustibles.IdCombustible,
                Descripcion = tipoCombustibles.Descripcion
            };


        }





    }

}

    

