using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokemons;
using Pokemons.Pokemones;

namespace ProyectoPrograI
{
    class Entrenador1 : Entrenador
    {
        public Entrenador1()
        {
            Nombre = "Entrenador 1";
            Equipo = new List<Pokemon>()
            {
                new Bulbasaur(),
                new Diglett(),
                new Blastoise()
            };
        }
    }

    class Entrenador2 : Entrenador
    {
        public Entrenador2()
        {
            Nombre = "Entrenador 2";
            Equipo = new List<Pokemon>()
            {
                new Pikachu(),
                new Geodude(),
                new Charizard()
            };
        }
    }
}
