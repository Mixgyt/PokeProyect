﻿using System.Windows.Forms;
using System.Drawing;

namespace ProyectoPrograI
{
    partial class EleccionPokemon
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EleccionPokemon));
            this.btnderecha = new FontAwesome.Sharp.IconButton();
            this.btnizquierda = new FontAwesome.Sharp.IconButton();
            this.listpokemons = new System.Windows.Forms.ImageList(this.components);
            this.listestadisticas = new System.Windows.Forms.ImageList(this.components);
            this.pcbpokemon = new System.Windows.Forms.PictureBox();
            this.pcbestadistica = new System.Windows.Forms.PictureBox();
            this.tipo = new System.Windows.Forms.Label();
            this.btnjugador1 = new System.Windows.Forms.Button();
            this.lbltipos = new System.Windows.Forms.Label();
            this.lblnombres = new System.Windows.Forms.Label();
            this.lblvida = new System.Windows.Forms.Label();
            this.ataque = new System.Windows.Forms.Label();
            this.defensa = new System.Windows.Forms.Label();
            this.velocidad = new System.Windows.Forms.Label();
            this.lblvidas = new System.Windows.Forms.Label();
            this.lblataques = new System.Windows.Forms.Label();
            this.lbldefensa = new System.Windows.Forms.Label();
            this.lblvelocidad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbljugador1 = new System.Windows.Forms.Label();
            this.lbljugador2 = new System.Windows.Forms.Label();
            this.njugador1 = new System.Windows.Forms.Label();
            this.njugador2 = new System.Windows.Forms.Label();
            this.lblequipo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btneliminar1 = new System.Windows.Forms.Button();
            this.btneliminar2 = new System.Windows.Forms.Button();
            this.txtnombre1 = new System.Windows.Forms.TextBox();
            this.txtnombre2 = new System.Windows.Forms.TextBox();
            this.btnjugador2 = new System.Windows.Forms.Button();
            this.btnbatalla = new System.Windows.Forms.Button();
            this.Equipo2 = new System.Windows.Forms.ListBox();
            this.Equipo1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbpokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbestadistica)).BeginInit();
            this.SuspendLayout();
            // 
            // btnderecha
            // 
            this.btnderecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnderecha.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight;
            this.btnderecha.IconColor = System.Drawing.Color.Black;
            this.btnderecha.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnderecha.IconSize = 30;
            this.btnderecha.Location = new System.Drawing.Point(469, 332);
            this.btnderecha.Name = "btnderecha";
            this.btnderecha.Size = new System.Drawing.Size(39, 32);
            this.btnderecha.TabIndex = 0;
            this.btnderecha.UseVisualStyleBackColor = false;
            this.btnderecha.Click += new System.EventHandler(this.btnderecha_Click);
            // 
            // btnizquierda
            // 
            this.btnizquierda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnizquierda.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            this.btnizquierda.IconColor = System.Drawing.Color.Black;
            this.btnizquierda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnizquierda.IconSize = 30;
            this.btnizquierda.Location = new System.Drawing.Point(236, 332);
            this.btnizquierda.Name = "btnizquierda";
            this.btnizquierda.Size = new System.Drawing.Size(39, 32);
            this.btnizquierda.TabIndex = 1;
            this.btnizquierda.UseVisualStyleBackColor = false;
            this.btnizquierda.Click += new System.EventHandler(this.btnizquierda_Click);
            // 
            // listpokemons
            // 
            this.listpokemons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listpokemons.ImageStream")));
            this.listpokemons.TransparentColor = System.Drawing.Color.Transparent;
            this.listpokemons.Images.SetKeyName(0, "Blastoise.png");
            this.listpokemons.Images.SetKeyName(1, "Bulbasaur.png");
            this.listpokemons.Images.SetKeyName(2, "Charizard.png");
            this.listpokemons.Images.SetKeyName(3, "Diglett.png");
            this.listpokemons.Images.SetKeyName(4, "Geodude.png");
            this.listpokemons.Images.SetKeyName(5, "Pikachu.png");
            // 
            // listestadisticas
            // 
            this.listestadisticas.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listestadisticas.ImageStream")));
            this.listestadisticas.TransparentColor = System.Drawing.Color.Transparent;
            this.listestadisticas.Images.SetKeyName(0, "e.blastoise.png");
            this.listestadisticas.Images.SetKeyName(1, "e.bulbasaur.png");
            this.listestadisticas.Images.SetKeyName(2, "e.charizard.png");
            this.listestadisticas.Images.SetKeyName(3, "e.diglett.png");
            this.listestadisticas.Images.SetKeyName(4, "e.geodude.png");
            this.listestadisticas.Images.SetKeyName(5, "e.pikachu.png");
            // 
            // pcbpokemon
            // 
            this.pcbpokemon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pcbpokemon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcbpokemon.Location = new System.Drawing.Point(298, 33);
            this.pcbpokemon.Name = "pcbpokemon";
            this.pcbpokemon.Size = new System.Drawing.Size(157, 95);
            this.pcbpokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbpokemon.TabIndex = 2;
            this.pcbpokemon.TabStop = false;
            // 
            // pcbestadistica
            // 
            this.pcbestadistica.Image = ((System.Drawing.Image)(resources.GetObject("pcbestadistica.Image")));
            this.pcbestadistica.Location = new System.Drawing.Point(293, 180);
            this.pcbestadistica.Name = "pcbestadistica";
            this.pcbestadistica.Size = new System.Drawing.Size(163, 148);
            this.pcbestadistica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbestadistica.TabIndex = 3;
            this.pcbestadistica.TabStop = false;
            // 
            // tipo
            // 
            this.tipo.AutoSize = true;
            this.tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.tipo.Location = new System.Drawing.Point(312, 131);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(46, 18);
            this.tipo.TabIndex = 4;
            this.tipo.Text = "Tipo:";
            // 
            // btnjugador1
            // 
            this.btnjugador1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnjugador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnjugador1.Location = new System.Drawing.Point(281, 332);
            this.btnjugador1.Name = "btnjugador1";
            this.btnjugador1.Size = new System.Drawing.Size(87, 28);
            this.btnjugador1.TabIndex = 5;
            this.btnjugador1.Text = "Jugador 1";
            this.btnjugador1.UseVisualStyleBackColor = false;
            this.btnjugador1.Click += new System.EventHandler(this.btnjugador1_Click);
            // 
            // lbltipos
            // 
            this.lbltipos.AutoSize = true;
            this.lbltipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbltipos.Location = new System.Drawing.Point(379, 131);
            this.lbltipos.Name = "lbltipos";
            this.lbltipos.Size = new System.Drawing.Size(52, 18);
            this.lbltipos.TabIndex = 7;
            this.lbltipos.Text = "label1";
            // 
            // lblnombres
            // 
            this.lblnombres.AutoSize = true;
            this.lblnombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblnombres.Location = new System.Drawing.Point(344, 9);
            this.lblnombres.Name = "lblnombres";
            this.lblnombres.Size = new System.Drawing.Size(52, 18);
            this.lblnombres.TabIndex = 8;
            this.lblnombres.Text = "label1";
            // 
            // lblvida
            // 
            this.lblvida.AutoSize = true;
            this.lblvida.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblvida.Location = new System.Drawing.Point(298, 160);
            this.lblvida.Name = "lblvida";
            this.lblvida.Size = new System.Drawing.Size(42, 20);
            this.lblvida.TabIndex = 9;
            this.lblvida.Text = "Vida:";
            // 
            // ataque
            // 
            this.ataque.AutoSize = true;
            this.ataque.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.ataque.Location = new System.Drawing.Point(298, 203);
            this.ataque.Name = "ataque";
            this.ataque.Size = new System.Drawing.Size(60, 20);
            this.ataque.TabIndex = 10;
            this.ataque.Text = "Ataque:";
            // 
            // defensa
            // 
            this.defensa.AutoSize = true;
            this.defensa.BackColor = System.Drawing.Color.Transparent;
            this.defensa.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.defensa.Location = new System.Drawing.Point(298, 243);
            this.defensa.Name = "defensa";
            this.defensa.Size = new System.Drawing.Size(66, 20);
            this.defensa.TabIndex = 11;
            this.defensa.Text = "Defensa:";
            // 
            // velocidad
            // 
            this.velocidad.AutoSize = true;
            this.velocidad.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.velocidad.Location = new System.Drawing.Point(297, 284);
            this.velocidad.Name = "velocidad";
            this.velocidad.Size = new System.Drawing.Size(78, 20);
            this.velocidad.TabIndex = 12;
            this.velocidad.Text = "Velocidad:";
            // 
            // lblvidas
            // 
            this.lblvidas.AutoSize = true;
            this.lblvidas.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvidas.Location = new System.Drawing.Point(344, 160);
            this.lblvidas.Name = "lblvidas";
            this.lblvidas.Size = new System.Drawing.Size(36, 20);
            this.lblvidas.TabIndex = 13;
            this.lblvidas.Text = "100";
            // 
            // lblataques
            // 
            this.lblataques.AutoSize = true;
            this.lblataques.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblataques.Location = new System.Drawing.Point(360, 203);
            this.lblataques.Name = "lblataques";
            this.lblataques.Size = new System.Drawing.Size(36, 20);
            this.lblataques.TabIndex = 14;
            this.lblataques.Text = "100";
            // 
            // lbldefensa
            // 
            this.lbldefensa.BackColor = System.Drawing.Color.Transparent;
            this.lbldefensa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldefensa.Location = new System.Drawing.Point(360, 243);
            this.lbldefensa.Name = "lbldefensa";
            this.lbldefensa.Size = new System.Drawing.Size(56, 20);
            this.lbldefensa.TabIndex = 15;
            this.lbldefensa.Text = "100";
            // 
            // lblvelocidad
            // 
            this.lblvelocidad.AutoSize = true;
            this.lblvelocidad.BackColor = System.Drawing.SystemColors.Control;
            this.lblvelocidad.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvelocidad.Location = new System.Drawing.Point(380, 284);
            this.lblvelocidad.Name = "lblvelocidad";
            this.lblvelocidad.Size = new System.Drawing.Size(36, 20);
            this.lblvelocidad.TabIndex = 16;
            this.lblvelocidad.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 17;
            // 
            // lbljugador1
            // 
            this.lbljugador1.AutoSize = true;
            this.lbljugador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbljugador1.Location = new System.Drawing.Point(77, 33);
            this.lbljugador1.Name = "lbljugador1";
            this.lbljugador1.Size = new System.Drawing.Size(83, 18);
            this.lbljugador1.TabIndex = 18;
            this.lbljugador1.Text = "Jugador 1";
            // 
            // lbljugador2
            // 
            this.lbljugador2.AutoSize = true;
            this.lbljugador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbljugador2.Location = new System.Drawing.Point(594, 33);
            this.lbljugador2.Name = "lbljugador2";
            this.lbljugador2.Size = new System.Drawing.Size(83, 18);
            this.lbljugador2.TabIndex = 19;
            this.lbljugador2.Text = "Jugador 2";
            // 
            // njugador1
            // 
            this.njugador1.AutoSize = true;
            this.njugador1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.njugador1.Location = new System.Drawing.Point(17, 67);
            this.njugador1.Name = "njugador1";
            this.njugador1.Size = new System.Drawing.Size(67, 20);
            this.njugador1.TabIndex = 20;
            this.njugador1.Text = "Nombre:";
            // 
            // njugador2
            // 
            this.njugador2.AutoSize = true;
            this.njugador2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.njugador2.Location = new System.Drawing.Point(522, 68);
            this.njugador2.Name = "njugador2";
            this.njugador2.Size = new System.Drawing.Size(67, 20);
            this.njugador2.TabIndex = 21;
            this.njugador2.Text = "Nombre:";
            // 
            // lblequipo
            // 
            this.lblequipo.AutoSize = true;
            this.lblequipo.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblequipo.Location = new System.Drawing.Point(94, 140);
            this.lblequipo.Name = "lblequipo";
            this.lblequipo.Size = new System.Drawing.Size(59, 20);
            this.lblequipo.TabIndex = 26;
            this.lblequipo.Text = "Equipo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label2.Location = new System.Drawing.Point(608, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Equipo:";
            // 
            // btneliminar1
            // 
            this.btneliminar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btneliminar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btneliminar1.Location = new System.Drawing.Point(82, 311);
            this.btneliminar1.Name = "btneliminar1";
            this.btneliminar1.Size = new System.Drawing.Size(78, 27);
            this.btneliminar1.TabIndex = 28;
            this.btneliminar1.Text = "Eliminar";
            this.btneliminar1.UseVisualStyleBackColor = false;
            this.btneliminar1.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btneliminar2
            // 
            this.btneliminar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btneliminar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btneliminar2.Location = new System.Drawing.Point(604, 311);
            this.btneliminar2.Name = "btneliminar2";
            this.btneliminar2.Size = new System.Drawing.Size(83, 27);
            this.btneliminar2.TabIndex = 29;
            this.btneliminar2.Text = "Eliminar";
            this.btneliminar2.UseVisualStyleBackColor = false;
            this.btneliminar2.Click += new System.EventHandler(this.btneliminar2_Click);
            // 
            // txtnombre1
            // 
            this.txtnombre1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtnombre1.Location = new System.Drawing.Point(80, 68);
            this.txtnombre1.Name = "txtnombre1";
            this.txtnombre1.Size = new System.Drawing.Size(133, 25);
            this.txtnombre1.TabIndex = 30;
            // 
            // txtnombre2
            // 
            this.txtnombre2.Location = new System.Drawing.Point(585, 69);
            this.txtnombre2.Name = "txtnombre2";
            this.txtnombre2.Size = new System.Drawing.Size(130, 20);
            this.txtnombre2.TabIndex = 31;
            // 
            // btnjugador2
            // 
            this.btnjugador2.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnjugador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnjugador2.Location = new System.Drawing.Point(374, 332);
            this.btnjugador2.Name = "btnjugador2";
            this.btnjugador2.Size = new System.Drawing.Size(89, 28);
            this.btnjugador2.TabIndex = 32;
            this.btnjugador2.Text = "Jugador 2";
            this.btnjugador2.UseVisualStyleBackColor = false;
            this.btnjugador2.Click += new System.EventHandler(this.btnjugador2_Click);
            // 
            // btnbatalla
            // 
            this.btnbatalla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnbatalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnbatalla.Location = new System.Drawing.Point(311, 378);
            this.btnbatalla.Name = "btnbatalla";
            this.btnbatalla.Size = new System.Drawing.Size(130, 29);
            this.btnbatalla.TabIndex = 33;
            this.btnbatalla.Text = "INICIAR BATALLA";
            this.btnbatalla.UseVisualStyleBackColor = false;
            this.btnbatalla.Click += new System.EventHandler(this.btnbatalla_Click);
            // 
            // Equipo2
            // 
            this.Equipo2.BackColor = System.Drawing.SystemColors.Control;
            this.Equipo2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equipo2.FormattingEnabled = true;
            this.Equipo2.ItemHeight = 20;
            this.Equipo2.Location = new System.Drawing.Point(576, 172);
            this.Equipo2.Name = "Equipo2";
            this.Equipo2.Size = new System.Drawing.Size(139, 124);
            this.Equipo2.TabIndex = 34;
            // 
            // Equipo1
            // 
            this.Equipo1.BackColor = System.Drawing.SystemColors.Control;
            this.Equipo1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equipo1.FormattingEnabled = true;
            this.Equipo1.ItemHeight = 20;
            this.Equipo1.Location = new System.Drawing.Point(59, 172);
            this.Equipo1.Name = "Equipo1";
            this.Equipo1.Size = new System.Drawing.Size(139, 124);
            this.Equipo1.TabIndex = 34;
            // 
            // EleccionPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(771, 419);
            this.Controls.Add(this.Equipo1);
            this.Controls.Add(this.Equipo2);
            this.Controls.Add(this.btnbatalla);
            this.Controls.Add(this.btnjugador2);
            this.Controls.Add(this.txtnombre2);
            this.Controls.Add(this.txtnombre1);
            this.Controls.Add(this.btneliminar2);
            this.Controls.Add(this.btneliminar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblequipo);
            this.Controls.Add(this.njugador2);
            this.Controls.Add(this.njugador1);
            this.Controls.Add(this.lbljugador2);
            this.Controls.Add(this.lbljugador1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblvelocidad);
            this.Controls.Add(this.lbldefensa);
            this.Controls.Add(this.lblataques);
            this.Controls.Add(this.lblvidas);
            this.Controls.Add(this.velocidad);
            this.Controls.Add(this.defensa);
            this.Controls.Add(this.ataque);
            this.Controls.Add(this.lblvida);
            this.Controls.Add(this.lblnombres);
            this.Controls.Add(this.lbltipos);
            this.Controls.Add(this.btnjugador1);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.pcbestadistica);
            this.Controls.Add(this.pcbpokemon);
            this.Controls.Add(this.btnizquierda);
            this.Controls.Add(this.btnderecha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EleccionPokemon";
            this.Text = "Eleccion Pokemon";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbpokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbestadistica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnderecha;
        private FontAwesome.Sharp.IconButton btnizquierda;
        private System.Windows.Forms.ImageList listpokemons;
        private System.Windows.Forms.ImageList listestadisticas;
        private System.Windows.Forms.PictureBox pcbpokemon;
        private System.Windows.Forms.PictureBox pcbestadistica;
        private System.Windows.Forms.Label tipo;
        private System.Windows.Forms.Button btnjugador1;
        private System.Windows.Forms.Label lbltipos;
        private System.Windows.Forms.Label lblnombres;
        private System.Windows.Forms.Label lblvida;
        private System.Windows.Forms.Label ataque;
        private System.Windows.Forms.Label defensa;
        private System.Windows.Forms.Label velocidad;
        private System.Windows.Forms.Label lblvidas;
        private System.Windows.Forms.Label lblataques;
        private System.Windows.Forms.Label lbldefensa;
        private System.Windows.Forms.Label lblvelocidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbljugador1;
        private System.Windows.Forms.Label lbljugador2;
        private System.Windows.Forms.Label njugador1;
        private System.Windows.Forms.Label njugador2;
        private System.Windows.Forms.Label lblequipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btneliminar1;
        private System.Windows.Forms.Button btneliminar2;
        private System.Windows.Forms.TextBox txtnombre1;
        private System.Windows.Forms.TextBox txtnombre2;
        private System.Windows.Forms.Button btnjugador2;
        private System.Windows.Forms.Button btnbatalla;
        private ListBox Equipo2;
        private ListBox Equipo1;
    }
}