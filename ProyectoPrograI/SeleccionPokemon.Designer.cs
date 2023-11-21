namespace ProyectoPrograI
{
    partial class SeleccionPokemon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Poke2Bt = new System.Windows.Forms.Button();
            this.Poke1Bt = new System.Windows.Forms.Button();
            this.Poke3Bt = new System.Windows.Forms.Button();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.CancelarBt = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // Poke2Bt
            // 
            this.Poke2Bt.BackgroundImage = global::ProyectoPrograI.Properties.Resources.Bulbasaur;
            this.Poke2Bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Poke2Bt.Enabled = false;
            this.Poke2Bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Poke2Bt.ForeColor = System.Drawing.Color.Red;
            this.Poke2Bt.Location = new System.Drawing.Point(132, 159);
            this.Poke2Bt.Name = "Poke2Bt";
            this.Poke2Bt.Size = new System.Drawing.Size(209, 101);
            this.Poke2Bt.TabIndex = 0;
            this.Poke2Bt.Text = "Bulbasaur";
            this.Poke2Bt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Poke2Bt.UseVisualStyleBackColor = true;
            this.Poke2Bt.Click += new System.EventHandler(this.Poke2Bt_Click);
            // 
            // Poke1Bt
            // 
            this.Poke1Bt.BackgroundImage = global::ProyectoPrograI.Properties.Resources.Blastoise;
            this.Poke1Bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Poke1Bt.Enabled = false;
            this.Poke1Bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Poke1Bt.ForeColor = System.Drawing.Color.Red;
            this.Poke1Bt.Location = new System.Drawing.Point(12, 38);
            this.Poke1Bt.Name = "Poke1Bt";
            this.Poke1Bt.Size = new System.Drawing.Size(209, 101);
            this.Poke1Bt.TabIndex = 0;
            this.Poke1Bt.Text = "Blastoise";
            this.Poke1Bt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Poke1Bt.UseVisualStyleBackColor = true;
            this.Poke1Bt.Click += new System.EventHandler(this.Poke1Bt_Click);
            // 
            // Poke3Bt
            // 
            this.Poke3Bt.BackgroundImage = global::ProyectoPrograI.Properties.Resources.Blastoise;
            this.Poke3Bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Poke3Bt.Enabled = false;
            this.Poke3Bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Poke3Bt.ForeColor = System.Drawing.Color.Red;
            this.Poke3Bt.Location = new System.Drawing.Point(256, 38);
            this.Poke3Bt.Name = "Poke3Bt";
            this.Poke3Bt.Size = new System.Drawing.Size(209, 101);
            this.Poke3Bt.TabIndex = 0;
            this.Poke3Bt.Text = "Blastoise";
            this.Poke3Bt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Poke3Bt.UseVisualStyleBackColor = true;
            this.Poke3Bt.Click += new System.EventHandler(this.Poke3Bt_Click);
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.Location = new System.Drawing.Point(149, 9);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(173, 20);
            this.TitleLbl.TabIndex = 1;
            this.TitleLbl.Text = "Escoge un Pokemon";
            // 
            // CancelarBt
            // 
            this.CancelarBt.BackColor = System.Drawing.Color.Brown;
            this.CancelarBt.FlatAppearance.BorderSize = 0;
            this.CancelarBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelarBt.ForeColor = System.Drawing.Color.White;
            this.CancelarBt.Location = new System.Drawing.Point(414, 231);
            this.CancelarBt.Name = "CancelarBt";
            this.CancelarBt.Size = new System.Drawing.Size(58, 29);
            this.CancelarBt.TabIndex = 2;
            this.CancelarBt.Text = "Cancelar";
            this.CancelarBt.UseVisualStyleBackColor = false;
            this.CancelarBt.Click += new System.EventHandler(this.CancelarBt_Click);
            // 
            // SeleccionPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 272);
            this.Controls.Add(this.CancelarBt);
            this.Controls.Add(this.TitleLbl);
            this.Controls.Add(this.Poke3Bt);
            this.Controls.Add(this.Poke2Bt);
            this.Controls.Add(this.Poke1Bt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SeleccionPokemon";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SeleccionarPokemon";
            this.Load += new System.EventHandler(this.SeleccionarPokemon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Poke1Bt;
        private System.Windows.Forms.Button Poke2Bt;
        private System.Windows.Forms.Button Poke3Bt;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Button CancelarBt;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}