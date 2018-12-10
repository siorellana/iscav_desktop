using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacialRecognition
{
    public partial class SelectMenuCon : Form
    {
        public SelectMenuCon()
        {
            InitializeComponent();
        }

        private void btnEdificio_Click(object sender, EventArgs e)
        {
            FacialRecognition.validador.validarDetec = "Conserje";

            modDepto modDepto = new modDepto();
            //propiedad.MdiParent = this;

            // propiedad.WindowState = FormWindowState.Maximized;
            modDepto.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FacialRecognition.validador.validarDetec = "Conserje";
            modDeteccion d = new modDeteccion();
            d.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FacialRecognition.validador.validarDetec = "Conserje";
            modEnroll rola = new modEnroll();
            this.Hide();
            rola.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FacialRecognition.validador.validarDetec = "Conserje";

            modVehiculo mv = new modVehiculo();
            mv.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menuLogin login = new menuLogin();
            this.Hide();
            login.Show();

           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
