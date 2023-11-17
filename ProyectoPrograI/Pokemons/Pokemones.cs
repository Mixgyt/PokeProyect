using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokemons.Ataques;

namespace Pokemons
{
    class Pokemones
    {
        public Pokemon Pikachu = new Electrico()
        {
            Nombre = "Pikachu",
            Estadisticas = new Estadisticas()
            {
                vida = 35,
                ataque = 55,
                defensa = 40,
                velocidad = 90,
            },
            Ataques = new List<Ataque> 
            { 
                new Impactrueno(),
                new Electrobola(),
                new Electrotela(),
                new Altovoltaje()

            },
        };

    }
}
