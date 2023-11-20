using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemons
{
    class Roca : Pokemon
    {
        public Roca() 
        {
            Tipo = Tipos.Roca;
            Debilidad = new List<Tipos> { Tipos.Agua, Tipos.Hierva, Tipos.Tierra };
        }
    }
}
