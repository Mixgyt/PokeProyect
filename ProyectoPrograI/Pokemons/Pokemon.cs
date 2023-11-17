using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemons
{
    class Pokemon
    {
        public string Nombre { get; set; }
        public Tipos tipo { get; set; }
        public Estadisticas estadisticas { get; set; }
        public List<Ataques> Ataques { get; set;}
        public Tipos debilidad { get; set; }
    }
}
