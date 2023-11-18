using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemons
{
    struct Estadisticas
    {
        public int vida {  get; set; }
        public int ataque { get; set; }
        public int defensa { get; set; }
        public int velocidad { get; set; }

        public string GetEstadisticas()
        {
            return $"\nVida: {vida}\nAtaque: {ataque}\nDefensas: {defensa}\nVelocidad: {velocidad}";
        }
    }
}
