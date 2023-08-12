using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerDeAutos.Entidades
{
    public class Reserva
    {
        public int IdReservas { get; set; }

        public string FechaDeEntrada { get; set; }

        public string FechaDeSalida { get; set;}

        public string IdVehiculos { get; set; }

        public string IdUsuarios { get; set; }

        public double Total { get; set;}


    }
}
