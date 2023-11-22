using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using Pokemons;
using Pokemons.Ataques;

namespace ProyectoPrograI
{
    partial class Combate : Form
    {
        //se Ultiza la clase SoundPlayer para la reproduccion de sonidos
        SoundPlayer reproducirSonidocomba = new SoundPlayer();

        //Entrenadores en la pelea
        public Entrenador entrenador1 { get; set; }
        public Entrenador entrenador2 { get; set; }

        //Pokemons dentro de la pelea
        private Pokemon pokemon1 { get; set; }
        private Pokemon pokemon2 { get; set; }

        //Variable que itera entre 0, 1 y 2 para los turnos
        private int iterable = 0;

        public Combate()
        {
            InitializeComponent();

            // codigo utlizado para la reproduccion de sonido
            reproducirSonidocomba = new SoundPlayer(Properties.Resources.sonido_combate);
            this.reproducirSonidocomba.PlayLooping();

            // aqui se le estamos agregando una imagen al boton de cambiar pokemon
            Bitmap image = new Bitmap(Properties.Resources.pokeball);
            CambiarPoke2Bt.BackgroundImage = image;
            CambiarPoke2Bt.BackgroundImageLayout = ImageLayout.Zoom;

            Bitmap img = new Bitmap(Properties.Resources.pokeball);
            CambiarPoke1Bt.BackgroundImage = img;
            CambiarPoke1Bt.BackgroundImageLayout = ImageLayout.Zoom;
        }
      
         // Esta funcion ayuda que detenga la musica hay cerrar la aplicacion
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            reproducirSonidocomba.Stop();
            base.OnFormClosed(e);
        }
        
        //Funcion que carga al momento de cargar la ventana de combate
        private void Combate_Load(object sender, EventArgs e)
        {
            pokemon1 = entrenador1.Equipo[0];
            pokemon2 = entrenador2.Equipo[0];

            LifePoke1.Maximum = pokemon1.Stats.vida;
            toolTip.SetToolTip(Poke1Img, pokemon1.Nombre.ToUpper() + "\n" + pokemon1.Stats.GetEstadisticas());

            LifePoke2.Maximum = pokemon2.Stats.vida;
            toolTip.SetToolTip(Poke2Img, pokemon2.Nombre.ToUpper() + "\n" + pokemon2.Stats.GetEstadisticas());
            RecargarDatos();
            nuevoTurno();
        }

        private void NuevosDatos(int poke)
        {
            if (poke == 1)
                LifePoke1.Maximum = pokemon1.Stats.ps;
            toolTip.SetToolTip(Poke1Img, pokemon1.Nombre.ToUpper() + "\n" + pokemon1.Stats.GetEstadisticas());
            //Poke1Img.Image.RotateFlip(RotateFlipType.Rotate180FlipY);

            if (poke == 2)
                LifePoke2.Maximum = pokemon2.Stats.ps;
            toolTip.SetToolTip(Poke2Img, pokemon2.Nombre.ToUpper() + "\n" + pokemon2.Stats.GetEstadisticas());
            RecargarDatos();
        }

        private void RecargarDatos()
        {
            //Cargando el pokemon 1
            Poke1Lbl.Text = pokemon1.Nombre;
            Poke1Img.Image = pokemon1.Imagen;

            //Console.WriteLine("poke1: "+pokemon1.Stats.vida); // linea de prueba

            //Su barra cambia si se cumplen las condiciones
            if (pokemon1.Stats.vida >= 0 && pokemon1.Stats.vida < 100)
            {
                LifePoke1.Value = pokemon1.Stats.vida;
                LifePoke1Lbl.Text = pokemon1.Stats.vida.ToString();
                if (pokemon1.Stats.vida > pokemon1.Stats.ps * 0.50)
                {
                    LifePoke1.ProgressBarColor = Color.Green;
                }
                else if (pokemon1.Stats.vida < pokemon1.Stats.ps * 0.50 && pokemon1.Stats.vida > pokemon1.Stats.ps * 0.25)
                {
                    LifePoke1.ProgressBarColor = Color.Yellow;
                }
                else if (pokemon1.Stats.vida < pokemon1.Stats.ps * 0.25)
                {
                    LifePoke1.ProgressBarColor = Color.Red;
                }
            }
            else
            {
                LifePoke1.Value = 0;
                LifePoke1Lbl.Text = 0.ToString();
            }
            //Asignando sus ataques
            Poke1AtkBt1.Text = pokemon1.Ataques[0].Nombre;
            toolTip.SetToolTip(Poke1AtkBt1, pokemon1.Ataques[0].GetEstadisticas());
            Poke1AtkBt2.Text = pokemon1.Ataques[1].Nombre;
            toolTip.SetToolTip(Poke1AtkBt2, pokemon1.Ataques[1].GetEstadisticas());
            Poke1AtkBt3.Text = pokemon1.Ataques[2].Nombre;
            toolTip.SetToolTip(Poke1AtkBt3, pokemon1.Ataques[2].GetEstadisticas());
            Poke1AtkBt4.Text = pokemon1.Ataques[3].Nombre;
            toolTip.SetToolTip(Poke1AtkBt4, pokemon1.Ataques[3].GetEstadisticas());

            //Cargando pokemon 2
            Poke2Lbl.Text = pokemon2.Nombre;
            Poke2Img.Image = pokemon2.Imagen;

            //Console.WriteLine("poke2: "+pokemon2.Stats.vida); //linea de prueba

            //Sus barra cambia si se cumplen las condiciones
            if (pokemon2.Stats.vida >= 0 && pokemon2.Stats.vida < 100)
            {
                LifePoke2.Value = pokemon2.Stats.vida;
                LifePoke2Lbl.Text = pokemon2.Stats.vida.ToString();
                if (pokemon2.Stats.vida > pokemon2.Stats.ps * 0.50)
                {
                    LifePoke2.ProgressBarColor = Color.Green;
                }
                else if (pokemon2.Stats.vida < pokemon2.Stats.ps * 0.50 && pokemon2.Stats.vida > pokemon2.Stats.ps * 0.25)
                {
                    LifePoke2.ProgressBarColor = Color.Yellow;
                }
                else if (pokemon2.Stats.vida < pokemon2.Stats.ps * 0.25)
                {
                    LifePoke2.ProgressBarColor = Color.Red;
                }
            }
            else
            {
                LifePoke2.Value = 0;
                LifePoke2Lbl.Text = 0.ToString();
            }

            //Asignando sus ataques
            Poke2AtkBt1.Text = pokemon2.Ataques[0].Nombre;
            toolTip.SetToolTip(Poke2AtkBt1, pokemon2.Ataques[0].GetEstadisticas());
            Poke2AtkBt2.Text = pokemon2.Ataques[1].Nombre;
            toolTip.SetToolTip(Poke2AtkBt2, pokemon2.Ataques[1].GetEstadisticas());
            Poke2AtkBt3.Text = pokemon2.Ataques[2].Nombre;
            toolTip.SetToolTip(Poke2AtkBt3, pokemon2.Ataques[2].GetEstadisticas());
            Poke2AtkBt4.Text = pokemon2.Ataques[3].Nombre;
            toolTip.SetToolTip(Poke2AtkBt4, pokemon2.Ataques[3].GetEstadisticas());
        }

        //Funcion creada para comprobar la vida de los pokemon si han sido derrotados o no
        private void ComprobarVida()
        {
            if (pokemon1.Stats.vida <= 0)
            {
                PanelAtkPoke1.Visible = false;
                PanelAtkPoke2.Visible = false;
                DialogoLbl.Text = $"{pokemon1.Nombre} ha ya no puede seguir peleando";
                TerminarCombate();
            }
            else if (pokemon2.Stats.vida <= 0)
            {
                PanelAtkPoke1.Visible = false;
                PanelAtkPoke2.Visible = false;
                DialogoLbl.Text = $"{pokemon2.Nombre} ha ya no puede seguir peleando";
                TerminarCombate();
            }
        }

        private void TerminarCombate()
        {
            if (entrenador2.CambiarPokemon(0).Stats.vida <= 0 && entrenador2.CambiarPokemon(1).Stats.vida <= 0 && entrenador2.CambiarPokemon(2).Stats.vida <= 0)
            {
                DialogoLbl.Text += $", {pokemon1.Nombre} gana el combate";
                TerminarBt.Text += $"\nEl entrenador {entrenador1.Nombre} gana el combate";
                PanelTerminar.Visible = true;
            }
            if (entrenador1.CambiarPokemon(0).Stats.vida <= 0 && entrenador1.CambiarPokemon(1).Stats.vida <= 0 && entrenador1.CambiarPokemon(2).Stats.vida <= 0)
            {
                DialogoLbl.Text += $", {pokemon2.Nombre} gana el combate";
                TerminarBt.Text += $"\nEl entrenador {entrenador2.Nombre} gana el combate";
                PanelTerminar.Visible = true;
            }
        }

        //Funcion ultilizada para ver que pokemon es más veloz para cederle el turno
        private void nuevoTurno()
        {
            iterable = 0;
            if (pokemon1.Stats.vida > 0 && pokemon2.Stats.vida > 0)
            {
                if (pokemon1.Stats.velocidad > pokemon2.Stats.velocidad)
                {
                    Pokemon1Ataca();
                }
                else
                {
                    Pokemon2Ataca();
                }
            }
            else
            {
                ComprobarVida();
            }
        }

        //Funcion que le cede el ataque al pokemon 1
        private void Pokemon1Ataca()
        {
            if (iterable < 2)
            {
                PanelAtkPoke2.Visible = false;
                PanelCambiarPoke2.Visible = false;
                PanelAtkPoke1.Visible = true;
                PanelCambiarPoke1.Visible = true;
                PokeLblinfo.Text = $"Turno del {entrenador1.Nombre} : {pokemon1.Nombre}";
            }
            else
            {
                nuevoTurno();
            }
            ComprobarVida();
        }

        //Funcion que le cede el ataque al pokemon 2
        private void Pokemon2Ataca()
        {
            if (iterable < 2)
            {
                PanelAtkPoke1.Visible = false;
                PanelCambiarPoke1.Visible = false;
                PanelAtkPoke2.Visible = true;
                PanelCambiarPoke2.Visible = true;
                PokeLblinfo.Text = $"Turno del {entrenador2.Nombre} : {pokemon2.Nombre}";
            }
            else
            {
                nuevoTurno();
            }
            ComprobarVida();
        }

        //Boton del ataque 1 del pokemon 1
        private void Poke1AtkBt1_Click(object sender, EventArgs e)
        {
            DialogoLbl.Text = Batalla.Ataque(pokemon1, pokemon2, pokemon1.Ataques[0]);
            RecargarDatos();
            iterable++;
            Pokemon2Ataca();
            Console.WriteLine(iterable);
        }

        //Boton del ataque 2 del pokemon 1
        private void Poke1AtkBt2_Click(object sender, EventArgs e)
        {
            DialogoLbl.Text = Batalla.Ataque(pokemon1, pokemon2, pokemon1.Ataques[1]);
            RecargarDatos();
            iterable++;
            Pokemon2Ataca();
        }

        //Boton del ataque 3 del pokemon 1
        private void Poke1AtkBt3_Click(object sender, EventArgs e)
        {
            DialogoLbl.Text = Batalla.Ataque(pokemon1, pokemon2, pokemon1.Ataques[2]);
            RecargarDatos();
            iterable++;
            Pokemon2Ataca();
        }

        //Boton del ataque 4 del pokemon 1
        private void Poke1AtkBt4_Click(object sender, EventArgs e)
        {
            DialogoLbl.Text = Batalla.Ataque(pokemon1, pokemon2, pokemon1.Ataques[3]);
            RecargarDatos();
            iterable++;
            Pokemon2Ataca();
        }

        //Boton del ataque 1 del pokemon 2
        private void Poke2AtkBt1_Click(object sender, EventArgs e)
        {
            DialogoLbl.Text = Batalla.Ataque(pokemon2, pokemon1, pokemon2.Ataques[0]);
            RecargarDatos();
            iterable++;
            Pokemon1Ataca();
        }

        //Boton del ataque 2 del pokemon 2
        private void Poke2AtkBt2_Click(object sender, EventArgs e)
        {
            DialogoLbl.Text = Batalla.Ataque(pokemon2, pokemon1, pokemon2.Ataques[1]);
            RecargarDatos();
            iterable++;
            Pokemon1Ataca();
        }

        //Boton del ataque 3 del pokemon 2
        private void Poke2AtkBt3_Click(object sender, EventArgs e)
        {
            DialogoLbl.Text = Batalla.Ataque(pokemon2, pokemon1, pokemon2.Ataques[2]);
            RecargarDatos();
            iterable++;
            Pokemon1Ataca();
        }

        //Boton del ataque 4 del pokemon 2
        private void Poke2AtkBt4_Click(object sender, EventArgs e)
        {
            DialogoLbl.Text = Batalla.Ataque(pokemon2, pokemon1, pokemon2.Ataques[3]);
            RecargarDatos();
            iterable++;
            Pokemon1Ataca();
        }

        //Funcion que muestra un dialogo para cambiar el pokemon del entrenador 1
        private void CambiarPoke1Bt_Click(object sender, EventArgs e)
        {
            CambiarPokemon form = new CambiarPokemon();
            form.entrenador = entrenador1;
            var result = form.ShowDialog();


            if (result == DialogResult.OK && form.pokemonSeleccionado != pokemon1)
            {
                DialogoLbl.Text = $"{entrenador1.Nombre} ha cambiado a {pokemon1.Nombre} por {form.pokemonSeleccionado.Nombre}";
                pokemon1 = form.pokemonSeleccionado;
                NuevosDatos(1);
                iterable++;
                Pokemon2Ataca();
            }
        }

        //Funcion que muestra un dialogo para cambiar el pokemon del entrenador 2
        private void CambiarPoke2Bt_Click(object sender, EventArgs e)
        {
            CambiarPokemon form = new CambiarPokemon();
            form.entrenador = entrenador2;
            var result = form.ShowDialog();


            if (result == DialogResult.OK && form.pokemonSeleccionado != pokemon2)
            {
                DialogoLbl.Text = $"{entrenador2.Nombre} ha cambiado a {pokemon2.Nombre} por {form.pokemonSeleccionado.Nombre}";
                pokemon2 = form.pokemonSeleccionado;
                NuevosDatos(2);
                iterable++;
                Pokemon1Ataca();
            }
        }

        private void TerminarBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
