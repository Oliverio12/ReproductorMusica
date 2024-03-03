namespace Reproductor
{
    partial class Editar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar));
            this.button1 = new System.Windows.Forms.Button();
            this.iconos = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.lblTituloC = new System.Windows.Forms.Label();
            this.txbTitulo = new System.Windows.Forms.TextBox();
            this.lblArtis = new System.Windows.Forms.Label();
            this.txbArtis = new System.Windows.Forms.TextBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.txbGenero = new System.Windows.Forms.TextBox();
            this.iconos2 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageKey = "Cancelar.png";
            this.button1.ImageList = this.iconos;
            this.button1.Location = new System.Drawing.Point(271, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSalir);
            // 
            // iconos
            // 
            this.iconos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconos.ImageStream")));
            this.iconos.TransparentColor = System.Drawing.Color.Transparent;
            this.iconos.Images.SetKeyName(0, "Guardar.png");
            this.iconos.Images.SetKeyName(1, "Cancelar.png");
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageKey = "Guardar.png";
            this.button2.ImageList = this.iconos;
            this.button2.Location = new System.Drawing.Point(111, 363);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 58);
            this.button2.TabIndex = 1;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnGuardar);
            // 
            // lblTituloC
            // 
            this.lblTituloC.AutoSize = true;
            this.lblTituloC.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloC.Location = new System.Drawing.Point(106, 53);
            this.lblTituloC.Name = "lblTituloC";
            this.lblTituloC.Size = new System.Drawing.Size(230, 28);
            this.lblTituloC.TabIndex = 2;
            this.lblTituloC.Text = "Titulo de la Canción";
            // 
            // txbTitulo
            // 
            this.txbTitulo.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTitulo.Location = new System.Drawing.Point(111, 97);
            this.txbTitulo.Name = "txbTitulo";
            this.txbTitulo.Size = new System.Drawing.Size(300, 34);
            this.txbTitulo.TabIndex = 3;
            // 
            // lblArtis
            // 
            this.lblArtis.AutoSize = true;
            this.lblArtis.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtis.Location = new System.Drawing.Point(106, 149);
            this.lblArtis.Name = "lblArtis";
            this.lblArtis.Size = new System.Drawing.Size(88, 28);
            this.lblArtis.TabIndex = 4;
            this.lblArtis.Text = "Artista";
            // 
            // txbArtis
            // 
            this.txbArtis.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbArtis.Location = new System.Drawing.Point(109, 189);
            this.txbArtis.Name = "txbArtis";
            this.txbArtis.Size = new System.Drawing.Size(300, 34);
            this.txbArtis.TabIndex = 5;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(106, 235);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(90, 28);
            this.lblGenero.TabIndex = 6;
            this.lblGenero.Text = "Genero";
            // 
            // txbGenero
            // 
            this.txbGenero.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbGenero.Location = new System.Drawing.Point(109, 266);
            this.txbGenero.Name = "txbGenero";
            this.txbGenero.Size = new System.Drawing.Size(300, 34);
            this.txbGenero.TabIndex = 7;
            // 
            // iconos2
            // 
            this.iconos2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconos2.ImageStream")));
            this.iconos2.TransparentColor = System.Drawing.Color.Transparent;
            this.iconos2.Images.SetKeyName(0, "multimedia.png");
            // 
            // Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(504, 493);
            this.ControlBox = false;
            this.Controls.Add(this.txbGenero);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.txbArtis);
            this.Controls.Add(this.lblArtis);
            this.Controls.Add(this.txbTitulo);
            this.Controls.Add(this.lblTituloC);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Editar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar";
            this.Load += new System.EventHandler(this.Editar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList iconos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblTituloC;
        public System.Windows.Forms.TextBox txbTitulo;
        private System.Windows.Forms.Label lblArtis;
        public System.Windows.Forms.TextBox txbArtis;
        private System.Windows.Forms.Label lblGenero;
        public System.Windows.Forms.TextBox txbGenero;
        private System.Windows.Forms.ImageList iconos2;
    }
}