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
        public Tipos Tipo { get; set; }
        public Estadisticas Estadisticas { get; set; }
        public List<Ataques> Ataques { get; set;}
        public Tipos Debilidad { get; set; }

        public void atacar()
        {

        }
    }
}
