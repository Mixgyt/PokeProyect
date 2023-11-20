using ProyectoPrograI.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokemons.Ataques;

namespace Pokemons.Pokemones
{
    class Blastoise : Agua
    {
        public Blastoise()
        {
            Nombre = "Blastoise";
            Stats = new Estadisticas()
            {
                vida = 79,
                ataque = 83,
                defensa = 100,
                velocidad = 78
            };
            Ataques = new List<Ataque>
            {

            };
            Imagen = Resources.Blastoise;
        }
    }
}
