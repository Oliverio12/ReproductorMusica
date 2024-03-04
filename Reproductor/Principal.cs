using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using NAudio.Utils;
using System.Security.Cryptography;


namespace Reproductor
{
    public partial class Principal : Form
    {

        DataTable _CANCIONES = new DataTable();
        WaveOutEvent salidaDeAudio = new WaveOutEvent();
        string rutaArchivo = "Canciones.dat";

        private Timer tiempo = new Timer();

        // Declarar una variable para mantener el tiempo transcurrido
        private TimeSpan tiempoTranscurrido = TimeSpan.Zero;

        // Método para actualizar el label con el tiempo transcurrido
        private void ActualizarTiempoTranscurrido()
        {
            lblStatus.Text = tiempoTranscurrido.ToString(@"mm\:ss");
        }



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
            tiempo.Interval = 1000; // 1 segundo
            tiempo.Tick += Temporizador_Tick;
            salidaDeAudio.PlaybackStopped += ReproduccionDispositivo_SalidaDetenida;
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




        private void btnAbrir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            f.Description = "Selecciona una carpeta con MP3";
            f.ShowDialog();
            if (f.SelectedPath.Length > 0)
            {
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

                            string velocidad = Cancion.Properties.AudioSampleRate.ToString();
                            NuevaFila["CVelocidad"] = velocidad;

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


        private void Temporizador_Tick(object sender, EventArgs e)
        {
            // Incrementar el tiempo transcurrido cada segundo
            tiempoTranscurrido = tiempoTranscurrido.Add(TimeSpan.FromSeconds(1));
            ActualizarTiempoTranscurrido();
        }

        private void ReproduccionDispositivo_SalidaDetenida(object sender, StoppedEventArgs e)
        {
            // Reiniciar el tiempo transcurrido cuando la reproducción se detiene
            tiempoTranscurrido = TimeSpan.Zero;
            ActualizarTiempoTranscurrido();
            // Detener el temporizador

            if (sender == btnDetener)
            {
                tiempo.Stop();
            }

            if (sender == btnReproducir) {
                tiempo.Start();
            }
            
            if (sender == btnPausa)
            {
                tiempo.Start();
            }
        }

        // Declara una variable para mantener el estado de reproducción actual
        private PlaybackState estadoReproduccionActual = PlaybackState.Stopped;
        private TimeSpan tiempoPausado;

        private void btnPausa_Click(object sender, EventArgs e)
        {
            if (salidaDeAudio.PlaybackState == PlaybackState.Playing)
            {
                salidaDeAudio.Pause();
                tiempoPausado = salidaDeAudio.GetPositionTimeSpan();
                estadoReproduccionActual = PlaybackState.Paused;
                tiempo.Stop();
            }
        }

        private void btnReproducir_Click(object sender, EventArgs e)
        {
            if (dtgCanciones.CurrentRow != null && dtgCanciones.CurrentRow.Cells["CRuta"].Value != null)
            {
                string rutaCancion = dtgCanciones.CurrentRow.Cells["CRuta"].Value.ToString();
                if (File.Exists(rutaCancion))
                {
                    if (estadoReproduccionActual == PlaybackState.Paused)
                    {
                        tiempoPausado = salidaDeAudio.GetPositionTimeSpan();
                        salidaDeAudio.Play();
                        estadoReproduccionActual = PlaybackState.Playing;
                        tiempo.Start();
                    }
                    else
                    {
                        if (salidaDeAudio.PlaybackState == PlaybackState.Playing)
                        {
                            salidaDeAudio.Stop();
                            salidaDeAudio.Dispose();
                        }

                        using (var audioFile = new AudioFileReader(rutaCancion))
                        {
                            salidaDeAudio = new WaveOutEvent();
                            salidaDeAudio.PlaybackStopped += ReproduccionDispositivo_SalidaDetenida;
                            salidaDeAudio.Init(audioFile);
                            salidaDeAudio.Play();
                            estadoReproduccionActual = PlaybackState.Playing;
                            tiempo.Start();
                        }
                    }
                }
            }
        }






        private void btnDetener_Click(object sender, EventArgs e)
        {
            salidaDeAudio.Stop();
            tiempo.Stop();
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
        private void FiltrarDatos(string filtro)
        {
            if (_CANCIONES != null)
            {
                int indiceEspacio = filtro.IndexOf(' ');
                string filtroTitulo= "";
               
                if (indiceEspacio != -1)
                {
                    filtroTitulo = filtro.Substring(indiceEspacio + 1);
                }
                else
                {
                    filtroTitulo = filtro;
                }
                string titulo = $"CTitulo LIKE '%{filtroTitulo}%' ";
                _CANCIONES.DefaultView.RowFilter = titulo;
                dtgCanciones.DataSource = _CANCIONES.DefaultView.ToTable();
            }
        }
        private void txb_TextChanged(object sender, EventArgs e)
        {
            string filtro = txb.Text;
            FiltrarDatos(filtro);
        }

       
    }//Final de codigo
}