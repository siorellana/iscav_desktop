using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacialRecognition;

namespace Iscav1
{
    public partial class Propiedad : Form
    {
        public Propiedad()
        {
            InitializeComponent();
        }


        protected void GvMostrar(object sender, EventArgs e)
        {

            dataGridPropiedad.DataSource = AccesoLogica.ObtenerPropiedad();

            //txtRut.Enabled = true;

            //btnEnviar.Enabled = true;
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
            txtIdpropiedad.Text = txtUbicacion.Text = txtDireccion.Text =
                 txtEstado.Text = txtPropietario.Text = "";
        }
        private void Propiedad_Load(object sender, EventArgs e)
        {
            GvMostrar(sender, e);

        }



        

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            try
            {
                if (!IsNumeric(txtIdpropiedad.Text) || !IsNumeric(txtPropietario.Text))
                {
                    lblMensaje.Text = "Ingrese solo numeros en los campos que se requieran ";

                }
                else
                {
                    if (txtIdpropiedad.Text == "" || txtUbicacion.Text == "" || txtEstado.Text == "" 
                       || txtPropietario.Text == "" || txtDireccion.Text == "")
                    {
                        lblMensaje.Text = "Ingrese todos los datos por favor .";
                    }
                    else
                    {



                        //return;


                        AccesoLogica negocio = new AccesoLogica();
                        int Id_Propiedad = Int32.Parse(txtIdpropiedad.Text);
                        string direccion = txtDireccion.Text;
                        string ubicacion = txtUbicacion.Text;
                        string estado = txtEstado.Text;

                        int id_propietario = Int32.Parse(txtPropietario.Text);

                        
                       
                        //int resultado = AccesoLogica.InsertPropietario(Id_Propiedad, direccion, ubicacion, estado, id_propietario);



                        //if (resultado > 0)

                        //    lblMensaje.Text = "Nuevo Registro Agregado Satisfactoriamente. ";




                      //  else

                       //     lblMensaje.Text = "Propiedad : [" + txtIdpropiedad.Text + "] ya existe, agrege otra";

                      //  negocio = null;

                    }
                    GvMostrar(sender, e);
                    limpiar();

                }

            }
            catch (Exception EX)
            {
                MessageBox.Show("No existe Propietario para asignar esta propiedad" + EX);
                limpiar();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            SelectMenuAdmin sele = new SelectMenuAdmin();

            sele.WindowState = FormWindowState.Maximized;
            sele.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            SelectMenuAdmin sele = new SelectMenuAdmin();

            sele.WindowState = FormWindowState.Maximized;
            sele.Show();
        }

        private void btnMostrarpropiedad_Click(object sender, EventArgs e)
        {
            dataGridPropiedad.DataSource = AccesoLogica.ObtenerPropiedad();
        }

      
    }
}
