using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlquilerDeAutos.Entidades;
using Microsoft.EntityFrameworkCore;

namespace AlquilerDeAutos.AcessoDatos
{
    public class AlquilerAutoContext : DbContext
    {


        public AlquilerAutoContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Pago> Pagos { get; set; }
        public DbSet<FormaDePago> FormaDePagos { get; set; }
        public DbSet<TipoCombustible> TipoCombustibles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Usuario>()
                .Property(p => p.DNI)
                .HasMaxLength(99_999_999)
                .IsRequired();


            modelBuilder.Entity<Usuario>()
                .Property(p => p.Nombre)
                .IsRequired();

            modelBuilder.Entity<Usuario>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<Usuario>()
                   .Property(p => p.Apellido)
                   .IsRequired();
            modelBuilder.Entity<Usuario>()
                   .Property(p => p.Email)
                   .IsRequired();
            modelBuilder.Entity<Usuario>()
                   .Property(p => p.CategoriaCarnet)
                   .IsRequired();
            modelBuilder.Entity<Usuario>()
                   .Property(p => p.FechaDeNacimiento)
                   .IsRequired();
            modelBuilder.Entity<Usuario>()
                   .Property(p => p.FechaDeVencimientoCarnet)
                   .IsRequired();
            modelBuilder.Entity<Usuario>()
                   .Property(p => p.Nacionalidad)
                   .HasMaxLength(25)
                   .IsRequired();
            modelBuilder.Entity<Usuario>()
                   .Property(p => p.Telefono)
                   .HasMaxLength(15)
                   .IsRequired();
            // Vehiculo

            modelBuilder.Entity<Vehiculo>()
                .Property(p => p.Anio);

            modelBuilder.Entity<Vehiculo>()
               .Property(p => p.Marca)
               .IsRequired();
            modelBuilder.Entity<Vehiculo>()
               .Property(p => p.IdTipoCombustible)
               .IsRequired();
            modelBuilder.Entity<Vehiculo>()
               .Property(p => p.CantidadPasajeros)
               .IsRequired();
            modelBuilder.Entity<Vehiculo>()
               .Property(p => p.CantidadPuertas)
               .IsRequired();
            modelBuilder.Entity<Vehiculo>()
               .HasKey(p => p.IdVehiculo);

            modelBuilder.Entity<Vehiculo>()
               .Property(p => p.Modelo)
               .IsRequired();
            modelBuilder.Entity<Vehiculo>()
               .Property(p => p.PrecioAlquilerPorDia)
               .IsRequired();

            modelBuilder.Entity<Vehiculo>()
               .Property(p => p.CapacidadDeBaul);

            modelBuilder.Entity<Vehiculo>()
                .HasOne(c => c.TiposCombustible)
                .WithMany(t => t.Vehiculos)
                .HasForeignKey(x => x.IdTipoCombustible);
            //Forma de pago

            modelBuilder.Entity<FormaDePago>()
               .Property(p => p.Descripcion)
               .IsRequired();
            modelBuilder.Entity<FormaDePago>()
                .HasKey(p => p.IdFormaDePago);
            //Pagos.

            modelBuilder.Entity<Pago>()
                .HasKey(p => p.IdPago);

            modelBuilder.Entity<Pago>()
               .Property(p => p.Monto)
               .IsRequired();
            modelBuilder.Entity<Pago>()
               .Property(p => p.IdReservas)
               .IsRequired();
            modelBuilder.Entity<Pago>()
               .Property(p => p.IdFormaDePago)
               .IsRequired();
            modelBuilder.Entity<Pago>()
                .HasOne(x => x.FormaDePago)
                .WithMany(f => f.Pagos)
                .HasForeignKey(x => x.IdFormaDePago);
            //Reserva.

            modelBuilder.Entity<Reserva>()
                .Property(p => p.FechaDeEntrada)
                .IsRequired();
            modelBuilder.Entity<Reserva>()
               .Property(p => p.Total)
               .IsRequired();
            modelBuilder.Entity<Reserva>()
               .Property(p => p.FechaDeSalida)
               .IsRequired();
            modelBuilder.Entity<Reserva>()
              .HasKey(x => x.IdReservas);

            modelBuilder.Entity<Reserva>()
               .Property(p => p.IdUsuarios)
               .IsRequired();
            modelBuilder.Entity<Reserva>()
               .Property(p => p.IdVehiculo)
               .IsRequired();
            modelBuilder.Entity<Reserva>()
               .HasOne(r => r.Usuario)
               .WithMany(u => u.Reservas)
               .HasForeignKey(x => x.IdUsuarios);
            modelBuilder.Entity<Reserva>()
                .HasOne(r => r.Vehiculo)
                .WithMany(u => u.Reservas)
                .HasForeignKey(x => x.IdVehiculo);
            //Tipo de combustible.

            modelBuilder.Entity<TipoCombustible>()
                .Property(p => p.Descripcion)
                .IsRequired();
            modelBuilder.Entity<TipoCombustible>()
                .HasKey(p => p.IdCombustible);



        }


    }
}

