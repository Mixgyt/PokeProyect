namespace ProyectoPrograI
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.FondoboxInicial = new System.Windows.Forms.PictureBox();
            this.ButtonIniciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FondoboxInicial)).BeginInit();
            this.SuspendLayout();
            // 
            // FondoboxInicial
            // 
            this.FondoboxInicial.BackColor = System.Drawing.Color.Yellow;
            this.FondoboxInicial.Image = ((System.Drawing.Image)(resources.GetObject("FondoboxInicial.Image")));
            this.FondoboxInicial.Location = new System.Drawing.Point(-1, -1);
            this.FondoboxInicial.Name = "FondoboxInicial";
            this.FondoboxInicial.Size = new System.Drawing.Size(797, 492);
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
            this.ButtonIniciar.Location = new System.Drawing.Point(12, 447);
            this.ButtonIniciar.Name = "ButtonIniciar";
            this.ButtonIniciar.Size = new System.Drawing.Size(89, 29);
            this.ButtonIniciar.TabIndex = 1;
            this.ButtonIniciar.Text = "Iniciar";
            this.ButtonIniciar.UseVisualStyleBackColor = false;
            this.ButtonIniciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(703, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Creditos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(794, 488);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonIniciar);
            this.Controls.Add(this.FondoboxInicial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pokemon";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FondoboxInicial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox FondoboxInicial;
        private System.Windows.Forms.Button ButtonIniciar;
        private System.Windows.Forms.Label label1;
    }
}

