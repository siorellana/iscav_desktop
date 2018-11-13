using System;
using System.Data;
using System.Windows.Forms;
using FacialRecognition;

namespace Iscav1
{
    public partial class modPersona : Form
    {
        
        public modPersona()
        {
            InitializeComponent();
        }

        private bool IsNumeric(String num)
        {
            try
            {
                double x = Convert.ToDouble(num);
                return true;

            }
            catch (Exception)
            {
                return false;

            }
        }

        public void limpiar()
        {
            //txtIdpropietario.Text= txtApeMaterno.Text = txtApePaterno.Text = txtCelular.Text =
            //      txtEdad.Text = txtNombre.Text = txtRut.Text = "";
        }
        protected void GvMostrar(object sender, EventArgs e)
        {

            //dataGridPropietario.DataSource = AccesoLogica.ObtenerPropietario();

            //txtRut.Enabled = true;

            //btnEnviar.Enabled = true;
        }
        private void btnBuscar_Click(object sender, EventArgs e)


        {
            try
            {
                if (txtFaceId.Text == " ")
                {
                    lblMensaje.Text = "Ingrese el ID de  para buscar ";

                }
                else
                {
                    if (!IsNumeric(txtFaceId.Text))
                    {
                        lblMensaje.Text = "Ingrese un Valor Númerico";

                    }
                    else
                    {

                        string faceid = txtFaceId.Text;
            var select = "SELECT * FROM tbpersona where faceid='" + faceid +"'";
            var c = new System.Data.SqlClient.SqlConnection((@"Data Source=localhost;Initial Catalog=dbprod;Trusted_Connection =True")); // Your Connection String here
            var dataAdapter = new System.Data.SqlClient.SqlDataAdapter(select, c);

            var commandBuilder = new System.Data.SqlClient.SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridPropietario.ReadOnly = true;
            dataGridPropietario.DataSource = ds.Tables[0];


                    }
                }
            }


            catch (Exception EX)
            {
                MessageBox.Show("No se logro eliminar Persona" + EX);
                limpiar();
            }
        }




    

        private void btnBusNombre_Click(object sender, EventArgs e)

        {


            try
            {
                if (txtNombre.Text == " ")
                {
                    lblMensaje.Text = "Ingrese el Nombre de  para buscar ";

                }
                else
                {
                    if (!IsNumeric(txtNombre.Text))
                    {
                        lblMensaje.Text = "Ingrese un Valor Númerico";

                    }
                    else
                    {
                        string nombre = txtNombre.Text;
            var select = "SELECT * FROM tbpersona where nombre='" + nombre + "'";
            var c = new System.Data.SqlClient.SqlConnection((@"Data Source=localhost;Initial Catalog=dbprod;Trusted_Connection =True")); // Your Connection String here
            var dataAdapter = new System.Data.SqlClient.SqlDataAdapter(select, c);

            var commandBuilder = new System.Data.SqlClient.SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridPropietario.ReadOnly = true;
            dataGridPropietario.DataSource = ds.Tables[0];

                    }
                }
            }


            catch (Exception EX)
            {
                MessageBox.Show("No se logro eliminar Persona" + EX);
                limpiar();
            }
        


    }

        private void btnMuestraTodo_Click(object sender, EventArgs e)
        {
            var select = "SELECT * FROM tbpersona";
            var c = new System.Data.SqlClient.SqlConnection((@"Data Source=localhost;Initial Catalog=dbprod;Trusted_Connection =True")); // Your Connection String here
            var dataAdapter = new System.Data.SqlClient.SqlDataAdapter(select, c);

            var commandBuilder = new System.Data.SqlClient.SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridPropietario.ReadOnly = true;
            dataGridPropietario.DataSource = ds.Tables[0];


        }

        //private void btnIngresar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (!IsNumeric(txtRut.Text) || !IsNumeric(txtIdpropietario.Text) || !IsNumeric(txtEdad.Text) || !IsNumeric(txtCelular.Text))
        //        {
        //            lblMensaje.Text = "Ingrese solo numeros en los campos que se requieran ";

        //        }
        //        else
        //        {
        //            if (txtRut.Text == "" || txtNombre.Text == "" || txtIdpropietario.Text == "" ||
        //                txtApePaterno.Text == "" || txtApeMaterno.Text == "" || txtCelular.Text == "" || txtEdad.Text == "")
        //            {
        //                lblMensaje.Text = "Ingrese todos los datos por favor .";
        //            }
        //            else
        //            {



        //                //return;


        //                AccesoLogica negocio = new AccesoLogica();
        //                int id_propietario = Int32.Parse(txtIdpropietario.Text);
        //                int edad = Int32.Parse(txtEdad.Text);
                       
        //                string nombre = txtNombre.Text;
        //                string apellido = txtApePaterno.Text;
        //                string apellidoM = txtApeMaterno.Text;
        //                int celular = Int32.Parse(txtCelular.Text);
        //                DateTime fecha_in = new DateTime(dtimefechain.Value.Year,dtimefechain.Value.Month,dtimefechain.Value.Day);
        //                string rut = txtRut.Text;
                        

                        

                        


        //                int resultado = negocio.InsertPropietario(id_propietario, nombre, apellido, apellidoM, edad, celular ,fecha_in,rut);



        //                if (resultado > 0)

        //                    lblMensaje.Text = "Nuevo Registro Agregado Satisfactoriamente. ";




        //                else

        //                    lblMensaje.Text = "Propietario : [" + txtIdpropietario.Text + "] ya existe, agrege otra";

        //                negocio = null;

        //            }
        //            GvMostrar(sender, e);
        //            limpiar();

        //        }

        //    }
        //    catch (Exception EX)
        //    {
        //        MessageBox.Show("Ya existe este propietario" + EX);
        //        limpiar();
        //    }

        //}

        private void btnModPropietario_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            SelectMenu sele = new SelectMenu();

            sele.WindowState = FormWindowState.Maximized;
            sele.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            SelectMenu sele = new SelectMenu();

            sele.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FacialRecognition.validador.validarDetec = "Persona";
            modEnroll rola = new modEnroll();
            rola.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FacialRecognition.validador.validarDetec = "Persona";
            modDeteccion d = new modDeteccion();
            d.Show();

        }

        private void modPersona_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbprodDataSet.tbpersona' Puede moverla o quitarla según sea necesario.
            //this.tbpersonaTableAdapter.Fill(this.dbprodDataSet.tbpersona);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var select = "SELECT * FROM tbpersona where tipopersona='Visita'";
            var c = new System.Data.SqlClient.SqlConnection((@"Data Source=localhost;Initial Catalog=dbprod;Trusted_Connection =True")); // Your Connection String here
            var dataAdapter = new System.Data.SqlClient.SqlDataAdapter(select, c);

            var commandBuilder = new System.Data.SqlClient.SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridPropietario.ReadOnly = true;
            dataGridPropietario.DataSource = ds.Tables[0];
        }

        private void btnResidentes_Click(object sender, EventArgs e)
        {
            var select = "SELECT * FROM tbpersona where tipopersona='Residente'";
            var c = new System.Data.SqlClient.SqlConnection((@"Data Source=localhost;Initial Catalog=dbprod;Trusted_Connection =True")); // Your Connection String here
            var dataAdapter = new System.Data.SqlClient.SqlDataAdapter(select, c);

            var commandBuilder = new System.Data.SqlClient.SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridPropietario.ReadOnly = true;
            dataGridPropietario.DataSource = ds.Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var select = "SELECT * FROM tbpersona where activo='false'";
            var c = new System.Data.SqlClient.SqlConnection((@"Data Source=localhost;Initial Catalog=dbprod;Trusted_Connection =True")); // Your Connection String here
            var dataAdapter = new System.Data.SqlClient.SqlDataAdapter(select, c);

            var commandBuilder = new System.Data.SqlClient.SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridPropietario.ReadOnly = true;
            dataGridPropietario.DataSource = ds.Tables[0];
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbpersonaTableAdapter1.FillBy(this.dbprodDataSet1.tbpersona);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //var select = "DELETE FROM tbpersona where faceid = '" + txtFaceId.Text + "'";
            //var c = new System.Data.SqlClient.SqlConnection((@"Data Source=localhost;Initial Catalog=dbprod;Trusted_Connection =True")); // Your Connection String here
            //var dataAdapter = new System.Data.SqlClient.SqlDataAdapter(select, c);

            //var commandBuilder = new System.Data.SqlClient.SqlCommandBuilder(dataAdapter);




            try
            {
                if (txtFaceId.Text == " ")
                {
                    lblMensaje.Text = "Ingrese el ID de Persona para eliminar";

                }
                else
                {
                    if (!IsNumeric(txtFaceId.Text))
                    {
                        lblMensaje.Text = "Ingrese un Valor Númerico en campo FACE ID";

                    }
                    else
                    {
                        // Objetos de conexión y comando
                        System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection((@"Data Source=localhost;Initial Catalog=dbprod;Trusted_Connection =True"));
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();


            // Estableciento propiedades
            cmd.Connection = conn;
            cmd.CommandText = "DELETE from dbo.tbpersona where faceid =@faceid";


            // Creando los parámetros necesarios
            cmd.Parameters.Add("@faceid", System.Data.SqlDbType.Int);
        


            cmd.Parameters["@faceid"].Value = int.Parse(txtFaceId.Text);
          

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            lblMensaje1.Text = "Se Elimino a usuario"+txtFaceId.Text;


                    }



                }

            }
            catch (Exception EX)
            {
                MessageBox.Show("No se logro eliminar Persona" + EX);
                limpiar();
            }




        }

        private void btnBuscarDepto_Click(object sender, EventArgs e)
        {
            //System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection((@"Data Source=localhost;Initial Catalog=dbprod;Trusted_Connection =True"));
            //System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();


            //// Estableciento propiedades
            //cmd.Connection = conn;
            //cmd.CommandText = "select * from dbo.tbpersona where depto =@depto";


            //// Creando los parámetros necesarios
            //cmd.Parameters.Add("@depto", System.Data.SqlDbType.Int);



            //cmd.Parameters["@depto"].Value = int.Parse(txtDepto.Text);


            //conn.Open();
            //cmd.ExecuteNonQuery();
            //conn.Close();
            try
            {
                if (txtDepto.Text == " ")
                {
                    lblMensaje.Text = "Ingrese el ID de departamento para eliminar";

                }
                else
                {
                    if (!IsNumeric(txtDepto.Text))
                    {
                        lblMensaje.Text = "Ingrese un Valor Númerico";

                    }
                    else
                    {

                        string depto = txtDepto.Text;
            var select = "SELECT * FROM tbpersona where depto='" + depto + "'";
            var c = new System.Data.SqlClient.SqlConnection((@"Data Source=localhost;Initial Catalog=dbprod;Trusted_Connection =True")); // Your Connection String here
            var dataAdapter = new System.Data.SqlClient.SqlDataAdapter(select, c);

            var commandBuilder = new System.Data.SqlClient.SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridPropietario.ReadOnly = true;
            dataGridPropietario.DataSource = ds.Tables[0];

            lblMensaje1.Text = "Se encontro a Persona";


                    }
                }
            }


            catch (Exception EX)
            {
                MessageBox.Show("No se logro eliminar Persona" + EX);
                limpiar();
            }
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
    }
    
}
