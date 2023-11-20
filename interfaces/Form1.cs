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
using interfaz.Properties;

namespace interfaz
{
    public partial class Form1 : Form
    {
        SoundPlayer reproducirSonidoIni =new SoundPlayer(); 
        public Form1()
        {
            InitializeComponent();
            reproducirSonidoIni = new SoundPlayer(Properties.Resources.sonido_Principal);
            this.reproducirSonidoIni.Play();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            Form BotonInicio = new Form2();
            BotonInicio.Show();
            this.Hide();
           
           
        }
        
        private void Form1_Load(object sender, EventArgs e)

        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }
    



    }
}
