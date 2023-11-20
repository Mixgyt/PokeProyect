using Pokemons.Ataques;
using ProyectoPrograI.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemons.Pokemones
{
    class Charizard : Fuego
    {
        public Charizard()
        {
            Nombre = "Charizard";
            Stats = new Estadisticas()
            {
                vida = 78,
                ataque = 84,
                defensa = 78,
                velocidad = 100
            };
            Ataques = new List<Ataque>
            {
                new Ascuas()
            };
            Imagen = Resources.Charizard;
        }
    }
}
