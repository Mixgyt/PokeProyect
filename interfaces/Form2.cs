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

namespace interfaz
{
    public partial class Form2 : Form
    {
        //se Ultiza la clase SoundPlayer para la reproduccion de sonidos
        SoundPlayer reproducirSonidocomba = new SoundPlayer();
        public Form2()
        {
            InitializeComponent();

            // codigo utlizado para la reproduccion de sonido
            reproducirSonidocomba = new SoundPlayer(Properties.Resources.sonido_combate);
            this.reproducirSonidocomba.PlayLooping();

            // aqui se le estamos agregando una imagen al boton de cambiar pokemon
            Bitmap image = new Bitmap(Properties.Resources.poke_bola_2_);
            BotonCambiar.BackgroundImage = image;
            BotonCambiar.BackgroundImageLayout = ImageLayout.Zoom;
        }
      
         // Esta funcion ayuda que detenga la musica hay cerrar la aplicacion
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            reproducirSonidocomba.Stop();
            base.OnFormClosed(e);
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
