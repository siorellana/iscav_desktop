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
<<<<<<< HEAD
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
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

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //FacialRecognition.validador.validarDetec = "Conserje";

            modDepto mDepto = new modDepto();
            this.Hide();

            mDepto.Show();
            //propiedad.MdiParent = this;
           
            // propiedad.WindowState = FormWindowState.Maximized;




        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            FacialRecognition.validador.validarDetec = "Conserje";
            modDeteccion d = new modDeteccion();
            this.Hide();
            d.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
=======
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
>>>>>>> e74c1d05333b30f10652cf8b35a6f4b05167b7dc
        {
            FacialRecognition.validador.validarDetec = "Conserje";
            modEnroll rola = new modEnroll();
            this.Hide();
            rola.Show();
        }

<<<<<<< HEAD
        private void pictureBox1_Click(object sender, EventArgs e)
=======
        private void button5_Click(object sender, EventArgs e)
>>>>>>> e74c1d05333b30f10652cf8b35a6f4b05167b7dc
        {
            FacialRecognition.validador.validarDetec = "Conserje";

            modVehiculo mv = new modVehiculo();
<<<<<<< HEAD
            this.Hide();
            mv.Show();

           
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            lblDepto.Show();
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            lblDepto.Hide();
        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            lblReconoce.Show();
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            lblReconoce.Hide();
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            lblVisita.Show();
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            lblVisita.Hide();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            lblVehiculo.Show();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            lblVehiculo.Hide();
=======
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

>>>>>>> e74c1d05333b30f10652cf8b35a6f4b05167b7dc
        }
    }
}
