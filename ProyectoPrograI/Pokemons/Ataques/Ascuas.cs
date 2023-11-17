using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemons.Ataques
{
    class Ascuas : Ataque
    {
        public Ascuas() 
        {
            Abreviatura = "Asc";
            Nombre = "Ascuas";
            Daño = 10;
            Tipo = Tipos.Fuego;
        }
    }
}
