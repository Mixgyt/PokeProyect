using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemons
{
    class Agua : Pokemon
    {
        public Agua() 
        {
            Tipo = Tipos.Agua;
            Debilidad = new List<Tipos> { Tipos.Hierva, Tipos.Electrico };
        }
    }
}
