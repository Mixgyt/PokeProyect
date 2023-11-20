﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemons.Ataques
{
    class Electrobola : Ataque
    {
        public Electrobola() 
        {
            Abreviatura = "Elb";
            Nombre = "Electrobola";
            Daño = 15;
            Tipo = Tipos.Electrico;
        }

        public override void Efecto(Pokemon poke1, Pokemon poke2)
        {
            Console.WriteLine("Electrobola");
        }
    }
}
