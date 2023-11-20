using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemons
{
    class Fuego : Pokemon
    {
        public Fuego() 
        {
            Tipo = Tipos.Fuego;
            Debilidad = new List<Tipos> { Tipos.Agua, Tipos.Tierra, Tipos.Roca };
        }
    }
}
