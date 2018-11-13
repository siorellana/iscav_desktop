using FacialRecognition;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using Negocio;

namespace Iscav1
{
    public partial class Residente : Form
    {
        public Residente()
        {
            InitializeComponent();
        }


        protected void GvMostrar(object sender, EventArgs e)
        {

            dataGridResidente.DataSource = AccesoLogica.ObtenerResidente();

            //txtRut.Enabled = true;

            //btnEnviar.Enabled = true;
        }
        private void Residente_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarNomResi_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            dataGridResidente.DataSource = AccesoLogica.ObtenerResidente();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

        }

        private void btnModResidente_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

        }
    }
}
