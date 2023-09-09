using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerDeAutos.Controladora.DTOs.Pago
{
    public class PagoCrearDto
    {
        public int IdFormaDePago { get; set; }
        public string IdReservas { get; set; }
        public double Monto { get; set; }
    }
}
