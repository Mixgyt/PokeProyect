using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemons.Ataques
{
    class Hidropulso : Ataque
    {
        public Hidropulso() 
        {
            Abreviatura = "Hid";
            Nombre = "Hidropulso";
            Daño = 10;
            Tipo = Tipos.Agua;
        }

        public override void Efecto(Pokemon poke1, Pokemon poke2)
        {
            Console.WriteLine("Hidropulso");
        }
    }
}
