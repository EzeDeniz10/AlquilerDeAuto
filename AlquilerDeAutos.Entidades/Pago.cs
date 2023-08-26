using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerDeAutos.Entidades
{
    public class Pago
    {
        public int IdPago { get; set; }

        public int IdFormaDePago { get; set; }

        public string IdReservas { get; set; }

        public double Monto { get; set; }

        public virtual FormaDePago FormaDePago { get; set; }

        public virtual Reserva Reserva { get; set; }




    }
}
