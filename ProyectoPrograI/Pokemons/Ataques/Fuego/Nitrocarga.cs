using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemons.Ataques
{
    class Nitrocarga : Ataque
    {
        public Nitrocarga() 
        {
            Abreviatura = "Nit";
            Nombre = "Nitrocarga";
            Daño = 15;
            Tipo = Tipos.Fuego;
        }

        public override void Efecto(Pokemon poke1, Pokemon poke2)
        {
            Console.WriteLine("Nitrocarga");
        }
    }
}
