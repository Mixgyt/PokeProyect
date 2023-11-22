using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemons.Ataques
{
    class Hidrovapor : Ataque
    {
        public Hidrovapor() 
        {
            Abreviatura = "Hdr";
            Nombre = "Hidrovapor";
            Daño = 11;
            Tipo = Tipos.Agua;
        }

        public override void Efecto(Pokemon poke1, Pokemon poke2)
        {
            Console.WriteLine("Hidrovapor");
        }
    }
}
