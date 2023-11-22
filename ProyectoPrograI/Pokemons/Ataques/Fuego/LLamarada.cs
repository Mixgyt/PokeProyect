using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemons.Ataques
{
    class LLamarada : Ataque
    {
        public LLamarada() 
        {
            Abreviatura = "Lla";
            Nombre = "Llamarada";
            Daño = 20;
            Tipo = Tipos.Fuego;
        }

        public override void Efecto(Pokemon poke1, Pokemon poke2)
        {
            Console.WriteLine("Llamarada");
        }
    }
}
