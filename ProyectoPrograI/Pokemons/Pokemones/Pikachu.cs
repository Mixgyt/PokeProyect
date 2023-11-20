using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoPrograI.Properties;
using Pokemons.Ataques;

namespace Pokemons.Pokemones
{
    class Pikachu : Electrico
    {
        public Pikachu() 
        {
            Nombre = "Pikachu";
            Stats = new Estadisticas()
            {
                vida = 35,
                ataque = 55,
                defensa = 40,
                velocidad = 90,
            };
            Ataques = new List<Ataque>
            {
                new Impactrueno(),
                new Electrobola(),
                new Electrotela(),
                new Altovoltaje()

            };
            Imagen = Resources.Pikachu;
        }
    }
}
