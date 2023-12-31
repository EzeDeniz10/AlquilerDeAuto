﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerDeAutos.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public long DNI { get; set; }

        public DateTime FechaDeNacimiento { get; set; }

        public string Nacionalidad { get; set; }

        public string Telefono { get; set; }

        public string Email { get; set; }


        public string CategoriaCarnet { get; set; }

        public DateTime FechaDeVencimientoCarnet { get; set; }

        public virtual List<Reserva> Reservas { get; set; } = new List<Reserva>();

       
    }
}
