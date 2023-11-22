using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemons
{
    abstract class Ataque
    {
        public string Abreviatura = "Asc";
        public string Nombre { get; set; }
        public int Daño { get; set; }
        public Tipos Tipo { get; set; }

        public abstract void Efecto(Pokemon poke1, Pokemon poke2);

        public string GetEstadisticas()
        {
            return $"{Nombre}\nTipo: {Tipo}\nDaño: {Daño}";
        }
    }
}
