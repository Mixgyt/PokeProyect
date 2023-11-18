using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokemons;
using System.Windows.Forms;

namespace ProyectoPrograI
{
    public partial class Pokedex : Form
    {
        Pokemones pokemones = new Pokemones();
        List<Pokemon> pokemons = new List<Pokemon>();
        int indexPoke = 0;
        public Pokedex()
        {
            InitializeComponent();
            pokemons.Add(pokemones.Pikachu);
            pokemons.Add(pokemones.Bulbasaur);
            pokemons.Add(pokemones.Blastoise);
            pokemons.Add(pokemones.Charizard);
            pokemons.Add(pokemones.Geodude);
            pokemons.Add(pokemones.Diglett);
        }

        private void text_Click(object sender, EventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            CambiarPokemon(indexPoke);
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
            Estadisticas.Text = pokemons[pokemon].Estadisticas.GetEstadisticas();
        }
    }
}
