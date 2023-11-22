using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemons.Ataques
{
    class Fuerza_Telurica : Ataque
    {
        public Fuerza_Telurica() 
        {
            Abreviatura = "Fut";
            Nombre = "Fuerza Telurica";
            Daño = 10;
            Tipo = Tipos.Tierra;
        }

        public override void Efecto(Pokemon poke1, Pokemon poke2)
        {
            Console.WriteLine("Fuerza Telurica");
        }
    }
}
