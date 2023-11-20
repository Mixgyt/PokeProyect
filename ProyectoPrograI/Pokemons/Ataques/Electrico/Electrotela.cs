using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemons.Ataques
{
    class Electrotela : Ataque
    {
        public Electrotela() 
        {
            Abreviatura = "Elt";
            Nombre = "Electrotela";
            Daño = 10;
            Tipo = Tipos.Electrico;
        }

        public override void Efecto(Pokemon poke1, Pokemon poke2)
        {
            Console.WriteLine("Electrotela");
        }
    }
}
