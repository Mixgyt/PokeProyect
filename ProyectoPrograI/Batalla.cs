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
            string mensaje;
            int criticoProb = rand.Next(0, 11);
            if (poke2.Debilidad.Contains(atk.Tipo))
            {
                double daño = (double)poke1.Stats.ataque / poke2.Stats.defensa * atk.Daño;
                daño = daño + (daño*0.25);
                mensaje = $"{poke1.Nombre} ataco a {poke2.Nombre} con {atk.Nombre} (SUPER EFECTIVO), causo {(int)daño} de daño";
                if (criticoProb < 4)
                {
                    daño = daño * 2;
                    mensaje = $"{poke1.Nombre} ataco a {poke2.Nombre} con {atk.Nombre} (SUPER EFECTIVO) y (CRITICO), causo {(int)daño} de daño";
                }
                poke2.Stats.vida = poke2.Stats.vida - (int)daño;
            }
            else
            {
                double daño = (double) poke1.Stats.ataque / poke2.Stats.defensa * atk.Daño;
                mensaje = $"{poke1.Nombre} ataco a {poke2.Nombre} con {atk.Nombre}, causo {(int)daño} de daño";
                if (criticoProb < 4)
                {
                    daño = daño * 2;
                    mensaje = $"{poke1.Nombre} ataco a {poke2.Nombre} con {atk.Nombre} (CRITICO), causo {(int)daño} de daño";
                }

                poke2.Stats.vida = poke2.Stats.vida - (int)daño;
                 
            }
            //Console.WriteLine(criticoProb);
            return mensaje;
        }

        /*public static string Ataque1(Pokemon poke1, Pokemon poke2, Ataque atk)
        {
            Random rand = new Random();
            double daño = (double) poke1.Stats.ataque / poke2.Stats.defensa * atk.Daño;
            Console.WriteLine($"La vida de {poke2.Nombre} seria: {poke2.Stats.vida - daño}, daño {daño}");
            return $"El daño es: {(int)daño}";
        }*/
        

        
    }
}
