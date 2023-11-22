using Pokemons.Ataques;
using Pokemons.Ataques.Electrico;
using ProyectoPrograI.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemons.Pokemones
{
    class Magnemite : Electrico
    { 
        public Magnemite() 
        {
            Nombre = "Magnemite";
            Stats = new Estadisticas()
            {
                ps = 25,
                vida = 25,
                ataque = 35,
                defensa = 70,
                velocidad = 45,
            };
            Ataques = new List<Ataque>
            {
                new Altovoltaje(),
                new Electrotela(),
                new Impactrueno(),
                new Chispazo()
            };
            Imagen = Resources.Magnemite;
        }
    }
}
