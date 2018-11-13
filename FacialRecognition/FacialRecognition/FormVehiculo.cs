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
    public partial class FormVehiculo : Form
    {
        public FormVehiculo()
        {
            InitializeComponent();
        }

        private void FormVehiculo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbprodDataSet1.tbdepto' Puede moverla o quitarla según sea necesario.
            this.tbdeptoTableAdapter.Fill(this.dbprodDataSet1.tbdepto);

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
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
           
           
        
                cmd.Parameters["@depto"].Value = int.Parse(combodepto.Text);
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
            }
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
    }
}
