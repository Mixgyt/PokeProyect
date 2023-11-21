using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemons.Ataques
{
    class Terremoto : Ataque
    {
        public Terremoto() 
        {
            Abreviatura = "Ter";
            Nombre = "Terremoto";
            Daño = 24;
            Tipo = Tipos.Tierra;
        }

        public override void Efecto(Pokemon poke1, Pokemon poke2)
        {
            Console.WriteLine("Terremoto");
        }
    }
}
