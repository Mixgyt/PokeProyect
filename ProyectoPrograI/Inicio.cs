using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoPrograI.Properties;
using ProyectoPrograI.Recursos;

namespace ProyectoPrograI
{
    public partial class Inicio : Form
    {
        //se Ultiza la clase SoundPlayer para la reproduccion de sonidos
        SoundPlayer reproducirSonidoIni =new SoundPlayer(); 

        //Aplicamos la variable reproduciSonidoIni para iniciar la musica 
        public Inicio()
        {
            InitializeComponent();
            reproducirSonidoIni = new SoundPlayer(Properties.Resources.sonido_Principal);
            reproducirSonidoIni.PlayLooping();
        }

        //Buton iniciar se vincula con la siguinte formulario (elccion pokemmon)
        private void button1_Click(object sender, EventArgs e)
        {
            Form BotonInicio = new EleccionPokemon();
            BotonInicio.Show();
            this.Hide();
            BotonInicio.FormClosed += cerrarVentana;

        }

        //se crea un metodo que cierra las ventanas que quedan abierta en segundo plano 
        private void cerrarVentana(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void Form1_Load(object sender, EventArgs e)

        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Creditos form = new Creditos();
            form.ShowDialog();
        }
    }
}
