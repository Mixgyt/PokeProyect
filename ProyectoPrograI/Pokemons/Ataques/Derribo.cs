using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemons.Ataques
{
    internal class Derribo : Ataque
    {
        public Derribo()
        {
            Abreviatura = "Der";
            Nombre = "Derribo";
            Daño = 8;
            Tipo = Tipos.Normal;
        }

        public override void Efecto(Pokemon poke1, Pokemon poke2)
        {
            Console.WriteLine("Derribo");
        }

    }
}
