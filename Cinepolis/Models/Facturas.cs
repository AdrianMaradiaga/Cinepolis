using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinepolis.Models
{
    public class Facturas
    {
        public string usuario { get; set; }
        public string pelicula { get; set; }
        public string cine { get; set; }
        public string horario { get; set; }
        public string sala { get; set; }
        public string asiento { get; set; }
    }
}
