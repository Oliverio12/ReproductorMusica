﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;


namespace Reproductor
{
    public partial class Principal : Form
    {

        DataTable _CANCIONES = new DataTable();
        WaveOutEvent outputDevice = new WaveOutEvent();
        string rutaArchivo = "Canciones.dat";
        private void IniciarTabla()
        {
            _CANCIONES.TableName = "Canciones";
            _CANCIONES.Columns.Add("CTitulo");
            _CANCIONES.Columns.Add("CRuta");
            _CANCIONES.Columns.Add("CArchivo");
            _CANCIONES.Columns.Add("CDuracion");
            _CANCIONES.Columns.Add("CTamano");
            _CANCIONES.Columns.Add("CGenero");
            _CANCIONES.Columns.Add("CVelocidad");
            _CANCIONES.Columns.Add("CArtista");
            dtgCanciones.AutoGenerateColumns = false;
            dtgCanciones.DataSource = _CANCIONES;

        }



        public Principal()
        {
            InitializeComponent();
            IniciarTabla();

            LeerCanciones();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }



        private void btnAbrir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            f.Description = "Selecciona una carpeta con MP3";
            f.ShowDialog();
            if (f.SelectedPath.Length > 0)
            {
                FileInfo finleInfo = new FileInfo(f.SelectedPath);
                System.IO.DirectoryInfo Carpeta = new DirectoryInfo(f.SelectedPath);
                foreach (FileInfo Archivo in Carpeta.GetFiles())
                {
                    if (Archivo.Extension.ToLower().Equals(".mp3"))
                    {
                        // Verificar si la canción ya existe en la DataTable
                        string nombreArchivo = Archivo.Name;
                        bool cancionExiste = false;
                        foreach (DataRow fila in _CANCIONES.Rows)
                        {
                            string nombreCancionExistente = fila["CArchivo"].ToString();
                            if (nombreCancionExistente.Equals(nombreArchivo))
                            {
                                cancionExiste = true;
                                break;
                            }
                        }

                        if (!cancionExiste)
                        {
                            TagLib.File Cancion = TagLib.File.Create(Archivo.FullName);
                            TimeSpan duracion = Cancion.Properties.Duration;

                            DataRow NuevaFila = _CANCIONES.NewRow();
                            NuevaFila["CTitulo"] = Cancion.Tag.Title;
                            NuevaFila["CRuta"] = Archivo.FullName;
                            NuevaFila["CArchivo"] = Archivo.Name;
                            NuevaFila["CDuracion"] = duracion.ToString(@"mm\:ss");
                            NuevaFila["CTamano"] = (Archivo.Length / 1024).ToString("N2");
                            NuevaFila["CVelocidad"] = Archivo.Name;
                            try
                            {
                                NuevaFila["CArtista"] = Cancion.Tag.AlbumArtists[0].ToString();
                                NuevaFila["CGenero"] = Cancion.Tag.Genres[0];

                            }
                            catch { }

                            _CANCIONES.Rows.Add(NuevaFila);
                        }
                    }
                }
                GuardarCanciones();
            }
        }



        private void btnReproducir_Click(object sender, EventArgs e)
        {
            DataGridViewCell clickedCell = dtgCanciones.CurrentCell;
            if (clickedCell != null && clickedCell.RowIndex != -1)
            {
                DataGridViewRow clickedRow = dtgCanciones.Rows[clickedCell.RowIndex];
                string rutaCancion = clickedRow.Cells["CRuta"].Value.ToString();
                if (File.Exists(rutaCancion))
                {
                    if (outputDevice.PlaybackState == PlaybackState.Playing)
                        outputDevice.Stop();
                    using (var audioFile = new AudioFileReader(rutaCancion))
                    {
                        outputDevice.Init(audioFile);
                        outputDevice.Play();
                    }
                }
            }
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            outputDevice.Stop();
        }


        // Método para guardar las canciones en un archivo binario
        private void GuardarCanciones()
        {
            try
            {
                using (FileStream fs = new FileStream(rutaArchivo, FileMode.Create))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, _CANCIONES);
                    lblCanciones.Text = dtgCanciones.Rows.Count.ToString();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al guardar las canciones.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para leer las canciones desde el archivo binario
        private void LeerCanciones()
        {
            if (File.Exists(rutaArchivo))
            {
                try
                {
                    using (FileStream fs = new FileStream(rutaArchivo, FileMode.Open))
                    {
                        IFormatter formatter = new BinaryFormatter();
                        _CANCIONES = (DataTable)formatter.Deserialize(fs);
                        dtgCanciones.DataSource = _CANCIONES;
                        lblCanciones.Text = dtgCanciones.Rows.Count.ToString();

                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al cargar las canciones.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditarCancion(object sender, EventArgs e)
        {

            if (MessageBox.Show(
                "¿Quieres EDITAR la canción seleccionada?",
                "Pregunta.",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes
                )
            {
                Editar EdC = new Editar();
                EdC.txbTitulo.Text = dtgCanciones
                    .CurrentRow //agarramos la fila
                    .Cells["CTitulo"]   //Especificamos la celda con un array con nombres
                    .Value //Validamos
                    .ToString(); //Convertimos a string
                EdC.txbArtis.Text = dtgCanciones
                    .CurrentRow //agarramos la fila
                    .Cells["CArtista"]   //Especificamos la celda con un array con nombres
                    .Value //Validamos
                    .ToString(); //Convertimos a string
                EdC.txbGenero.Text = dtgCanciones
                    .CurrentRow //agarramos la fila
                    .Cells["CGenero"]   //Especificamos la celda con un array con nombres
                    .Value //Validamos
                    .ToString(); //Convertimos a string


                EdC.ShowDialog();//Sacamos la nueva ventana
                if (EdC.Procesar)
                {
                    try
                    {
                        dtgCanciones.CurrentRow.Cells["CTitulo"].Value = EdC.txbTitulo.Text;
                        dtgCanciones.CurrentRow.Cells["CArtista"].Value = EdC.txbArtis.Text;
                        dtgCanciones.CurrentRow.Cells["CGenero"].Value = EdC.txbGenero.Text;

                        MessageBox.Show("Registro Editado",
                        "Confirmacion",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        GuardarCanciones();

                        lblCanciones.Text = dtgCanciones.Rows.Count.ToString();
                    }
                    catch { }
                }
            }

        }



    }//Final de codigo
}