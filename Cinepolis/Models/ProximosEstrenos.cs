using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinepolis.Models
{
    public class ProximosEstrenos
    {
        public int IdPelicula { get; set; }
        public string Titulo { get; set; }
        public string Duracion { get; set; }
        public string Sinopsis { get; set; }
        public string RutaImagenP { get; set; }
        public string RutaImagenB { get; set; }
    }
}
