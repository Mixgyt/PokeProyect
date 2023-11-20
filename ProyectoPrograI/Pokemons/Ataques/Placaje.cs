using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemons.Ataques
{
    internal class Placaje : Ataque
    {
        public Placaje() 
        {
            Abreviatura = "Pla";
            Nombre = "Placaje";
            Daño = 5;
            Tipo = Tipos.Normal;
        }

        public override void Efecto(Pokemon poke1, Pokemon poke2)
        {
            Console.WriteLine("Placaje");
        }

    }
}
