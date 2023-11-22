using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemons.Ataques
{
    class Empapar : Ataque
    {
        public Empapar() 
        {
            Abreviatura = "Emp";
            Nombre = "Empapar";
            Daño = 3;
            Tipo = Tipos.Agua;
        }

        public override void Efecto(Pokemon poke1, Pokemon poke2)
        {
            Console.WriteLine("Empapar");
        }
    }
}
