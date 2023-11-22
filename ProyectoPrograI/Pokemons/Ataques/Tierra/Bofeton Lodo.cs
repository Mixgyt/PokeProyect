using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemons.Ataques
{
    class Bofeton_Lodo : Ataque
    {
        public Bofeton_Lodo() 
        {
            Abreviatura = "Bfl";
            Nombre = "Bofeton Lodo";
            Daño = 7;
            Tipo = Tipos.Tierra;
        }

        public override void Efecto(Pokemon poke1, Pokemon poke2)
        {
            Console.WriteLine("Bofeton Lodo");
        }
    }
}
