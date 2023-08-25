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

        public string IdVehiculo { get; set; }

        public int IdUsuarios { get; set; }

        public double Total { get; set;}

        public virtual Vehiculo Vehiculo { get; set; }
        
        public virtual Usuario Usuario { get; set; }

        public virtual List<Pago> Pagos { get; set; } = new List<Pago>();   


    }
}
