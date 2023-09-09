﻿// <auto-generated />
using System;
using AlquilerDeAutos.AcessoDatos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AlquilerDeAutos.AcessoDatos.Migrations
{
    [DbContext(typeof(AlquilerAutoContext))]
    [Migration("20230826154443_ArregloFormaPago")]
    partial class ArregloFormaPago
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AlquilerDeAutos.Entidades.FormaDePago", b =>
                {
                    b.Property<int>("IdFormaDePago")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdFormaDePago"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdFormaDePago");

                    b.ToTable("FormaDePagos");
                });

            modelBuilder.Entity("AlquilerDeAutos.Entidades.Pago", b =>
                {
                    b.Property<int>("IdPago")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPago"));

                    b.Property<int>("IdFormaDePago")
                        .HasColumnType("int");

                    b.Property<string>("IdReservas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Monto")
                        .HasColumnType("float");

                    b.Property<int>("ReservaIdReservas")
                        .HasColumnType("int");

                    b.HasKey("IdPago");

                    b.HasIndex("IdFormaDePago");

                    b.HasIndex("ReservaIdReservas");

                    b.ToTable("Pagos");
                });

            modelBuilder.Entity("AlquilerDeAutos.Entidades.Reserva", b =>
                {
                    b.Property<int>("IdReservas")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdReservas"));

                    b.Property<string>("FechaDeEntrada")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FechaDeSalida")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdUsuarios")
                        .HasColumnType("int");

                    b.Property<int>("IdVehiculo")
                        .HasColumnType("int");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.HasKey("IdReservas");

                    b.HasIndex("IdUsuarios");

                    b.HasIndex("IdVehiculo");

                    b.ToTable("Reservas");
                });

            modelBuilder.Entity("AlquilerDeAutos.Entidades.TipoCombustible", b =>
                {
                    b.Property<int>("IdCombustible")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCombustible"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCombustible");

                    b.ToTable("tipoCombustibles");
                });

            modelBuilder.Entity("AlquilerDeAutos.Entidades.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoriaCarnet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("DNI")
                        .HasMaxLength(99999999)
                        .HasColumnType("bigint");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaDeNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaDeVencimientoCarnet")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nacionalidad")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("AlquilerDeAutos.Entidades.Vehiculo", b =>
                {
                    b.Property<int>("IdVehiculo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdVehiculo"));

                    b.Property<int>("Anio")
                        .HasColumnType("int");

                    b.Property<int>("CantidadPasajeros")
                        .HasColumnType("int");

                    b.Property<int>("CantidadPuertas")
                        .HasColumnType("int");

                    b.Property<int>("CapacidadCombustible")
                        .HasColumnType("int");

                    b.Property<double>("CapacidadDeBaul")
                        .HasColumnType("float");

                    b.Property<int>("IdTipoCombustible")
                        .HasColumnType("int");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PrecioAlquilerPorDia")
                        .HasColumnType("float");

                    b.HasKey("IdVehiculo");

                    b.HasIndex("IdTipoCombustible");

                    b.ToTable("vehiculos");
                });

            modelBuilder.Entity("AlquilerDeAutos.Entidades.Pago", b =>
                {
                    b.HasOne("AlquilerDeAutos.Entidades.FormaDePago", "FormaDePago")
                        .WithMany("Pagos")
                        .HasForeignKey("IdFormaDePago")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AlquilerDeAutos.Entidades.Reserva", "Reserva")
                        .WithMany("Pagos")
                        .HasForeignKey("ReservaIdReservas")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FormaDePago");

                    b.Navigation("Reserva");
                });

            modelBuilder.Entity("AlquilerDeAutos.Entidades.Reserva", b =>
                {
                    b.HasOne("AlquilerDeAutos.Entidades.Usuario", "Usuario")
                        .WithMany("Reservas")
                        .HasForeignKey("IdUsuarios")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AlquilerDeAutos.Entidades.Vehiculo", "Vehiculo")
                        .WithMany("Reservas")
                        .HasForeignKey("IdVehiculo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");

                    b.Navigation("Vehiculo");
                });

            modelBuilder.Entity("AlquilerDeAutos.Entidades.Vehiculo", b =>
                {
                    b.HasOne("AlquilerDeAutos.Entidades.TipoCombustible", "TiposCombustible")
                        .WithMany("Vehiculos")
                        .HasForeignKey("IdTipoCombustible")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TiposCombustible");
                });

            modelBuilder.Entity("AlquilerDeAutos.Entidades.FormaDePago", b =>
                {
                    b.Navigation("Pagos");
                });

            modelBuilder.Entity("AlquilerDeAutos.Entidades.Reserva", b =>
                {
                    b.Navigation("Pagos");
                });

            modelBuilder.Entity("AlquilerDeAutos.Entidades.TipoCombustible", b =>
                {
                    b.Navigation("Vehiculos");
                });

            modelBuilder.Entity("AlquilerDeAutos.Entidades.Usuario", b =>
                {
                    b.Navigation("Reservas");
                });

            modelBuilder.Entity("AlquilerDeAutos.Entidades.Vehiculo", b =>
                {
                    b.Navigation("Reservas");
                });
#pragma warning restore 612, 618
        }
    }
}
