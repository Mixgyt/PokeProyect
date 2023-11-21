using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemons.Ataques
{
    class Roca_Afilada : Ataque
    {
        public Roca_Afilada()
        {
            Abreviatura = "Roa";
            Nombre = "Roca Afilada";
            Daño = 17;
            Tipo = Tipos.Roca;
        }

        public override void Efecto(Pokemon poke1, Pokemon poke2)
        {
            Console.WriteLine("Roca Afilada");
        }
    }
}
