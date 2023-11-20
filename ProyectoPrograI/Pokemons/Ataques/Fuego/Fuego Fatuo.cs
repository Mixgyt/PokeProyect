using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemons.Ataques.Electrico
{
    class Fuego_Fatuo : Ataque
    {
        public Fuego_Fatuo()
        {
            Abreviatura = "Fuf";
            Nombre = "Fuego Fatuo";
            Daño = 11;
            Tipo = Tipos.Fuego;
        }

        public override void Efecto(Pokemon poke1, Pokemon poke2)
        {
            Console.WriteLine("Fuego Fatuo");
        }
    }
}
