using Pokemons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemons.Ataques
{
    class Rompe_Roca : Ataque
    {
        public Rompe_Roca() 
        {
            Abreviatura = "Ror";
            Nombre = "Rompe Roca";
            Daño = 20;
            Tipo = Tipos.Roca;
        }

        public override void Efecto(Pokemon poke1, Pokemon poke2)
        {
            Console.WriteLine("Rompe Roca");
        }
    }
}
