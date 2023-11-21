using Pokemons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemons.Ataques
{
    class Chorro_de_Agua : Ataque
    {
        public Chorro_de_Agua()
        {
            Abreviatura = "Cha";
            Nombre = "Chorro de Agua";
            Daño = 5;
            Tipo = Tipos.Agua;
        }

        public override void Efecto(Pokemon poke1, Pokemon poke2)
        {
            Console.WriteLine("Chorro de Agua");
        }
    }
}
