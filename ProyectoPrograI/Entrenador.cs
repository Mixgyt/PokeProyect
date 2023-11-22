using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokemons;

namespace ProyectoPrograI
{
    class Entrenador
    {
        public string Nombre { get; set; }
        public List<Pokemon> Equipo { get; set; }


        public void ElegirPokemon(Pokemon pokemon)
        {
            Equipo.Add(pokemon);
        }

        public Pokemon CambiarPokemon(int poke)
        {
            return Equipo[poke];
        }
    }
}
