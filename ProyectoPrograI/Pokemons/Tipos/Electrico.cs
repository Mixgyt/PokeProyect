using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemons
{
    class Electrico : Pokemon
    {
        public Electrico() 
        {
            Tipo = Tipos.Electrico;
            Debilidad = new List<Tipos>() { Tipos.Tierra };
        }
    }
}
