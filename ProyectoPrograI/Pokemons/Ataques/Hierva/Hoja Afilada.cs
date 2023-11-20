using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemons.Ataques
{
    internal class Hoja_Afilada : Ataque
    {
        public Hoja_Afilada()
        {
            Abreviatura = "Hoa";
            Nombre = "Hoja Afilada";
            Daño = 13;
            Tipo = Tipos.Hierva;
        }

        public override void Efecto(Pokemon poke1, Pokemon poke2)
        {
            Console.WriteLine("Hoja Afilada");
        }

    }
}
