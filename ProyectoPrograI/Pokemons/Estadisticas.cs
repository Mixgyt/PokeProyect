using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemons
{
    class Estadisticas
    {
        public int ps { get; set; }
        public int vida {  get; set; }
        public int ataque { get; set; }
        public int defensa { get; set; }
        public int velocidad { get; set; }

        public string GetEstadisticas()
        {
            return $"Estadisticas: \nVida: {vida}\nAtaque: {ataque}\nDefensa: {defensa}\nVelocidad: {velocidad}";
        }
    }
}
