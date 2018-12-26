using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacialRecognition
{
    public partial class FormVehiculo : Form
    {
        public FormVehiculo()
        {
            InitializeComponent();
        }

        private void FormVehiculo_Load(object sender, EventArgs e)
        {
            lblEstacionamiento.Text = FacialRecognition.numEstacionamiento.numeroEstacionamiento;
            // TODO: esta línea de código carga datos en la tabla 'dbprodDataSet1.tbdepto' Puede moverla o quitarla según sea necesario.
            //this.tbdeptoTableAdapter.Fill(this.dbprodDataSet1.tbdepto);



        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DateTime horaActual = DateTime.Now;
            if (lblEstacionamiento.Text == "Estacionamiento 1")
            {
                FacialRecognition.estacionamiento1.nombre = txtNombre.Text;
                FacialRecognition.estacionamiento1.depto = txtDepto.Text;
                FacialRecognition.estacionamiento1.horaInicio = horaActual.ToString();
                FacialRecognition.estacionamiento1.patente = txtPatente.Text;
                timer1.Enabled = true;
                timer1.Start();
                FacialRecognition.estacionamiento1.tiempo = 60;
                this.Hide();

            }
            if (lblEstacionamiento.Text == "Estacionamiento 2")
            {
                FacialRecognition.estacionamiento2.nombre = txtNombre.Text;
                FacialRecognition.estacionamiento2.depto = txtDepto.Text;
                FacialRecognition.estacionamiento2.horaInicio = horaActual.ToString();
                FacialRecognition.estacionamiento2.patente = txtPatente.Text;
                timer2.Enabled = true;
                timer2.Start();
                FacialRecognition.estacionamiento2.tiempo = 60;
                this.Hide();


            }
            if (lblEstacionamiento.Text == "Estacionamiento 3")
            {
                FacialRecognition.estacionamiento3.nombre = txtNombre.Text;
                FacialRecognition.estacionamiento3.depto = txtDepto.Text;
                FacialRecognition.estacionamiento3.horaInicio = horaActual.ToString();
                FacialRecognition.estacionamiento3.patente = txtPatente.Text;
                timer3.Enabled = true;
                timer3.Start();
                FacialRecognition.estacionamiento3.tiempo = 60;
                this.Hide();


            }
            if (lblEstacionamiento.Text == "Estacionamiento 4")
            {
                FacialRecognition.estacionamiento4.nombre = txtNombre.Text;
                FacialRecognition.estacionamiento4.depto = txtDepto.Text;
                FacialRecognition.estacionamiento4.horaInicio = horaActual.ToString();
                FacialRecognition.estacionamiento4.patente = txtPatente.Text;
                timer4.Enabled = true;
                timer4.Start();
                FacialRecognition.estacionamiento4.tiempo = 60;
                this.Hide();

            }
            if (lblEstacionamiento.Text == "Estacionamiento 5")
            {
                FacialRecognition.estacionamiento5.nombre = txtNombre.Text;
                FacialRecognition.estacionamiento5.depto = txtDepto.Text;
                FacialRecognition.estacionamiento5.horaInicio = horaActual.ToString();
                FacialRecognition.estacionamiento5.patente = txtPatente.Text;
                timer5.Enabled = true;
                timer5.Start();
                FacialRecognition.estacionamiento5.tiempo = 60;
                this.Hide();

            }
            if (lblEstacionamiento.Text == "Estacionamiento 6")
            {
                FacialRecognition.estacionamiento6.nombre = txtNombre.Text;
                FacialRecognition.estacionamiento6.depto = txtDepto.Text;
                FacialRecognition.estacionamiento6.horaInicio = horaActual.ToString();
                FacialRecognition.estacionamiento6.patente = txtPatente.Text;
                timer6.Enabled = true;
                timer6.Start();
                FacialRecognition.estacionamiento6.tiempo = 60;
                this.Hide();


            }



            /*try
            {
                // Objetos de conexión y comando
                System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection((@"Data Source=localhost;Initial Catalog=dbprod;Trusted_Connection =True"));
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                // Estableciento propiedades
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO tbvehiculo VALUES (@depto, @color, @marca, @patente)";

                // Creando los parámetros necesarios
                cmd.Parameters.Add("@depto", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@color", System.Data.SqlDbType.NVarChar);
                cmd.Parameters.Add("@marca", System.Data.SqlDbType.NVarChar);
                cmd.Parameters.Add("@patente", System.Data.SqlDbType.NVarChar);
           
           
        
              /*  cmd.Parameters["@depto"].Value = int.Parse(combodepto.Text);
                cmd.Parameters["@color"].Value = txtcolor.Text;
                cmd.Parameters["@marca"].Value = txtmarca.Text;
                cmd.Parameters["@patente"].Value = txtpatente.Text;

              
           

       

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {

                throw;
            }*/

        }

        private void txtcolor_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void txtmarca_Enter(object sender, EventArgs e)
        {

        }

        private void txtpatente_Enter(object sender, EventArgs e)
        {

        }

        private void txtcolor_Leave(object sender, EventArgs e)
        {

        }

        private void txtmarca_Leave(object sender, EventArgs e)
        {

        }

        private void txtpatente_Leave(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPatente_Click(object sender, EventArgs e)
        {
            string[] paths = Directory.GetFiles(Application.StartupPath + "/TrainedFaces/patente", "*.png");
            List<string> images = paths.ToList();
            Random random = new Random();
            imgPatente.ImageLocation = paths[random.Next(0, images.Count - 1)];
            if (imgPatente.ImageLocation.Contains("dcbk96.png"))
            {
                txtPatente.Text = "DC BK - 96";
            }
            if (imgPatente.ImageLocation.Contains("cvvv26.png"))
            {
                txtPatente.Text = "CV VV - 26";
            }
            if (imgPatente.ImageLocation.Contains("cwcd77.png"))
            {
                txtPatente.Text = "CW CD - 77";
            }
            if (imgPatente.ImageLocation.Contains("clfg90.png"))
            {
                txtPatente.Text = "CL FG - 90";
            }
            if (imgPatente.ImageLocation.Contains("cfvh87.png"))
            {
                txtPatente.Text = "CF VH - 87";
            }
            if (imgPatente.ImageLocation.Contains("ddfk60.png"))
            {
                txtPatente.Text = "DD FK - 60";
            }
            if (imgPatente.ImageLocation.Contains("ddff69.png"))
            {
                txtPatente.Text = "DD FF - 69";
            }
            if (imgPatente.ImageLocation.Contains("dsyw63.png"))
            {
                txtPatente.Text = "DS YW - 63";
            }
            if (imgPatente.ImageLocation.Contains("crzk53.png"))
            {
                txtPatente.Text = "CR ZK - 53";
            }
            if (imgPatente.ImageLocation.Contains("cjwp84.png"))
            {
                txtPatente.Text = "CJ WP - 84";
            }
            if (imgPatente.ImageLocation.Contains("dryk69.png"))
            {
                txtPatente.Text = "DR YK - 69";
            }
            if (imgPatente.ImageLocation.Contains("bxbk86.png"))
            {
                txtPatente.Text = "BX BK - 86";
            }
            if (imgPatente.ImageLocation.Contains("dvhc14.png"))
            {
                txtPatente.Text = "DV HC - 14";
            }
            if (imgPatente.ImageLocation.Contains("cvjb75.png"))
            {
                txtPatente.Text = "CV JB - 75";
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            FacialRecognition.estacionamiento1.tiempo--;
            if (FacialRecognition.estacionamiento1.tiempo == 0)
            {
                timer1.Stop();
                MessageBox.Show("El estacionamiento 1 ocupado por patente " + FacialRecognition.estacionamiento1.patente + " ya ha cumplido su tiempo, llamar a " + FacialRecognition.estacionamiento1.depto);
               
                timer1.Enabled = false;


            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            FacialRecognition.estacionamiento2.tiempo--;
            if (FacialRecognition.estacionamiento2.tiempo == 0)
            {
                timer2.Stop();
                MessageBox.Show("El estacionamiento 2 ocupado por patente " + FacialRecognition.estacionamiento2.patente + " ya ha cumplido su tiempo, llamar a " + FacialRecognition.estacionamiento2.depto);
                
                timer2.Enabled = false;


            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            FacialRecognition.estacionamiento3.tiempo--;
            if (FacialRecognition.estacionamiento3.tiempo == 0)
            {
                timer3.Stop();
                MessageBox.Show("El estacionamiento 3 ocupado por patente " + FacialRecognition.estacionamiento3.patente + " ya ha cumplido su tiempo, llamar a " + FacialRecognition.estacionamiento3.depto);
                
                timer3.Enabled = false;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            FacialRecognition.estacionamiento4.tiempo--;
            if (FacialRecognition.estacionamiento4.tiempo == 0)
            {
                timer4.Stop();
                MessageBox.Show("El estacionamiento 4 ocupado por patente " + FacialRecognition.estacionamiento4.patente + " ya ha cumplido su tiempo, llamar a " + FacialRecognition.estacionamiento4.depto);
                
                timer4.Enabled = false;
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            FacialRecognition.estacionamiento5.tiempo--;
            if (FacialRecognition.estacionamiento5.tiempo == 0)
            {
                timer5.Stop();
                MessageBox.Show("El estacionamiento 5 ocupado por patente " + FacialRecognition.estacionamiento5.patente + " ya ha cumplido su tiempo, llamar a " + FacialRecognition.estacionamiento5.depto);
                
                timer5.Enabled = false;
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            FacialRecognition.estacionamiento6.tiempo--;
            if (FacialRecognition.estacionamiento6.tiempo == 0)
            {
                timer6.Stop();
                MessageBox.Show("El estacionamiento 6 ocupado por patente " + FacialRecognition.estacionamiento6.patente + " ya ha cumplido su tiempo, llamar a " + FacialRecognition.estacionamiento6.depto);
                
                timer6.Enabled = false;
            }
        }
    }
}
