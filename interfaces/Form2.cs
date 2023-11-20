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
        SoundPlayer reproducirSonidocomba = new SoundPlayer();
        public Form2()
        {
            InitializeComponent();
            reproducirSonidocomba = new SoundPlayer(Properties.Resources.sonido_combate);
            this.reproducirSonidocomba.Play();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            reproducirSonidocomba.Stop();
            base.OnFormClosed(e);
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\MINEDUCYT\Pictures\proyecto pokemon");
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
