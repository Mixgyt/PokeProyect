using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemons.Ataques
{
    class Pataleta : Ataque
    {
        public Pataleta() 
        {
            Abreviatura = "Pat";
            Nombre = "Pataleta";
            Daño = 15;
            Tipo = Tipos.Tierra;
        }

        public override void Efecto(Pokemon poke1, Pokemon poke2)
        {
            Console.WriteLine("Pataleta");
        }
    }
}
