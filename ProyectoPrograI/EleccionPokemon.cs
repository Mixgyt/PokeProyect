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
    public partial class EleccionPokemon : Form
    {
        private List<Pokemon> pokemons;
        private List<Pokemon> equipo1 = new List<Pokemon>();
        private List<Pokemon> equipo2 = new List<Pokemon>();
        private int[,] colores = new int[6,3]
        {
            {214, 225, 247},
            {156, 251, 201},
            {248, 230, 180},
            {239, 201, 138},
            {227, 225, 221},
            {249, 247, 130},
        };

        public EleccionPokemon()
        {
            InitializeComponent();
            pokemons = new List<Pokemon>() { 
                new Blastoise(), new Bulbasaur(), 
                new Charizard(), new Diglett(),
                new Geodude(), new Pikachu()
                };
        }
        int count = 0;

        private void btnderecha_Click(object sender, EventArgs e)
        {
            if (count < 5)
            {
                count++;
            }


            pcbpokemon.Image = listpokemons.Images[count];
            pcbestadistica.Image = listestadisticas.Images[count];
            pcbpokemon.BackColor = Color.FromArgb(colores[count, 0], colores[count, 1], colores[count, 2]);
            lblnombres.Text = pokemons[count].Nombre;
            lbltipos.Text = pokemons[count].Tipo.ToString();
            lblvidas.Text = pokemons[count].Stats.vida.ToString();
            lblataques.Text = pokemons[count].Stats.ataque.ToString();
            lbldefensa.Text = pokemons[count].Stats.defensa.ToString();
            lblvelocidad.Text = pokemons[count].Stats.velocidad.ToString();
        }

        private void btnizquierda_Click(object sender, EventArgs e)
        {
            if (count > 0)
            {
                count--;
            }

            pcbpokemon.Image = listpokemons.Images[count];
            pcbestadistica.Image = listestadisticas.Images[count];
            pcbpokemon.BackColor = Color.FromArgb(colores[count, 0], colores[count, 1], colores[count, 2]);
            lblnombres.Text = pokemons[count].Nombre;
            lbltipos.Text = pokemons[count].Tipo.ToString();
            lblvidas.Text = pokemons[count].Stats.vida.ToString();
            lblataques.Text = pokemons[count].Stats.ataque.ToString();
            lbldefensa.Text = pokemons[count].Stats.defensa.ToString();
            lblvelocidad.Text = pokemons[count].Stats.velocidad.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pcbpokemon.Image = listpokemons.Images[count];
            pcbpokemon.BackColor = Color.FromArgb(colores[count,0], colores[count, 1], colores[count, 2]);
            pcbestadistica.Image = listestadisticas.Images[count];
            lblnombres.Text = pokemons[count].Nombre;
            lbltipos.Text = pokemons[count].Tipo.ToString();
            lblvidas.Text = pokemons[count].Stats.vida.ToString();
            lblataques.Text = pokemons[count].Stats.ataque.ToString();
            lbldefensa.Text = pokemons[count].Stats.defensa.ToString();
            lblvelocidad.Text = pokemons[count].Stats.velocidad.ToString();
        }

        private void btnbatalla_Click(object sender, EventArgs e)
        {
            if(Equipo1.Items.Count == 3 && Equipo2.Items.Count == 3)
            {

            }
            else
            {
                MessageBox.Show("No puedes iniciar una batalla sin tener 3 pokemon cada uno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnjugador2_Click(object sender, EventArgs e)
        {
            if (Equipo2.Items.Count < 3)
            { 
                Equipo2.Items.Add(pokemons[count].Nombre);
                A�adirAlEquipo(true);
            }
            else
            {
                MessageBox.Show("No puedes a�adir m�s de 3 pokemon a tu equipo","Error",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnjugador1_Click(object sender, EventArgs e)
        {
            if (Equipo1.Items.Count < 3)
            {
                Equipo1.Items.Add(pokemons[count].Nombre);
                A�adirAlEquipo(false);
            }
            else
            {
                MessageBox.Show("No puedes a�adir m�s de 3 pokemon a tu equipo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void A�adirAlEquipo(bool equipo)
        {
            if(!equipo) 
            {
                switch (pokemons[count].Nombre)
                {
                    case "Blastoise":
                        equipo1.Add(new Blastoise());
                        break;
                    case "Bulbasaur":
                        equipo1.Add(new Bulbasaur());
                        break;
                    case "Charizard":
                        equipo1.Add(new Charizard());
                        break;
                    case "Diglett":
                        equipo1.Add(new Diglett());
                        break;
                    case "Geodude":
                        equipo1.Add(new Geodude());
                        break;
                    case "Pikachu":
                        equipo1.Add(new Pikachu());
                        break;
                }
            }
            else
            {
                switch (pokemons[count].Nombre)
                {
                    case "Blastoise":
                        equipo2.Add(new Blastoise());
                        break;
                    case "Bulbasaur":
                        equipo2.Add(new Bulbasaur());
                        break;
                    case "Charizard":
                        equipo2.Add(new Charizard());
                        break;
                    case "Diglett":
                        equipo2.Add(new Diglett());
                        break;
                    case "Geodude":
                        equipo2.Add(new Geodude());
                        break;
                    case "Pikachu":
                        equipo2.Add(new Pikachu());
                        break;
                }
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            Equipo1.Items.Remove(Equipo1.Text);
        }

        private void btneliminar2_Click(object sender, EventArgs e)
        {
            Equipo2.Items.Remove(Equipo2.Text);
        }
    }
}