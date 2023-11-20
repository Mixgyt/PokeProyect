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
using System.Media;
using ProyectoPrograI.Properties;

namespace ProyectoPrograI
{
    public partial class Pokedex : Form
    {
        List<Pokemon> pokemons = new List<Pokemon>();
        int indexPoke = 0;
        SoundPlayer reproductor;
        public Pokedex()
        {
            InitializeComponent();
            pokemons.Add(new Pikachu());
            pokemons.Add(new Bulbasaur());
            pokemons.Add(new Blastoise());
            pokemons.Add(new Charizard());
            pokemons.Add(new Geodude());
            pokemons.Add(new Diglett());
            //reproductor = new SoundPlayer(Resources.MainSound);
        }

        private void text_Click(object sender, EventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            CambiarPokemon(indexPoke);
            this.FormClosed += SilenciarMusica;
            //reproductor.PlayLooping();
        }

        private void SilenciarMusica(object sender, EventArgs e)
        {
            //reproductor.Stop();
        }

        private void RigthBt_Click(object sender, EventArgs e)
        {
            if (indexPoke < pokemons.Count-1)
            {
                CambiarPokemon(++indexPoke);
            }
        }

        private void LeftBt_Click(object sender, EventArgs e)
        {
            if (indexPoke > 0)
            CambiarPokemon(--indexPoke);
        }

        private void CambiarPokemon(int pokemon)
        {
            Imagen.Image = pokemons[pokemon].Imagen;
            NombreLbl.Text = "Nombre: " + pokemons[pokemon].Nombre;
            Estadisticas.Text = pokemons[pokemon].Stats.GetEstadisticas();
            TipoLbl.Text = "Tipo: "+pokemons[pokemon].Tipo.ToString();
        }
    }
}
