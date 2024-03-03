using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reproductor
{
    public partial class Editar : Form
    {
        private Boolean _Procesar = false;
        public bool Procesar { get => _Procesar; set => _Procesar = value; }

        public Editar()
        {
            InitializeComponent();
        }

        private void Editar_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar(object sender, EventArgs e)
        {

            if (MessageBox.Show(
               "¿Quieres Guardar?",
               "Pregunta.",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes
               )
            {
                _Procesar = true;
                Close();
            }

        }

    }


}
