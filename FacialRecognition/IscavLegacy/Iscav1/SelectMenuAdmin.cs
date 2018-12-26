using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Iscav1
{
    public partial class SelectMenuAdmin : Form
    {
        public SelectMenuAdmin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Propiedad propiedad = new Propiedad();
            propiedad.MdiParent = this;

            propiedad.WindowState = FormWindowState.Maximized;
            propiedad.Show();

            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
          //  modPersona propietario = new modPersona();

       //     propietario.MdiParent = this;

         //   propietario.WindowState = FormWindowState.Maximized;
         //   propietario.Show();


            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Reporte repo = new Reporte();

            repo.MdiParent = this;

            repo.WindowState = FormWindowState.Maximized;
            repo.Show();

            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
        }
    }
}
