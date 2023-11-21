using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemons.Ataques
{
    class Pedrada : Ataque
    {
        public Pedrada() 
        {
            Abreviatura = "Ped";
            Nombre = "Pedrada";
            Daño = 18;
            Tipo = Tipos.Roca;
        }

        public override void Efecto(Pokemon poke1, Pokemon poke2)
        {
            Console.WriteLine("Pedrada");
        }
    }
}
