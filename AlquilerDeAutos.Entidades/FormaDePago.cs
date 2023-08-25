using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerDeAutos.Entidades
{
   public class FormaDePago
    {
        public int IdFormaDePago { get; set; }

        public int Descripcion { get; set; }

        public virtual List<Pago> Pagos { get; set; } = new List<Pago>();   


    }
}
