using Datos;
using System;
using System.Windows.Forms;

using FacialRecognition;
using System.Data;
using Iscav1;

namespace FacialRecognition
{
    public partial class FrmEdificio : Form
    {
        public FrmEdificio()
        {
            InitializeComponent();

            dataGridDepartamento.Update();
            dataGridEdificio.Update();
        }

        Random rnd = new Random();

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
            
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            try
            {
                //if (!IsNumeric(txtIdedificio.Text))
                //{
                //    lblMensaje.Text = "Ingrese solo numeros en el Id del Edificio ";

                ////}
                //else
                //{
                    //txtIdedificio.Text == "" ||
                    if ( txtDireccion.Text == "" || txtNombre.Text == ""
                      )
                    {
                        lblMensaje.Text = "Ingrese todos los datos por favor .";
                    }
                    else
                    {
                        int rdmEdificio = rnd.Next(1000);

                        txtIdedificio.Text = rdmEdificio.ToString();

                        // Objetos de conexión y comando
                        System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection((@"Data Source=localhost;Initial Catalog=dbprod;Trusted_Connection =True"));
                        System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                   
                        // Estableciento propiedades
                        cmd.Connection = conn;
                     cmd.CommandText = "INSERT INTO tbedificio VALUES (@id_edificio, @direccion, @nombre)";

                        // Creando los parámetros necesarios
                        cmd.Parameters.Add("@id_edificio", System.Data.SqlDbType.Int);
                        cmd.Parameters.Add("@direccion", System.Data.SqlDbType.NVarChar);
                        
                        cmd.Parameters.Add("@nombre", System.Data.SqlDbType.NVarChar);
                  
                        
        
                        cmd.Parameters["@id_edificio"].Value = int.Parse(txtIdedificio.Text);
                        cmd.Parameters["@direccion"].Value = txtDireccion.Text;
                        cmd.Parameters["@nombre"].Value = txtNombre.Text;
                       
                 
                        // Asignando el valor de la imagen
                        //// Stream usado como buffer
                        //System.IO.MemoryStream ms = new System.IO.MemoryStream();
                        //// Se guarda la imagen en el buffer
                        //imageBox2.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        //// Se extraen los bytes del buffer para asignarlos como valor para el 
                        //// parámetro.
                        //cmd.Parameters["@image"].Value = ms.GetBuffer();

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();



                        //return;


                        //AccesoLogica negocio = new AccesoLogica();

                        //int id_edificio = Int32.Parse(txtIdedificio.Text);
                        //string direccion = txtDireccion.Text;
                        //string nombre = txtNombre.Text;

                        lblMensaje.Text = "Nuevo Registro Agregado Satisfactoriamente. ";
                    pictureBox1_Click(sender,e);

                    FrmEdificio_Load(sender, e);




                        //int resultado = new AccesoLogica().InsertEdificio(id_edificio, direccion, nombre);



                    //    if (resultado > 0)

                    //        lblMensaje.Text = "Nuevo Registro Agregado Satisfactoriamente. ";




                    //    else

                    //        lblMensaje.Text = "Edificio : [" + txtIdedificio.Text + "] ya existe, agrege otro";

                    //    negocio = null;

                    ////}



                }

            }
            catch (Exception EX)
            {
                MessageBox.Show("No se logro ingresar edificio" + EX);
                limpiar();
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtIdedificio.Text == "" || txtDireccion.Text == "" || txtNombre.Text == "")
                {
                    lblMensaje.Text = "Complete los datos solicitados por favor ....... .";
                }
                else
                {

                    // Objetos de conexión y comando
                    System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection((@"Data Source=localhost;Initial Catalog=dbprod;Trusted_Connection =True"));
                    System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();


                    // Estableciento propiedades
                    cmd.Connection = conn;
                    cmd.CommandText = "UPDATE tbedificio set[direccion] = @direccion, [nombre] = @nombre  where id_edificio = @id_edificio";
                    
                    // Creando los parámetros necesarios
                    cmd.Parameters.Add("@id_edificio", System.Data.SqlDbType.Int);
                    cmd.Parameters.Add("@direccion", System.Data.SqlDbType.NVarChar);

                    cmd.Parameters.Add("@nombre", System.Data.SqlDbType.NVarChar);



                    cmd.Parameters["@id_edificio"].Value = int.Parse(txtIdedificio.Text);
                    cmd.Parameters["@direccion"].Value = txtDireccion.Text;
                    cmd.Parameters["@nombre"].Value = txtNombre.Text;


                    // Asignando el valor de la imagen
                    //// Stream usado como buffer
                    //System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    //// Se guarda la imagen en el buffer
                    //imageBox2.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    //// Se extraen los bytes del buffer para asignarlos como valor para el 
                    //// parámetro.
                    //cmd.Parameters["@image"].Value = ms.GetBuffer();

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();


                    //return;



                    //AccesoLogica negocio = new AccesoLogica();

                    //int id_edificio = Int32.Parse(txtIdedificio.Text);
                    //string direccion = txtDireccion.Text;
                    //string nombre = txtNombre.Text;



                    //// int cobros = Int32.Parse(txtCobros.Text);
                    ////int pago = Int32.Parse(txtPagos.Text);


                    //int resultado = negocio.ModificarEdificio(id_edificio, direccion, nombre);



                    //if (//resultado > 0)

                    lblMensaje.Text = "Se modifico el Edificio correctamente. ";




                    //else

                      //  lblMensaje.Text = "No se logro modificar la propiedad valide los datos por favor ....";

                   // negocio = null;

                }
                
               

            }


            catch (Exception EX)
            {
                lblMensaje.Text = "No se logro ingresar una Propiedad";
                throw;
            }


        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

            //    try
            //    {
            //        if (txtIdedificio.Text == " ")
            //        {
            //            lblMensaje.Text = "Ingrese el ID de Edificio para eliminar";

            //        }
            //        else
            //        {
            //            if (!IsNumeric(txtIdedificio.Text))
            //            {
            //                lblMensaje.Text = "Ingrese un Valor Númerico";

            //            }
            //            else
            //            {




            //                System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection((@"Data Source=localhost;Initial Catalog=dbprod;Trusted_Connection =True"));
            //                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();


            //                // Estableciento propiedades
            //                cmd.Connection = conn;
            //                cmd.CommandText = "DELETE  from dbo.tbedificio  where id_edificio= @id_edificio";

            //                // Creando los parámetros necesarios
            //                cmd.Parameters.Add("@id_edificio", System.Data.SqlDbType.Int);
            //                cmd.Parameters.Add("@direccion", System.Data.SqlDbType.NVarChar);

            //                cmd.Parameters.Add("@nombre", System.Data.SqlDbType.NVarChar);



            //                cmd.Parameters["@id_edificio"].Value = int.Parse(txtIdedificio.Text);
            //                cmd.Parameters["@direccion"].Value = txtDireccion.Text;
            //                cmd.Parameters["@nombre"].Value = txtNombre.Text;


            //                // Asignando el valor de la imagen
            //                //// Stream usado como buffer
            //                //System.IO.MemoryStream ms = new System.IO.MemoryStream();
            //                //// Se guarda la imagen en el buffer
            //                //imageBox2.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            //                //// Se extraen los bytes del buffer para asignarlos como valor para el 
            //                //// parámetro.
            //                //cmd.Parameters["@image"].Value = ms.GetBuffer();

            //                conn.Open();
            //                cmd.ExecuteNonQuery();
            //                conn.Close();
            //                //AccesoDatos datos = new AccesoDatos();
            //                //int EliminarHid = Int32.Parse(txtIdedificio.Text);
            //                //dataGridEdificio.DataSource = AccesoDatos.EliminarPropiedad(EliminarHid);
            //                lblMensaje.Text = "Se elimino Edificio";

            //            }
            //        }

            //    }
            //    catch (Exception)
            //    {
            //        lblMensaje.Text = "No se encontro Departamento";
            //        throw;
            //    }

        }

        private void FrmEdificio_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbprodDataSet1.tbdepto' Puede moverla o quitarla según sea necesario.
            this.tbdeptoTableAdapter.Fill(this.dbprodDataSet1.tbdepto);
            // TODO: esta línea de código carga datos en la tabla 'dbprodDataSet1.tbedificio' Puede moverla o quitarla según sea necesario.
            this.tbedificioTableAdapter.Fill(this.dbprodDataSet1.tbedificio);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if ( !IsNumeric(txtnumero.Text)|| !IsNumeric(txtpiso.Text))
                {
                    lblMensaje.Text = "Ingrese solo numeros los campos ";

                }
                else
                {


                    if ( txtnumero.Text == "" || txtpiso.Text == "" ||cboidedificio.Text==""
                      )
                    {
                        lblMensaje.Text = "Ingrese todos los datos por favor .";
                    }
                    else
                    {

                        // Objetos de conexión y comando
                        System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection((@"Data Source=localhost;Initial Catalog=dbprod;Trusted_Connection =True"));
                        System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();


                        // Estableciento propiedades
                        cmd.Connection = conn;
                        cmd.CommandText = "INSERT INTO tbdepto VALUES ( @numero, @piso,@id_edificio)";

                        // Creando los parámetros necesarios
                        
                        cmd.Parameters.Add("@numero", System.Data.SqlDbType.Int);
                        cmd.Parameters.Add("@piso", System.Data.SqlDbType.Int);

                        cmd.Parameters.Add("@id_edificio", System.Data.SqlDbType.Int);



                       
                        cmd.Parameters["@numero"].Value = int.Parse(txtnumero.Text);
                        cmd.Parameters["@piso"].Value = int.Parse(txtpiso.Text);
                        cmd.Parameters["@id_edificio"].Value = int.Parse(cboidedificio.Text);


                        // Asignando el valor de la imagen
                        //// Stream usado como buffer
                        //System.IO.MemoryStream ms = new System.IO.MemoryStream();
                        //// Se guarda la imagen en el buffer
                        //imageBox2.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        //// Se extraen los bytes del buffer para asignarlos como valor para el 
                        //// parámetro.
                        //cmd.Parameters["@image"].Value = ms.GetBuffer();

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();



                        //return;


                        //AccesoLogica negocio = new AccesoLogica();

                        //int id_edificio = Int32.Parse(txtIdedificio.Text);
                        //string direccion = txtDireccion.Text;
                        //string nombre = txtNombre.Text;

                        lblMensaje.Text = "Nuevo Registro Agregado Satisfactoriamente. ";
                        pictureBox2_Click(sender,e);




                        //int resultado = new AccesoLogica().InsertEdificio(id_edificio, direccion, nombre);



                        //    if (resultado > 0)

                        //        lblMensaje.Text = "Nuevo Registro Agregado Satisfactoriamente. ";




                        //    else

                        //        lblMensaje.Text = "Edificio : [" + txtIdedificio.Text + "] ya existe, agrege otro";

                        //    negocio = null;

                    }



                }

            }
            catch (Exception EX)
            {
                MessageBox.Show("No se logro ingresar Departamento" + EX);
                limpiar();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                if ( !IsNumeric(txtnumero.Text) || !IsNumeric(txtpiso.Text) || !IsNumeric(cboidedificio.Text))
                {
                    lblMensaje.Text = "Ingrese solo numeros los campos ";

                }
                else
                {
                    if (txtnumero.Text == "" || txtpiso.Text == "" || cboidedificio.Text == ""
                      )
                    {
                        lblMensaje.Text = "Ingrese todos los datos por favor .";
                    }
                    else
                    {

                        // Objetos de conexión y comando
                        System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection((@"Data Source=localhost;Initial Catalog=dbprod;Trusted_Connection =True"));
                        System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();


                        // Estableciento propiedades
                        cmd.Connection = conn;
                        cmd.CommandText = " UPDATE  tbdepto set [numero] = @numero ,  [piso] = @piso, [id_edificio] = @id_edificio  where numero = @numero";

                      

                        // Creando los parámetros necesarios
                        
                        cmd.Parameters.Add("@numero", System.Data.SqlDbType.Int);
                        cmd.Parameters.Add("@piso", System.Data.SqlDbType.Int);

                        cmd.Parameters.Add("@id_edificio", System.Data.SqlDbType.Int);



                       
                        cmd.Parameters["@numero"].Value = int.Parse(txtnumero.Text);
                        cmd.Parameters["@piso"].Value = int.Parse(txtpiso.Text);
                        cmd.Parameters["@id_edificio"].Value = int.Parse(cboidedificio.Text);


                        // Asignando el valor de la imagen
                        //// Stream usado como buffer
                        //System.IO.MemoryStream ms = new System.IO.MemoryStream();
                        //// Se guarda la imagen en el buffer
                        //imageBox2.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        //// Se extraen los bytes del buffer para asignarlos como valor para el 
                        //// parámetro.
                        //cmd.Parameters["@image"].Value = ms.GetBuffer();

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();



                        //return;


                        //AccesoLogica negocio = new AccesoLogica();

                        //int id_edificio = Int32.Parse(txtIdedificio.Text);
                        //string direccion = txtDireccion.Text;
                        //string nombre = txtNombre.Text;

                        lblMensaje.Text = "Nuevo Registro Agregado Satisfactoriamente. ";




                        //int resultado = new AccesoLogica().InsertEdificio(id_edificio, direccion, nombre);



                        //    if (resultado > 0)

                        //        lblMensaje.Text = "Nuevo Registro Agregado Satisfactoriamente. ";




                        //    else

                        //        lblMensaje.Text = "Edificio : [" + txtIdedificio.Text + "] ya existe, agrege otro";

                        //    negocio = null;

                    }



                }

            }
            catch (Exception EX)
            {
                MessageBox.Show("No se logro ingresar Departamento" + EX);
                limpiar();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnumero.Text == " ")
                {
                    lblMensaje.Text = "Ingrese el Numero de departamento para eliminar";

                }
                else
                {
                    if (!IsNumeric(txtnumero.Text))
                    {
                        lblMensaje.Text = "Ingrese un Valor Númerico";

                    }
                    else
                    {

                        // Objetos de conexión y comando
                        System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection((@"Data Source=localhost;Initial Catalog=dbprod;Trusted_Connection =True"));
                        System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();


                        // Estableciento propiedades
                        cmd.Connection = conn;
                        cmd.CommandText = "DELETE from dbo.tbdepto where numero =@numero";
                  

                        // Creando los parámetros necesarios
                        cmd.Parameters.Add("@numero", System.Data.SqlDbType.Int);
                       // cmd.Parameters.Add("@numero", System.Data.SqlDbType.Int);
                       // cmd.Parameters.Add("@piso", System.Data.SqlDbType.Int);

                       //cmd.Parameters.Add("@id_edificio", System.Data.SqlDbType.Int);



                        cmd.Parameters["@numero"].Value = int.Parse(txtnumero.Text);
                        //cmd.Parameters["@numero"].Value = int.Parse(txtnumero.Text);
                        //cmd.Parameters["@piso"].Value = int.Parse(txtpiso.Text);
                        //cmd.Parameters["@id_edificio"].Value = int.Parse(cboidedificio.Text);


                        // Asignando el valor de la imagen
                        //// Stream usado como buffer
                        //System.IO.MemoryStream ms = new System.IO.MemoryStream();
                        //// Se guarda la imagen en el buffer
                        //imageBox2.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        //// Se extraen los bytes del buffer para asignarlos como valor para el 
                        //// parámetro.
                        //cmd.Parameters["@image"].Value = ms.GetBuffer();

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();



                        //return;


                        //AccesoLogica negocio = new AccesoLogica();

                        //int id_edificio = Int32.Parse(txtIdedificio.Text);
                        //string direccion = txtDireccion.Text;
                        //string nombre = txtNombre.Text;

                        lblMensaje.Text = "Nuevo Registro Agregado Satisfactoriamente. ";




                        //int resultado = new AccesoLogica().InsertEdificio(id_edificio, direccion, nombre);



                        //    if (resultado > 0)

                        //        lblMensaje.Text = "Nuevo Registro Agregado Satisfactoriamente. ";




                        //    else

                        //        lblMensaje.Text = "Edificio : [" + txtIdedificio.Text + "] ya existe, agrege otro";

                        //    negocio = null;

                    }



                }

            }
            catch (Exception EX)
            {
                MessageBox.Show("No se logro eliminar Departamento" + EX);
                limpiar();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var select = "SELECT * FROM tbedificio ";
            var c = new System.Data.SqlClient.SqlConnection((@"Data Source=localhost;Initial Catalog=dbprod;Trusted_Connection =True")); // Your Connection String here
            var dataAdapter = new System.Data.SqlClient.SqlDataAdapter(select, c);

            var commandBuilder = new System.Data.SqlClient.SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridEdificio.ReadOnly = true;
            dataGridEdificio.DataSource = ds.Tables[0];
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var select = "SELECT * FROM tbdepto ";
            var c = new System.Data.SqlClient.SqlConnection((@"Data Source=localhost;Initial Catalog=dbprod;Trusted_Connection =True")); // Your Connection String here
            var dataAdapter = new System.Data.SqlClient.SqlDataAdapter(select, c);

            var commandBuilder = new System.Data.SqlClient.SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridDepartamento.ReadOnly = true;
            dataGridDepartamento.DataSource = ds.Tables[0];

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectMenu menu = new SelectMenu();
            menu.Show();

        }

        private void txtnumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }


        private void cboidedificio_SelectedIndexChanged(object sender, EventArgs e)
        {
            var select = "SELECT * FROM tbedificio ";
            var c = new System.Data.SqlClient.SqlConnection((@"Data Source=localhost;Initial Catalog=dbprod;Trusted_Connection =True")); // Your Connection String here
            var dataAdapter = new System.Data.SqlClient.SqlDataAdapter(select, c);

            var commandBuilder = new System.Data.SqlClient.SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridEdificio.ReadOnly = true;
            dataGridEdificio.DataSource = ds.Tables[0];
        }

    }
}
