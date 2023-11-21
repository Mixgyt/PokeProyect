﻿using Pokemons.Ataques;
using ProyectoPrograI.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemons.Pokemones
{
    class Diglett : Tierra
    {
        public Diglett()
        {
            Nombre = "Diglett";
            Stats = new Estadisticas()
            {
                ps = 10,
                vida = 10,
                ataque = 55,
                defensa = 30,
                velocidad = 95
            };
            Ataques = new List<Ataque>
            {
                new Bofeton_Lodo(),
                new Pataleta(),
                new Terremoto(),
                new Fuerza_Telurica()
            };
            Imagen = Resources.Diglett;
        }
    }
}
