namespace ProyectoPrograI
{
    partial class Pokedex
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Estadisticas = new System.Windows.Forms.Label();
            this.NombreLbl = new System.Windows.Forms.Label();
            this.EstadisticasLbl = new System.Windows.Forms.Label();
            this.TipoLbl = new System.Windows.Forms.Label();
            this.LeftBt = new FontAwesome.Sharp.IconButton();
            this.RigthBt = new FontAwesome.Sharp.IconButton();
            this.Imagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // Estadisticas
            // 
            this.Estadisticas.AutoSize = true;
            this.Estadisticas.Location = new System.Drawing.Point(142, 255);
            this.Estadisticas.Name = "Estadisticas";
            this.Estadisticas.Size = new System.Drawing.Size(29, 13);
            this.Estadisticas.TabIndex = 0;
            this.Estadisticas.Text = "label";
            this.Estadisticas.Click += new System.EventHandler(this.text_Click);
            // 
            // NombreLbl
            // 
            this.NombreLbl.AutoSize = true;
            this.NombreLbl.Location = new System.Drawing.Point(131, 210);
            this.NombreLbl.Name = "NombreLbl";
            this.NombreLbl.Size = new System.Drawing.Size(50, 13);
            this.NombreLbl.TabIndex = 2;
            this.NombreLbl.Text = "Nombre: ";
            // 
            // EstadisticasLbl
            // 
            this.EstadisticasLbl.AutoSize = true;
            this.EstadisticasLbl.Location = new System.Drawing.Point(142, 242);
            this.EstadisticasLbl.Name = "EstadisticasLbl";
            this.EstadisticasLbl.Size = new System.Drawing.Size(63, 13);
            this.EstadisticasLbl.TabIndex = 2;
            this.EstadisticasLbl.Text = "Estadisticas";
            // 
            // TipoLbl
            // 
            this.TipoLbl.AutoSize = true;
            this.TipoLbl.Location = new System.Drawing.Point(131, 348);
            this.TipoLbl.Name = "TipoLbl";
            this.TipoLbl.Size = new System.Drawing.Size(31, 13);
            this.TipoLbl.TabIndex = 4;
            this.TipoLbl.Text = "Tipo:";
            // 
            // LeftBt
            // 
            this.LeftBt.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            this.LeftBt.IconColor = System.Drawing.Color.Black;
            this.LeftBt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LeftBt.Location = new System.Drawing.Point(12, 375);
            this.LeftBt.Name = "LeftBt";
            this.LeftBt.Size = new System.Drawing.Size(73, 51);
            this.LeftBt.TabIndex = 3;
            this.LeftBt.UseVisualStyleBackColor = true;
            this.LeftBt.Click += new System.EventHandler(this.LeftBt_Click);
            // 
            // RigthBt
            // 
            this.RigthBt.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight;
            this.RigthBt.IconColor = System.Drawing.Color.Black;
            this.RigthBt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RigthBt.Location = new System.Drawing.Point(298, 375);
            this.RigthBt.Name = "RigthBt";
            this.RigthBt.Size = new System.Drawing.Size(73, 51);
            this.RigthBt.TabIndex = 3;
            this.RigthBt.UseVisualStyleBackColor = true;
            this.RigthBt.Click += new System.EventHandler(this.RigthBt_Click);
            // 
            // Imagen
            // 
            this.Imagen.Location = new System.Drawing.Point(78, 48);
            this.Imagen.Name = "Imagen";
            this.Imagen.Size = new System.Drawing.Size(204, 148);
            this.Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Imagen.TabIndex = 1;
            this.Imagen.TabStop = false;
            // 
            // Pokedex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 450);
            this.Controls.Add(this.TipoLbl);
            this.Controls.Add(this.LeftBt);
            this.Controls.Add(this.RigthBt);
            this.Controls.Add(this.EstadisticasLbl);
            this.Controls.Add(this.NombreLbl);
            this.Controls.Add(this.Imagen);
            this.Controls.Add(this.Estadisticas);
            this.Name = "Pokedex";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Estadisticas;
        private System.Windows.Forms.PictureBox Imagen;
        private System.Windows.Forms.Label NombreLbl;
        private System.Windows.Forms.Label EstadisticasLbl;
        private FontAwesome.Sharp.IconButton RigthBt;
        private FontAwesome.Sharp.IconButton LeftBt;
        private System.Windows.Forms.Label TipoLbl;
    }
}

