﻿using Iscav1;
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
    public partial class modReporte : Form
    {
        public modReporte()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            SelectMenu sele = new SelectMenu();

            sele.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnPiso1_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("https://app.powerbi.com/view?r=eyJrIjoiODFmYTM3ZGQtMjg4Ny00NjcwLWJiYjgtNjkyOGEyODJiOTQ4IiwidCI6IjM4YTFlMGExLWI2YjEtNDJlOS1iM2E5LTU5NzYyNjY3MGIxNyIsImMiOjR9");
        }

        private void btnPiso2_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            this.webBrowser1.Navigate("https://app.powerbi.com/view?r=eyJrIjoiYTU1OTFiZGEtYzRiZi00NDY1LWI1NmQtZDM0NzkzY2Q4Mjc4IiwidCI6IjM4YTFlMGExLWI2YjEtNDJlOS1iM2E5LTU5NzYyNjY3MGIxNyIsImMiOjR9");
=======
            this.webBrowser1.Navigate("http://www.google.com");
>>>>>>> e74c1d05333b30f10652cf8b35a6f4b05167b7dc
        }

        private void btnPiso3_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
           
=======
            this.webBrowser1.Navigate("http://www.facebook.com");
>>>>>>> e74c1d05333b30f10652cf8b35a6f4b05167b7dc
        }
    }
}
