using FacialRecognition;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            txtid.Text = "";
            txtpass.Text = "";
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            if (txtid.Text.Equals("admin") && txtpass.Text.Equals("1234"))
            {
                MessageBox.Show("Bienvenido a ISCAV");


                

                SelectMenuAdmin menu = new SelectMenuAdmin();

                menu.WindowState = FormWindowState.Maximized;
                menu.Show();
            }
            else
            {

                MessageBox.Show("ERROR¡¡¡ Ingrese su usuario y contraseña correcta .. ...");
                Limpiar();
           
                //AccesoLogica negocio = new AccesoLogica();

                //string user = txtid.Text;
                //string pass = txtpass.Text;

                //negocio.
         



            }

            
        }
    }
}
