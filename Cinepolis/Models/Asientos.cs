using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinepolis.Models
{
    public class Asientos
    {
        public string Nombre { get; set; }
        public EstadoAsiento Estado { get; set; }

        public enum EstadoAsiento
        {
            Libre,
            Reservado,
            Seleccionado
        }
    }
}
