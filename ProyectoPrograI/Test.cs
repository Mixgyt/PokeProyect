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
    public partial class Inicio : Form
    {
        Pokemones pokemones = new Pokemones(); 
        public Inicio()
        {
            InitializeComponent();
        }

        private void text_Click(object sender, EventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            text.Text = pokemones.Pikachu.Estadisticas.GetEstadisticas();
        }
    }
}
