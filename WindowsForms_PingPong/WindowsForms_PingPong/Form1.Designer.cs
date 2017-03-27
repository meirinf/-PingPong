namespace WindowsForms_PingPong
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
            this.Apellidos = new System.Windows.Forms.TextBox();
            this.ImagenJugador = new System.Windows.Forms.PictureBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenJugador)).BeginInit();
            this.SuspendLayout();
            // 
            // Apellidos
            // 
            this.Apellidos.Location = new System.Drawing.Point(124, 12);
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.Size = new System.Drawing.Size(148, 20);
            this.Apellidos.TabIndex = 3;
            this.Apellidos.TextChanged += new System.EventHandler(this.Apellidos_TextChanged_1);
            // 
            // ImagenJugador
            // 
            this.ImagenJugador.Location = new System.Drawing.Point(6, 12);
            this.ImagenJugador.Name = "ImagenJugador";
            this.ImagenJugador.Size = new System.Drawing.Size(100, 50);
            this.ImagenJugador.TabIndex = 4;
            this.ImagenJugador.TabStop = false;
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(124, 42);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(148, 20);
            this.Nombre.TabIndex = 5;
            this.Nombre.TextChanged += new System.EventHandler(this.Nombre_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.ImagenJugador);
            this.Controls.Add(this.Apellidos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImagenJugador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.PictureBox ImagenJugador;
        private System.Windows.Forms.TextBox Apellidos;
    }
}

