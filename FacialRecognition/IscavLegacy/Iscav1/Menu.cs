using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clases;

namespace Iscav1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void propietarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  modPersona propietario = new modPersona();

          //  propietario.MdiParent = this;

         //   propietario.WindowState = FormWindowState.Maximized;
          //  propietario.Show();

        }

        private void propiedadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Propiedad propiedad = new Propiedad();
            propiedad.MdiParent = this;

            propiedad.WindowState = FormWindowState.Maximized;
            propiedad.Show();

        }

        private void residenteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Residente residente = new Residente();

            residente.MdiParent = this;

            residente.WindowState = FormWindowState.Maximized;
            residente.Show();
        }

        private void visitaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Visita visita = new Visita();

            visita.MdiParent = this;

            visita.WindowState = FormWindowState.Maximized;
            visita.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void enrolarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Enrola enrola = new Enrola();

            enrola.MdiParent = this;

            enrola.WindowState = FormWindowState.Maximized;
            enrola.Show();

        }
    }
}
