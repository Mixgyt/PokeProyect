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

        private Entrenador entrenador1 { get; set; }
        private Entrenador entrenador2 { get; set; }

        int iterable;

        public TestBatalla()
        {
            InitializeComponent();
            entrenador1 = new Entrenador1();
            entrenador2 = new Entrenador2();

            pokemon1 = entrenador1.CambiarPokemon(0);
            pokemon2 = entrenador2.CambiarPokemon(0);
        }

        private void TestBatalla_Load(object sender, EventArgs e)
        {   
            //Poke1Img.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
            LifePoke1.Maximum = pokemon1.Stats.vida;
            toolTip.SetToolTip(Poke1Img,pokemon1.Nombre.ToUpper()+"\n"+pokemon1.Stats.GetEstadisticas());
            
            LifePoke2.Maximum = pokemon2.Stats.vida;
            toolTip.SetToolTip(Poke2Img, pokemon2.Nombre.ToUpper() + "\n" + pokemon2.Stats.GetEstadisticas());
            RecargarDatos();
            nuevoTurno();
        }

        private void NuevosDatos(int poke)
        {
            if(poke == 1)
                LifePoke1.Maximum = pokemon1.Stats.ps;
                toolTip.SetToolTip(Poke1Img, pokemon1.Nombre.ToUpper() + "\n" + pokemon1.Stats.GetEstadisticas());
            //Poke1Img.Image.RotateFlip(RotateFlipType.Rotate180FlipY);

            if (poke == 2)
                LifePoke2.Maximum = pokemon2.Stats.ps;
                toolTip.SetToolTip(Poke2Img, pokemon2.Nombre.ToUpper() + "\n" + pokemon2.Stats.GetEstadisticas());
            RecargarDatos();
        }

        private void RecargarDatos()
        {
            //Cargando el pokemon 1
            Poke1Lbl.Text = Poke1LblSignal.Text = pokemon1.Nombre;
            Poke1Img.Image = pokemon1.Imagen;
            //Cargando vida
            //Console.WriteLine("poke1: "+pokemon1.Stats.vida);
            if (pokemon1.Stats.vida >= 0 && pokemon1.Stats.vida < 100)
            {
                LifePoke1.Value = pokemon1.Stats.vida;
                LifePoke1Lbl.Text = pokemon1.Stats.vida.ToString();
                if (pokemon1.Stats.vida > pokemon1.Stats.ps * 0.50)
                {
                    LifePoke1.ProgressBarColor = Color.Green;
                }
                else if (pokemon1.Stats.vida < pokemon1.Stats.ps * 0.50 && pokemon1.Stats.vida > pokemon1.Stats.ps * 0.25)
                {
                    LifePoke1.ProgressBarColor = Color.Yellow;
                }
                else if (pokemon1.Stats.vida < pokemon1.Stats.ps * 0.25)
                {
                    LifePoke1.ProgressBarColor = Color.Red;
                }
            }
            else
            {
                LifePoke1.Value = 0;
                LifePoke1Lbl.Text = 0.ToString();
            }
            //Asignando sus ataques
            Poke1AtkBt1.Text = pokemon1.Ataques[0].Nombre;
            toolTip.SetToolTip(Poke1AtkBt1,pokemon1.Ataques[0].GetEstadisticas());
            Poke1AtkBt2.Text = pokemon1.Ataques[1].Nombre;
            toolTip.SetToolTip(Poke1AtkBt2, pokemon1.Ataques[1].GetEstadisticas());
            Poke1AtkBt3.Text = pokemon1.Ataques[2].Nombre;
            toolTip.SetToolTip(Poke1AtkBt3, pokemon1.Ataques[2].GetEstadisticas());
            Poke1AtkBt4.Text = pokemon1.Ataques[3].Nombre;
            toolTip.SetToolTip(Poke1AtkBt4, pokemon1.Ataques[3].GetEstadisticas());

            //Cargando pokemon 2
            Poke2Lbl.Text = Poke2LblSignal.Text = pokemon2.Nombre;
            Poke2Img.Image = pokemon2.Imagen;
            //Console.WriteLine("poke2: "+pokemon2.Stats.vida);
            //Cargando vida  
            if (pokemon2.Stats.vida >= 0 && pokemon2.Stats.vida < 100)
            {
                LifePoke2.Value = pokemon2.Stats.vida;
                LifePoke2Lbl.Text = pokemon2.Stats.vida.ToString();
                if(pokemon2.Stats.vida > pokemon2.Stats.ps*0.50)
                {
                    LifePoke2.ProgressBarColor = Color.Green;
                }
                else if(pokemon2.Stats.vida < pokemon2.Stats.ps*0.50 && pokemon2.Stats.vida > pokemon2.Stats.ps*0.25)
                {
                    LifePoke2.ProgressBarColor = Color.Yellow;
                }
                else if(pokemon2.Stats.vida < pokemon2.Stats.ps*0.25)
                {
                    LifePoke2.ProgressBarColor = Color.Red;
                }
            }
            else
            {
                LifePoke2.Value = 0;
                LifePoke2Lbl.Text = 0.ToString();
            }
            //Asignando sus ataques
            Poke2AtkBt1.Text = pokemon2.Ataques[0].Nombre;
            toolTip.SetToolTip(Poke2AtkBt1, pokemon2.Ataques[0].GetEstadisticas());
            Poke2AtkBt2.Text = pokemon2.Ataques[1].Nombre;
            toolTip.SetToolTip(Poke2AtkBt2, pokemon2.Ataques[1].GetEstadisticas());
            Poke2AtkBt3.Text = pokemon2.Ataques[2].Nombre;
            toolTip.SetToolTip(Poke2AtkBt3, pokemon2.Ataques[2].GetEstadisticas());
            Poke2AtkBt4.Text = pokemon2.Ataques[3].Nombre;
            toolTip.SetToolTip(Poke2AtkBt4, pokemon2.Ataques[3].GetEstadisticas());
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
                PanelCambiarPoke2.Visible = false;
                PanelAtkPoke1.Visible = true;
                PanelCambiarPoke1.Visible = true;
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
                PanelCambiarPoke1.Visible = false;
                PanelAtkPoke2.Visible = true;
                PanelCambiarPoke2.Visible = true;
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
        private void CambiarPoke1Bt_Click(object sender, EventArgs e)
        {
            SeleccionPokemon form = new SeleccionPokemon();
            form.entrenador = entrenador1;
            var result = form.ShowDialog();


            if (result == DialogResult.OK && form.pokemonSeleccionado != pokemon1)
            {
                DialogoLbl.Text = $"{entrenador1.Nombre} ha cambiado a {pokemon1.Nombre} por {form.pokemonSeleccionado.Nombre}";
                pokemon1 = form.pokemonSeleccionado;
                NuevosDatos(1);
                iterable++;
                Pokemon2Ataca();
            }
        }

        private void CambiarPoke2Bt_Click(object sender, EventArgs e)
        {
            SeleccionPokemon form = new SeleccionPokemon();
            form.entrenador = entrenador2;
            var result = form.ShowDialog();


            if (result == DialogResult.OK && form.pokemonSeleccionado != pokemon2)
            {
                DialogoLbl.Text = $"{entrenador2.Nombre} ha cambiado a {pokemon2.Nombre} por {form.pokemonSeleccionado.Nombre}";
                pokemon2 = form.pokemonSeleccionado;
                NuevosDatos(2);
                iterable++;
                Pokemon1Ataca();
            }
        }

        
    }
}
