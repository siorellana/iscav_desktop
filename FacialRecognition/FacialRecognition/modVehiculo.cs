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


            //Estacionamiento 1
            if (FacialRecognition.estacionamiento1.tiempo > 0)
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
                btnEstacionamiento1.Visible = false;
                btnSalida1.Visible = true;
                lblTiempo1.Text = Convert.ToString(FacialRecognition.estacionamiento1.tiempo);
                lblDepto1.Text = FacialRecognition.estacionamiento1.depto;
                lblPatente1.Text = FacialRecognition.estacionamiento1.patente;
                lblHoraIngreso1.Text = FacialRecognition.estacionamiento1.horaInicio;
                lblTiempo1.Text = Convert.ToString(FacialRecognition.estacionamiento1.tiempo);

            }
            if (FacialRecognition.estacionamiento1.tiempo == -1)
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
                btnSalida1.Visible = false;
                btnEstacionamiento1.Visible = true;
                
            }
            if (FacialRecognition.estacionamiento1.tiempo == 0)
            {
                
                lblStatus1.Text = "Notificar a visita";
                lblDepto1.Visible = false;
                label5.Visible = false;
                lblPatente1.Visible = false;
                label4.Visible = false;
                lblHoraIngreso1.Visible = false;
                label3.Visible = false;
                lblTiempo1.Visible = false;
                label2.Visible = false;
                btnEstacionamiento1.Visible = false;
                btnSalida1.Visible = true;
            }

            //Estacionamiento 2
            if (FacialRecognition.estacionamiento2.tiempo > 0)
            {

                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                lblDepto2.Visible = true;
                lblPatente2.Visible = true;
                lblHoraIngreso2.Visible = true;
                lblTiempo2.Visible = true;
                lblStatus2.Text = "Ocupado";
                btnEstacionamiento2.Visible = false;
                btnSalida2.Visible = true;
                lblTiempo2.Text = Convert.ToString(FacialRecognition.estacionamiento2.tiempo);
                lblDepto2.Text = FacialRecognition.estacionamiento2.depto;
                lblPatente2.Text = FacialRecognition.estacionamiento2.patente;
                lblHoraIngreso2.Text = FacialRecognition.estacionamiento2.horaInicio;
                //lblTiempo2.Text = Convert.ToString(FacialRecognition.estacionamiento2.tiempo);

            }
            if (FacialRecognition.estacionamiento2.tiempo == -1)
            {
                lblStatus2.Text = "Disponible";
                lblDepto2.Visible = false;
                lblPatente2.Visible = false;
                lblHoraIngreso2.Visible = false;
                lblTiempo2.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                btnSalida2.Visible = false;
                btnEstacionamiento2.Visible = true;
            }
            if (FacialRecognition.estacionamiento2.tiempo == 0)
            {
                lblStatus2.Text = "Notificar a visita";
                lblDepto2.Visible = false;
                lblPatente2.Visible = false;
                lblHoraIngreso2.Visible = false;
                lblTiempo2.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                btnEstacionamiento2.Visible = false;
                btnSalida2.Visible = true;
            }

            //Estacionamiento 3
            if (FacialRecognition.estacionamiento3.tiempo > 0)
            {
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                lblDepto3.Visible = true;
                lblPatente3.Visible = true;
                lblHoraIngreso3.Visible = true;
                lblTiempo3.Visible = true;
                lblStatus3.Text = "Ocupado";
                btnEstacionamiento3.Visible = false;
                btnSalida3.Visible = true;
                lblTiempo3.Text = Convert.ToString(FacialRecognition.estacionamiento3.tiempo);
                lblDepto3.Text = FacialRecognition.estacionamiento3.depto;
                lblPatente3.Text = FacialRecognition.estacionamiento3.patente;
                lblHoraIngreso3.Text = FacialRecognition.estacionamiento3.horaInicio;
              //  lblTiempo3.Text = Convert.ToString(FacialRecognition.estacionamiento3.tiempo);

            }
            
            if (FacialRecognition.estacionamiento3.tiempo == 0)
            {
                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                lblStatus3.Text = "Notificar a visita";
                lblDepto3.Visible = false;
                lblPatente3.Visible = false;
                lblHoraIngreso3.Visible = false;
                lblTiempo3.Visible = false;
                btnEstacionamiento3.Visible = false;
                btnSalida3.Visible = true;
            }
            if (FacialRecognition.estacionamiento3.tiempo == -1)
            {
                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                lblStatus3.Text = "Disponible";
                lblDepto3.Visible = false;
                lblPatente3.Visible = false;
                lblHoraIngreso3.Visible = false;
                lblTiempo3.Visible = false;
                btnSalida3.Visible = false;
                btnEstacionamiento3.Visible = true;
            }

            //Estacionamiento 4
            if (FacialRecognition.estacionamiento4.tiempo > 0)
            {
                label16.Visible = true;
                label17.Visible = true;
                label18.Visible = true;
                label19.Visible = true;
                lblDepto4.Visible = true;
                lblPatente4.Visible = true;
                lblHoraIngreso4.Visible = true;
                lblTiempo4.Visible = true;
                lblStatus4.Text = "Ocupado";
                btnEstacionamiento4.Visible = false;
                btnSalida4.Visible = true;
                lblTiempo4.Text = Convert.ToString(FacialRecognition.estacionamiento4.tiempo);
                lblDepto4.Text = FacialRecognition.estacionamiento4.depto;
                lblPatente4.Text = FacialRecognition.estacionamiento4.patente;
                lblHoraIngreso4.Text = FacialRecognition.estacionamiento4.horaInicio;
                lblTiempo4.Text = Convert.ToString(FacialRecognition.estacionamiento4.tiempo);

            }
            if (FacialRecognition.estacionamiento4.tiempo == -1)
            {
                label16.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                label19.Visible = false;
                lblStatus4.Text = "Disponible";
                lblDepto4.Visible = false;
                lblPatente4.Visible = false;
                lblHoraIngreso4.Visible = false;
                lblTiempo4.Visible = false;
                btnSalida4.Visible = false;
                btnEstacionamiento4.Visible = true;
            }
            if (FacialRecognition.estacionamiento4.tiempo == 0)
            {
                label16.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                label19.Visible = false;
                lblStatus4.Text = "Notificar a visita";
                lblDepto4.Visible = false;
                lblPatente4.Visible = false;
                lblHoraIngreso4.Visible = false;
                lblTiempo4.Visible = false;
                btnEstacionamiento4.Visible = false;
                btnSalida4.Visible = true;
            }

            //Estacionamiento 5
            if (FacialRecognition.estacionamiento5.tiempo > 0)
            {
                label21.Visible = true;
                label22.Visible = true;
                label23.Visible = true;
                label24.Visible = true;
                lblDepto5.Visible = true;
                lblPatente5.Visible = true;
                lblHoraIngreso5.Visible = true;
                lblTiempo5.Visible = true;
                lblStatus5.Text = "Ocupado";
                btnEstacionamiento5.Visible = false;
                btnSalida5.Visible = true;
                lblTiempo5.Text = Convert.ToString(FacialRecognition.estacionamiento5.tiempo);
                lblDepto5.Text = FacialRecognition.estacionamiento5.depto;
                lblPatente5.Text = FacialRecognition.estacionamiento5.patente;
                lblHoraIngreso5.Text = FacialRecognition.estacionamiento5.horaInicio;
                lblTiempo5.Text = Convert.ToString(FacialRecognition.estacionamiento5.tiempo);

            }
            if (FacialRecognition.estacionamiento5.tiempo == -1)
            {
                label21.Visible = false;
                label22.Visible = false;
                label23.Visible = false;
                label24.Visible = false;
                lblStatus5.Text = "Disponible";
                lblDepto5.Visible = false;
                lblPatente5.Visible = false;
                lblHoraIngreso5.Visible = false;
                lblTiempo5.Visible = false;
                btnSalida5.Visible = false;
                btnEstacionamiento5.Visible = true;
            }
            if (FacialRecognition.estacionamiento5.tiempo == 0)
            {
                label21.Visible = false;
                label22.Visible = false;
                label23.Visible = false;
                label24.Visible = false;
                lblStatus5.Text = "Notificar a visita";
                lblDepto5.Visible = false;
                lblPatente5.Visible = false;
                lblHoraIngreso5.Visible = false;
                lblTiempo5.Visible = false;
                btnEstacionamiento5.Visible = false;
                btnSalida5.Visible = true;
            }

            //Estacionamiento 6
            if (FacialRecognition.estacionamiento6.tiempo > 0)
            {
                label26.Visible = true;
                label27.Visible = true;
                label28.Visible = true;
                label29.Visible = true;
                lblDepto6.Visible = true;
                lblPatente6.Visible = true;
                lblHoraIngreso6.Visible = true;
                lblTiempo6.Visible = true;
                lblStatus6.Text = "Ocupado";
                btnEstacionamiento6.Visible = false;
                btnSalida6.Visible = true;
                lblTiempo6.Text = Convert.ToString(FacialRecognition.estacionamiento6.tiempo);
                lblDepto6.Text = FacialRecognition.estacionamiento6.depto;
                lblPatente6.Text = FacialRecognition.estacionamiento6.patente;
                lblHoraIngreso6.Text = FacialRecognition.estacionamiento6.horaInicio;
                lblTiempo6.Text = Convert.ToString(FacialRecognition.estacionamiento6.tiempo);

            }
            if (FacialRecognition.estacionamiento6.tiempo == -1)
            {
                label26.Visible = false;
                label27.Visible = false;
                label28.Visible = false;
                label29.Visible = false;
                lblStatus6.Text = "Disponible";
                lblDepto6.Visible = false;
                lblPatente6.Visible = false;
                lblHoraIngreso6.Visible = false;
                lblTiempo6.Visible = false;
                btnSalida6.Visible = false;
                btnEstacionamiento6.Visible = true;
            }
            if (FacialRecognition.estacionamiento6.tiempo == 0)
            {
                label26.Visible = false;
                label27.Visible = false;
                label28.Visible = false;
                label29.Visible = false;
                lblStatus6.Text = "Notificar a visita";
                lblDepto6.Visible = false;
                lblPatente6.Visible = false;
                lblHoraIngreso6.Visible = false;
                lblTiempo6.Visible = false;
                btnEstacionamiento6.Visible = false;
                btnSalida6.Visible = true;
            }


        }

        private void modVehiculo_Load(object sender, EventArgs e)
        {
            FacialRecognition.tiempo.segundos = 60;
            lblStatus1.Visible = false;
            lblDepto1.Visible = false;
            lblPatente1.Visible = false;
            lblHoraIngreso1.Visible = false;
            lblTiempo1.Visible = false;
            btnSalida1.Visible = false;

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

        private void btnSalida1_Click(object sender, EventArgs e)
        {
            DateTime horaActual = DateTime.Now;
            FacialRecognition.estacionamiento1.tiempo = -1;
            //Guardar en base de datos

            try
            {
                // Objetos de conexión y comando
                System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection((@"Data Source=localhost;Initial Catalog=dbprod;Trusted_Connection =True"));
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                // Estableciento propiedades
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO registroVehiculos VALUES (@depto, @nombre, @patente, @horaIngreso, @horaRetiro, @estacionamiento)";

                // Creando los parámetros necesarios
                cmd.Parameters.Add("@depto", System.Data.SqlDbType.NVarChar);
                cmd.Parameters.Add("@nombre", System.Data.SqlDbType.NVarChar);
                cmd.Parameters.Add("@patente", System.Data.SqlDbType.NVarChar);
                cmd.Parameters.Add("@horaIngreso", System.Data.SqlDbType.DateTime);
                cmd.Parameters.Add("@horaRetiro", System.Data.SqlDbType.DateTime);
                cmd.Parameters.Add("@estacionamiento", System.Data.SqlDbType.NVarChar);
                                             
                cmd.Parameters["@depto"].Value = FacialRecognition.estacionamiento1.depto;
                cmd.Parameters["@nombre"].Value = FacialRecognition.estacionamiento1.nombre;
                cmd.Parameters["@patente"].Value = FacialRecognition.estacionamiento1.patente;
                cmd.Parameters["@horaIngreso"].Value = FacialRecognition.estacionamiento1.horaInicio;
                cmd.Parameters["@horaRetiro"].Value = horaActual;
                cmd.Parameters["@estacionamiento"].Value = "Estacionamiento 1";
             
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
              }
              catch (Exception)
              {

                  throw;
              }

                btnSalida1.Visible = false;
                MessageBox.Show("El vehiculo patente " + FacialRecognition.estacionamiento1.patente + " ha dejado el edificio a las " + Convert.ToString(horaActual));


            //Borrar variables
            FacialRecognition.estacionamiento1.nombre = null;
            FacialRecognition.estacionamiento1.depto = null;
            FacialRecognition.estacionamiento1.horaInicio = null;
            FacialRecognition.estacionamiento1.patente = null;
        }

        private void btnSalida2_Click(object sender, EventArgs e)
        {
            DateTime horaActual = DateTime.Now;
            FacialRecognition.estacionamiento2.tiempo = -1;
            //Guardar en BBDD
            try
            {
                // Objetos de conexión y comando
                System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection((@"Data Source=localhost;Initial Catalog=dbprod;Trusted_Connection =True"));
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                // Estableciento propiedades
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO registroVehiculos VALUES (@depto, @nombre, @patente, @horaIngreso, @horaRetiro, @estacionamiento)";

                // Creando los parámetros necesarios
                cmd.Parameters.Add("@depto", System.Data.SqlDbType.NVarChar);
                cmd.Parameters.Add("@nombre", System.Data.SqlDbType.NVarChar);
                cmd.Parameters.Add("@patente", System.Data.SqlDbType.NVarChar);
                cmd.Parameters.Add("@horaIngreso", System.Data.SqlDbType.DateTime);
                cmd.Parameters.Add("@horaRetiro", System.Data.SqlDbType.DateTime);
                cmd.Parameters.Add("@estacionamiento", System.Data.SqlDbType.NVarChar);

                cmd.Parameters["@depto"].Value = FacialRecognition.estacionamiento2.depto;
                cmd.Parameters["@nombre"].Value = FacialRecognition.estacionamiento2.nombre;
                cmd.Parameters["@patente"].Value = FacialRecognition.estacionamiento2.patente;
                cmd.Parameters["@horaIngreso"].Value = FacialRecognition.estacionamiento2.horaInicio;
                cmd.Parameters["@horaRetiro"].Value = horaActual;
                cmd.Parameters["@estacionamiento"].Value = "Estacionamiento 2";

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {

                throw;
            }

            btnSalida2.Visible = false;
            MessageBox.Show("El vehiculo patente " + FacialRecognition.estacionamiento2.patente + " ha dejado el edificio a las " + Convert.ToString(horaActual));

            //Borrar variables
            FacialRecognition.estacionamiento2.nombre = null;
            FacialRecognition.estacionamiento2.depto = null;
            FacialRecognition.estacionamiento2.horaInicio = null;
            FacialRecognition.estacionamiento2.patente = null;
        }

        private void btnSalida3_Click(object sender, EventArgs e)
        {
            DateTime horaActual = DateTime.Now;
            FacialRecognition.estacionamiento3.tiempo = -1;
            //Guardar en BBDD
            try
            {
                // Objetos de conexión y comando
                System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection((@"Data Source=localhost;Initial Catalog=dbprod;Trusted_Connection =True"));
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                // Estableciento propiedades
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO registroVehiculos VALUES (@depto, @nombre, @patente, @horaIngreso, @horaRetiro, @estacionamiento)";

                // Creando los parámetros necesarios
                cmd.Parameters.Add("@depto", System.Data.SqlDbType.NVarChar);
                cmd.Parameters.Add("@nombre", System.Data.SqlDbType.NVarChar);
                cmd.Parameters.Add("@patente", System.Data.SqlDbType.NVarChar);
                cmd.Parameters.Add("@horaIngreso", System.Data.SqlDbType.DateTime);
                cmd.Parameters.Add("@horaRetiro", System.Data.SqlDbType.DateTime);
                cmd.Parameters.Add("@estacionamiento", System.Data.SqlDbType.NVarChar);

                cmd.Parameters["@depto"].Value = FacialRecognition.estacionamiento3.depto;
                cmd.Parameters["@nombre"].Value = FacialRecognition.estacionamiento3.nombre;
                cmd.Parameters["@patente"].Value = FacialRecognition.estacionamiento3.patente;
                cmd.Parameters["@horaIngreso"].Value = FacialRecognition.estacionamiento3.horaInicio;
                cmd.Parameters["@horaRetiro"].Value = horaActual;
                cmd.Parameters["@estacionamiento"].Value = "Estacionamiento 3";

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {

                throw;
            }

            btnSalida3.Visible = false;
            MessageBox.Show("El vehiculo patente " + FacialRecognition.estacionamiento3.patente + " ha dejado el edificio a las " + Convert.ToString(horaActual));

            //Borrar variables 
            FacialRecognition.estacionamiento3.nombre = null;
            FacialRecognition.estacionamiento3.depto = null;
            FacialRecognition.estacionamiento3.horaInicio = null;
            FacialRecognition.estacionamiento3.patente = null;
            estacionamiento3.tiempo = -1;
        }

        private void btnSalida4_Click(object sender, EventArgs e)
        {
            DateTime horaActual = DateTime.Now;
            FacialRecognition.estacionamiento4.tiempo = -1;
            //Guardar en BBDD
            try
            {
                // Objetos de conexión y comando
                System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection((@"Data Source=localhost;Initial Catalog=dbprod;Trusted_Connection =True"));
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                // Estableciento propiedades
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO registroVehiculos VALUES (@depto, @nombre, @patente, @horaIngreso, @horaRetiro, @estacionamiento)";

                // Creando los parámetros necesarios
                cmd.Parameters.Add("@depto", System.Data.SqlDbType.NVarChar);
                cmd.Parameters.Add("@nombre", System.Data.SqlDbType.NVarChar);
                cmd.Parameters.Add("@patente", System.Data.SqlDbType.NVarChar);
                cmd.Parameters.Add("@horaIngreso", System.Data.SqlDbType.DateTime);
                cmd.Parameters.Add("@horaRetiro", System.Data.SqlDbType.DateTime);
                cmd.Parameters.Add("@estacionamiento", System.Data.SqlDbType.NVarChar);

                cmd.Parameters["@depto"].Value = FacialRecognition.estacionamiento4.depto;
                cmd.Parameters["@nombre"].Value = FacialRecognition.estacionamiento4.nombre;
                cmd.Parameters["@patente"].Value = FacialRecognition.estacionamiento4.patente;
                cmd.Parameters["@horaIngreso"].Value = FacialRecognition.estacionamiento4.horaInicio;
                cmd.Parameters["@horaRetiro"].Value = horaActual;
                cmd.Parameters["@estacionamiento"].Value = "Estacionamiento 4";

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {

                throw;
            }

            btnSalida4.Visible = false;
            MessageBox.Show("El vehiculo patente " + FacialRecognition.estacionamiento4.patente + " ha dejado el edificio a las " + Convert.ToString(horaActual));

            //Borrar variables
            FacialRecognition.estacionamiento4.nombre = null;
            FacialRecognition.estacionamiento4.depto = null;
            FacialRecognition.estacionamiento4.horaInicio = null;
            FacialRecognition.estacionamiento4.patente = null;
        }

        private void btnSalida5_Click(object sender, EventArgs e)
        {
            DateTime horaActual = DateTime.Now;
            FacialRecognition.estacionamiento5.tiempo = -1;
            //Guardar en BBDD
            try
            {
                // Objetos de conexión y comando
                System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection((@"Data Source=localhost;Initial Catalog=dbprod;Trusted_Connection =True"));
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                // Estableciento propiedades
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO registroVehiculos VALUES (@depto, @nombre, @patente, @horaIngreso, @horaRetiro, @estacionamiento)";

                // Creando los parámetros necesarios
                cmd.Parameters.Add("@depto", System.Data.SqlDbType.NVarChar);
                cmd.Parameters.Add("@nombre", System.Data.SqlDbType.NVarChar);
                cmd.Parameters.Add("@patente", System.Data.SqlDbType.NVarChar);
                cmd.Parameters.Add("@horaIngreso", System.Data.SqlDbType.DateTime);
                cmd.Parameters.Add("@horaRetiro", System.Data.SqlDbType.DateTime);
                cmd.Parameters.Add("@estacionamiento", System.Data.SqlDbType.NVarChar);

                cmd.Parameters["@depto"].Value = FacialRecognition.estacionamiento5.depto;
                cmd.Parameters["@nombre"].Value = FacialRecognition.estacionamiento5.nombre;
                cmd.Parameters["@patente"].Value = FacialRecognition.estacionamiento5.patente;
                cmd.Parameters["@horaIngreso"].Value = FacialRecognition.estacionamiento5.horaInicio;
                cmd.Parameters["@horaRetiro"].Value = horaActual;
                cmd.Parameters["@estacionamiento"].Value = "Estacionamiento 5";

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {

                throw;
            }

            btnSalida5.Visible = false;
            MessageBox.Show("El vehiculo patente " + FacialRecognition.estacionamiento5.patente + " ha dejado el edificio a las " + Convert.ToString(horaActual));

            //Borrar variables
            FacialRecognition.estacionamiento5.nombre = null;
            FacialRecognition.estacionamiento5.depto = null;
            FacialRecognition.estacionamiento5.horaInicio = null;
            FacialRecognition.estacionamiento5.patente = null;

        }

        private void btnSalida6_Click(object sender, EventArgs e)
        {
            DateTime horaActual = DateTime.Now;
            FacialRecognition.estacionamiento6.tiempo = -1;
            //Guardar en BBDD
            try
            {
                // Objetos de conexión y comando
                System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection((@"Data Source=localhost;Initial Catalog=dbprod;Trusted_Connection =True"));
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                // Estableciento propiedades
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO registroVehiculos VALUES (@depto, @nombre, @patente, @horaIngreso, @horaRetiro, @estacionamiento)";

                // Creando los parámetros necesarios
                cmd.Parameters.Add("@depto", System.Data.SqlDbType.NVarChar);
                cmd.Parameters.Add("@nombre", System.Data.SqlDbType.NVarChar);
                cmd.Parameters.Add("@patente", System.Data.SqlDbType.NVarChar);
                cmd.Parameters.Add("@horaIngreso", System.Data.SqlDbType.DateTime);
                cmd.Parameters.Add("@horaRetiro", System.Data.SqlDbType.DateTime);
                cmd.Parameters.Add("@estacionamiento", System.Data.SqlDbType.NVarChar);

                cmd.Parameters["@depto"].Value = FacialRecognition.estacionamiento6.depto;
                cmd.Parameters["@nombre"].Value = FacialRecognition.estacionamiento6.nombre;
                cmd.Parameters["@patente"].Value = FacialRecognition.estacionamiento6.patente;
                cmd.Parameters["@horaIngreso"].Value = FacialRecognition.estacionamiento6.horaInicio;
                cmd.Parameters["@horaRetiro"].Value = horaActual;
                cmd.Parameters["@estacionamiento"].Value = "Estacionamiento 6";

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {

                throw;
            }

            btnSalida6.Visible = false;
            MessageBox.Show("El vehiculo patente " + FacialRecognition.estacionamiento6.patente + " ha dejado el edificio a las " + Convert.ToString(horaActual));

            //Borrar variables
            FacialRecognition.estacionamiento6.nombre = null;
            FacialRecognition.estacionamiento6.depto = null;
            FacialRecognition.estacionamiento6.horaInicio = null;
            FacialRecognition.estacionamiento6.patente = null;
        }
    }
}
