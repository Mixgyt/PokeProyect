using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemons.Ataques
{
    internal class Latigo_Cepa : Ataque
    {
        public Latigo_Cepa()
        {
            Abreviatura = "LaC";
            Nombre = "Latigo Cepa";
            Daño = 7;
            Tipo = Tipos.Hierva;
        }

        public override void Efecto(Pokemon poke1, Pokemon poke2)
        {
            Console.WriteLine("Latigo Cepa");
        }

    }
}
