using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokemons.Ataques;
using ProyectoPrograI.Properties;

namespace Pokemons
{
    class Pokes
    {
        public Pokemon Pikachu = new Electrico()
        {
            Nombre = "Pikachu",
            Stats = new Estadisticas()
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
            Imagen = Resources.Pikachu,
        };

        public Pokemon Charizard = new Fuego()
        {
            Nombre = "Charizard",
            Stats = new Estadisticas()
            {
                vida = 78,
                ataque = 84,
                defensa = 78,
                velocidad = 100
            },
            Ataques = new List<Ataque>
            {
                new Ascuas()
            },
            Imagen = Resources.Charizard
        };

        public Pokemon Bulbasaur = new Hierva()
        {
            Nombre = "Bulbasaur",
            Stats = new Estadisticas()
            {
                vida = 45,
                ataque = 49,
                defensa = 49,
                velocidad = 45
            },
            Ataques = new List<Ataque>
            {
                new Placaje(),
                new Derribo(),
                new Hoja_Afilada(),
                new Latigo_Cepa()
            },
            Imagen = Resources.Bulbasaur
        };

        public Pokemon Diglett = new Tierra()
        {
            Nombre = "Diglett",
            Stats = new Estadisticas()
            {
                vida = 10,
                ataque = 55,
                defensa = 25,
                velocidad = 95
            },
            Ataques = new List<Ataque>
            {

            },
            Imagen = Resources.Diglett
        };

        public Pokemon Blastoise = new Agua()
        {
            Nombre = "Blastoise",
            Stats = new Estadisticas()
            {
                vida = 79,
                ataque = 83,
                defensa = 100,
                velocidad = 78
            },
            Ataques = new List<Ataque>
            {

            },
            Imagen = Resources.Blastoise
        };

        public Pokemon Geodude = new Roca()
        {
            Nombre = "Geodude",
            Stats = new Estadisticas()
            {
                vida = 40,
                ataque = 80,
                defensa = 100,
                velocidad = 20
            },
            Ataques = new List<Ataque>
            {

            },
            Imagen = Resources.Geodude
        };

    }
}
