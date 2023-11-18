using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokemons.Ataques;
using ProyectoPrograI.Properties;

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
            Imagen = Resources.Pikachu,
        };

        public Pokemon Charizard = new Fuego()
        {
            Nombre = "Charizard",
            Estadisticas = new Estadisticas()
            {
                vida = 0,
                ataque = 0,
                defensa = 0,
                velocidad = 0
            },
            Ataques = new List<Ataque>
            {

            },
            Imagen = Resources.Charizard
        };

        public Pokemon Bulbasaur = new Hierva()
        {
            Nombre = "Bulbasaur",
            Estadisticas = new Estadisticas()
            {
                vida = 0,
                ataque = 0,
                defensa = 0,
                velocidad = 0
            },
            Ataques = new List<Ataque>
            {

            },
            Imagen = Resources.Bulbasaur
        };

        public Pokemon Diglett = new Tierra()
        {
            Nombre = "Diglett",
            Estadisticas = new Estadisticas()
            {
                vida = 0,
                ataque = 0,
                defensa = 0,
                velocidad = 0
            },
            Ataques = new List<Ataque>
            {

            },
            Imagen = Resources.Diglett
        };

        public Pokemon Blastoise = new Agua()
        {
            Nombre = "Blastoise",
            Estadisticas = new Estadisticas()
            {
                vida = 0,
                ataque = 0,
                defensa = 0,
                velocidad = 0
            },
            Ataques = new List<Ataque>
            {

            },
            Imagen = Resources.Blastoise
        };

        public Pokemon Geodude = new Roca()
        {
            Nombre = "Geodude",
            Estadisticas = new Estadisticas()
            {
                vida = 0,
                ataque = 0,
                defensa = 0,
                velocidad = 0
            },
            Ataques = new List<Ataque>
            {

            },
            Imagen = Resources.Geodude
        };

    }
}
