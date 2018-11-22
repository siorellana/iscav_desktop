using Iscav1;
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
    public partial class modVehiculo : Form
    {
        public modVehiculo()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            SelectMenu sm = new SelectMenu();
            sm.Show();
            this.Hide();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnEstacionamiento1_Click(object sender, EventArgs e)
        {
            FacialRecognition.numEstacionamiento.numeroEstacionamiento = btnEstacionamiento1.Text;
            FormVehiculo form = new FormVehiculo();
            form.Show();
        }
    }
}
