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

        private void btnEstacionamiento2_Click(object sender, EventArgs e)
        {
            FacialRecognition.numEstacionamiento.numeroEstacionamiento = btnEstacionamiento2.Text;
            FormVehiculo form = new FormVehiculo();
            form.Show();
        }

        private void btnEstacionamiento3_Click(object sender, EventArgs e)
        {
            FacialRecognition.numEstacionamiento.numeroEstacionamiento = btnEstacionamiento3.Text;
            FormVehiculo form = new FormVehiculo();
            form.Show();
        }

        private void btnEstacionamiento4_Click(object sender, EventArgs e)
        {
            FacialRecognition.numEstacionamiento.numeroEstacionamiento = btnEstacionamiento4.Text;
            FormVehiculo form = new FormVehiculo();
            form.Show();
        }

        private void btnEstacionamiento5_Click(object sender, EventArgs e)
        {
            FacialRecognition.numEstacionamiento.numeroEstacionamiento = btnEstacionamiento5.Text;
            FormVehiculo form = new FormVehiculo();
            form.Show();
        }

        private void btnEstacionamiento6_Click(object sender, EventArgs e)
        {
            FacialRecognition.numEstacionamiento.numeroEstacionamiento = btnEstacionamiento6.Text;
            FormVehiculo form = new FormVehiculo();
            form.Show();
        }

        private void timerStatus_Tick(object sender, EventArgs e)
        {
            lblStatus1.Visible = true;
            label1.Visible = true;
            lblStatus2.Visible = true;
            label10.Visible = true;
            lblStatus3.Visible = true;
            label15.Visible = true;
            lblStatus4.Visible = true;
            label20.Visible = true;
            lblStatus5.Visible = true;
            label25.Visible = true;
            lblStatus6.Visible = true;
            label30.Visible = true;



            if (FacialRecognition.estacionamiento1.tiempo != 0)
            {
                lblDepto1.Visible = true;
                label2.Visible = true;
                lblPatente1.Visible = true;
                label3.Visible = true;
                lblHoraIngreso1.Visible = true;
                label4.Visible = true;
                lblTiempo1.Visible = true;
                label5.Visible = true;
                lblStatus1.Text = "Ocupado";
                lblTiempo1.Text = Convert.ToString(FacialRecognition.estacionamiento1.tiempo);
                lblDepto1.Text = FacialRecognition.estacionamiento1.depto;
                lblPatente1.Text = FacialRecognition.estacionamiento1.patente;
                lblHoraIngreso1.Text = FacialRecognition.estacionamiento1.horaInicio;
                lblTiempo1.Text = Convert.ToString(FacialRecognition.estacionamiento1.tiempo);

            }
            else
            {
                lblStatus1.Text = "Disponible";
                lblDepto1.Visible = false;
                label5.Visible = false;
                lblPatente1.Visible = false;
                label4.Visible = false;
                lblHoraIngreso1.Visible = false;
                label3.Visible = false;
                lblTiempo1.Visible = false;
                label2.Visible = false;

            }

            if (FacialRecognition.estacionamiento2.tiempo != 0)
            {
                lblDepto2.Visible = true;
                lblPatente2.Visible = true;
                lblHoraIngreso2.Visible = true;
                lblTiempo2.Visible = true;
                lblStatus2.Text = "Ocupado";
                lblTiempo2.Text = Convert.ToString(FacialRecognition.estacionamiento2.tiempo);
                lblDepto2.Text = FacialRecognition.estacionamiento2.depto;
                lblPatente2.Text = FacialRecognition.estacionamiento2.patente;
                lblHoraIngreso2.Text = FacialRecognition.estacionamiento2.horaInicio;
                lblTiempo2.Text = Convert.ToString(FacialRecognition.estacionamiento2.tiempo);

            }
            else
            {
                lblStatus2.Text = "Disponible";
                lblDepto2.Visible = false;
                lblPatente2.Visible = false;
                lblHoraIngreso2.Visible = false;
                lblTiempo2.Visible = false;
            }

            if (FacialRecognition.estacionamiento3.tiempo != 0)
            {
                lblDepto3.Visible = true;
                lblPatente3.Visible = true;
                lblHoraIngreso3.Visible = true;
                lblTiempo3.Visible = true;
                lblStatus3.Text = "Ocupado";
                lblTiempo3.Text = Convert.ToString(FacialRecognition.estacionamiento3.tiempo);
                lblDepto3.Text = FacialRecognition.estacionamiento3.depto;
                lblPatente3.Text = FacialRecognition.estacionamiento3.patente;
                lblHoraIngreso3.Text = FacialRecognition.estacionamiento3.horaInicio;
                lblTiempo3.Text = Convert.ToString(FacialRecognition.estacionamiento3.tiempo);

            }
            else
            {
                lblStatus3.Text = "Disponible";
                lblDepto3.Visible = false;
                lblPatente3.Visible = false;
                lblHoraIngreso3.Visible = false;
                lblTiempo3.Visible = false;
            }

            if (FacialRecognition.estacionamiento4.tiempo != 0)
            {
                lblDepto4.Visible = true;
                lblPatente4.Visible = true;
                lblHoraIngreso4.Visible = true;
                lblTiempo4.Visible = true;
                lblStatus4.Text = "Ocupado";
                lblTiempo4.Text = Convert.ToString(FacialRecognition.estacionamiento4.tiempo);
                lblDepto4.Text = FacialRecognition.estacionamiento4.depto;
                lblPatente4.Text = FacialRecognition.estacionamiento4.patente;
                lblHoraIngreso4.Text = FacialRecognition.estacionamiento4.horaInicio;
                lblTiempo4.Text = Convert.ToString(FacialRecognition.estacionamiento4.tiempo);

            }
            else
            {
                lblStatus4.Text = "Disponible";
                lblDepto4.Visible = false;
                lblPatente4.Visible = false;
                lblHoraIngreso4.Visible = false;
                lblTiempo4.Visible = false;
            }

            if (FacialRecognition.estacionamiento5.tiempo != 0)
            {
                lblDepto5.Visible = true;
                lblPatente5.Visible = true;
                lblHoraIngreso5.Visible = true;
                lblTiempo5.Visible = true;
                lblStatus5.Text = "Ocupado";
                lblTiempo5.Text = Convert.ToString(FacialRecognition.estacionamiento5.tiempo);
                lblDepto5.Text = FacialRecognition.estacionamiento5.depto;
                lblPatente5.Text = FacialRecognition.estacionamiento5.patente;
                lblHoraIngreso5.Text = FacialRecognition.estacionamiento5.horaInicio;
                lblTiempo5.Text = Convert.ToString(FacialRecognition.estacionamiento5.tiempo);

            }
            else
            {
                lblStatus5.Text = "Disponible";
                lblDepto5.Visible = false;
                lblPatente5.Visible = false;
                lblHoraIngreso5.Visible = false;
                lblTiempo5.Visible = false;
            }

            if (FacialRecognition.estacionamiento6.tiempo != 0)
            {
                lblDepto6.Visible = true;
                lblPatente6.Visible = true;
                lblHoraIngreso6.Visible = true;
                lblTiempo6.Visible = true;
                lblStatus6.Text = "Ocupado";
                lblTiempo6.Text = Convert.ToString(FacialRecognition.estacionamiento6.tiempo);
                lblDepto6.Text = FacialRecognition.estacionamiento6.depto;
                lblPatente6.Text = FacialRecognition.estacionamiento6.patente;
                lblHoraIngreso6.Text = FacialRecognition.estacionamiento6.horaInicio;
                lblTiempo6.Text = Convert.ToString(FacialRecognition.estacionamiento6.tiempo);

            }
            else
            {
                lblStatus6.Text = "Disponible";
                lblDepto6.Visible = false;
                lblPatente6.Visible = false;
                lblHoraIngreso6.Visible = false;
                lblTiempo6.Visible = false;
            }


        }

        private void modVehiculo_Load(object sender, EventArgs e)
        {
            lblStatus1.Visible = false;
            lblDepto1.Visible = false;
            lblPatente1.Visible = false;
            lblHoraIngreso1.Visible = false;
            lblTiempo1.Visible = false;

            lblStatus2.Visible = false;
            lblDepto2.Visible = false;
            lblPatente2.Visible = false;
            lblHoraIngreso2.Visible = false;
            lblTiempo2.Visible = false;

            lblStatus3.Visible = false;
            lblDepto3.Visible = false;
            lblPatente3.Visible = false;
            lblHoraIngreso3.Visible = false;
            lblTiempo3.Visible = false;

            lblStatus4.Visible = false;
            lblDepto4.Visible = false;
            lblPatente4.Visible = false;
            lblHoraIngreso4.Visible = false;
            lblTiempo4.Visible = false;

            lblStatus5.Visible = false;
            lblDepto5.Visible = false;
            lblPatente5.Visible = false;
            lblHoraIngreso5.Visible = false;
            lblTiempo5.Visible = false;

            lblStatus6.Visible = false;
            lblDepto6.Visible = false;
            lblPatente6.Visible = false;
            lblHoraIngreso6.Visible = false;
            lblTiempo6.Visible = false;

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
            label22.Visible = false;
            label23.Visible = false;
            label24.Visible = false;
            label25.Visible = false;
            label26.Visible = false;
            label27.Visible = false;
            label28.Visible = false;
            label29.Visible = false;
            label30.Visible = false;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
