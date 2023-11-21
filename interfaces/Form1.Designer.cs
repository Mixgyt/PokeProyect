namespace interfaz
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FondoboxInicial = new System.Windows.Forms.PictureBox();
            this.ButtonIniciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FondoboxInicial)).BeginInit();
            this.SuspendLayout();
            // 
            // FondoboxInicial
            // 
            this.FondoboxInicial.BackColor = System.Drawing.Color.Yellow;
            this.FondoboxInicial.Image = ((System.Drawing.Image)(resources.GetObject("FondoboxInicial.Image")));
            this.FondoboxInicial.Location = new System.Drawing.Point(-1, -1);
            this.FondoboxInicial.Name = "FondoboxInicial";
            this.FondoboxInicial.Size = new System.Drawing.Size(728, 460);
            this.FondoboxInicial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FondoboxInicial.TabIndex = 0;
            this.FondoboxInicial.TabStop = false;
            // 
            // ButtonIniciar
            // 
            this.ButtonIniciar.BackColor = System.Drawing.Color.Blue;
            this.ButtonIniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ButtonIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.ButtonIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonIniciar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonIniciar.Location = new System.Drawing.Point(31, 409);
            this.ButtonIniciar.Name = "ButtonIniciar";
            this.ButtonIniciar.Size = new System.Drawing.Size(89, 29);
            this.ButtonIniciar.TabIndex = 1;
            this.ButtonIniciar.Text = "Iniciar";
            this.ButtonIniciar.UseVisualStyleBackColor = false;
            this.ButtonIniciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 459);
            this.Controls.Add(this.ButtonIniciar);
            this.Controls.Add(this.FondoboxInicial);
            this.Name = "Form1";
            this.Text = "pokemon";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FondoboxInicial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox FondoboxInicial;
        private System.Windows.Forms.Button ButtonIniciar;
    }
}

