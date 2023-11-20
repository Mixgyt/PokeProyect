using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokemons;

namespace ProyectoPrograI
{
    static class Batalla
    {
        
        public static string Ataque(Pokemon poke1, Pokemon poke2, Ataque atk)
        {
            //Poke1 es el que hace el ataque
            //Poke2 es quien recibe el ataque
            Random rand = new Random();
            string mensaje = "";
            int criticoProb = rand.Next(0, 11);
            if (poke2.Debilidad.Contains(atk.Tipo))
            {
                int daño = poke2.Stats.defensa + poke2.Stats.vida - (atk.Daño + poke1.Stats.ataque);
                daño = (int)Math.Round(daño - ((poke2.Stats.vida-daño) * 0.25));
                mensaje = $"{poke1.Nombre} ataco a {poke2.Nombre} con {atk.Nombre} (SUPER EFECTIVO), causo {poke2.Stats.vida - daño} de daño";
                if (criticoProb < 4)
                {
                    daño = (daño * 2) - poke2.Stats.vida;
                    mensaje = $"{poke1.Nombre} ataco a {poke2.Nombre} con {atk.Nombre} (SUPER EFECTIVO) y (CRITICO), causo {poke2.Stats.vida - daño} de daño";
                }
                poke2.Stats.vida = daño;
            }
            else
            {
                int daño = poke2.Stats.defensa + poke2.Stats.vida - (atk.Daño + poke1.Stats.ataque);
                mensaje = $"{poke1.Nombre} ataco a {poke2.Nombre} con {atk.Nombre}, causo {poke2.Stats.vida - daño} de daño";
                if (criticoProb <= 4)
                {
                    daño = (daño * 2) - poke2.Stats.vida;
                    mensaje = $"{poke1.Nombre} ataco a {poke2.Nombre} con {atk.Nombre} (CRITICO), causo {poke2.Stats.vida - daño} de daño";
                }

                poke2.Stats.vida = daño;
                 
            }
            //Console.WriteLine(criticoProb);
            return mensaje;
        }
        

        
    }
}
