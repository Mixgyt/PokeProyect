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
using System.Media;

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

        private SoundPlayer player;

        public EleccionPokemon()
        {
            InitializeComponent();
            pokemons = new List<Pokemon>() { 
                new Blastoise(), new Bulbasaur(), 
                new Charizard(), new Diglett(),
                new Geodude(), new Pikachu()
            };

            player = new SoundPlayer(Resources.sonido_eleccion);
            player.PlayLooping();
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

        private Entrenador UnirEquipo(int entrenador)
        {
            if (entrenador == 1)
            {
                return new Entrenador()
                {
                    Nombre = txtnombre1.Text,
                    Equipo = equipo1
                };
            }
            else
            {
                return new Entrenador()
                {
                    Nombre = txtnombre2.Text,
                    Equipo = equipo2
                };
            }
        }

        private void Cerrar(object sender, EventArgs e)
        {
            this.Show();
            Equipo1.Items.Clear();
            equipo1.Clear();
            Equipo2.Items.Clear();
            equipo2.Clear();
            player.PlayLooping();
        }

        private void btnbatalla_Click(object sender, EventArgs e)
        {
            if(Equipo1.Items.Count == 3 && Equipo2.Items.Count == 3)
            {
                if (txtnombre1.Text.Trim() != "" && txtnombre2.Text.Trim() != "")
                {
                    Combate form = new Combate();
                    form.entrenador1 = UnirEquipo(1);
                    form.entrenador2 = UnirEquipo(2);
                    form.Show();
                    this.Hide();
                    //player.Stop();
                    form.FormClosed += Cerrar;
                }
                else
                {
                    MessageBox.Show("Los entrenadores deben tener un nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
                AñadirAlEquipo(true);
            }
            else
            {
                MessageBox.Show("No puedes añadir más de 3 pokemon a tu equipo","Error",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnjugador1_Click(object sender, EventArgs e)
        {
            if (Equipo1.Items.Count < 3)
            {
                Equipo1.Items.Add(pokemons[count].Nombre);
                AñadirAlEquipo(false);
            }
            else
            {
                MessageBox.Show("No puedes añadir más de 3 pokemon a tu equipo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void AñadirAlEquipo(bool equipo)
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
            Pokemon del = equipo1.Find(p => p.Nombre == Equipo1.Text);
            equipo1.Remove(del);
            Equipo1.Items.Remove(Equipo1.Text);
        }

        private void btneliminar2_Click(object sender, EventArgs e)
        {  
            Pokemon del = equipo2.Find(p => p.Nombre == Equipo2.Text);
            Equipo2.Items.Remove(Equipo2.Text);
            equipo2.Remove(del);
        }
    }
}