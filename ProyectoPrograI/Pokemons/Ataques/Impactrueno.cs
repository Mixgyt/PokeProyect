using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemons.Ataques
{
    class Impactrueno : Ataque
    {
        public Impactrueno() 
        {
            Abreviatura = "Imp";
            Nombre = "Impactrueno";
            Daño = 5;
            Tipo = Tipos.Electrico;
        }

        public override void Efecto(Pokemon poke1, Pokemon poke2)
        {
            Console.WriteLine("Impactrueno");
        }
    }
}
