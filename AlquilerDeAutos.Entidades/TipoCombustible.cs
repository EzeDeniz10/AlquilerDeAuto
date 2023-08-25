using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerDeAutos.Entidades
{
    public class TipoCombustible
    {
        public int IdCombustible{ get; set; }

        public string Descripcion { get; set; }

        public virtual List<Vehiculo> Vehiculos { get; set; } = new List<Vehiculo>();


    }
}
