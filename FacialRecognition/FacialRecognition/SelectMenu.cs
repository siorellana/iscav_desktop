﻿using FacialRecognition;
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
    public partial class SelectMenu : Form
    {
        public SelectMenu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           // FrmEdificio Fredificio = new FrmEdificio();
            //propiedad.MdiParent = this;

           // propiedad.WindowState = FormWindowState.Maximized;
          //  Fredificio.Show();
           // this.Hide();


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            

        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            modReporte repo = new modReporte();

            //repo.MdiParent = this;

            repo.WindowState = FormWindowState.Maximized;
            repo.Show();
            this.Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            menuLogin login = new menuLogin();
            login.Show();   
            this.Hide();
        }

        private void SelectMenu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            modDepto modDepto = new modDepto();
            //propiedad.MdiParent = this;

            // propiedad.WindowState = FormWindowState.Maximized;
            modDepto.Show();
            this.Hide();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FacialRecognition.validador.validarDetec = "Persona";
            modEnroll rola = new modEnroll();
            rola.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            modPersona propietario = new modPersona();

            // propietario.MdiParent = this;

            //   propietario.WindowState = FormWindowState.Maximized;
            propietario.Show();
            this.Hide();
        }

        private void btnPersonas_Click(object sender, EventArgs e)
        {
            modPersona propietario = new modPersona();

            // propietario.MdiParent = this;

            //   propietario.WindowState = FormWindowState.Maximized;
            propietario.Show();
            this.Hide();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            modDepto modDepto = new modDepto();
            //propiedad.MdiParent = this;

            // propiedad.WindowState = FormWindowState.Maximized;
            modDepto.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            modReporte repo = new modReporte();

            //repo.MdiParent = this;

            repo.WindowState = FormWindowState.Maximized;
            repo.Show();
            this.Hide();

        }
    }
}
