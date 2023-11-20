using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokemons;
using Pokemons.Pokemones;
using System.Windows.Forms;
using ProyectoPrograI.Properties;
using System.Windows.Controls;
using System.Threading;

namespace ProyectoPrograI
{
    public partial class TestBatalla : Form
    {   
        private Pokemon pokemon1 { get; set; }
        private Pokemon pokemon2 { get; set; }

        int iterable;

        public TestBatalla()
        {
            InitializeComponent();
            pokemon1 = new Pikachu();
            pokemon2 = new Bulbasaur();
        }

        private void TestBatalla_Load(object sender, EventArgs e)
        {
            
            Poke1Img.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
            LifePoke1.Maximum = pokemon1.Stats.vida;

            
            LifePoke2.Maximum = pokemon2.Stats.vida;
            RecargarDatos();
            nuevoTurno();
        }

        private void RecargarDatos()
        {
            //Cargando el pokemon 1
            Poke1Lbl.Text = Poke1LblSignal.Text = pokemon1.Nombre;
            Poke1Img.Image = pokemon1.Imagen;
            //Cargando vida
            if (pokemon1.Stats.vida >= 0)
            {
                LifePoke1.Value = pokemon1.Stats.vida;
                LifePoke1Lbl.Text = pokemon1.Stats.vida.ToString();
            }
            else
            {
                LifePoke1.Value = 0;
                LifePoke1Lbl.Text = 0.ToString();
            }
            //Asignando sus ataques
            Poke1AtkBt1.Text = pokemon1.Ataques[0].Nombre;
            Poke1AtkBt2.Text = pokemon1.Ataques[1].Nombre;
            Poke1AtkBt3.Text = pokemon1.Ataques[2].Nombre;
            Poke1AtkBt4.Text = pokemon1.Ataques[3].Nombre;

            //Cargando pokemon 2
            Poke2Lbl.Text = Poke2LblSignal.Text = pokemon2.Nombre;
            Poke2Img.Image = pokemon2.Imagen;
            //Cargando vida  
            if (pokemon2.Stats.vida >= 0)
            {
                LifePoke2.Value = pokemon2.Stats.vida;
                LifePoke2Lbl.Text = pokemon2.Stats.vida.ToString();
            }
            else
            {
                LifePoke2.Value = 0;
                LifePoke2Lbl.Text = 0.ToString();
            }
            //Asignando sus ataques
            Poke2AtkBt1.Text = pokemon2.Ataques[0].Nombre;
            Poke2AtkBt2.Text = pokemon2.Ataques[1].Nombre;
            Poke2AtkBt3.Text = pokemon2.Ataques[2].Nombre;
            Poke2AtkBt4.Text = pokemon2.Ataques[3].Nombre;
        }

        private void nuevoTurno()
        {
            iterable = 0;
            if (pokemon1.Stats.vida > 0 && pokemon2.Stats.vida > 0)
            {
                if (pokemon1.Stats.velocidad > pokemon2.Stats.velocidad)
                {
                    Pokemon1Ataca();
                }
                else
                {
                    Pokemon2Ataca();
                }
            }
            else
            {
                ComprobarVida();
            }
        }

        private void Pokemon1Ataca()
        {
            if(iterable < 2) 
            {
                PanelAtkPoke2.Visible = false;
                PanelAtkPoke1.Visible = true;
            }
            else
            {
                nuevoTurno();
            }
            ComprobarVida();
        }

        private void Pokemon2Ataca()
        {   
            if (iterable < 2)
            { 
                PanelAtkPoke1.Visible = false;
                PanelAtkPoke2.Visible = true; 
            }
            else
            {
                nuevoTurno();
            }
            ComprobarVida();
        }

        private void ComprobarVida()
        {
            if (pokemon1.Stats.vida <= 0)
            {
                PanelAtkPoke1.Visible = false;
                PanelAtkPoke2.Visible = false;
                DialogoLbl.Text = $"{pokemon1.Nombre} ha ya no puede seguir peleando, {pokemon2.Nombre} gana el combate";
            }
            else if (pokemon2.Stats.vida <= 0)
            {
                PanelAtkPoke1.Visible = false;
                PanelAtkPoke2.Visible = false;
                DialogoLbl.Text = $"{pokemon2.Nombre} ha ya no puede seguir peleando, {pokemon1.Nombre} gana el combate";
            }
        }

        private void Poke1AtkBt1_Click(object sender, EventArgs e)
        {
            DialogoLbl.Text = Batalla.Ataque(pokemon1, pokemon2, pokemon1.Ataques[0]);
            RecargarDatos();
            iterable++;
            Pokemon2Ataca();
            Console.WriteLine(iterable);
        }

        private void Poke1AtkBt2_Click(object sender, EventArgs e)
        {
            DialogoLbl.Text = Batalla.Ataque(pokemon1, pokemon2, pokemon1.Ataques[1]);
            RecargarDatos();
            iterable++;
            Pokemon2Ataca();
        }

        private void Poke1AtkBt3_Click(object sender, EventArgs e)
        {
            DialogoLbl.Text = Batalla.Ataque(pokemon1, pokemon2, pokemon1.Ataques[2]);
            RecargarDatos();
            iterable++;
            Pokemon2Ataca();
        }

        private void Poke1AtkBt4_Click(object sender, EventArgs e)
        {
            DialogoLbl.Text = Batalla.Ataque(pokemon1, pokemon2, pokemon1.Ataques[3]);
            RecargarDatos();
            iterable++;
            Pokemon2Ataca();
        }

        private void Poke2AtkBt1_Click(object sender, EventArgs e)
        {
            DialogoLbl.Text = Batalla.Ataque(pokemon2, pokemon1, pokemon2.Ataques[0]);
            RecargarDatos();
            iterable++;
            Pokemon1Ataca();
        }

        private void Poke2AtkBt2_Click(object sender, EventArgs e)
        {
            DialogoLbl.Text = Batalla.Ataque(pokemon2, pokemon1, pokemon2.Ataques[1]);
            RecargarDatos();
            iterable++;
            Pokemon1Ataca();
        }

        private void Poke2AtkBt3_Click(object sender, EventArgs e)
        {
            DialogoLbl.Text = Batalla.Ataque(pokemon2, pokemon1, pokemon2.Ataques[2]);
            RecargarDatos();
            iterable++;
            Pokemon1Ataca();
        }

        private void Poke2AtkBt4_Click(object sender, EventArgs e)
        {
            DialogoLbl.Text = Batalla.Ataque(pokemon2, pokemon1, pokemon2.Ataques[3]);
            RecargarDatos();
            iterable++;
            Pokemon1Ataca();
        }
    }
}
