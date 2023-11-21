using ProyectoPrograI.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokemons.Ataques;

namespace Pokemons.Pokemones
{
    class Geodude : Roca
    {
        public Geodude() 
        {
            Nombre = "Geodude";
            Stats = new Estadisticas()
            {
                ps = 40,
                vida = 40,
                ataque = 80,
                defensa = 100,
                velocidad = 20
            };
            Ataques = new List<Ataque>
            {
                new Placaje(),
                new Pedrada(),
                new Roca_Afilada(),
                new Rompe_Roca()
            };
            Imagen = Resources.Geodude;
        }
    }
}
