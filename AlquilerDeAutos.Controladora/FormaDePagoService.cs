using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlquilerDeAutos.AcessoDatos;
using AlquilerDeAutos.Controladora.DTOs.FormaDePago;
using AlquilerDeAutos.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace AlquilerDeAutos.Controladora
{
    public class FormaDePagoService : IFormaDePagoService
    {
        private readonly AlquilerAutoContext _context;

        public FormaDePagoService(AlquilerAutoContext context)
        {
            _context = context;

        }
        public async Task<List<FormaDePagoDetalleDto>> ObtenerTodos()
        {
            var formaDePagos = await _context.FormaDePagos.Select(fp => new FormaDePagoDetalleDto
            {
                Descripcion = fp.Descripcion,
                IdFormaDePago = fp.IdFormaDePago

            }).ToListAsync();

            return formaDePagos;

        }

        public async Task<FormaDePagoDetalleDto> ObtenerPorId(int id)
        {
            var formaDePagos = await _context.FormaDePagos.FindAsync(id);

            if (formaDePagos == null)
            {
                throw new Exception($"La forma de pago con el id {id} no existe");
            }

            return new FormaDePagoDetalleDto
            {
                IdFormaDePago = formaDePagos.IdFormaDePago,
                Descripcion = formaDePagos.Descripcion

            };


        }

        public async Task<FormaDePagoDetalleDto> Crear(FormaDePagoCrearDto dto)
        //Validacion
        {
            var existeNombre = await _context.FormaDePagos
                                             .AnyAsync(x => x.Descripcion.ToLower() == dto.Descripcion.ToLower());
            if (existeNombre)
                throw new Exception($"El nombre {dto.Descripcion} ya existe usa otra descripcion");
            //Mapeo

            var entidad = new FormaDePago
            {
                Descripcion = dto.Descripcion,
            };
            //hace la query y la guarda

            await _context.AddAsync(entidad);
            await _context.SaveChangesAsync();

            return new FormaDePagoDetalleDto
            {
                IdFormaDePago = entidad.IdFormaDePago,
                Descripcion = entidad.Descripcion,
            };


        }
        public async Task<FormaDePagoDetalleDto> Actualizar(int id, FormaDePagoCrearDto dto)
        {
            var formaDePagos = await _context.FormaDePagos.FindAsync(id);

            if (formaDePagos == null)
            {
                throw new Exception($"La forma de pago con el id {id} no existe");
            }

            formaDePagos.Descripcion = dto.Descripcion;

            _context.Update(formaDePagos);
            await _context.SaveChangesAsync();

            return new FormaDePagoDetalleDto
            {
                IdFormaDePago = formaDePagos.IdFormaDePago,
                Descripcion = formaDePagos.Descripcion
            };

        }
        public async Task<FormaDePagoDetalleDto> Eliminar(int id)
        {
            var formaDePagos = await _context.FormaDePagos.FindAsync(id);

            if (formaDePagos == null)
            {
                throw new Exception($"La forma de pago con el id {id} no existe");
            }

            _context.Remove(formaDePagos);
            await _context.SaveChangesAsync();

            return new FormaDePagoDetalleDto
            {
                IdFormaDePago = formaDePagos.IdFormaDePago,
                Descripcion = formaDePagos.Descripcion
            };


        }





    }
}
