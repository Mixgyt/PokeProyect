using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemons.Ataques.Electrico
{
    class Chispazo : Ataque
    {
        public Chispazo() 
        {
            Abreviatura = "Cis";
            Nombre = "Chispazo";
            Daño = 25;
            Tipo = Tipos.Electrico;
        }

        public override void Efecto(Pokemon poke1, Pokemon poke2)
        {
            Console.WriteLine("Chispazo");
        }
    }
}
