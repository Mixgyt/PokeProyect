using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemons
{
    class Pokemon
    {
        public string Nombre { get; set; }
        public Tipos Tipo { get; set; }
        public Estadisticas Stats { get; set; }
        public List<Ataque> Ataques { get; set;}
        public List<Tipos> Debilidad { get; set; }
        public Bitmap Imagen { get; set; }
    }
}
