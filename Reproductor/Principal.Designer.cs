namespace Reproductor
{
    partial class Principal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.Iconos = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAbrir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnReproducir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDetener = new System.Windows.Forms.ToolStripButton();
            this.txb = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPausa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dtgCanciones = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCanciones = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.CTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CArchivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CArtista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDuracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTamaño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CVelocidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRuta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCanciones)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Iconos
            // 
            this.Iconos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Iconos.ImageStream")));
            this.Iconos.TransparentColor = System.Drawing.Color.Transparent;
            this.Iconos.Images.SetKeyName(0, "Abrir.png");
            this.Iconos.Images.SetKeyName(1, "detener.png");
            this.Iconos.Images.SetKeyName(2, "Play.png");
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAbrir,
            this.toolStripSeparator1,
            this.btnReproducir,
            this.toolStripSeparator2,
            this.btnDetener,
            this.txb,
            this.toolStripButton4,
            this.toolStripSeparator3,
            this.btnPausa,
            this.toolStripSeparator5,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1280, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAbrir
            // 
            this.btnAbrir.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrir.Image")));
            this.btnAbrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(122, 24);
            this.btnAbrir.Text = "Abrir Carpeta";
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btnReproducir
            // 
            this.btnReproducir.Image = ((System.Drawing.Image)(resources.GetObject("btnReproducir.Image")));
            this.btnReproducir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReproducir.Name = "btnReproducir";
            this.btnReproducir.Size = new System.Drawing.Size(60, 24);
            this.btnReproducir.Text = "Play";
            this.btnReproducir.Click += new System.EventHandler(this.btnReproducir_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btnDetener
            // 
            this.btnDetener.Image = ((System.Drawing.Image)(resources.GetObject("btnDetener.Image")));
            this.btnDetener.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(64, 24);
            this.btnDetener.Text = "Stop";
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // txb
            // 
            this.txb.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb.Name = "txb";
            this.txb.Size = new System.Drawing.Size(200, 27);
            this.txb.TextChanged += new System.EventHandler(this.txb_TextChanged);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton4.Text = "Buscar";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // btnPausa
            // 
            this.btnPausa.Image = ((System.Drawing.Image)(resources.GetObject("btnPausa.Image")));
            this.btnPausa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPausa.Name = "btnPausa";
            this.btnPausa.Size = new System.Drawing.Size(70, 24);
            this.btnPausa.Text = "Pausa";
            this.btnPausa.Click += new System.EventHandler(this.btnPausa_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(129, 24);
            this.toolStripButton1.Text = "Editar Cancion";
            this.toolStripButton1.Click += new System.EventHandler(this.btnEditarCancion);
            // 
            // dtgCanciones
            // 
            this.dtgCanciones.AllowUserToAddRows = false;
            this.dtgCanciones.AllowUserToDeleteRows = false;
            this.dtgCanciones.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgCanciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgCanciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCanciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CTitulo,
            this.CArchivo,
            this.CArtista,
            this.CDuracion,
            this.CTamaño,
            this.CGenero,
            this.CVelocidad,
            this.CRuta});
            this.dtgCanciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgCanciones.GridColor = System.Drawing.Color.LightGray;
            this.dtgCanciones.Location = new System.Drawing.Point(0, 27);
            this.dtgCanciones.Name = "dtgCanciones";
            this.dtgCanciones.ReadOnly = true;
            this.dtgCanciones.RowHeadersWidth = 51;
            this.dtgCanciones.RowTemplate.Height = 24;
            this.dtgCanciones.Size = new System.Drawing.Size(1280, 499);
            this.dtgCanciones.TabIndex = 3;
            this.dtgCanciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblCanciones,
            this.toolStripSeparator4,
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 500);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1280, 26);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(76, 20);
            this.toolStripStatusLabel1.Text = "Canciones";
            // 
            // lblCanciones
            // 
            this.lblCanciones.Name = "lblCanciones";
            this.lblCanciones.Size = new System.Drawing.Size(17, 20);
            this.lblCanciones.Text = "0";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 26);
            // 
            // lblStatus
            // 
            this.lblStatus.Image = ((System.Drawing.Image)(resources.GetObject("lblStatus.Image")));
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStatus.Size = new System.Drawing.Size(64, 20);
            this.lblStatus.Text = "00:00";
            // 
            // CTitulo
            // 
            this.CTitulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CTitulo.DataPropertyName = "CTitulo";
            this.CTitulo.FillWeight = 620.3209F;
            this.CTitulo.HeaderText = "Titulo";
            this.CTitulo.MinimumWidth = 200;
            this.CTitulo.Name = "CTitulo";
            this.CTitulo.ReadOnly = true;
            // 
            // CArchivo
            // 
            this.CArchivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CArchivo.DataPropertyName = "CArchivo";
            this.CArchivo.FillWeight = 3.655539F;
            this.CArchivo.HeaderText = "Archivo";
            this.CArchivo.MinimumWidth = 200;
            this.CArchivo.Name = "CArchivo";
            this.CArchivo.ReadOnly = true;
            // 
            // CArtista
            // 
            this.CArtista.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CArtista.DataPropertyName = "CArtista";
            this.CArtista.FillWeight = 47.68137F;
            this.CArtista.HeaderText = "Artista";
            this.CArtista.MinimumWidth = 80;
            this.CArtista.Name = "CArtista";
            this.CArtista.ReadOnly = true;
            // 
            // CDuracion
            // 
            this.CDuracion.DataPropertyName = "CDuracion";
            this.CDuracion.FillWeight = 25.66844F;
            this.CDuracion.HeaderText = "Duracion";
            this.CDuracion.MinimumWidth = 100;
            this.CDuracion.Name = "CDuracion";
            this.CDuracion.ReadOnly = true;
            this.CDuracion.Width = 125;
            // 
            // CTamaño
            // 
            this.CTamaño.DataPropertyName = "CTamano";
            this.CTamaño.FillWeight = 25.66844F;
            this.CTamaño.HeaderText = "Tamaño";
            this.CTamaño.MinimumWidth = 100;
            this.CTamaño.Name = "CTamaño";
            this.CTamaño.ReadOnly = true;
            this.CTamaño.Width = 125;
            // 
            // CGenero
            // 
            this.CGenero.DataPropertyName = "CGenero";
            this.CGenero.FillWeight = 25.66844F;
            this.CGenero.HeaderText = "Genero";
            this.CGenero.MinimumWidth = 100;
            this.CGenero.Name = "CGenero";
            this.CGenero.ReadOnly = true;
            this.CGenero.Width = 125;
            // 
            // CVelocidad
            // 
            this.CVelocidad.DataPropertyName = "CVelocidad";
            this.CVelocidad.FillWeight = 25.66844F;
            this.CVelocidad.HeaderText = "Velocidad";
            this.CVelocidad.MinimumWidth = 100;
            this.CVelocidad.Name = "CVelocidad";
            this.CVelocidad.ReadOnly = true;
            this.CVelocidad.Width = 125;
            // 
            // CRuta
            // 
            this.CRuta.DataPropertyName = "CRuta";
            this.CRuta.FillWeight = 25.66844F;
            this.CRuta.HeaderText = "Ruta";
            this.CRuta.MinimumWidth = 350;
            this.CRuta.Name = "CRuta";
            this.CRuta.ReadOnly = true;
            this.CRuta.Width = 350;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1280, 526);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dtgCanciones);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Principal";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reproductor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCanciones)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList Iconos;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAbrir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnReproducir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnDetener;
        private System.Windows.Forms.ToolStripTextBox txb;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblCanciones;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        public System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnPausa;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CArchivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CArtista;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDuracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTamaño;
        private System.Windows.Forms.DataGridViewTextBoxColumn CGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn CVelocidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRuta;
        public System.Windows.Forms.DataGridView dtgCanciones;
    }
}

