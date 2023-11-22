using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemons.Ataques
{
    class Altovoltaje: Ataque
    {
        public Altovoltaje() 
        {
            Abreviatura = "Alt";
            Nombre = "Altovoltaje";
            Daño = 13;
            Tipo = Tipos.Electrico;
        }

        public override void Efecto(Pokemon poke1, Pokemon poke2)
        {
            Console.WriteLine("Altovoltaje");
            //
        }
    }
}
