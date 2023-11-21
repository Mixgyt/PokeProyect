using Pokemons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrograI
{
    partial class SeleccionPokemon : Form
    {
        public Entrenador entrenador { get; set; }
        public Pokemon pokemonSeleccionado { get; set; }

        public SeleccionPokemon()
        {
            InitializeComponent();
        }

        private void SeleccionarPokemon_Load(object sender, EventArgs e)
        {
            Poke1Bt.Text = entrenador.CambiarPokemon(0).Nombre;
            Poke1Bt.BackgroundImage = entrenador.CambiarPokemon(0).Imagen;
            if (entrenador.CambiarPokemon(0).Stats.vida > 0)
            {
                Poke1Bt.ForeColor = Color.Black;
                Poke1Bt.Enabled = true;
            }

            Poke2Bt.Text = entrenador.CambiarPokemon(1).Nombre;
            Poke2Bt.BackgroundImage = entrenador.CambiarPokemon(1).Imagen;
            if (entrenador.CambiarPokemon(1).Stats.vida > 0)
            {
                Poke2Bt.ForeColor = Color.Black;
                Poke2Bt.Enabled = true;
            }

            Poke3Bt.Text = entrenador.CambiarPokemon(2).Nombre;
            Poke3Bt.BackgroundImage = entrenador.CambiarPokemon(2).Imagen;
            if (entrenador.CambiarPokemon(2).Stats.vida > 0)
            {
                Poke3Bt.ForeColor = Color.Black;
                Poke3Bt.Enabled = true;
            }

            toolTip1.SetToolTip(Poke3Bt, entrenador.CambiarPokemon(2).Stats.GetEstadisticas());
            toolTip1.SetToolTip(Poke2Bt, entrenador.CambiarPokemon(1).Stats.GetEstadisticas());
            toolTip1.SetToolTip(Poke1Bt, entrenador.CambiarPokemon(0).Stats.GetEstadisticas());
        }

        private void Poke1Bt_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            pokemonSeleccionado = entrenador.CambiarPokemon(0);
            this.Close();
        }
        private void Poke2Bt_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            pokemonSeleccionado = entrenador.CambiarPokemon(1);
            this.Close();
        }

        private void Poke3Bt_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            pokemonSeleccionado = entrenador.CambiarPokemon(2);
            this.Close();
        }

        private void CancelarBt_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        
    }
}
