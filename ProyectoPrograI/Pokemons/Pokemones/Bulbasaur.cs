using Pokemons.Ataques;
using ProyectoPrograI.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemons.Pokemones
{
    class Bulbasaur : Hierva
    {
        public Bulbasaur()
        {
            Nombre = "Bulbasaur";
            Stats = new Estadisticas()
            {
                ps = 45,
                vida = 45,
                ataque = 49,
                defensa = 49,
                velocidad = 45
            };
            Ataques = new List<Ataque>
            {
                new Placaje(),
                new Derribo(),
                new Hoja_Afilada(),
                new Latigo_Cepa()
            };
            Imagen = Resources.Bulbasaur;
        }
    }
}
